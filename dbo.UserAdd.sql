CREATE PROC	GovedoAdd
@IDzivali varchar(50),
@Imeživali varchar(50),
@Datumrojstva date,
@Spol varchar(50),
@Pasma varchar(50),
@IDmatere varchar(50),
@IDočeta varchar(50),
@Dokument image
AS
	INSERT INTO Govedo(IDzivali, Imezivali, Datumrojstva, Spol, Pasma, IDmatere, IDoceta, Dokument)
	VALUES (@IDzivali,@Imezivali,@Datumrojstva,@Spol,@Pasma,@IDmatere,@IDoceta,@Dokument)