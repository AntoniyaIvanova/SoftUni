DELETE 
FROM [Reports] 
WHERE StatusId IN(
SELECT Id
FROM [Status]
WHERE Id = 4)

DELETE
FROM [Status]
WHERE Id = 4
