CREATE TABLE Status
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Description VARCHAR(20) NOT NULL
)
GO
INSERT INTO Status(Description)
VALUES
('Activo'),
('Inactivo')
GO