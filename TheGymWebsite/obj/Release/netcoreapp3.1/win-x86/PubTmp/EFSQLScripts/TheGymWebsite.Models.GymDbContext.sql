IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        [Title] int NOT NULL,
        [FirstName] nvarchar(max) NOT NULL,
        [LastName] nvarchar(max) NOT NULL,
        [DateOfBirth] datetime2 NOT NULL,
        [Gender] int NOT NULL,
        [AddressLineOne] nvarchar(max) NOT NULL,
        [AddressLineTwo] nvarchar(max) NULL,
        [Town] nvarchar(max) NOT NULL,
        [Postcode] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    CREATE TABLE [FreePasses] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [Email] nvarchar(max) NOT NULL,
        [DateIssued] datetime2 NOT NULL,
        [DateUsed] datetime2 NULL,
        CONSTRAINT [PK_FreePasses] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    CREATE TABLE [Gyms] (
        [Id] int NOT NULL IDENTITY,
        [GymName] nvarchar(50) NOT NULL,
        [Email] nvarchar(max) NOT NULL,
        [AddressLineOne] nvarchar(max) NOT NULL,
        [AddressLineTwo] nvarchar(max) NULL,
        [Town] nvarchar(max) NOT NULL,
        [Postcode] nvarchar(max) NOT NULL,
        [Telephone] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Gyms] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    CREATE TABLE [MembershipDeals] (
        [Id] int NOT NULL IDENTITY,
        [Duration] int NOT NULL,
        [Price] decimal(18,2) NOT NULL,
        CONSTRAINT [PK_MembershipDeals] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    CREATE TABLE [OpenHours] (
        [Id] int NOT NULL IDENTITY,
        [Date] datetime2 NOT NULL,
        [DayName] int NOT NULL,
        [OpenTime] time NOT NULL,
        [CloseTime] time NOT NULL,
        [Note] nvarchar(max) NULL,
        CONSTRAINT [PK_OpenHours] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    CREATE TABLE [Vacancies] (
        [Id] int NOT NULL IDENTITY,
        [JobTitle] nvarchar(200) NOT NULL,
        [JobType] int NOT NULL,
        [JobPeriod] int NOT NULL,
        [Salary] decimal(18,2) NOT NULL,
        [PayInterval] int NOT NULL,
        [Description] nvarchar(max) NULL,
        CONSTRAINT [PK_Vacancies] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(450) NOT NULL,
        [ProviderKey] nvarchar(450) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(450) NOT NULL,
        [Name] nvarchar(450) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    CREATE TABLE [AttendanceRecord] (
        [Id] bigint NOT NULL IDENTITY,
        [Date] datetime2 NOT NULL,
        [UserId] nvarchar(450) NULL,
        CONSTRAINT [PK_AttendanceRecord] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AttendanceRecord_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
        SET IDENTITY_INSERT [AspNetRoles] ON;
    INSERT INTO [AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
    VALUES (N'a493461b-47bc-474d-bd3a-07a52957747a', N'e7b51411-2fe7-449d-b874-dd19059caf5b', N'Admin', N'ADMIN');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
        SET IDENTITY_INSERT [AspNetRoles] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'AddressLineOne', N'AddressLineTwo', N'ConcurrencyStamp', N'DateOfBirth', N'Email', N'EmailConfirmed', N'FirstName', N'Gender', N'LastName', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'Postcode', N'SecurityStamp', N'Title', N'Town', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
        SET IDENTITY_INSERT [AspNetUsers] ON;
    INSERT INTO [AspNetUsers] ([Id], [AccessFailedCount], [AddressLineOne], [AddressLineTwo], [ConcurrencyStamp], [DateOfBirth], [Email], [EmailConfirmed], [FirstName], [Gender], [LastName], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [Postcode], [SecurityStamp], [Title], [Town], [TwoFactorEnabled], [UserName])
    VALUES (N'058d87a0-1976-44a2-8c88-4781b3511e4c', 0, N'1 Admin Road', N'Admin Area', N'bb87ff6b-66a1-4d68-8ca2-e793c258ef80', '2000-01-01T00:00:00.0000000', N'admin@admin.com', CAST(1 AS bit), N'AdminFirstName', 0, N'AdminLastName', CAST(0 AS bit), NULL, N'ADMIN@ADMIN.COM', N'ADMIN@ADMIN.COM', N'AQAAAAEAACcQAAAAEAJzw8cCMpe+bq3T1HT+uYdF+YFj2uflfKlk27wkgzFcmP5bAIVgCNPqPKKWAxy8Mg==', N'00000000000', CAST(0 AS bit), N'AD1 2MN', N'c39b4a6d-569e-43c8-a192-553881a11a63', 0, N'AdminTown', CAST(0 AS bit), N'admin@admin.com'),
    (N'edba9b4b-0235-4eee-bb81-355a5ccd3b52', 0, N'1 huss Road', N'huss Area', N'770912ad-9d58-45fa-924d-7072c546ad4e', '2000-01-01T00:00:00.0000000', N'huss@yahoo.com', CAST(1 AS bit), N'hussFirstName', 0, N'hussLastName', CAST(0 AS bit), NULL, N'HUSS@YAHOO.COM', N'HUSS@YAHOO.COM', N'AQAAAAEAACcQAAAAEBcyJoaBvyjTiu64WZWJAoMrHo3CzYKfNOG7QP2vGMx0MUVtqP64CZwKc6EvvG8Cgw==', N'00000000000', CAST(0 AS bit), N'AD1 2MN', N'89570777-b26f-409e-9a68-7098413a5410', 0, N'hussTown', CAST(0 AS bit), N'huss@yahoo.com'),
    (N'693011a1-d273-4e3c-9337-2b318e3202cc', 0, N'1 beky Road', N'beky Area', N'8505d011-cafb-47e0-819d-b9e16e861d7a', '1950-01-01T00:00:00.0000000', N'beky@yahoo.com', CAST(1 AS bit), N'bekyFirstName', 1, N'bekyLastName', CAST(0 AS bit), NULL, N'BEKY@YAHOO.COM', N'BEKY@YAHOO.COM', N'AQAAAAEAACcQAAAAEEfMAA9YKfKKGtiopfQ3qot1JcFtVDFY2gbz7WbuUbzlRVUIWyGN/9lcMNwx7+61hw==', N'00000000000', CAST(0 AS bit), N'AD1 2MN', N'6ef16860-8d45-4515-98fe-bbad3b7b7cd2', 0, N'bekyTown', CAST(0 AS bit), N'beky@yahoo.com'),
    (N'37aa996d-0a42-4f4f-a865-efd9d896562e', 0, N'1 alice Road', N'alice Area', N'09856784-ea96-4385-a336-6d375d76d49c', '1960-01-01T00:00:00.0000000', N'alice@yahoo.com', CAST(1 AS bit), N'aliceFirstName', 1, N'aliceLastName', CAST(0 AS bit), NULL, N'ALICE@YAHOO.COM', N'ALICE@YAHOO.COM', N'AQAAAAEAACcQAAAAEOAHhH3dXLXUFIYC7ZGNPdUuMvLZMF3qukDxYqJeqoHO0rJjhKWum7xMOz4GP3NuJQ==', N'00000000000', CAST(0 AS bit), N'AD1 2MN', N'9070433b-4c7a-4e17-a440-9558eccc356b', 0, N'aliceTown', CAST(0 AS bit), N'alice@yahoo.com'),
    (N'5e22abd5-fec6-4fec-b82c-a58ee1ed6031', 0, N'1 seba Road', N'seba Area', N'4e188020-8be8-4e48-a661-a3d582ef37e9', '1970-01-01T00:00:00.0000000', N'seba@yahoo.com', CAST(1 AS bit), N'sebaFirstName', 1, N'sebaLastName', CAST(0 AS bit), NULL, N'SEBA@YAHOO.COM', N'SEBA@YAHOO.COM', N'AQAAAAEAACcQAAAAEPx/SK1hn1C7NJe18qz6Y0kKr9K7rb83H91o9nnxxTGAoLlRleJUPrkqUgQVc+9neA==', N'00000000000', CAST(0 AS bit), N'AD1 2MN', N'32e57bd4-46d6-4bd8-8235-067a5dceee67', 0, N'sebaTown', CAST(0 AS bit), N'seba@yahoo.com'),
    (N'9b68cba0-9f94-4af8-9e06-94b7f6359489', 0, N'1 john Road', N'john Area', N'd5750fd7-a5aa-4e3a-8360-7cd157e14994', '1994-01-01T00:00:00.0000000', N'john@yahoo.com', CAST(1 AS bit), N'johnFirstName', 0, N'johnLastName', CAST(0 AS bit), NULL, N'JOHN@YAHOO.COM', N'JOHN@YAHOO.COM', N'AQAAAAEAACcQAAAAEELjtZUcSZn/opgj3Im86Qe+ovUu0c9z3K4ydcsWn/vbtoDdOCFYhFzrYVS+AcRYWw==', N'00000000000', CAST(0 AS bit), N'AD1 2MN', N'84f6df13-f30f-409c-b285-cb19b0ba78a9', 0, N'johnTown', CAST(0 AS bit), N'john@yahoo.com'),
    (N'03014e1d-0217-4c46-8e8f-a54b66e49880', 0, N'1 tom Road', N'tom Area', N'5e15e8e5-1712-44e9-9804-48cbf5b1dcde', '1993-01-01T00:00:00.0000000', N'tom@yahoo.com', CAST(1 AS bit), N'tomFirstName', 0, N'tomLastName', CAST(0 AS bit), NULL, N'TOM@YAHOO.COM', N'TOM@YAHOO.COM', N'AQAAAAEAACcQAAAAEAt5syQFXelwOQDQ8pQeQYkGIQZv5txiXNVurHf0bkLyIhd7gd9OIkcDkYbLl+PxLw==', N'00000000000', CAST(0 AS bit), N'AD1 2MN', N'b7684f7f-5dd6-4a64-9a6f-aff89aec28db', 0, N'tomTown', CAST(0 AS bit), N'tom@yahoo.com'),
    (N'1c0ddbe9-fbf3-4b7a-a1b9-08b735b2e0b9', 0, N'1 jack Road', N'jack Area', N'60c6a946-b102-42bf-b492-b2530d57c71d', '1984-01-01T00:00:00.0000000', N'jack@yahoo.com', CAST(1 AS bit), N'jackFirstName', 0, N'jackLastName', CAST(0 AS bit), NULL, N'JACK@YAHOO.COM', N'JACK@YAHOO.COM', N'AQAAAAEAACcQAAAAEAdNJXt5d4Kfgj6dzfSfTnHuu1mqUZwdi3ZtglcovSGXXtRweCvyJwY1FVUj7DNygg==', N'00000000000', CAST(0 AS bit), N'AD1 2MN', N'06d0ec12-a59c-4778-bc32-ede0c6138d95', 0, N'jackTown', CAST(0 AS bit), N'jack@yahoo.com'),
    (N'6e6ef8a9-4a93-4a1a-83e6-69e512aaf480', 0, N'1 jam Road', N'jam Area', N'fcfcf89d-93b6-4af2-b847-3e99d5a5f509', '1982-01-01T00:00:00.0000000', N'jam@yahoo.com', CAST(1 AS bit), N'jamFirstName', 0, N'jamLastName', CAST(0 AS bit), NULL, N'JAM@YAHOO.COM', N'JAM@YAHOO.COM', N'AQAAAAEAACcQAAAAENTHmXUEshF+Dd3uOkwR7A8lG1mD8G1AHRDczjamC9dyrite9K5Wo5KahIXMetfQOg==', N'00000000000', CAST(0 AS bit), N'AD1 2MN', N'9d545ffd-6f78-44b0-b3cc-7883f20f391d', 0, N'jamTown', CAST(0 AS bit), N'jam@yahoo.com'),
    (N'6512c7cd-f60f-4124-8858-5271a0a15813', 0, N'1 mark Road', N'mark Area', N'cd28c606-23a0-4e06-9904-598661da989c', '2010-01-01T00:00:00.0000000', N'mark@yahoo.com', CAST(1 AS bit), N'markFirstName', 0, N'markLastName', CAST(0 AS bit), NULL, N'MARK@YAHOO.COM', N'MARK@YAHOO.COM', N'AQAAAAEAACcQAAAAECqMdg1TtQQ+mbCEcuVKAmMcGAJdrQ4otOnHwvCP02bscp/9PvZXVJhNpZkw5p0tHw==', N'00000000000', CAST(0 AS bit), N'AD1 2MN', N'b0413cf9-e017-4c09-9b34-64859876ea0b', 0, N'markTown', CAST(0 AS bit), N'mark@yahoo.com');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'AddressLineOne', N'AddressLineTwo', N'ConcurrencyStamp', N'DateOfBirth', N'Email', N'EmailConfirmed', N'FirstName', N'Gender', N'LastName', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'Postcode', N'SecurityStamp', N'Title', N'Town', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
        SET IDENTITY_INSERT [AspNetUsers] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AddressLineOne', N'AddressLineTwo', N'Email', N'GymName', N'Postcode', N'Telephone', N'Town') AND [object_id] = OBJECT_ID(N'[Gyms]'))
        SET IDENTITY_INSERT [Gyms] ON;
    INSERT INTO [Gyms] ([Id], [AddressLineOne], [AddressLineTwo], [Email], [GymName], [Postcode], [Telephone], [Town])
    VALUES (1, N'33 Oak road', N'Erdon', N'thegymbirmingham@yahoo.com', N'The Gym', N'B20 1EZ', N'07739983984', N'Birmingham');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AddressLineOne', N'AddressLineTwo', N'Email', N'GymName', N'Postcode', N'Telephone', N'Town') AND [object_id] = OBJECT_ID(N'[Gyms]'))
        SET IDENTITY_INSERT [Gyms] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Duration', N'Price') AND [object_id] = OBJECT_ID(N'[MembershipDeals]'))
        SET IDENTITY_INSERT [MembershipDeals] ON;
    INSERT INTO [MembershipDeals] ([Id], [Duration], [Price])
    VALUES (1, 1, 10.0),
    (2, 3, 20.0),
    (3, 7, 100.0),
    (4, 8, 160.0);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Duration', N'Price') AND [object_id] = OBJECT_ID(N'[MembershipDeals]'))
        SET IDENTITY_INSERT [MembershipDeals] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CloseTime', N'Date', N'DayName', N'Note', N'OpenTime') AND [object_id] = OBJECT_ID(N'[OpenHours]'))
        SET IDENTITY_INSERT [OpenHours] ON;
    INSERT INTO [OpenHours] ([Id], [CloseTime], [Date], [DayName], [Note], [OpenTime])
    VALUES (1, '22:00:00', '0001-01-01T00:00:00.0000000', 1, NULL, '06:00:00'),
    (2, '22:00:00', '0001-01-01T00:00:00.0000000', 2, NULL, '06:00:00'),
    (3, '22:00:00', '0001-01-01T00:00:00.0000000', 3, NULL, '06:00:00'),
    (4, '22:00:00', '0001-01-01T00:00:00.0000000', 4, NULL, '06:00:00'),
    (5, '22:00:00', '0001-01-01T00:00:00.0000000', 5, NULL, '06:00:00'),
    (6, '20:00:00', '0001-01-01T00:00:00.0000000', 6, NULL, '08:00:00'),
    (7, '20:00:00', '0001-01-01T00:00:00.0000000', 0, NULL, '08:00:00');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CloseTime', N'Date', N'DayName', N'Note', N'OpenTime') AND [object_id] = OBJECT_ID(N'[OpenHours]'))
        SET IDENTITY_INSERT [OpenHours] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ClaimType', N'ClaimValue', N'RoleId') AND [object_id] = OBJECT_ID(N'[AspNetRoleClaims]'))
        SET IDENTITY_INSERT [AspNetRoleClaims] ON;
    INSERT INTO [AspNetRoleClaims] ([Id], [ClaimType], [ClaimValue], [RoleId])
    VALUES (1, N'ManageBusiness', N'True', N'a493461b-47bc-474d-bd3a-07a52957747a'),
    (2, N'ManageRoles', N'True', N'a493461b-47bc-474d-bd3a-07a52957747a'),
    (3, N'ManageUsers', N'True', N'a493461b-47bc-474d-bd3a-07a52957747a'),
    (4, N'IssueBans', N'True', N'a493461b-47bc-474d-bd3a-07a52957747a');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ClaimType', N'ClaimValue', N'RoleId') AND [object_id] = OBJECT_ID(N'[AspNetRoleClaims]'))
        SET IDENTITY_INSERT [AspNetRoleClaims] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ClaimType', N'ClaimValue', N'UserId') AND [object_id] = OBJECT_ID(N'[AspNetUserClaims]'))
        SET IDENTITY_INSERT [AspNetUserClaims] ON;
    INSERT INTO [AspNetUserClaims] ([Id], [ClaimType], [ClaimValue], [UserId])
    VALUES (10, N'DateOfBirth', N'01/01/1984', N'1c0ddbe9-fbf3-4b7a-a1b9-08b735b2e0b9'),
    (9, N'DateOfBirth', N'01/01/1993', N'03014e1d-0217-4c46-8e8f-a54b66e49880'),
    (8, N'DateOfBirth', N'01/01/1994', N'9b68cba0-9f94-4af8-9e06-94b7f6359489'),
    (7, N'DateOfBirth', N'01/01/1970', N'5e22abd5-fec6-4fec-b82c-a58ee1ed6031'),
    (6, N'DateOfBirth', N'01/01/1960', N'37aa996d-0a42-4f4f-a865-efd9d896562e'),
    (4, N'DateOfBirth', N'01/01/2000', N'edba9b4b-0235-4eee-bb81-355a5ccd3b52'),
    (11, N'DateOfBirth', N'01/01/1982', N'6e6ef8a9-4a93-4a1a-83e6-69e512aaf480'),
    (3, N'MembershipExpiry', N'31/12/9999', N'058d87a0-1976-44a2-8c88-4781b3511e4c'),
    (2, N'Employee', N'26/12/2019', N'058d87a0-1976-44a2-8c88-4781b3511e4c'),
    (1, N'DateOfBirth', N'01/01/2000', N'058d87a0-1976-44a2-8c88-4781b3511e4c'),
    (5, N'DateOfBirth', N'01/01/1950', N'693011a1-d273-4e3c-9337-2b318e3202cc'),
    (12, N'DateOfBirth', N'01/01/2010', N'6512c7cd-f60f-4124-8858-5271a0a15813');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ClaimType', N'ClaimValue', N'UserId') AND [object_id] = OBJECT_ID(N'[AspNetUserClaims]'))
        SET IDENTITY_INSERT [AspNetUserClaims] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'UserId', N'RoleId') AND [object_id] = OBJECT_ID(N'[AspNetUserRoles]'))
        SET IDENTITY_INSERT [AspNetUserRoles] ON;
    INSERT INTO [AspNetUserRoles] ([UserId], [RoleId])
    VALUES (N'058d87a0-1976-44a2-8c88-4781b3511e4c', N'a493461b-47bc-474d-bd3a-07a52957747a');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'UserId', N'RoleId') AND [object_id] = OBJECT_ID(N'[AspNetUserRoles]'))
        SET IDENTITY_INSERT [AspNetUserRoles] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    CREATE INDEX [IX_AttendanceRecord_UserId] ON [AttendanceRecord] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    CREATE UNIQUE INDEX [IX_MembershipDeals_Duration] ON [MembershipDeals] ([Duration]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191226181837_Initial project migration')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20191226181837_Initial project migration', N'3.1.0');
END;

GO

