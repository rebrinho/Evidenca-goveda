CREATE TABLE [dbo].[Govedo] (
    [ID]            INT          IDENTITY (1, 1) NOT NULL,
    [ID živali]     VARCHAR (50) NOT NULL,
    [Ime živali]    VARCHAR (50) NOT NULL,
    [Datum rojstva] VARCHAR (50) NOT NULL,
    [Spol]          VARCHAR (50) NOT NULL,
    [Pasma]         VARCHAR (50) NOT NULL,
    [ID matere]     VARCHAR (50) NOT NULL,
    [ID očeta]      VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Govedo] PRIMARY KEY CLUSTERED ([ID] ASC)
);

