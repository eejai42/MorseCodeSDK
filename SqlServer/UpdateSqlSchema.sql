

USE [MorseCodeSDK];

DECLARE @ObjectName NVARCHAR(100)

    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'WikipediaId' AND Object_ID = Object_ID(N'Wikipedia'))
BEGIN
        ALTER TABLE [dbo].[Wikipedia] ADD [WikipediaId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Wikipedia'))
BEGIN
        ALTER TABLE [dbo].[Wikipedia] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Wikipedia] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Wikipedia'))
BEGIN
        ALTER TABLE [dbo].[Wikipedia] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Wikipedia] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'MorseId' AND Object_ID = Object_ID(N'Morse'))
BEGIN
        ALTER TABLE [dbo].[Morse] ADD [MorseId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Morse'))
BEGIN
        ALTER TABLE [dbo].[Morse] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Morse] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Morse'))
BEGIN
        ALTER TABLE [dbo].[Morse] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Morse] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'SamuelId' AND Object_ID = Object_ID(N'Samuel'))
BEGIN
        ALTER TABLE [dbo].[Samuel] ADD [SamuelId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Samuel'))
BEGIN
        ALTER TABLE [dbo].[Samuel] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Samuel] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Samuel'))
BEGIN
        ALTER TABLE [dbo].[Samuel] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Samuel] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'SamuelfbmorseId' AND Object_ID = Object_ID(N'Samuelfbmorse'))
BEGIN
        ALTER TABLE [dbo].[Samuelfbmorse] ADD [SamuelfbmorseId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Samuelfbmorse'))
BEGIN
        ALTER TABLE [dbo].[Samuelfbmorse] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Samuelfbmorse] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Samuelfbmorse'))
BEGIN
        ALTER TABLE [dbo].[Samuelfbmorse] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Samuelfbmorse] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'InternationalId' AND Object_ID = Object_ID(N'International'))
BEGIN
        ALTER TABLE [dbo].[International] ADD [InternationalId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'International'))
BEGIN
        ALTER TABLE [dbo].[International] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[International] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'International'))
BEGIN
        ALTER TABLE [dbo].[International] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[International] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'RomanId' AND Object_ID = Object_ID(N'Roman'))
BEGIN
        ALTER TABLE [dbo].[Roman] ADD [RomanId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Roman'))
BEGIN
        ALTER TABLE [dbo].[Roman] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Roman] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Roman'))
BEGIN
        ALTER TABLE [dbo].[Roman] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Roman] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'EnglishId' AND Object_ID = Object_ID(N'English'))
BEGIN
        ALTER TABLE [dbo].[English] ADD [EnglishId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'English'))
BEGIN
        ALTER TABLE [dbo].[English] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[English] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'English'))
BEGIN
        ALTER TABLE [dbo].[English] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[English] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'AeronauticalId' AND Object_ID = Object_ID(N'Aeronautical'))
BEGIN
        ALTER TABLE [dbo].[Aeronautical] ADD [AeronauticalId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Aeronautical'))
BEGIN
        ALTER TABLE [dbo].[Aeronautical] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Aeronautical] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Aeronautical'))
BEGIN
        ALTER TABLE [dbo].[Aeronautical] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Aeronautical] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'AviationId' AND Object_ID = Object_ID(N'Aviation'))
BEGIN
        ALTER TABLE [dbo].[Aviation] ADD [AviationId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Aviation'))
BEGIN
        ALTER TABLE [dbo].[Aviation] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Aviation] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Aviation'))
BEGIN
        ALTER TABLE [dbo].[Aviation] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Aviation] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'CableId' AND Object_ID = Object_ID(N'Cable'))
BEGIN
        ALTER TABLE [dbo].[Cable] ADD [CableId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Cable'))
BEGIN
        ALTER TABLE [dbo].[Cable] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Cable] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Cable'))
BEGIN
        ALTER TABLE [dbo].[Cable] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Cable] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'FarnsworthId' AND Object_ID = Object_ID(N'Farnsworth'))
BEGIN
        ALTER TABLE [dbo].[Farnsworth] ADD [FarnsworthId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Farnsworth'))
BEGIN
        ALTER TABLE [dbo].[Farnsworth] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Farnsworth] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Farnsworth'))
BEGIN
        ALTER TABLE [dbo].[Farnsworth] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Farnsworth] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'LearningId' AND Object_ID = Object_ID(N'Learning'))
BEGIN
        ALTER TABLE [dbo].[Learning] ADD [LearningId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Learning'))
BEGIN
        ALTER TABLE [dbo].[Learning] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Learning] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Learning'))
BEGIN
        ALTER TABLE [dbo].[Learning] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Learning] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'MnemonicId' AND Object_ID = Object_ID(N'Mnemonic'))
BEGIN
        ALTER TABLE [dbo].[Mnemonic] ADD [MnemonicId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Mnemonic'))
BEGIN
        ALTER TABLE [dbo].[Mnemonic] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Mnemonic] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Mnemonic'))
BEGIN
        ALTER TABLE [dbo].[Mnemonic] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Mnemonic] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'EncyclopediaId' AND Object_ID = Object_ID(N'Encyclopedia'))
BEGIN
        ALTER TABLE [dbo].[Encyclopedia] ADD [EncyclopediaId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Encyclopedia'))
BEGIN
        ALTER TABLE [dbo].[Encyclopedia] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Encyclopedia] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Encyclopedia'))
BEGIN
        ALTER TABLE [dbo].[Encyclopedia] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Encyclopedia] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'JumpId' AND Object_ID = Object_ID(N'Jump'))
BEGIN
        ALTER TABLE [dbo].[Jump] ADD [JumpId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Jump'))
BEGIN
        ALTER TABLE [dbo].[Jump] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Jump] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Jump'))
BEGIN
        ALTER TABLE [dbo].[Jump] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Jump] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'NavigationId' AND Object_ID = Object_ID(N'Navigation'))
BEGIN
        ALTER TABLE [dbo].[Navigation] ADD [NavigationId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Navigation'))
BEGIN
        ALTER TABLE [dbo].[Navigation] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Navigation] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Navigation'))
BEGIN
        ALTER TABLE [dbo].[Navigation] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Navigation] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'HeadId' AND Object_ID = Object_ID(N'Head'))
BEGIN
        ALTER TABLE [dbo].[Head] ADD [HeadId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Head'))
BEGIN
        ALTER TABLE [dbo].[Head] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Head] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Head'))
BEGIN
        ALTER TABLE [dbo].[Head] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Head] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'SearchId' AND Object_ID = Object_ID(N'Search'))
BEGIN
        ALTER TABLE [dbo].[Search] ADD [SearchId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Search'))
BEGIN
        ALTER TABLE [dbo].[Search] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Search] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Search'))
BEGIN
        ALTER TABLE [dbo].[Search] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Search] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'UploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngId' AND Object_ID = Object_ID(N'Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng'))
BEGIN
        ALTER TABLE [dbo].[Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng] ADD [UploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng'))
BEGIN
        ALTER TABLE [dbo].[Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng'))
BEGIN
        ALTER TABLE [dbo].[Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'FileinternationalmorsecodesvgId' AND Object_ID = Object_ID(N'Fileinternationalmorsecodesvg'))
BEGIN
        ALTER TABLE [dbo].[Fileinternationalmorsecodesvg] ADD [FileinternationalmorsecodesvgId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Fileinternationalmorsecodesvg'))
BEGIN
        ALTER TABLE [dbo].[Fileinternationalmorsecodesvg] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Fileinternationalmorsecodesvg] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Fileinternationalmorsecodesvg'))
BEGIN
        ALTER TABLE [dbo].[Fileinternationalmorsecodesvg] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Fileinternationalmorsecodesvg] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'ChartId' AND Object_ID = Object_ID(N'Chart'))
