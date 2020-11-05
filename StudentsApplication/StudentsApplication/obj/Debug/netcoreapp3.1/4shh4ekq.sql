IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Student] (
    [StudentId] uniqueidentifier NOT NULL,
    [AnotherKeyProperty] uniqueidentifier NOT NULL,
    [Name] nvarchar(12) NOT NULL,
    [Age] int NULL,
    [IsRegularStudent] bit NOT NULL DEFAULT CAST(1 AS bit),
    CONSTRAINT [PK_Student] PRIMARY KEY ([StudentId])
);

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'AnotherKeyProperty', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] ON;
INSERT INTO [Student] ([StudentId], [Age], [AnotherKeyProperty], [Name])
VALUES ('752b1c8b-0674-437e-8bbc-7fe1cfe7dfb5', 30, '00000000-0000-0000-0000-000000000000', N'John Doe');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'AnotherKeyProperty', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'AnotherKeyProperty', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] ON;
INSERT INTO [Student] ([StudentId], [Age], [AnotherKeyProperty], [Name])
VALUES ('eb5da8aa-f7b3-489b-9c73-2253de285ffc', 25, '00000000-0000-0000-0000-000000000000', N'Jane Doe');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'AnotherKeyProperty', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'AnotherKeyProperty', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] ON;
INSERT INTO [Student] ([StudentId], [Age], [AnotherKeyProperty], [Name])
VALUES ('be0de541-9d5d-4b58-af0f-2192ba3eea4c', 28, '00000000-0000-0000-0000-000000000000', N'Mike Miles');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'AnotherKeyProperty', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201105101921_InitialMigration', N'3.1.9');

GO

DELETE FROM [Student]
WHERE [StudentId] = '752b1c8b-0674-437e-8bbc-7fe1cfe7dfb5';
SELECT @@ROWCOUNT;


GO

DELETE FROM [Student]
WHERE [StudentId] = 'be0de541-9d5d-4b58-af0f-2192ba3eea4c';
SELECT @@ROWCOUNT;


GO

DELETE FROM [Student]
WHERE [StudentId] = 'eb5da8aa-f7b3-489b-9c73-2253de285ffc';
SELECT @@ROWCOUNT;


GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Student]') AND [c].[name] = N'AnotherKeyProperty');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Student] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Student] DROP COLUMN [AnotherKeyProperty];

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] ON;
INSERT INTO [Student] ([StudentId], [Age], [Name])
VALUES ('3398544f-756e-476b-8839-88a5a5cdf6e6', 30, N'John Doe');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] ON;
INSERT INTO [Student] ([StudentId], [Age], [Name])
VALUES ('be2b5622-bfc4-40e8-bce1-fa8fbcb814e6', 25, N'Jane Doe');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] ON;
INSERT INTO [Student] ([StudentId], [Age], [Name])
VALUES ('7a393d79-ec68-4292-ac62-45c7f26c18d1', 28, N'Mike Miles');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201105102038_DeletedAnotherStudentKey', N'3.1.9');

GO

DELETE FROM [Student]
WHERE [StudentId] = '3398544f-756e-476b-8839-88a5a5cdf6e6';
SELECT @@ROWCOUNT;


GO

DELETE FROM [Student]
WHERE [StudentId] = '7a393d79-ec68-4292-ac62-45c7f26c18d1';
SELECT @@ROWCOUNT;


GO

DELETE FROM [Student]
WHERE [StudentId] = 'be2b5622-bfc4-40e8-bce1-fa8fbcb814e6';
SELECT @@ROWCOUNT;


GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] ON;
INSERT INTO [Student] ([StudentId], [Age], [Name])
VALUES ('31d0b276-f175-4d6d-bc3f-afa8777caf8f', 30, N'John Doe'),
('3287a62e-9f49-4655-ae0e-ba0ac04630be', 25, N'Jane Doe'),
('cee77ebd-82eb-436b-a018-5f6affa11c89', 28, N'Mike Miles'),
('a7df0328-d0c1-48bf-9a07-f1b80eb2b41f', 29, N'Angela Green');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201105111459_NewStudentsMigration', N'3.1.9');

GO

