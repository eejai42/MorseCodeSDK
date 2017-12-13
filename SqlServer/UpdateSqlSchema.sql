

USE [MorseCodeSDK];

DECLARE @ObjectName NVARCHAR(100)

    
    
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

    
    
    

SELECT *
FROM (SELECT 'true' AS Success) AS Results
FOR XML AUTO
                   