BEGIN
        ALTER TABLE [dbo].[Chart] ADD [ChartId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Chart'))
BEGIN
        ALTER TABLE [dbo].[Chart] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Chart] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Chart'))
BEGIN
        ALTER TABLE [dbo].[Chart] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Chart] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'CodeId' AND Object_ID = Object_ID(N'Code'))
BEGIN
        ALTER TABLE [dbo].[Code] ADD [CodeId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Code'))
BEGIN
        ALTER TABLE [dbo].[Code] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Code] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Code'))
BEGIN
        ALTER TABLE [dbo].[Code] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Code] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'IturId' AND Object_ID = Object_ID(N'Itur'))
BEGIN
        ALTER TABLE [dbo].[Itur] ADD [IturId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Itur'))
BEGIN
        ALTER TABLE [dbo].[Itur] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Itur] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Itur'))
BEGIN
        ALTER TABLE [dbo].[Itur] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Itur] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'MethodId' AND Object_ID = Object_ID(N'Method'))
BEGIN
        ALTER TABLE [dbo].[Method] ADD [MethodId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Method'))
BEGIN
        ALTER TABLE [dbo].[Method] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Method] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Method'))
BEGIN
        ALTER TABLE [dbo].[Method] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Method] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'TextId' AND Object_ID = Object_ID(N'Text'))
BEGIN
        ALTER TABLE [dbo].[Text] ADD [TextId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Text'))
BEGIN
        ALTER TABLE [dbo].[Text] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Text] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Text'))
BEGIN
        ALTER TABLE [dbo].[Text] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Text] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'WrittenlanguageId' AND Object_ID = Object_ID(N'Writtenlanguage'))
BEGIN
        ALTER TABLE [dbo].[Writtenlanguage] ADD [WrittenlanguageId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Writtenlanguage'))
BEGIN
        ALTER TABLE [dbo].[Writtenlanguage] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Writtenlanguage] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Writtenlanguage'))
BEGIN
        ALTER TABLE [dbo].[Writtenlanguage] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Writtenlanguage] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'InformationId' AND Object_ID = Object_ID(N'Information'))
BEGIN
        ALTER TABLE [dbo].[Information] ADD [InformationId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Information'))
BEGIN
        ALTER TABLE [dbo].[Information] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Information] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Information'))
BEGIN
        ALTER TABLE [dbo].[Information] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Information] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'SeriesId' AND Object_ID = Object_ID(N'Series'))
BEGIN
        ALTER TABLE [dbo].[Series] ADD [SeriesId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Series'))
BEGIN
        ALTER TABLE [dbo].[Series] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Series] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Series'))
BEGIN
        ALTER TABLE [dbo].[Series] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Series] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'ListenerId' AND Object_ID = Object_ID(N'Listener'))
BEGIN
        ALTER TABLE [dbo].[Listener] ADD [ListenerId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Listener'))
BEGIN
        ALTER TABLE [dbo].[Listener] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Listener] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Listener'))
BEGIN
        ALTER TABLE [dbo].[Listener] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Listener] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'ObserverId' AND Object_ID = Object_ID(N'Observer'))
BEGIN
        ALTER TABLE [dbo].[Observer] ADD [ObserverId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Observer'))
BEGIN
        ALTER TABLE [dbo].[Observer] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Observer] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Observer'))
BEGIN
        ALTER TABLE [dbo].[Observer] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Observer] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'EquipmentId' AND Object_ID = Object_ID(N'Equipment'))
BEGIN
        ALTER TABLE [dbo].[Equipment] ADD [EquipmentId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Equipment'))
BEGIN
        ALTER TABLE [dbo].[Equipment] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Equipment] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Equipment'))
BEGIN
        ALTER TABLE [dbo].[Equipment] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Equipment] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'InventorId' AND Object_ID = Object_ID(N'Inventor'))
BEGIN
        ALTER TABLE [dbo].[Inventor] ADD [InventorId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Inventor'))
BEGIN
        ALTER TABLE [dbo].[Inventor] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Inventor] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Inventor'))
BEGIN
        ALTER TABLE [dbo].[Inventor] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Inventor] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'TelegraphId' AND Object_ID = Object_ID(N'Telegraph'))
BEGIN
        ALTER TABLE [dbo].[Telegraph] ADD [TelegraphId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Telegraph'))
BEGIN
        ALTER TABLE [dbo].[Telegraph] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Telegraph] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Telegraph'))
BEGIN
        ALTER TABLE [dbo].[Telegraph] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Telegraph] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'IsoId' AND Object_ID = Object_ID(N'Iso'))
BEGIN
        ALTER TABLE [dbo].[Iso] ADD [IsoId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Iso'))
BEGIN
        ALTER TABLE [dbo].[Iso] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Iso] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Iso'))
BEGIN
        ALTER TABLE [dbo].[Iso] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Iso] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'AlphabetId' AND Object_ID = Object_ID(N'Alphabet'))
BEGIN
        ALTER TABLE [dbo].[Alphabet] ADD [AlphabetId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Alphabet'))
BEGIN
        ALTER TABLE [dbo].[Alphabet] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Alphabet] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Alphabet'))
BEGIN
        ALTER TABLE [dbo].[Alphabet] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Alphabet] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'IsobasiclatinalphabetId' AND Object_ID = Object_ID(N'Isobasiclatinalphabet'))
BEGIN
        ALTER TABLE [dbo].[Isobasiclatinalphabet] ADD [IsobasiclatinalphabetId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Isobasiclatinalphabet'))
BEGIN
        ALTER TABLE [dbo].[Isobasiclatinalphabet] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Isobasiclatinalphabet] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Isobasiclatinalphabet'))
BEGIN
        ALTER TABLE [dbo].[Isobasiclatinalphabet] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Isobasiclatinalphabet] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'ArabicnumeralId' AND Object_ID = Object_ID(N'Arabicnumeral'))
BEGIN
        ALTER TABLE [dbo].[Arabicnumeral] ADD [ArabicnumeralId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Arabicnumeral'))
BEGIN
        ALTER TABLE [dbo].[Arabicnumeral] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Arabicnumeral] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Arabicnumeral'))
BEGIN
        ALTER TABLE [dbo].[Arabicnumeral] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Arabicnumeral] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'SetId' AND Object_ID = Object_ID(N'Set'))
BEGIN
        ALTER TABLE [dbo].[Set] ADD [SetId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Set'))
BEGIN
        ALTER TABLE [dbo].[Set] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Set] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Set'))
BEGIN
        ALTER TABLE [dbo].[Set] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Set] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'PunctuationId' AND Object_ID = Object_ID(N'Punctuation'))
BEGIN
        ALTER TABLE [dbo].[Punctuation] ADD [PunctuationId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Punctuation'))
BEGIN
        ALTER TABLE [dbo].[Punctuation] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Punctuation] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Punctuation'))
BEGIN
        ALTER TABLE [dbo].[Punctuation] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Punctuation] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'ProsignsformorsecodeId' AND Object_ID = Object_ID(N'Prosignsformorsecode'))
BEGIN
        ALTER TABLE [dbo].[Prosignsformorsecode] ADD [ProsignsformorsecodeId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Prosignsformorsecode'))
BEGIN
        ALTER TABLE [dbo].[Prosignsformorsecode] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Prosignsformorsecode] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Prosignsformorsecode'))
