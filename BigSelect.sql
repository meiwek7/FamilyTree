CREATE VIEW CharacterFullInfo
AS
SELECT 
CharacterFirstName.firstName
,CharacterSecondName.secondName
,CharacterLastName.lastName
,CharacterNationality.nationality
,CharacterBirthCountry.country as birthCountry
,CharacterDeathCountry.country as deathCountry
,CharacterLivingCountry.country as livingCountry
,CharacterBirthPlace.place as birthPlace
,CharacterDeathPlace.place as deathPlace
,CharacterLivingPlace.place as livingPalce
,CharacterReligious.religious
,CharacterBirthDate.birthDate
,CharacterDeathDate.deathDate
,CharacterBiography.biography
,CharacterPhoto.photo
FROM Character
LEFT JOIN CharacterFirstName ON Character.id = CharacterFirstName.characterId
AND CharacterFirstName.changeId IN (SELECT MAX(changeId) as maxchangeId
									FROM CharacterFirstName
									GROUP BY characterId
									)
LEFT JOIN CharacterSecondName ON Character.id = CharacterSecondName.characterId
AND CharacterSecondName.changeId IN (SELECT MAX(changeId) as maxchangeId
									FROM CharacterSecondName
									GROUP BY characterId
									)
LEFT JOIN CharacterLastName ON Character.id = CharacterLastName.characterId
AND CharacterLastName.changeId IN (SELECT MAX(changeId) as maxchangeId
									FROM CharacterLastName
									GROUP BY characterId
									)
LEFT JOIN CharacterNationality ON Character.id = CharacterNationality.characterId
AND CharacterNationality.changeId IN (SELECT MAX(changeId) as maxchangeId
									FROM CharacterNationality
									GROUP BY characterId
									)
LEFT JOIN CharacterBirthCountry ON Character.id = CharacterBirthCountry.characterId
AND CharacterBirthCountry.changeId IN (SELECT MAX(changeId) as maxchangeId
									FROM CharacterBirthCountry
									GROUP BY characterId
									)
LEFT JOIN CharacterDeathCountry ON Character.id = CharacterDeathCountry.characterId
AND CharacterDeathCountry.changeId IN (SELECT MAX(changeId) as maxchangeId
									FROM CharacterDeathCountry
									GROUP BY characterId
									)
LEFT JOIN CharacterLivingCountry ON Character.id = CharacterLivingCountry.charcaterId
AND CharacterLivingCountry.changeId IN (SELECT MAX(changeId) as maxchangeId
									FROM CharacterLivingCountry
									GROUP BY charcaterId
									--ֿמלוםÿעü טלÿ סעמכבצא
									)
LEFT JOIN CharacterBirthPlace ON Character.id = CharacterBirthPlace.characterId
AND CharacterBirthPlace.changeId IN (SELECT MAX(changeId) as maxchangeId
									FROM CharacterBirthPlace
									GROUP BY characterId
									)
LEFT JOIN CharacterDeathPlace ON Character.id = CharacterDeathPlace.characterId
AND CharacterDeathPlace.changeId IN (SELECT MAX(changeId) as maxchangeId
									FROM CharacterDeathPlace
									GROUP BY characterId
									)
LEFT JOIN CharacterLivingPlace ON Character.id = CharacterLivingPlace.characterId
AND CharacterLivingPlace.changeId IN (SELECT MAX(changeId) as maxchangeId
									FROM CharacterLivingPlace
									GROUP BY characterId
									)
LEFT JOIN CharacterReligious ON Character.id = CharacterReligious.characterId
AND CharacterReligious.changeId IN (SELECT MAX(changeId) as maxchangeId
									FROM CharacterReligious
									GROUP BY characterId
									)
LEFT JOIN CharacterBirthDate ON Character.id = CharacterBirthDate.characterId
AND CharacterBirthDate.changeId IN (SELECT MAX(changeId) as maxchangeId
									FROM CharacterBirthDate
									GROUP BY characterId
									)
LEFT JOIN CharacterDeathDate ON Character.id = CharacterDeathDate.characterId
AND CharacterDeathDate.changeId IN (SELECT MAX(changeId) as maxchangeId
									FROM CharacterDeathDate
									GROUP BY characterId
									)
LEFT JOIN CharacterBiography ON Character.id = CharacterBiography.characterId
AND CharacterBiography.changeId IN (SELECT MAX(changeId) as maxchangeId
									FROM CharacterBiography
									GROUP BY characterId
									)
LEFT JOIN CharacterPhoto ON Character.id = CharacterBiography.characterId
AND CharacterPhoto.changeId IN (SELECT MAX(changeId) as maxchangeId
									FROM CharacterPhoto
									GROUP BY characterId
									)