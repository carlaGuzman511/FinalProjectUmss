CREATE TABLE DonationType
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Description VARCHAR(20) NOT NULL
)
GO
INSERT INTO DonationType(Description)
VALUES
('Sangre'),
('Riñón'),
('Hígado'),
('Pulmón'),
('Páncreas'),
('Intestino Delgado'),
('Corazón'),
('Corneas'),
('Huesos'),
('Piel'),
('Tendones'),
('Medula Osea')
GO