BEGIN
        ALTER TABLE [dbo].[Prosignsformorsecode] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Prosignsformorsecode] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'RadioId' AND Object_ID = Object_ID(N'Radio'))
BEGIN
        ALTER TABLE [dbo].[Radio] ADD [RadioId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Radio'))
BEGIN
        ALTER TABLE [dbo].[Radio] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Radio] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Radio'))
BEGIN
        ALTER TABLE [dbo].[Radio] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Radio] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'AmateurradioId' AND Object_ID = Object_ID(N'Amateurradio'))
BEGIN
        ALTER TABLE [dbo].[Amateurradio] ADD [AmateurradioId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Amateurradio'))
BEGIN
        ALTER TABLE [dbo].[Amateurradio] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Amateurradio] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Amateurradio'))
BEGIN
        ALTER TABLE [dbo].[Amateurradio] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Amateurradio] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'PracticeId' AND Object_ID = Object_ID(N'Practice'))
BEGIN
        ALTER TABLE [dbo].[Practice] ADD [PracticeId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Practice'))
BEGIN
        ALTER TABLE [dbo].[Practice] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Practice] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Practice'))
BEGIN
        ALTER TABLE [dbo].[Practice] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Practice] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'SymbolId' AND Object_ID = Object_ID(N'Symbol'))
BEGIN
        ALTER TABLE [dbo].[Symbol] ADD [SymbolId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Symbol'))
BEGIN
        ALTER TABLE [dbo].[Symbol] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Symbol] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Symbol'))
BEGIN
        ALTER TABLE [dbo].[Symbol] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Symbol] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'CharacterId' AND Object_ID = Object_ID(N'Character'))
BEGIN
        ALTER TABLE [dbo].[Character] ADD [CharacterId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Character'))
BEGIN
        ALTER TABLE [dbo].[Character] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Character] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Character'))
BEGIN
        ALTER TABLE [dbo].[Character] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Character] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'DurationId' AND Object_ID = Object_ID(N'Duration'))
BEGIN
        ALTER TABLE [dbo].[Duration] ADD [DurationId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Duration'))
BEGIN
        ALTER TABLE [dbo].[Duration] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Duration] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Duration'))
BEGIN
        ALTER TABLE [dbo].[Duration] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Duration] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'UnitId' AND Object_ID = Object_ID(N'Unit'))
BEGIN
        ALTER TABLE [dbo].[Unit] ADD [UnitId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Unit'))
BEGIN
        ALTER TABLE [dbo].[Unit] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Unit] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Unit'))
BEGIN
        ALTER TABLE [dbo].[Unit] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Unit] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'TimeId' AND Object_ID = Object_ID(N'Time'))
BEGIN
        ALTER TABLE [dbo].[Time] ADD [TimeId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Time'))
BEGIN
        ALTER TABLE [dbo].[Time] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Time] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Time'))
BEGIN
        ALTER TABLE [dbo].[Time] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Time] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'MeasurementId' AND Object_ID = Object_ID(N'Measurement'))
BEGIN
        ALTER TABLE [dbo].[Measurement] ADD [MeasurementId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Measurement'))
BEGIN
        ALTER TABLE [dbo].[Measurement] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Measurement] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Measurement'))
BEGIN
        ALTER TABLE [dbo].[Measurement] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Measurement] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'TransmissionId' AND Object_ID = Object_ID(N'Transmission'))
BEGIN
        ALTER TABLE [dbo].[Transmission] ADD [TransmissionId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Transmission'))
BEGIN
        ALTER TABLE [dbo].[Transmission] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Transmission] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Transmission'))
BEGIN
        ALTER TABLE [dbo].[Transmission] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Transmission] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'SilenceId' AND Object_ID = Object_ID(N'Silence'))
BEGIN
        ALTER TABLE [dbo].[Silence] ADD [SilenceId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Silence'))
BEGIN
        ALTER TABLE [dbo].[Silence] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Silence] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Silence'))
BEGIN
        ALTER TABLE [dbo].[Silence] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Silence] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'WordId' AND Object_ID = Object_ID(N'Word'))
BEGIN
        ALTER TABLE [dbo].[Word] ADD [WordId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Word'))
BEGIN
        ALTER TABLE [dbo].[Word] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Word] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Word'))
BEGIN
        ALTER TABLE [dbo].[Word] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Word] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'DelimiterId' AND Object_ID = Object_ID(N'Delimiter'))
BEGIN
        ALTER TABLE [dbo].[Delimiter] ADD [DelimiterId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Delimiter'))
BEGIN
        ALTER TABLE [dbo].[Delimiter] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Delimiter] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Delimiter'))
BEGIN
        ALTER TABLE [dbo].[Delimiter] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Delimiter] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'SpaceId' AND Object_ID = Object_ID(N'Space'))
BEGIN
        ALTER TABLE [dbo].[Space] ADD [SpaceId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Space'))
BEGIN
        ALTER TABLE [dbo].[Space] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Space] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Space'))
BEGIN
        ALTER TABLE [dbo].[Space] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Space] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'SpeedId' AND Object_ID = Object_ID(N'Speed'))
BEGIN
        ALTER TABLE [dbo].[Speed] ADD [SpeedId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Speed'))
BEGIN
        ALTER TABLE [dbo].[Speed] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Speed] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Speed'))
BEGIN
        ALTER TABLE [dbo].[Speed] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Speed] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'CommunicationId' AND Object_ID = Object_ID(N'Communication'))
BEGIN
        ALTER TABLE [dbo].[Communication] ADD [CommunicationId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Communication'))
BEGIN
        ALTER TABLE [dbo].[Communication] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Communication] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Communication'))
BEGIN
        ALTER TABLE [dbo].[Communication] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Communication] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'LengthId' AND Object_ID = Object_ID(N'Length'))
BEGIN
        ALTER TABLE [dbo].[Length] ADD [LengthId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Length'))
BEGIN
        ALTER TABLE [dbo].[Length] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Length] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Length'))
BEGIN
        ALTER TABLE [dbo].[Length] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Length] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'FrequencyId' AND Object_ID = Object_ID(N'Frequency'))
BEGIN
        ALTER TABLE [dbo].[Frequency] ADD [FrequencyId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Frequency'))
BEGIN
        ALTER TABLE [dbo].[Frequency] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Frequency] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Frequency'))
BEGIN
        ALTER TABLE [dbo].[Frequency] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Frequency] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'OccurrenceId' AND Object_ID = Object_ID(N'Occurrence'))
BEGIN
        ALTER TABLE [dbo].[Occurrence] ADD [OccurrenceId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Occurrence'))
BEGIN
        ALTER TABLE [dbo].[Occurrence] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Occurrence] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Occurrence'))
BEGIN
        ALTER TABLE [dbo].[Occurrence] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Occurrence] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'EntropyencodingId' AND Object_ID = Object_ID(N'Entropyencoding'))
BEGIN
        ALTER TABLE [dbo].[Entropyencoding] ADD [EntropyencodingId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Entropyencoding'))
BEGIN
        ALTER TABLE [dbo].[Entropyencoding] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Entropyencoding] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Entropyencoding'))
BEGIN
        ALTER TABLE [dbo].[Entropyencoding] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Entropyencoding] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'AmateurradiooperatorId' AND Object_ID = Object_ID(N'Amateurradiooperator'))
