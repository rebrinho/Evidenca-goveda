CREATE TABLE [dbo].[Uporabniki] (
    [ID]                INT          NOT NULL,
    [Ime]               VARCHAR (50) NULL,
    [Priimek]           VARCHAR (50) NULL,
    [Uporabniško geslo] NCHAR (15)   NULL,
    CONSTRAINT [PK_Uporabniki] PRIMARY KEY ([ID])
);

