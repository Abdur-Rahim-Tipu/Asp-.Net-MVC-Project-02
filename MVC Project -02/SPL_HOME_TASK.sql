CREATE DATABASE DocumentDb
GO
Use DocumentDb
go
CREATE TABLE DocumentCategoryInfo
(
	CategoryId INT IDENTITY NOT NULL PRIMARY KEY,
	CategoryName NVARCHAR(150) NOT NULL,
	CategoryNameBangla NVARCHAR(250),
	[Description] NVARCHAR(500),
	[Status] BIT NOT NULL
)
GO
CREATE TABLE DocumentInformation
(
	DocumentyIdentity BIGINT IDENTITY NOT NULL PRIMARY KEY,
	CategoryId INT NOT NULL REFERENCES DocumentCategoryInfo (CategoryId),
	DocumentReferenceName NVARCHAR(150) NOT NULL,
	DocumentDate DATE NOT NULL,
	DocumentName NVARCHAR(250) NOT NULL,
	DocumentNameBangla NVARCHAR(500),
	[Description] NVARCHAR(1500),
	[Status] BIT NOT NULL
)
GO
CREATE TABLE MetaDataInformation
(
	MetaIdentity BIGINT IDENTITY NOT NULL PRIMARY KEY,
	DocumentyIdentity BIGINT NOT NULL REFERENCES DocumentInformation (DocumentyIdentity),
	MetaName NVARCHAR(150) NOT NULL,
	MetaNameBangla NVARCHAR(250),
	[Description] NVARCHAR(500)
)
GO
CREATE TABLE FileInformation
(
	FileIdentity BIGINT IDENTITY NOT NULL PRIMARY KEY,
	DocumentyIdentity BIGINT NOT NULL REFERENCES DocumentInformation (DocumentyIdentity),
	FileNo NVARCHAR(50),
	[FileName] NVARCHAR(250) NOT NULL,
	FileNameBangla NVARCHAR(450),
	[Description] NVARCHAR(500),
	FilePath NVARCHAR(500),
	FileStatus NVARCHAR(500)
)