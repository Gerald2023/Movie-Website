CREATE TABLE [dbo].[tblMovie]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Title] VARCHAR(50) NOT NULL,
	[Descripition] VARCHAR(50) NOT NULL, 
	[Cost] DECIMAL(18,2) NOT NULL,
	[RatingId] INT NOT NULL,
	[FormatId] INT NOT NULL,
	[DirectorId] INT NOT NULL,
	[InStkQty] INT NOT NULL,
	[ImagePath] VARCHAR(50) NOT NULL,


)
