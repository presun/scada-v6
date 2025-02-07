﻿// Copyright (c) Rapid Software LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Scada.Web.Plugins.PlgScheme.Model.DataTypes;
using Scada.Web.Plugins.PlgScheme.Model.PropertyGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Serialization;
using System.Xml;

namespace Scada.Web.Plugins.PlgScheme.Model
{
    /// <summary>
    /// Scheme document properties.
    /// <para>Свойства документа схемы.</para>
    /// </summary>
    public class SchemeDocument : IObservableItem, ISchemeViewAvailable
    {
        /// <summary>
        /// Размер схемы по умолчанию.
        /// </summary>
        public static readonly Size DefaultSize = new(800, 600);

        /// <summary>
        /// Ссылка на представление схемы.
        /// </summary>
        [NonSerialized]
        protected SchemeView schemeView;


        /// <summary>
        /// Конструктор.
        /// </summary>
        public SchemeDocument()
        {
            schemeView = null;
            CnlFilter = new List<int>();
            Images = new Dictionary<string, Image>();
            SetToDefault();
        }


        /// <summary>
        /// Получить версию редактора схем, в котором сохранён файл схемы.
        /// </summary>
        #region Attributes
        [DisplayName("Version"), Category(Categories.Design)]
        [Description("Version of Scheme Editor that saved the file of the scheme.")]
        #endregion
        public string Version { get; protected set; }

        /// <summary>
        /// Получить или установить размер.
        /// </summary>
        #region Attributes
        [DisplayName("Size"), Category(Categories.Layout)]
        [Description("The size of the scheme in pixels.")]
        #endregion
        public Size Size { get; set; }

        /// <summary>
        /// Получить или установить цвет фона.
        /// </summary>
        #region Attributes
        [DisplayName("Background color"), Category(Categories.Appearance)]
        [Description("The background color of the scheme.")]
        //[Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [DefaultValue("White")]
        #endregion
        public string BackColor { get; set; }

        /// <summary>
        /// Получить или установить наименование фонового изображения.
        /// </summary>
        #region Attributes
        [DisplayName("Background image"), Category(Categories.Appearance)]
        [Description("The background image used for the scheme.")]
        //[TypeConverter(typeof(ImageConverter)), Editor(typeof(ImageEditor), typeof(UITypeEditor))]
        [DefaultValue("")]
        #endregion
        public string BackImageName { get; set; }

        /// <summary>
        /// Получить или установить шрифт.
        /// </summary>
        #region Attributes
        [DisplayName("Font"), Category(Categories.Appearance)]
        [Description("The font used to display text in the scheme.")]
        #endregion
        public Font Font { get; set; }

        /// <summary>
        /// Получить или установить основной цвет.
        /// </summary>
        #region Attributes
        [DisplayName("Foreground color"), Category(Categories.Appearance)]
        [Description("The foreground color of the scheme, which is used to display text.")]
        //[Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        [DefaultValue("Black")]
        #endregion
        public string ForeColor { get; set; }

        /// <summary>
        /// Получить или установить заголовок.
        /// </summary>
        #region Attributes
        [DisplayName("Title"), Category(Categories.Appearance)]
        [Description("The title of the scheme.")]
        #endregion
        public string Title { get; set; }

        /// <summary>
        /// Получить фильтр по входным каналам.
        /// </summary>
        #region Attributes
        [DisplayName("Channel filter"), Category(Categories.Data)]
        [Description("The input channels used as a filter for displaying events filtered by view.")]
        //[TypeConverter(typeof(RangeConverter)), Editor(typeof(RangeEditor), typeof(UITypeEditor))]
        [JsonIgnore]
        #endregion
        public List<int> CnlFilter { get; protected set; }

        /// <summary>
        /// Получить словарь изображений схемы.
        /// </summary>
        #region Attributes
        [DisplayName("Images"), Category(Categories.Data)]
        [Description("The collection of images used in the scheme.")]
        //[TypeConverter(typeof(CollectionConverter)), Editor(typeof(ImageEditor), typeof(UITypeEditor))]
        [JsonIgnore]
        #endregion
        public Dictionary<string, Image> Images { get; protected set; }