BEGIN
        ALTER TABLE [dbo].[Amateurradiooperator] ADD [AmateurradiooperatorId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Amateurradiooperator'))
BEGIN
        ALTER TABLE [dbo].[Amateurradiooperator] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Amateurradiooperator] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Amateurradiooperator'))
BEGIN
        ALTER TABLE [dbo].[Amateurradiooperator] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Amateurradiooperator] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'KnowledgeId' AND Object_ID = Object_ID(N'Knowledge'))
BEGIN
        ALTER TABLE [dbo].[Knowledge] ADD [KnowledgeId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Knowledge'))
BEGIN
        ALTER TABLE [dbo].[Knowledge] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Knowledge] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Knowledge'))
BEGIN
        ALTER TABLE [dbo].[Knowledge] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Knowledge] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'ProficiencyId' AND Object_ID = Object_ID(N'Proficiency'))
BEGIN
        ALTER TABLE [dbo].[Proficiency] ADD [ProficiencyId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Proficiency'))
BEGIN
        ALTER TABLE [dbo].[Proficiency] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Proficiency] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Proficiency'))
BEGIN
        ALTER TABLE [dbo].[Proficiency] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Proficiency] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'LicensingId' AND Object_ID = Object_ID(N'Licensing'))
BEGIN
        ALTER TABLE [dbo].[Licensing] ADD [LicensingId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Licensing'))
BEGIN
        ALTER TABLE [dbo].[Licensing] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Licensing] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Licensing'))
BEGIN
        ALTER TABLE [dbo].[Licensing] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Licensing] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'AmateurradiolicenseId' AND Object_ID = Object_ID(N'Amateurradiolicense'))
BEGIN
        ALTER TABLE [dbo].[Amateurradiolicense] ADD [AmateurradiolicenseId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Amateurradiolicense'))
BEGIN
        ALTER TABLE [dbo].[Amateurradiolicense] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Amateurradiolicense] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Amateurradiolicense'))
BEGIN
        ALTER TABLE [dbo].[Amateurradiolicense] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Amateurradiolicense] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'AviatorId' AND Object_ID = Object_ID(N'Aviator'))
BEGIN
        ALTER TABLE [dbo].[Aviator] ADD [AviatorId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Aviator'))
BEGIN
        ALTER TABLE [dbo].[Aviator] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Aviator] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Aviator'))
BEGIN
        ALTER TABLE [dbo].[Aviator] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Aviator] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'AirId' AND Object_ID = Object_ID(N'Air'))
BEGIN
        ALTER TABLE [dbo].[Air] ADD [AirId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Air'))
BEGIN
        ALTER TABLE [dbo].[Air] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Air] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Air'))
BEGIN
        ALTER TABLE [dbo].[Air] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Air] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'TrafficId' AND Object_ID = Object_ID(N'Traffic'))
BEGIN
        ALTER TABLE [dbo].[Traffic] ADD [TrafficId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Traffic'))
BEGIN
        ALTER TABLE [dbo].[Traffic] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Traffic] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Traffic'))
BEGIN
        ALTER TABLE [dbo].[Traffic] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Traffic] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'AirtrafficcontrollerId' AND Object_ID = Object_ID(N'Airtrafficcontroller'))
BEGIN
        ALTER TABLE [dbo].[Airtrafficcontroller] ADD [AirtrafficcontrollerId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Airtrafficcontroller'))
BEGIN
        ALTER TABLE [dbo].[Airtrafficcontroller] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Airtrafficcontroller] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Airtrafficcontroller'))
BEGIN
        ALTER TABLE [dbo].[Airtrafficcontroller] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Airtrafficcontroller] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'UnderstandingId' AND Object_ID = Object_ID(N'Understanding'))
BEGIN
        ALTER TABLE [dbo].[Understanding] ADD [UnderstandingId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Understanding'))
BEGIN
        ALTER TABLE [dbo].[Understanding] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Understanding] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Understanding'))
BEGIN
        ALTER TABLE [dbo].[Understanding] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Understanding] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'NavigationalaidId' AND Object_ID = Object_ID(N'Navigationalaid'))
BEGIN
        ALTER TABLE [dbo].[Navigationalaid] ADD [NavigationalaidId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Navigationalaid'))
BEGIN
        ALTER TABLE [dbo].[Navigationalaid] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Navigationalaid] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Navigationalaid'))
BEGIN
        ALTER TABLE [dbo].[Navigationalaid] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Navigationalaid] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'VhfomnidirectionalrangeId' AND Object_ID = Object_ID(N'Vhfomnidirectionalrange'))
BEGIN
        ALTER TABLE [dbo].[Vhfomnidirectionalrange] ADD [VhfomnidirectionalrangeId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Vhfomnidirectionalrange'))
BEGIN
        ALTER TABLE [dbo].[Vhfomnidirectionalrange] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Vhfomnidirectionalrange] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Vhfomnidirectionalrange'))
BEGIN
        ALTER TABLE [dbo].[Vhfomnidirectionalrange] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Vhfomnidirectionalrange] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'NondirectionalbeaconId' AND Object_ID = Object_ID(N'Nondirectionalbeacon'))
BEGIN
        ALTER TABLE [dbo].[Nondirectionalbeacon] ADD [NondirectionalbeaconId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Nondirectionalbeacon'))
BEGIN
        ALTER TABLE [dbo].[Nondirectionalbeacon] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Nondirectionalbeacon] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Nondirectionalbeacon'))
BEGIN
        ALTER TABLE [dbo].[Nondirectionalbeacon] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Nondirectionalbeacon] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'VoiceId' AND Object_ID = Object_ID(N'Voice'))
BEGIN
        ALTER TABLE [dbo].[Voice] ADD [VoiceId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Voice'))
BEGIN
        ALTER TABLE [dbo].[Voice] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Voice] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Voice'))
BEGIN
        ALTER TABLE [dbo].[Voice] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Voice] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'DecodingId' AND Object_ID = Object_ID(N'Decoding'))
BEGIN
        ALTER TABLE [dbo].[Decoding] ADD [DecodingId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Decoding'))
BEGIN
        ALTER TABLE [dbo].[Decoding] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Decoding] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Decoding'))
BEGIN
        ALTER TABLE [dbo].[Decoding] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Decoding] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'DeviceId' AND Object_ID = Object_ID(N'Device'))
BEGIN
        ALTER TABLE [dbo].[Device] ADD [DeviceId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Device'))
BEGIN
        ALTER TABLE [dbo].[Device] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Device] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Device'))
BEGIN
        ALTER TABLE [dbo].[Device] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Device] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'AlternativeId' AND Object_ID = Object_ID(N'Alternative'))
BEGIN
        ALTER TABLE [dbo].[Alternative] ADD [AlternativeId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Alternative'))
BEGIN
        ALTER TABLE [dbo].[Alternative] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Alternative] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Alternative'))
BEGIN
        ALTER TABLE [dbo].[Alternative] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Alternative] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'SpeechId' AND Object_ID = Object_ID(N'Speech'))
BEGIN
        ALTER TABLE [dbo].[Speech] ADD [SpeechId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Speech'))
BEGIN
        ALTER TABLE [dbo].[Speech] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Speech] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Speech'))
BEGIN
        ALTER TABLE [dbo].[Speech] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Speech] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'AmateurradiorepeaterId' AND Object_ID = Object_ID(N'Amateurradiorepeater'))
BEGIN
        ALTER TABLE [dbo].[Amateurradiorepeater] ADD [AmateurradiorepeaterId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Amateurradiorepeater'))
BEGIN
        ALTER TABLE [dbo].[Amateurradiorepeater] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Amateurradiorepeater] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Amateurradiorepeater'))
