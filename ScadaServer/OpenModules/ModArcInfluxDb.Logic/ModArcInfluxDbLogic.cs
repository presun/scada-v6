﻿/*
 * Copyright 2021 Mikhail Shiryaev
 * All rights reserved
 * 
 * Product  : Rapid SCADA
 * Module   : ModArcInfluxDb
 * Summary  : Implements the server module logic
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2020
 * Modified : 2021
 */

using Scada.Server.Archives;
using Scada.Server.Config;
using Scada.Server.Lang;
using Scada.Server.Modules.ModArcInfluxDb.Logic.Config;

namespace Scada.Server.Modules.ModArcInfluxDb.Logic
{
    /// <summary>
    /// Implements the server module logic.
    /// <para>Реализует логику серверного модуля.</para>
    /// </summary>
    public class ModArcInfluxDbLogic : ModuleLogic
    {
        private readonly ModuleConfig moduleConfig; // the module configuration


        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModArcInfluxDbLogic(IServerContext serverContext)
            : base(serverContext)
        {
            moduleConfig = new ModuleConfig();
        }


        /// <summary>
        /// Gets the module code.
        /// </summary>
        public override string Code
        {
            get
            {
                return ModuleUtils.ModuleCode;
            }
        }

        /// <summary>
        /// Gets the module purposes.
        /// </summary>
        public override ModulePurposes ModulePurposes
        {
            get
            {
                return ModulePurposes.Archive;
            }
        }


        /// <summary>
        /// Creates a new archive logic.
        /// </summary>
        public override ArchiveLogic CreateArchive(IArchiveContext archiveContext, ArchiveConfig archiveConfig, 
            int[] cnlNums)
        {
            return archiveConfig.Kind == ArchiveKind.Historical 
                ? new InfluxHAL(archiveContext, archiveConfig, cnlNums, moduleConfig) 
                : null;
        }

        /// <summary>
        /// Performs actions when starting the service.
        /// </summary>
        public override void OnServiceStart()
        {
            if (!moduleConfig.Load(ModuleConfig.GetFilePath(AppDirs.ConfigDir), out string errMsg))
                Log.WriteError(ServerPhrases.ModuleMessage, Code, errMsg);
        }
    }
}
