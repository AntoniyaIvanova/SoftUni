SELECT CONCAT(p.FirstName, ' ', p.LastName) AS [Full Name], pl.Name AS [Plane Name], CONCAT(f.Origin, ' - ', f.Destination), lt.Type AS [Luggage Type]
FROM Passengers AS p
JOIN Tickets AS t
ON p.Id = t.PassengerId
JOIN Flights AS f
ON f.Id = t.FlightId
JOIN Planes AS pl
ON pl.Id = f.PlaneId
JOIN Luggages AS l
ON l.Id = t.LuggageId
JOIN LuggageTypes AS lt
ON lt.Id = l.LuggageTypeId
ORDER BY [Full Name] ASC, pl.Name ASC, f.Origin ASC, f.Destination ASC, lt.Type ASC