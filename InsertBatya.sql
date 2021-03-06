USE [FamilyTree]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[InsertNewChar]
		@UserId = 2,
		@firstName = N'Andrey',
		@secondName = N'Nikolaevich',
		@lastName = N'Bakhmat',
		@nationality = N'Ukrainian',
		@birthCountry = N'Ukraine',
		@deathCountry = NULL,
		@livingCountry = N'Ukraine',
		@birthPlace = N'Zachepilovka',
		@deathPlace = NULL,
		@livingPalce = N'Kiev',
		@religious = N'Atheist',
		@birthDate = '19711018',
		@deathDate = NULL,
		@biography = N'Prosto moy Batya',
		@photo = NULL

SELECT	'Return Value' = @return_value

GO
