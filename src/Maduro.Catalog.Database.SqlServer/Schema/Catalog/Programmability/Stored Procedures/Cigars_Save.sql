CREATE PROCEDURE [Catalog].[Cigars_Save]
(
	@Id uniqueidentifier,
	@Data nvarchar(MAX)
)
AS

    IF EXISTS(SELECT 1 FROM [Catalog].[Cigars] WHERE [Id] = @Id)
	BEGIN
		UPDATE
			[Catalog].[Cigars]
		SET
			[Data] = @Data
		WHERE
			[Id] = @Id
	END
	ELSE
	BEGIN
		INSERT INTO
			[Catalog].[Cigars]
			(
                [Id],
				[Data]
			)
		VALUES
			(
                @Id,
				@Data
			)
	END