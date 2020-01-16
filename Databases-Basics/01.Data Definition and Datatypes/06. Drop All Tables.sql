EXEC sp_msforeachtable "ALTER TABLE ? NOCHECK CONSTRAINT all" -- Checks For Foreign Key
EXEC sp_MSforeachtable @command1 = "DROP TABLE ?" -- Drops All Tables