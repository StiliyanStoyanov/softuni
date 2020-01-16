CREATE TABLE Users (
	Id INT PRIMARY KEY IDENTITY,
	Username NVARCHAR(200) NOT NULL,
	[Password] VARCHAR(96) NOT NULL,
	ProfilePicture VARBINARY(MAX),
	LastLoginTime DATETIME,
	IsDeleted BIT
	-- Possible Change So Primary Key is not Autonamed 
	-- Id INT UNIQUE IDENTITY,
	-- CONSTRAINT PK_Users PRIMARY KEY(Id)
)

INSERT INTO Users (Username, [Password], ProfilePicture, LastLoginTime, IsDeleted)
 VALUES
('Stamat', HASHBYTES('SHA1', '123'), NULL, CONVERT(datetime,'22-07-2018', 103), 0),
('Gosho', '456', NULL, CONVERT(datetime,'01-05-2018', 103), 0),
('Pesho', '789', NULL, CONVERT(datetime,'06-11-2018', 103), 0),
('Vankata', '321', NULL, CONVERT(datetime,'25-12-2018', 103), 0),
('Kiro', '654', NULL, CONVERT(datetime,'11-08-2018', 103), 0)

ALTER TABLE Users
ADD CONSTRAINT Check_ProfilePicture 
CHECK (DATALENGTH(ProfilePicture) <= 900 * 1024)
