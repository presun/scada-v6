-- project.app_storage definition

-- Drop table

-- DROP TABLE project.app_storage;

CREATE TABLE project.app_storage (
	file_id int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY,
	app_id int4 NOT NULL,
	"path" varchar NOT NULL,
	contents varchar NULL,
	write_time timestamp with time zone,
	CONSTRAINT un_app_storage_app_path UNIQUE (app_id, path),
	CONSTRAINT pk_app_storage PRIMARY KEY (file_id)
);
CREATE INDEX fki_app_storage_app_fkey ON project.app_storage USING btree (app_id);


-- project.app_storage foreign keys

ALTER TABLE project.app_storage ADD CONSTRAINT fk_app_storage_app FOREIGN KEY (app_id) REFERENCES project.app(app_id);
