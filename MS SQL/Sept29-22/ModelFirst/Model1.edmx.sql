
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/29/2022 22:10:51
-- Generated from EDMX file: G:\C#\SQL with ADO\Modelfirst_bank\DAL\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BankDB_Modelfirst];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Borrowers'
CREATE TABLE [dbo].[Borrowers] (
    [BorrowerId] int IDENTITY(1,1) NOT NULL,
    [borrower_name] nvarchar(max)  NOT NULL,
    [Companyname] nvarchar(max)  NOT NULL,
    [Jobname] nvarchar(max)  NOT NULL,
    [Address_Streetno] int  NOT NULL,
    [Address_State] nvarchar(max)  NOT NULL,
    [Address_Country] nvarchar(max)  NOT NULL,
    [Address_city] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Loans'
CREATE TABLE [dbo].[Loans] (
    [LoanId] int IDENTITY(1,1) NOT NULL,
    [Loantype] nvarchar(max)  NOT NULL,
    [Amount] nvarchar(max)  NOT NULL,
    [Duration] nvarchar(max)  NOT NULL,
    [Rate_of_Interest] nvarchar(max)  NOT NULL,
    [BorrowerBorrowerId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [BorrowerId] in table 'Borrowers'
ALTER TABLE [dbo].[Borrowers]
ADD CONSTRAINT [PK_Borrowers]
    PRIMARY KEY CLUSTERED ([BorrowerId] ASC);
GO

-- Creating primary key on [LoanId] in table 'Loans'
ALTER TABLE [dbo].[Loans]
ADD CONSTRAINT [PK_Loans]
    PRIMARY KEY CLUSTERED ([LoanId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [BorrowerBorrowerId] in table 'Loans'
ALTER TABLE [dbo].[Loans]
ADD CONSTRAINT [FK_BorrowerLoan]
    FOREIGN KEY ([BorrowerBorrowerId])
    REFERENCES [dbo].[Borrowers]
        ([BorrowerId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BorrowerLoan'
CREATE INDEX [IX_FK_BorrowerLoan]
ON [dbo].[Loans]
    ([BorrowerBorrowerId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------