        /// <summary>
        /// Получить или установить ссылку на представление схемы.
        /// </summary>
        [Browsable(false), JsonIgnore]
        public SchemeView SchemeView
        {
            get
            {
                return schemeView;
            }
            set
            {
                schemeView = value;
            }
        }


        /// <summary>
        /// Установить значения свойств документа схемы по умолчанию.
        /// </summary>
        public void SetToDefault()
        {
            Version = "";
            Size = DefaultSize;
            BackColor = "White";
            BackImageName = "";
            Font = new Font();
            ForeColor = "Black";
            Title = "";
            CnlFilter.Clear();
            Images.Clear();
        }

        /// <summary>
        /// Загрузить свойства документа схемы из XML-узла.
        /// </summary>
        public void LoadFromXml(XmlNode xmlNode)
        {
            if (xmlNode == null)
                throw new ArgumentNullException(nameof(xmlNode));

            SetToDefault();

            Version = xmlNode.GetChildAsString("Version");
            Size = Size.GetChildAsSize(xmlNode, "Size");
            BackColor = xmlNode.GetChildAsString("BackColor");
            BackImageName = xmlNode.GetChildAsString("BackImageName");
            Font = Font.GetChildAsFont(xmlNode, "Font");
            ForeColor = xmlNode.GetChildAsString("ForeColor");
            Title = xmlNode.GetChildAsString("Title");
            CnlFilter.AddRange(ScadaUtils.ParseIntArray(xmlNode.GetChildAsString("CnlFilter")));
        }

        /// <summary>
        /// Сохранить свойства документа схемы в XML-узле.
        /// </summary>
        public void SaveToXml(XmlElement xmlElem)
        {
            if (xmlElem == null)
                throw new ArgumentNullException(nameof(xmlElem));

            Version = SchemeUtils.SchemeVersion;
            xmlElem.AppendElem("Version", Version);
            Size.AppendElem(xmlElem, "Size", Size);
            xmlElem.AppendElem("BackColor", BackColor);
            xmlElem.AppendElem("BackImageName", BackImageName);
            Font.AppendElem(xmlElem, "Font", Font);
            xmlElem.AppendElem("ForeColor", ForeColor);
            xmlElem.AppendElem("Title", Title);
            xmlElem.AppendElem("CnlFilter", ScadaUtils.ToLongString(CnlFilter));
        }


        /// <summary>
        /// Вернуть строковое представление объекта.
        /// </summary>
        public override string ToString()
        {
            return Title + (string.IsNullOrEmpty(Title) ? "" : " - ") + GetType().Name;
        }

        /// <summary>
        /// Копировать свойства объекта в заданный объект.
        /// </summary>
        public void CopyTo(SchemeDocument schemeDoc)
        {
            if (schemeDoc == null)
                throw new ArgumentNullException(nameof(schemeDoc));

            // not copied: Images, SchemeView and ItemChanged
            schemeDoc.Size = Size;
            schemeDoc.BackColor = BackColor;
            schemeDoc.BackImageName = BackImageName;
            schemeDoc.Font = Font.Clone();
            schemeDoc.ForeColor = ForeColor;
            schemeDoc.Title = Title;
            schemeDoc.CnlFilter.Clear();
            schemeDoc.CnlFilter.AddRange(CnlFilter);
        }

        /// <summary>
        /// Копировать объект.
        /// </summary>
        public SchemeDocument Copy()
        {
            SchemeDocument schemeDoc = new();
            CopyTo(schemeDoc);
            return schemeDoc;
        }

        /// <summary>
        /// Вызвать событие ItemChanged.
        /// </summary>
        public void OnItemChanged(SchemeChangeTypes changeType, object changedObject, object oldKey = null)
        {
            ItemChanged?.Invoke(this, changeType, changedObject, oldKey);
        }


        /// <summary>
        /// Событие возникающее при изменении документа схемы.
        /// </summary>
        [field: NonSerialized]
        public event ItemChangedEventHandler ItemChanged;
    }
}
