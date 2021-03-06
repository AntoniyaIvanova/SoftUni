SELECT [Name] as [Game], 
CASE
	WHEN
		DATEPART(HOUR, Start) BETWEEN 0 AND 11 THEN 'Morning'
	WHEN
		DATEPART(HOUR, Start) BETWEEN 12 AND 17 THEN 'Afternoon' 
	WHEN
		DATEPART(HOUR, Start) BETWEEN 18 AND 23 THEN 'Evening'
END AS [Part of the Day], 
CASE
	WHEN 
		Duration <= 3 THEN 'Extra Short'
	WHEN
		Duration >= 4 AND Duration <= 6 THEN 'Short'
	WHEN 
		Duration > 6 THEN 'Long'
	WHEN 
		Duration IS NULL THEN 'Extra Long'
END as [Duration]
FROM GAMES
ORDER BY [Game], [Duration]
