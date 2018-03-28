USE FamilyTree;
GO
CREATE PROCEDURE InsertNewChar
@UserId							int
,@firstName						varchar(50)	 = NULL
,@secondName					varchar(50)	 = NULL
,@lastName						varchar(50)	 = NULL
,@nationality					varchar(30)	 = NULL
,@birthCountry					varchar(30)	 = NULL
,@deathCountry					varchar(30)	 = NULL
,@livingCountry					varchar(30)	 = NULL
,@birthPlace					varchar(30)	 = NULL
,@deathPlace					varchar(30)	 = NULL
,@livingPalce					varchar(30)	 = NULL
,@religious						varchar(30)	 = NULL
,@birthDate						date		 = NULL
,@deathDate						date		 = NULL
,@biography						varchar(max) = NULL
,@photo							varchar(200)  = NULL
AS
BEGIN
    INSERT INTO Logs
	VALUES(@UserId)

	INSERT INTO Character
	VALUES(@UserId)

	DECLARE @LogId int
	SET @LogId = (
					SELECT MAX(Logs.changeId)
					FROM Logs
					WHERE userId = @UserId
				  )
	
	DECLARE @CharId int
	SET @CharId = (
					SELECT MAX(Character.id)
					FROM Character
					WHERE Character.creator = @UserId
				  )

	IF (@firstName IS NOT NULL)
	BEGIN
		 INSERT INTO CharacterFirstName
		 VALUES(@CharId, @firstName, @LogId)
	END
	IF (@secondName IS NOT NULL)
	BEGIN
		 INSERT INTO CharacterSecondName
		 VALUES(@CharId, @SecondName, @LogId)
	END
	
	IF (@lastName IS NOT NULL)
	BEGIN
		 INSERT INTO CharacterLastName
		 VALUES(@CharId, @lastName, @LogId)
	END
	IF (@nationality IS NOT NULL)
	BEGIN
		 IF(
		    (SELECT name
			 FROM Nationality
			 WHERE Nationality.name = @nationality
			 ) IS NULL)
			 BEGIN
				INSERT INTO Nationality
				VALUES(@nationality)
			 END
		 INSERT INTO CharacterNationality
		 VALUES(@CharId, @nationality, @LogId)
	END
	IF (@birthCountry IS NOT NULL)
	BEGIN
		IF(
		    (SELECT name
			 FROM Country
			 WHERE Country.name = @birthCountry
			 ) IS NULL)
			 BEGIN
				INSERT INTO Country
				VALUES(@birthCountry)
			 END
		 INSERT INTO CharacterBirthCountry
		 VALUES(@CharId, @birthCountry, @LogId)
	END
	IF (@deathCountry IS NOT NULL)
	BEGIN
		IF(
		    (SELECT name
			 FROM Country
			 WHERE Country.name = @deathCountry
			 ) IS NULL)
			 BEGIN
				INSERT INTO Country
				VALUES(@deathCountry)
			 END
		 INSERT INTO CharacterDeathCountry
		 VALUES(@CharId, @deathCountry, @LogId)
	END
	IF (@livingCountry IS NOT NULL)
	BEGIN
		IF(
		    (SELECT name
			 FROM Country
			 WHERE Country.name = @livingCountry
			 ) IS NULL)
			 BEGIN
				INSERT INTO Country
				VALUES(@livingCountry)
			 END
		 INSERT INTO CharacterLivingCountry
		 VALUES(@CharId, @livingCountry, @LogId)
	END
	IF (@birthPlace IS NOT NULL)
	BEGIN
		IF(
		    (SELECT name
			 FROM Place
			 WHERE Place.name = @birthPlace
			 ) IS NULL)
			 BEGIN
				INSERT INTO Place
				VALUES(@birthPlace)
			 END
		 INSERT INTO CharacterBirthPlace
		 VALUES(@CharId, @birthPlace, @LogId)
	END
	IF (@deathPlace IS NOT NULL)
	BEGIN
		IF(
		    (SELECT name
			 FROM Place
			 WHERE Place.name = @deathPlace
			 ) IS NULL)
			 BEGIN
				INSERT INTO Place
				VALUES(@deathPlace)
			 END
		 INSERT INTO CharacterDeathPlace
		 VALUES(@CharId, @deathPlace, @LogId)
	END
	IF (@livingPalce IS NOT NULL)
	BEGIN
		IF(
		    (SELECT name
			 FROM Place
			 WHERE Place.name = @livingPalce
			 ) IS NULL)
			 BEGIN
				INSERT INTO Place
				VALUES(@livingPalce)
			 END
		 INSERT INTO CharacterLivingPlace
		 VALUES(@CharId, @livingPalce, @LogId)
	END
	IF (@religious IS NOT NULL)
	BEGIN
		IF(
		    (SELECT name
			 FROM Religious
			 WHERE Religious.name = @religious
			 ) IS NULL)
			 BEGIN
				INSERT INTO Religious
				VALUES(@religious)
			 END
		 INSERT INTO CharacterReligious
		 VALUES(@CharId, @religious, @LogId)
	END
	IF (@birthDate IS NOT NULL)
	BEGIN
		 INSERT INTO CharacterBirthDate
		 VALUES(@CharId, @birthDate, @LogId)
	END
	IF (@deathDate IS NOT NULL)
	BEGIN
		 INSERT INTO CharacterDeathDate
		 VALUES(@CharId, @deathDate, @LogId)
	END
	IF (@biography IS NOT NULL)
	BEGIN
		 INSERT INTO CharacterBiography
		 VALUES(@CharId, @biography, @LogId)
	END
	IF (@photo IS NOT NULL)
	BEGIN
		 INSERT INTO CharacterPhoto
		 VALUES(@CharId, @photo, @LogId)
	END
END;