BEGIN
        ALTER TABLE [dbo].[Amateurradiorepeater] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Amateurradiorepeater] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'ExampleId' AND Object_ID = Object_ID(N'Example'))
BEGIN
        ALTER TABLE [dbo].[Example] ADD [ExampleId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Example'))
BEGIN
        ALTER TABLE [dbo].[Example] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Example] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Example'))
BEGIN
        ALTER TABLE [dbo].[Example] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Example] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'UploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngId' AND Object_ID = Object_ID(N'Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng'))
BEGIN
        ALTER TABLE [dbo].[Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng] ADD [UploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng'))
BEGIN
        ALTER TABLE [dbo].[Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng'))
BEGIN
        ALTER TABLE [dbo].[Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'FilesossvgId' AND Object_ID = Object_ID(N'Filesossvg'))
BEGIN
        ALTER TABLE [dbo].[Filesossvg] ADD [FilesossvgId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Filesossvg'))
BEGIN
        ALTER TABLE [dbo].[Filesossvg] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Filesossvg] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Filesossvg'))
BEGIN
        ALTER TABLE [dbo].[Filesossvg] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Filesossvg] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'EmergencyId' AND Object_ID = Object_ID(N'Emergency'))
BEGIN
        ALTER TABLE [dbo].[Emergency] ADD [EmergencyId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Emergency'))
BEGIN
        ALTER TABLE [dbo].[Emergency] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Emergency] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Emergency'))
BEGIN
        ALTER TABLE [dbo].[Emergency] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Emergency] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'TelecommunicationId' AND Object_ID = Object_ID(N'Telecommunication'))
BEGIN
        ALTER TABLE [dbo].[Telecommunication] ADD [TelecommunicationId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Telecommunication'))
BEGIN
        ALTER TABLE [dbo].[Telecommunication] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Telecommunication] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Telecommunication'))
BEGIN
        ALTER TABLE [dbo].[Telecommunication] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Telecommunication] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'DistressId' AND Object_ID = Object_ID(N'Distress'))
BEGIN
        ALTER TABLE [dbo].[Distress] ADD [DistressId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Distress'))
BEGIN
        ALTER TABLE [dbo].[Distress] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Distress] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Distress'))
BEGIN
        ALTER TABLE [dbo].[Distress] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Distress] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'TreatyId' AND Object_ID = Object_ID(N'Treaty'))
BEGIN
        ALTER TABLE [dbo].[Treaty] ADD [TreatyId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Treaty'))
BEGIN
        ALTER TABLE [dbo].[Treaty] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Treaty] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Treaty'))
BEGIN
        ALTER TABLE [dbo].[Treaty] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Treaty] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'DevelopmentId' AND Object_ID = Object_ID(N'Development'))
BEGIN
        ALTER TABLE [dbo].[Development] ADD [DevelopmentId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Development'))
BEGIN
        ALTER TABLE [dbo].[Development] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Development] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Development'))
BEGIN
        ALTER TABLE [dbo].[Development] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Development] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'HistoryId' AND Object_ID = Object_ID(N'History'))
BEGIN
        ALTER TABLE [dbo].[History] ADD [HistoryId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'History'))
BEGIN
        ALTER TABLE [dbo].[History] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[History] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'History'))
BEGIN
        ALTER TABLE [dbo].[History] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[History] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'DevelopmentandhistoryId' AND Object_ID = Object_ID(N'Developmentandhistory'))
BEGIN
        ALTER TABLE [dbo].[Developmentandhistory] ADD [DevelopmentandhistoryId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Developmentandhistory'))
BEGIN
        ALTER TABLE [dbo].[Developmentandhistory] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Developmentandhistory] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Developmentandhistory'))
BEGIN
        ALTER TABLE [dbo].[Developmentandhistory] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Developmentandhistory] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'UserId' AND Object_ID = Object_ID(N'User'))
BEGIN
        ALTER TABLE [dbo].[User] ADD [UserId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'User'))
BEGIN
        ALTER TABLE [dbo].[User] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[User] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'User'))
BEGIN
        ALTER TABLE [dbo].[User] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[User] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'UserproficiencyId' AND Object_ID = Object_ID(N'Userproficiency'))
BEGIN
        ALTER TABLE [dbo].[Userproficiency] ADD [UserproficiencyId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Userproficiency'))
BEGIN
        ALTER TABLE [dbo].[Userproficiency] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Userproficiency] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Userproficiency'))
BEGIN
        ALTER TABLE [dbo].[Userproficiency] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Userproficiency] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'InternationalmorsecodeId' AND Object_ID = Object_ID(N'Internationalmorsecode'))
BEGIN
        ALTER TABLE [dbo].[Internationalmorsecode] ADD [InternationalmorsecodeId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Internationalmorsecode'))
BEGIN
        ALTER TABLE [dbo].[Internationalmorsecode] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Internationalmorsecode] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Internationalmorsecode'))
BEGIN
        ALTER TABLE [dbo].[Internationalmorsecode] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Internationalmorsecode] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'TechnologyId' AND Object_ID = Object_ID(N'Technology'))
BEGIN
        ALTER TABLE [dbo].[Technology] ADD [TechnologyId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Technology'))
BEGIN
        ALTER TABLE [dbo].[Technology] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Technology] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Technology'))
BEGIN
        ALTER TABLE [dbo].[Technology] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Technology] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'MorsecodeasanassistivetechnologyId' AND Object_ID = Object_ID(N'Morsecodeasanassistivetechnology'))
BEGIN
        ALTER TABLE [dbo].[Morsecodeasanassistivetechnology] ADD [MorsecodeasanassistivetechnologyId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Morsecodeasanassistivetechnology'))
BEGIN
        ALTER TABLE [dbo].[Morsecodeasanassistivetechnology] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Morsecodeasanassistivetechnology] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Morsecodeasanassistivetechnology'))
BEGIN
        ALTER TABLE [dbo].[Morsecodeasanassistivetechnology] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Morsecodeasanassistivetechnology] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'RepresentationId' AND Object_ID = Object_ID(N'Representation'))
BEGIN
        ALTER TABLE [dbo].[Representation] ADD [RepresentationId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Representation'))
BEGIN
        ALTER TABLE [dbo].[Representation] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Representation] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Representation'))
BEGIN
        ALTER TABLE [dbo].[Representation] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Representation] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'TimingId' AND Object_ID = Object_ID(N'Timing'))
BEGIN
        ALTER TABLE [dbo].[Timing] ADD [TimingId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Timing'))
BEGIN
        ALTER TABLE [dbo].[Timing] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Timing] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Timing'))
BEGIN
        ALTER TABLE [dbo].[Timing] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Timing] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'CablecodeId' AND Object_ID = Object_ID(N'Cablecode'))
BEGIN
        ALTER TABLE [dbo].[Cablecode] ADD [CablecodeId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Cablecode'))
BEGIN
        ALTER TABLE [dbo].[Cablecode] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Cablecode] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Cablecode'))
BEGIN
        ALTER TABLE [dbo].[Cablecode] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Cablecode] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'SpokenrepresentationId' AND Object_ID = Object_ID(N'Spokenrepresentation'))
BEGIN
        ALTER TABLE [dbo].[Spokenrepresentation] ADD [SpokenrepresentationId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Spokenrepresentation'))
BEGIN
        ALTER TABLE [dbo].[Spokenrepresentation] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Spokenrepresentation] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Spokenrepresentation'))
