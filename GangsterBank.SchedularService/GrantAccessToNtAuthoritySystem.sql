CREATE USER [NT AUTHORITY\SYSTEM]
    FOR LOGIN [NT AUTHORITY\SYSTEM]
    WITH DEFAULT_SCHEMA = dbo;
Go

EXEC sp_addrolemember 'db_owner', 'NT AUTHORITY\SYSTEM'