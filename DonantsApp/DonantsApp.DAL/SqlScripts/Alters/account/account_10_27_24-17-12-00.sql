CREATE TABLE Account
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Username VARCHAR(15),
	Password VARCHAR(30),
	PersonId INT FOREIGN KEY REFERENCES Person(Id),
)
GO

INSERT INTO Account(Username, Password, PersonId)
VALUES
('carlag', 'c7317943G*', 1),
('josesg', 'c7317943G*', 3),
('alvarog', 'c7317943G*', 4),
('soniag', 'c7317943G*', 2),
('joselg', 'c7317943G*', 5)
GO