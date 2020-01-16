ALTER TABLE Users
ADD CONSTRAINT Default_LastLogin DEFAULT GETDATE() FOR LastLoginTime;
-- Optional WHERE

SELECT * FROM Users

UPDATE Users
SET LastLoginTime = DEFAULT;



