CREATE TABLE PostType
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Description VARCHAR(50) NOT NULL
)
INSERT INTO PostType(Description)
VALUES
('Donacion'),
('Busqueda de Personas Desaparecidas'),
('Accidente'),
('Incidente')
GO