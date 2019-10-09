CREATE PROCEDURE [Catalog].[Cigars_GetSingle]
(
	@Id uniqueidentifier
)
AS

	SELECT 
		[Id],
		[Data] AS SerializedContent
	FROM
		[Catalog].[Cigars]
	WHERE
		[Id] = @Id