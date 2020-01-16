CREATE DATABASE Movies

USE Movies
GO

CREATE TABLE Directors (
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	DirectorName VARCHAR(30) UNIQUE NOT NULL,
	Notes VARCHAR(300),
)

CREATE TABLE Genres(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	GenreName VARCHAR(30) UNIQUE NOT NULL,
	Notes VARCHAR(300),
)

CREATE TABLE Categories(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	CategoryName VARCHAR(30) UNIQUE NOT NULL,
	Notes VARCHAR(300),
)

CREATE TABLE Movies(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	Title VARCHAR(50) UNIQUE NOT NULL,
	DirectorId INT NOT NULL,
	CopyrightYear INT NOT NULL,
	Length INT NOT NULL,
	GenreId INT NOT NULL, 
	CategoryId INT NOT NULL, 
	Rating NUMERIC(2, 1), 
	Notes NVARCHAR(max),
	FOREIGN KEY (DirectorId) REFERENCES Directors (Id),
	FOREIGN KEY (GenreId) REFERENCES Genres (Id),
	FOREIGN KEY (CategoryId) REFERENCES Categories (Id),
	CHECK (CopyrightYear >= 1900),
	CHECK (Rating > 0 AND Rating <= 10),
	CHECK (Length > 0)
)



INSERT INTO Directors
VALUES
('George Lucas', 'Lucas is best known as the creator of the Star Wars and Indiana Jones franchises'),
('Christopher Nolan', 'One of my favorite director'),
('Steven Spilberg', 'One of the most influential personalities in the history of cinema'),
('Frank Darabont', 'Three time Oscar mominee, Known for the Shawshank Redemption'),
('Ridley Scott', 'Described by film producer Michael Deeley as "the very best eye in the business')

/*
INSERT INTO Directors(DirectorName)
VALUES
('Clint Eastwood')

UPDATE Directors
SET DirectorName = 'George Lucas', Notes = 'Lucas is best known as the creator of the Star Wars and Indiana Jones franchises'
WHERE Id = 6
*/
SELECT * FROM Directors