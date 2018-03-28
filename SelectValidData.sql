SELECT firstName
FROM CharacterFirstName
WHERE changeId IN (
					SELECT MAX(changeId) as maxchangeId
					FROM CharacterFirstName
					GROUP BY characterId
					)