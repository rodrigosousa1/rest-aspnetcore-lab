CREATE TABLE IF NOT EXISTS public."Persons"
(
    "Id" serial NOT NULL,
    "FirstName" character varying(60) COLLATE pg_catalog."default" NOT NULL,
    "LastName" character varying(60) COLLATE pg_catalog."default" NOT NULL,
    "Address" character varying(60) COLLATE pg_catalog."default" NOT NULL,
    "Gender" character varying(60) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT "Persons_pkey" PRIMARY KEY ("Id")
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public."Persons"
    OWNER to postgres;