BEGIN
        ALTER TABLE [dbo].[Spokenrepresentation] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Spokenrepresentation] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'MinuteId' AND Object_ID = Object_ID(N'Minute'))
BEGIN
        ALTER TABLE [dbo].[Minute] ADD [MinuteId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Minute'))
BEGIN
        ALTER TABLE [dbo].[Minute] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Minute] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Minute'))
BEGIN
        ALTER TABLE [dbo].[Minute] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Minute] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'SpeedinwordsperminuteId' AND Object_ID = Object_ID(N'Speedinwordsperminute'))
BEGIN
        ALTER TABLE [dbo].[Speedinwordsperminute] ADD [SpeedinwordsperminuteId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Speedinwordsperminute'))
BEGIN
        ALTER TABLE [dbo].[Speedinwordsperminute] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Speedinwordsperminute] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Speedinwordsperminute'))
BEGIN
        ALTER TABLE [dbo].[Speedinwordsperminute] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Speedinwordsperminute] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'FarnsworthspeedId' AND Object_ID = Object_ID(N'Farnsworthspeed'))
BEGIN
        ALTER TABLE [dbo].[Farnsworthspeed] ADD [FarnsworthspeedId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Farnsworthspeed'))
BEGIN
        ALTER TABLE [dbo].[Farnsworthspeed] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Farnsworthspeed] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Farnsworthspeed'))
BEGIN
        ALTER TABLE [dbo].[Farnsworthspeed] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Farnsworthspeed] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'DisplayId' AND Object_ID = Object_ID(N'Display'))
BEGIN
        ALTER TABLE [dbo].[Display] ADD [DisplayId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Display'))
BEGIN
        ALTER TABLE [dbo].[Display] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Display] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Display'))
BEGIN
        ALTER TABLE [dbo].[Display] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Display] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'AlternativedisplayofcommoncharactersininternationalmorsecodeId' AND Object_ID = Object_ID(N'Alternativedisplayofcommoncharactersininternationalmorsecode'))
BEGIN
        ALTER TABLE [dbo].[Alternativedisplayofcommoncharactersininternationalmorsecode] ADD [AlternativedisplayofcommoncharactersininternationalmorsecodeId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Alternativedisplayofcommoncharactersininternationalmorsecode'))
BEGIN
        ALTER TABLE [dbo].[Alternativedisplayofcommoncharactersininternationalmorsecode] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Alternativedisplayofcommoncharactersininternationalmorsecode] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Alternativedisplayofcommoncharactersininternationalmorsecode'))
BEGIN
        ALTER TABLE [dbo].[Alternativedisplayofcommoncharactersininternationalmorsecode] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Alternativedisplayofcommoncharactersininternationalmorsecode] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'LinkId' AND Object_ID = Object_ID(N'Link'))
BEGIN
        ALTER TABLE [dbo].[Link] ADD [LinkId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Link'))
BEGIN
        ALTER TABLE [dbo].[Link] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Link] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Link'))
BEGIN
        ALTER TABLE [dbo].[Link] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Link] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'BudgetId' AND Object_ID = Object_ID(N'Budget'))
BEGIN
        ALTER TABLE [dbo].[Budget] ADD [BudgetId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Budget'))
BEGIN
        ALTER TABLE [dbo].[Budget] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Budget] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Budget'))
BEGIN
        ALTER TABLE [dbo].[Budget] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Budget] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'NonId' AND Object_ID = Object_ID(N'Non'))
BEGIN
        ALTER TABLE [dbo].[Non] ADD [NonId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Non'))
BEGIN
        ALTER TABLE [dbo].[Non] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Non] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Non'))
BEGIN
        ALTER TABLE [dbo].[Non] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Non] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'LatinextensionId' AND Object_ID = Object_ID(N'Latinextension'))
BEGIN
        ALTER TABLE [dbo].[Latinextension] ADD [LatinextensionId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Latinextension'))
BEGIN
        ALTER TABLE [dbo].[Latinextension] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Latinextension] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Latinextension'))
BEGIN
        ALTER TABLE [dbo].[Latinextension] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Latinextension] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'SoftwareId' AND Object_ID = Object_ID(N'Software'))
BEGIN
        ALTER TABLE [dbo].[Software] ADD [SoftwareId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Software'))
BEGIN
        ALTER TABLE [dbo].[Software] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Software] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Software'))
BEGIN
        ALTER TABLE [dbo].[Software] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Software] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'DecodingsoftwareId' AND Object_ID = Object_ID(N'Decodingsoftware'))
BEGIN
        ALTER TABLE [dbo].[Decodingsoftware] ADD [DecodingsoftwareId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Decodingsoftware'))
BEGIN
        ALTER TABLE [dbo].[Decodingsoftware] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Decodingsoftware] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Decodingsoftware'))
BEGIN
        ALTER TABLE [dbo].[Decodingsoftware] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Decodingsoftware] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'SeealsoId' AND Object_ID = Object_ID(N'Seealso'))
BEGIN
        ALTER TABLE [dbo].[Seealso] ADD [SeealsoId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Seealso'))
BEGIN
        ALTER TABLE [dbo].[Seealso] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Seealso] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Seealso'))
BEGIN
        ALTER TABLE [dbo].[Seealso] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Seealso] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'BibliographyId' AND Object_ID = Object_ID(N'Bibliography'))
BEGIN
        ALTER TABLE [dbo].[Bibliography] ADD [BibliographyId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Bibliography'))
BEGIN
        ALTER TABLE [dbo].[Bibliography] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Bibliography] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Bibliography'))
BEGIN
        ALTER TABLE [dbo].[Bibliography] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Bibliography] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'EnwikipediaorgwikispecialcentralautologinstarttypexId' AND Object_ID = Object_ID(N'Enwikipediaorgwikispecialcentralautologinstarttypex'))
BEGIN
        ALTER TABLE [dbo].[Enwikipediaorgwikispecialcentralautologinstarttypex] ADD [EnwikipediaorgwikispecialcentralautologinstarttypexId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Enwikipediaorgwikispecialcentralautologinstarttypex'))
BEGIN
        ALTER TABLE [dbo].[Enwikipediaorgwikispecialcentralautologinstarttypex] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Enwikipediaorgwikispecialcentralautologinstarttypex] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Enwikipediaorgwikispecialcentralautologinstarttypex'))
BEGIN
        ALTER TABLE [dbo].[Enwikipediaorgwikispecialcentralautologinstarttypex] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Enwikipediaorgwikispecialcentralautologinstarttypex] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'HttpsenwikipediaorgwindexphptitlemorsecodeoldidId' AND Object_ID = Object_ID(N'Httpsenwikipediaorgwindexphptitlemorsecodeoldid'))
BEGIN
        ALTER TABLE [dbo].[Httpsenwikipediaorgwindexphptitlemorsecodeoldid] ADD [HttpsenwikipediaorgwindexphptitlemorsecodeoldidId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Httpsenwikipediaorgwindexphptitlemorsecodeoldid'))
BEGIN
        ALTER TABLE [dbo].[Httpsenwikipediaorgwindexphptitlemorsecodeoldid] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Httpsenwikipediaorgwindexphptitlemorsecodeoldid] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Httpsenwikipediaorgwindexphptitlemorsecodeoldid'))
BEGIN
        ALTER TABLE [dbo].[Httpsenwikipediaorgwindexphptitlemorsecodeoldid] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Httpsenwikipediaorgwindexphptitlemorsecodeoldid] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'LetterId' AND Object_ID = Object_ID(N'Letter'))
