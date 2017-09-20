
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/20/2017 09:18:12
-- Generated from EDMX file: D:\Downloads\WIASchool\WIASchool\WIASchool\MyDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [WIAB2];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_School_has_Courses_Courses]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[School_has_Courses] DROP CONSTRAINT [FK_School_has_Courses_Courses];
GO
IF OBJECT_ID(N'[dbo].[FK_School_has_Courses_Schools]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[School_has_Courses] DROP CONSTRAINT [FK_School_has_Courses_Schools];
GO
IF OBJECT_ID(N'[dbo].[FK_Students_Schools]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Students] DROP CONSTRAINT [FK_Students_Schools];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Courses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Courses];
GO
IF OBJECT_ID(N'[dbo].[School_has_Courses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[School_has_Courses];
GO
IF OBJECT_ID(N'[dbo].[Schools]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Schools];
GO
IF OBJECT_ID(N'[dbo].[Students]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Students];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Courses'
CREATE TABLE [dbo].[Courses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(60)  NULL,
    [Created] datetime  NULL,
    [Updated] datetime  NULL,
    [Allowed] bit  NULL
);
GO

-- Creating table 'Schools'
CREATE TABLE [dbo].[Schools] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(150)  NULL,
    [Address] nvarchar(200)  NULL,
    [Address2] nvarchar(150)  NULL,
    [City] nvarchar(150)  NULL,
    [State] nvarchar(5)  NULL,
    [Created] datetime  NULL,
    [Updated] datetime  NULL,
    [Allowed] bit  NULL
);
GO

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(60)  NULL,
    [LastName] nvarchar(60)  NULL,
    [Created] datetime  NULL,
    [Updated] datetime  NULL,
    [SchoolId] int  NULL,
    [Allowed] bit  NULL
);
GO

-- Creating table 'School_has_Courses'
CREATE TABLE [dbo].[School_has_Courses] (
    [Courses_Id] int  NOT NULL,
    [Schools_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [PK_Courses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Schools'
ALTER TABLE [dbo].[Schools]
ADD CONSTRAINT [PK_Schools]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Courses_Id], [Schools_Id] in table 'School_has_Courses'
ALTER TABLE [dbo].[School_has_Courses]
ADD CONSTRAINT [PK_School_has_Courses]
    PRIMARY KEY CLUSTERED ([Courses_Id], [Schools_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SchoolId] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_Students_Schools]
    FOREIGN KEY ([SchoolId])
    REFERENCES [dbo].[Schools]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Students_Schools'
CREATE INDEX [IX_FK_Students_Schools]
ON [dbo].[Students]
    ([SchoolId]);
GO

-- Creating foreign key on [Courses_Id] in table 'School_has_Courses'
ALTER TABLE [dbo].[School_has_Courses]
ADD CONSTRAINT [FK_School_has_Courses_Courses]
    FOREIGN KEY ([Courses_Id])
    REFERENCES [dbo].[Courses]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Schools_Id] in table 'School_has_Courses'
ALTER TABLE [dbo].[School_has_Courses]
ADD CONSTRAINT [FK_School_has_Courses_Schools]
    FOREIGN KEY ([Schools_Id])
    REFERENCES [dbo].[Schools]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_School_has_Courses_Schools'
CREATE INDEX [IX_FK_School_has_Courses_Schools]
ON [dbo].[School_has_Courses]
    ([Schools_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------