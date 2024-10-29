CREATE TABLE Person
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	FirstName VARCHAR(100) NOT NULL,
	LastName VARCHAR(100) NOT NULL,
	BirthDate DATE NOT NULL,
	BloodTypeId INT FOREIGN KEY REFERENCES BloodType(Id),
	PhoneNumber VARCHAR(20) NULL,
	Image VARCHAR(MAX) NULL,
	Address VARCHAR(50),
	Ci VARCHAR(20)
)
GO
INSERT INTO Person(FirstName, LastName, BirthDate, BloodTypeId, PhoneNumber, Image, Address, Ci)
VALUES
('Carla Marcela', 'Guzman Miranda', '1997-11-05', 8, '75478526', NULL, 'Av. Panamericana J.G. Aguirre # 1000', '73179413'),
('Sonia Berna', 'Miranda Aspiazu', '1968-08-20', 8, '75478521', NULL, 'Av. Panamericana J.G. Aguirre # 100', '3504559'),
('Jose Sergio', 'Guzman Miranda', '2000-08-20', 8, '71478526', NULL, 'Av. Panamericana J.G. Aguirre # 1000', '73779413'),
('Alvaro Fernando', 'Guzman Miranda', '2006-09-30', 8, '72478526', NULL, 'Av. Panamericana J.G. Aguirre # 1000', '9479413'),
('Jose Luis', 'Guzman Agreda', '1971-05-10', 8, '71478526', NULL, 'Av. Panamericana J.G. Aguirre # 1000', '4379413')
GO