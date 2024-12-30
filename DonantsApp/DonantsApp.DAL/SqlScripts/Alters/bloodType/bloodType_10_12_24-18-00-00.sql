CREATE TABLE BloodType
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Description VARCHAR(3) NOT NULL
)
INSERT INTO BloodType(Description)
VALUES
('A+'),
('A-'),
('B+'),
('B-'),
('AB+'),
('AB-'),
('O+'),
('O-')
GO
