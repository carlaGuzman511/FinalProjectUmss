CREATE TABLE Comment
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Description VARCHAR(2000) NOT NULL,
	PostId INT FOREIGN KEY REFERENCES Post(Id),
	DateAdded DATETIME NOT NULL,
	DateChanged DATETIME NOT NULL
)
GO
INSERT INTO Comment(Description, PostId, DateAdded, DateChanged)
VALUES
('yo podria donar', 1, GETDATE(), GETDATE()),
('me parece haber visto una persona con la misma ropa en la av. 6 de agosto a las 10 de la maniana', 2, GETDATE(), GETDATE()),
('accidente en la av 6 de agosto', 3, GETDATE(), GETDATE()),
('incidente', 4, GETDATE(), GETDATE())
GO