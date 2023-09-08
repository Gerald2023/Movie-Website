CREATE TABLE [dbo].[tblOrderItem]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[OrderId] INT NOT NULL,
	[MovieId] INT NOT NULL,
	[Quantity] INT NOT NULL,
	[Cost] DECIMAL(18,2) NOT NULL
)