BEGIN
        ALTER TABLE [dbo].[Letter] ADD [LetterId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Letter'))
BEGIN
        ALTER TABLE [dbo].[Letter] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Letter] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Letter'))
BEGIN
        ALTER TABLE [dbo].[Letter] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Letter] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'NumeralId' AND Object_ID = Object_ID(N'Numeral'))
BEGIN
        ALTER TABLE [dbo].[Numeral] ADD [NumeralId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Numeral'))
BEGIN
        ALTER TABLE [dbo].[Numeral] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Numeral] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Numeral'))
BEGIN
        ALTER TABLE [dbo].[Numeral] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Numeral] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'ToneId' AND Object_ID = Object_ID(N'Tone'))
BEGIN
        ALTER TABLE [dbo].[Tone] ADD [ToneId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Tone'))
BEGIN
        ALTER TABLE [dbo].[Tone] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Tone] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Tone'))
BEGIN
        ALTER TABLE [dbo].[Tone] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Tone] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'LightId' AND Object_ID = Object_ID(N'Light'))
BEGIN
        ALTER TABLE [dbo].[Light] ADD [LightId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Light'))
BEGIN
        ALTER TABLE [dbo].[Light] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Light] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Light'))
BEGIN
        ALTER TABLE [dbo].[Light] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Light] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'ClickId' AND Object_ID = Object_ID(N'Click'))
BEGIN
        ALTER TABLE [dbo].[Click] ADD [ClickId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Click'))
BEGIN
        ALTER TABLE [dbo].[Click] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Click] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Click'))
BEGIN
        ALTER TABLE [dbo].[Click] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Click] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'SignalId' AND Object_ID = Object_ID(N'Signal'))
BEGIN
        ALTER TABLE [dbo].[Signal] ADD [SignalId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Signal'))
BEGIN
        ALTER TABLE [dbo].[Signal] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Signal] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Signal'))
BEGIN
        ALTER TABLE [dbo].[Signal] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Signal] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'ProsignId' AND Object_ID = Object_ID(N'Prosign'))
BEGIN
        ALTER TABLE [dbo].[Prosign] ADD [ProsignId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Prosign'))
BEGIN
        ALTER TABLE [dbo].[Prosign] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Prosign] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Prosign'))
BEGIN
        ALTER TABLE [dbo].[Prosign] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Prosign] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'SequenceId' AND Object_ID = Object_ID(N'Sequence'))
BEGIN
        ALTER TABLE [dbo].[Sequence] ADD [SequenceId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Sequence'))
BEGIN
        ALTER TABLE [dbo].[Sequence] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Sequence] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Sequence'))
BEGIN
        ALTER TABLE [dbo].[Sequence] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Sequence] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'DotId' AND Object_ID = Object_ID(N'Dot'))
BEGIN
        ALTER TABLE [dbo].[Dot] ADD [DotId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Dot'))
BEGIN
        ALTER TABLE [dbo].[Dot] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Dot] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Dot'))
BEGIN
        ALTER TABLE [dbo].[Dot] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Dot] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'DashId' AND Object_ID = Object_ID(N'Dash'))
BEGIN
        ALTER TABLE [dbo].[Dash] ADD [DashId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Dash'))
BEGIN
        ALTER TABLE [dbo].[Dash] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Dash] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Dash'))
BEGIN
        ALTER TABLE [dbo].[Dash] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Dash] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'LanguageId' AND Object_ID = Object_ID(N'Language'))
BEGIN
        ALTER TABLE [dbo].[Language] ADD [LanguageId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Language'))
BEGIN
        ALTER TABLE [dbo].[Language] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Language] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Language'))
BEGIN
        ALTER TABLE [dbo].[Language] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Language] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'ExtensionId' AND Object_ID = Object_ID(N'Extension'))
BEGIN
        ALTER TABLE [dbo].[Extension] ADD [ExtensionId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Extension'))
BEGIN
        ALTER TABLE [dbo].[Extension] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Extension] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Extension'))
BEGIN
        ALTER TABLE [dbo].[Extension] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Extension] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'TelegraphOperatorId' AND Object_ID = Object_ID(N'TelegraphOperator'))
BEGIN
        ALTER TABLE [dbo].[TelegraphOperator] ADD [TelegraphOperatorId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'TelegraphOperator'))
BEGIN
        ALTER TABLE [dbo].[TelegraphOperator] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[TelegraphOperator] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'TelegraphOperator'))
BEGIN
        ALTER TABLE [dbo].[TelegraphOperator] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[TelegraphOperator] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'CountryId' AND Object_ID = Object_ID(N'Country'))
BEGIN
        ALTER TABLE [dbo].[Country] ADD [CountryId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Country'))
BEGIN
        ALTER TABLE [dbo].[Country] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Country] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Country'))
BEGIN
        ALTER TABLE [dbo].[Country] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Country] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'PilotId' AND Object_ID = Object_ID(N'Pilot'))
BEGIN
        ALTER TABLE [dbo].[Pilot] ADD [PilotId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Pilot'))
BEGIN
        ALTER TABLE [dbo].[Pilot] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Pilot] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Pilot'))
BEGIN
        ALTER TABLE [dbo].[Pilot] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Pilot] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'ControllerId' AND Object_ID = Object_ID(N'Controller'))
BEGIN
        ALTER TABLE [dbo].[Controller] ADD [ControllerId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Controller'))
BEGIN
        ALTER TABLE [dbo].[Controller] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Controller] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Controller'))
BEGIN
        ALTER TABLE [dbo].[Controller] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Controller] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'AidId' AND Object_ID = Object_ID(N'Aid'))
BEGIN
        ALTER TABLE [dbo].[Aid] ADD [AidId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Aid'))
BEGIN
        ALTER TABLE [dbo].[Aid] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Aid] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Aid'))
BEGIN
        ALTER TABLE [dbo].[Aid] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Aid] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'VorId' AND Object_ID = Object_ID(N'Vor'))
BEGIN
        ALTER TABLE [dbo].[Vor] ADD [VorId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Vor'))
BEGIN
        ALTER TABLE [dbo].[Vor] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Vor] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Vor'))
BEGIN
        ALTER TABLE [dbo].[Vor] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Vor] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'NdbId' AND Object_ID = Object_ID(N'Ndb'))
BEGIN
        ALTER TABLE [dbo].[Ndb] ADD [NdbId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Ndb'))
BEGIN
        ALTER TABLE [dbo].[Ndb] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Ndb] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Ndb'))
BEGIN
        ALTER TABLE [dbo].[Ndb] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Ndb] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'ConditionId' AND Object_ID = Object_ID(N'Condition'))
BEGIN
        ALTER TABLE [dbo].[Condition] ADD [ConditionId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Condition'))
BEGIN
        ALTER TABLE [dbo].[Condition] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Condition] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Condition'))
BEGIN
        ALTER TABLE [dbo].[Condition] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Condition] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'HumanId' AND Object_ID = Object_ID(N'Human'))
BEGIN
        ALTER TABLE [dbo].[Human] ADD [HumanId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Human'))
BEGIN
        ALTER TABLE [dbo].[Human] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Human] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Human'))
BEGIN
        ALTER TABLE [dbo].[Human] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Human] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'DatumId' AND Object_ID = Object_ID(N'Datum'))
BEGIN
        ALTER TABLE [dbo].[Datum] ADD [DatumId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Datum'))
BEGIN
        ALTER TABLE [dbo].[Datum] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Datum] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Datum'))
