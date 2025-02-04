CREATE VIEW [dbo].[PersonAddress]
	AS
	SELECT [p].[Id] AS PersonId, [p].[FirstName], [p].[LastName],
		[a].[Id] as AddressId, [a].[StreetAddress],
		[a].[City], [a].[State], [a].[ZipCode]
	FROM dbo.Person p 
	LEFT JOIN dbo.Address a on p.Id = a.PersonId
