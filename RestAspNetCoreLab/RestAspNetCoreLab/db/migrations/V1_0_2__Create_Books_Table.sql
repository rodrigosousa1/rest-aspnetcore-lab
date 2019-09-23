CREATE TABLE IF NOT EXISTS public."Books"
(
    "Id" serial NOT NULL,
    "Author" character varying(20) COLLATE pg_catalog."default" NOT NULL,
    "PublishDate" timestamp without time zone NOT NULL,
    "Price" numeric(65,2) NOT NULL,
    "Title" character varying(50) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT "Books_pkey" PRIMARY KEY ("Id")
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public."Books"
    OWNER to postgres;