BEGIN
        ALTER TABLE [dbo].[Datum] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Datum] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'ChannelId' AND Object_ID = Object_ID(N'Channel'))
BEGIN
        ALTER TABLE [dbo].[Channel] ADD [ChannelId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Channel'))
BEGIN
        ALTER TABLE [dbo].[Channel] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Channel] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Channel'))
BEGIN
        ALTER TABLE [dbo].[Channel] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Channel] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'RepeaterId' AND Object_ID = Object_ID(N'Repeater'))
BEGIN
        ALTER TABLE [dbo].[Repeater] ADD [RepeaterId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Repeater'))
BEGIN
        ALTER TABLE [dbo].[Repeater] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Repeater] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Repeater'))
BEGIN
        ALTER TABLE [dbo].[Repeater] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Repeater] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'ContentId' AND Object_ID = Object_ID(N'Content'))
BEGIN
        ALTER TABLE [dbo].[Content] ADD [ContentId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Content'))
BEGIN
        ALTER TABLE [dbo].[Content] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Content] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Content'))
BEGIN
        ALTER TABLE [dbo].[Content] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Content] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'UsId' AND Object_ID = Object_ID(N'Us'))
BEGIN
        ALTER TABLE [dbo].[Us] ADD [UsId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Us'))
BEGIN
        ALTER TABLE [dbo].[Us] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Us] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Us'))
BEGIN
        ALTER TABLE [dbo].[Us] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Us] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'OtheruId' AND Object_ID = Object_ID(N'Otheru'))
BEGIN
        ALTER TABLE [dbo].[Otheru] ADD [OtheruId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Otheru'))
BEGIN
        ALTER TABLE [dbo].[Otheru] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Otheru] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Otheru'))
BEGIN
        ALTER TABLE [dbo].[Otheru] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Otheru] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'ApplicationId' AND Object_ID = Object_ID(N'Application'))
BEGIN
        ALTER TABLE [dbo].[Application] ADD [ApplicationId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Application'))
BEGIN
        ALTER TABLE [dbo].[Application] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Application] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Application'))
BEGIN
        ALTER TABLE [dbo].[Application] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Application] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'AndspeedId' AND Object_ID = Object_ID(N'Andspeed'))
BEGIN
        ALTER TABLE [dbo].[Andspeed] ADD [AndspeedId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Andspeed'))
BEGIN
        ALTER TABLE [dbo].[Andspeed] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Andspeed] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Andspeed'))
BEGIN
        ALTER TABLE [dbo].[Andspeed] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Andspeed] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'IssueId' AND Object_ID = Object_ID(N'Issue'))
BEGIN
        ALTER TABLE [dbo].[Issue] ADD [IssueId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Issue'))
BEGIN
        ALTER TABLE [dbo].[Issue] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Issue] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Issue'))
BEGIN
        ALTER TABLE [dbo].[Issue] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Issue] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'LinkbudgetissueId' AND Object_ID = Object_ID(N'Linkbudgetissue'))
BEGIN
        ALTER TABLE [dbo].[Linkbudgetissue] ADD [LinkbudgetissueId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Linkbudgetissue'))
BEGIN
        ALTER TABLE [dbo].[Linkbudgetissue] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Linkbudgetissue] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Linkbudgetissue'))
BEGIN
        ALTER TABLE [dbo].[Linkbudgetissue] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Linkbudgetissue] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'LearningmethodId' AND Object_ID = Object_ID(N'Learningmethod'))
BEGIN
        ALTER TABLE [dbo].[Learningmethod] ADD [LearningmethodId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Learningmethod'))
BEGIN
        ALTER TABLE [dbo].[Learningmethod] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Learningmethod] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Learningmethod'))
BEGIN
        ALTER TABLE [dbo].[Learningmethod] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Learningmethod] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'NumberId' AND Object_ID = Object_ID(N'Number'))
BEGIN
        ALTER TABLE [dbo].[Number] ADD [NumberId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Number'))
BEGIN
        ALTER TABLE [dbo].[Number] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Number] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Number'))
BEGIN
        ALTER TABLE [dbo].[Number] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Number] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'VariantId' AND Object_ID = Object_ID(N'Variant'))
BEGIN
        ALTER TABLE [dbo].[Variant] ADD [VariantId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Variant'))
BEGIN
        ALTER TABLE [dbo].[Variant] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Variant] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Variant'))
BEGIN
        ALTER TABLE [dbo].[Variant] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Variant] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'ProsignsformorsecodeandnonenglishvariantId' AND Object_ID = Object_ID(N'Prosignsformorsecodeandnonenglishvariant'))
BEGIN
        ALTER TABLE [dbo].[Prosignsformorsecodeandnonenglishvariant] ADD [ProsignsformorsecodeandnonenglishvariantId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Prosignsformorsecodeandnonenglishvariant'))
BEGIN
        ALTER TABLE [dbo].[Prosignsformorsecodeandnonenglishvariant] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Prosignsformorsecodeandnonenglishvariant] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Prosignsformorsecodeandnonenglishvariant'))
BEGIN
        ALTER TABLE [dbo].[Prosignsformorsecodeandnonenglishvariant] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Prosignsformorsecodeandnonenglishvariant] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'SymbolrepresentationId' AND Object_ID = Object_ID(N'Symbolrepresentation'))
BEGIN
        ALTER TABLE [dbo].[Symbolrepresentation] ADD [SymbolrepresentationId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Symbolrepresentation'))
BEGIN
        ALTER TABLE [dbo].[Symbolrepresentation] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Symbolrepresentation] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Symbolrepresentation'))
BEGIN
        ALTER TABLE [dbo].[Symbolrepresentation] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Symbolrepresentation] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'UnusualvariantId' AND Object_ID = Object_ID(N'Unusualvariant'))
BEGIN
        ALTER TABLE [dbo].[Unusualvariant] ADD [UnusualvariantId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Unusualvariant'))
BEGIN
        ALTER TABLE [dbo].[Unusualvariant] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Unusualvariant] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Unusualvariant'))
BEGIN
        ALTER TABLE [dbo].[Unusualvariant] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Unusualvariant] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'ReferenceId' AND Object_ID = Object_ID(N'Reference'))
BEGIN
        ALTER TABLE [dbo].[Reference] ADD [ReferenceId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Reference'))
BEGIN
        ALTER TABLE [dbo].[Reference] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Reference] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Reference'))
BEGIN
        ALTER TABLE [dbo].[Reference] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Reference] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'ExternallinkId' AND Object_ID = Object_ID(N'Externallink'))
BEGIN
        ALTER TABLE [dbo].[Externallink] ADD [ExternallinkId] UNIQUEIDENTIFIER NULL;
END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Name' AND Object_ID = Object_ID(N'Externallink'))
BEGIN
        ALTER TABLE [dbo].[Externallink] ADD [Name] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Externallink] ALTER COLUMN [Name] NVARCHAR(100) NOT NULL;

    

	END

    
    
    
    
    -- COUNT: 3
IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'Description' AND Object_ID = Object_ID(N'Externallink'))
BEGIN
        ALTER TABLE [dbo].[Externallink] ADD [Description] NVARCHAR(100) NULL;
END

    
ELSE
    BEGIN 


        ALTER TABLE [dbo].[Externallink] ALTER COLUMN [Description] NVARCHAR(100) NOT NULL;

    

	END

    
    
    

SELECT *
FROM (SELECT 'true' AS Success) AS Results
FOR XML AUTO
                   