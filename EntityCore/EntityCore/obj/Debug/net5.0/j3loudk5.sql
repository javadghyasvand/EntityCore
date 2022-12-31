IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [CodesSet] (
    [Description] nvarchar(max) NULL,
    [Price] float NOT NULL,
    [Id] bigint NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Inventory] bigint NOT NULL,
    [DateTime] datetime2 NOT NULL,
    CONSTRAINT [PK_CodesSet] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221230062827_init', N'5.0.0');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [CodesSet] DROP CONSTRAINT [PK_CodesSet];
GO

EXEC sp_rename N'[CodesSet]', N'Products';
GO

ALTER TABLE [Products] ADD CONSTRAINT [PK_Products] PRIMARY KEY ([Id]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221230111939_data', N'5.0.0');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Products] ADD [IsInStok] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221231151155_addInstok', N'5.0.0');
GO

COMMIT;
GO

