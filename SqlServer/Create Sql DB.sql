
    SET ANSI_NULLS ON
    GO

    SET QUOTED_IDENTIFIER ON
    GO
    
    
      -- TABLE: Wikipedia
      -- TABLE: Morse
      -- TABLE: Samuel
      -- TABLE: Samuelfbmorse
      -- TABLE: International
      -- TABLE: Roman
      -- TABLE: English
      -- TABLE: Aeronautical
      -- TABLE: Aviation
      -- TABLE: Cable
      -- TABLE: Farnsworth
      -- TABLE: Learning
      -- TABLE: Mnemonic
      -- TABLE: Encyclopedia
      -- TABLE: Jump
      -- TABLE: Navigation
      -- TABLE: Head
      -- TABLE: Search
      -- TABLE: Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng
      -- TABLE: Fileinternationalmorsecodesvg
      -- TABLE: Chart
      -- TABLE: Code
      -- TABLE: Itur
      -- TABLE: Method
      -- TABLE: Text
      -- TABLE: Writtenlanguage
      -- TABLE: Information
      -- TABLE: Series
      -- TABLE: Listener
      -- TABLE: Observer
      -- TABLE: Equipment
      -- TABLE: Inventor
      -- TABLE: Telegraph
      -- TABLE: Iso
      -- TABLE: Alphabet
      -- TABLE: Isobasiclatinalphabet
      -- TABLE: Arabicnumeral
      -- TABLE: Set
      -- TABLE: Punctuation
      -- TABLE: Prosignsformorsecode
      -- TABLE: Radio
      -- TABLE: Amateurradio
      -- TABLE: Practice
      -- TABLE: Symbol
      -- TABLE: Character
      -- TABLE: Duration
      -- TABLE: Unit
      -- TABLE: Time
      -- TABLE: Measurement
      -- TABLE: Transmission
      -- TABLE: Silence
      -- TABLE: Word
      -- TABLE: Delimiter
      -- TABLE: Space
      -- TABLE: Speed
      -- TABLE: Communication
      -- TABLE: Length
      -- TABLE: Frequency
      -- TABLE: Occurrence
      -- TABLE: Entropyencoding
      -- TABLE: Amateurradiooperator
      -- TABLE: Knowledge
      -- TABLE: Proficiency
      -- TABLE: Licensing
      -- TABLE: Amateurradiolicense
      -- TABLE: Aviator
      -- TABLE: Air
      -- TABLE: Traffic
      -- TABLE: Airtrafficcontroller
      -- TABLE: Understanding
      -- TABLE: Navigationalaid
      -- TABLE: Vhfomnidirectionalrange
      -- TABLE: Nondirectionalbeacon
      -- TABLE: Voice
      -- TABLE: Decoding
      -- TABLE: Device
      -- TABLE: Alternative
      -- TABLE: Speech
      -- TABLE: Amateurradiorepeater
      -- TABLE: Example
      -- TABLE: Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng
      -- TABLE: Filesossvg
      -- TABLE: Emergency
      -- TABLE: Telecommunication
      -- TABLE: Distress
      -- TABLE: Treaty
      -- TABLE: Development
      -- TABLE: History
      -- TABLE: Developmentandhistory
      -- TABLE: User
      -- TABLE: Userproficiency
      -- TABLE: Internationalmorsecode
      -- TABLE: Technology
      -- TABLE: Morsecodeasanassistivetechnology
      -- TABLE: Representation
      -- TABLE: Timing
      -- TABLE: Cablecode
      -- TABLE: Spokenrepresentation
      -- TABLE: Minute
      -- TABLE: Speedinwordsperminute
      -- TABLE: Farnsworthspeed
      -- TABLE: Display
      -- TABLE: Alternativedisplayofcommoncharactersininternationalmorsecode
      -- TABLE: Link
      -- TABLE: Budget
      -- TABLE: Non
      -- TABLE: Latinextension
      -- TABLE: Software
      -- TABLE: Decodingsoftware
      -- TABLE: Seealso
      -- TABLE: Bibliography
      -- TABLE: Enwikipediaorgwikispecialcentralautologinstarttypex
      -- TABLE: Httpsenwikipediaorgwindexphptitlemorsecodeoldid
      -- TABLE: Letter
      -- TABLE: Numeral
      -- TABLE: Tone
      -- TABLE: Light
      -- TABLE: Click
      -- TABLE: Signal
      -- TABLE: Prosign
      -- TABLE: Sequence
      -- TABLE: Dot
      -- TABLE: Dash
      -- TABLE: Language
      -- TABLE: Extension
      -- TABLE: TelegraphOperator
      -- TABLE: Country
      -- TABLE: Pilot
      -- TABLE: Controller
      -- TABLE: Aid
      -- TABLE: Vor
      -- TABLE: Ndb
      -- TABLE: Condition
      -- TABLE: Human
      -- TABLE: Datum
      -- TABLE: Channel
      -- TABLE: Repeater
      -- TABLE: Content
      -- TABLE: Us
      -- TABLE: Otheru
      -- TABLE: Application
      -- TABLE: Andspeed
      -- TABLE: Issue
      -- TABLE: Linkbudgetissue
      -- TABLE: Learningmethod
      -- TABLE: Number
      -- TABLE: Variant
      -- TABLE: Prosignsformorsecodeandnonenglishvariant
      -- TABLE: Symbolrepresentation
      -- TABLE: Unusualvariant
      -- TABLE: Reference
      -- TABLE: Externallink
      /*
      -- CREATE DATABASE
      IF NOT EXISTS (SELECT * from sys.databases WHERE name = 'MorseCodeSDK')
      BEGIN
          CREATE DATABASE [MorseCodeSDK];
      END
        GO
        
     USE [MorseCodeSDK];
     */
      
      
        -- TABLE: Wikipedia
        -- ****** Object:  Table [dbo].[Wikipedia]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Wikipedia]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Wikipedia] (
          [WikipediaId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Wikipedia] PRIMARY KEY CLUSTERED
          (
            [WikipediaId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Morse
        -- ****** Object:  Table [dbo].[Morse]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Morse]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Morse] (
          [MorseId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Morse] PRIMARY KEY CLUSTERED
          (
            [MorseId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Samuel
        -- ****** Object:  Table [dbo].[Samuel]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Samuel]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Samuel] (
          [SamuelId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Samuel] PRIMARY KEY CLUSTERED
          (
            [SamuelId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Samuelfbmorse
        -- ****** Object:  Table [dbo].[Samuelfbmorse]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Samuelfbmorse]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Samuelfbmorse] (
          [SamuelfbmorseId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Samuelfbmorse] PRIMARY KEY CLUSTERED
          (
            [SamuelfbmorseId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: International
        -- ****** Object:  Table [dbo].[International]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[International]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[International] (
          [InternationalId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_International] PRIMARY KEY CLUSTERED
          (
            [InternationalId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Roman
        -- ****** Object:  Table [dbo].[Roman]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Roman]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Roman] (
          [RomanId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Roman] PRIMARY KEY CLUSTERED
          (
            [RomanId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: English
        -- ****** Object:  Table [dbo].[English]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[English]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[English] (
          [EnglishId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_English] PRIMARY KEY CLUSTERED
          (
            [EnglishId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Aeronautical
        -- ****** Object:  Table [dbo].[Aeronautical]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Aeronautical]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Aeronautical] (
          [AeronauticalId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Aeronautical] PRIMARY KEY CLUSTERED
          (
            [AeronauticalId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Aviation
        -- ****** Object:  Table [dbo].[Aviation]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Aviation]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Aviation] (
          [AviationId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Aviation] PRIMARY KEY CLUSTERED
          (
            [AviationId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Cable
        -- ****** Object:  Table [dbo].[Cable]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Cable]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Cable] (
          [CableId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Cable] PRIMARY KEY CLUSTERED
          (
            [CableId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Farnsworth
        -- ****** Object:  Table [dbo].[Farnsworth]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Farnsworth]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Farnsworth] (
          [FarnsworthId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Farnsworth] PRIMARY KEY CLUSTERED
          (
            [FarnsworthId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Learning
        -- ****** Object:  Table [dbo].[Learning]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Learning]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Learning] (
          [LearningId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Learning] PRIMARY KEY CLUSTERED
          (
            [LearningId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Mnemonic
        -- ****** Object:  Table [dbo].[Mnemonic]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mnemonic]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Mnemonic] (
          [MnemonicId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Mnemonic] PRIMARY KEY CLUSTERED
          (
            [MnemonicId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Encyclopedia
        -- ****** Object:  Table [dbo].[Encyclopedia]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Encyclopedia]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Encyclopedia] (
          [EncyclopediaId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Encyclopedia] PRIMARY KEY CLUSTERED
          (
            [EncyclopediaId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Jump
        -- ****** Object:  Table [dbo].[Jump]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Jump]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Jump] (
          [JumpId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Jump] PRIMARY KEY CLUSTERED
          (
            [JumpId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Navigation
        -- ****** Object:  Table [dbo].[Navigation]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Navigation]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Navigation] (
          [NavigationId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Navigation] PRIMARY KEY CLUSTERED
          (
            [NavigationId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Head
        -- ****** Object:  Table [dbo].[Head]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Head]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Head] (
          [HeadId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Head] PRIMARY KEY CLUSTERED
          (
            [HeadId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Search
        -- ****** Object:  Table [dbo].[Search]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Search]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Search] (
          [SearchId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Search] PRIMARY KEY CLUSTERED
          (
            [SearchId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng
        -- ****** Object:  Table [dbo].[Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng] (
          [UploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng] PRIMARY KEY CLUSTERED
          (
            [UploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Fileinternationalmorsecodesvg
        -- ****** Object:  Table [dbo].[Fileinternationalmorsecodesvg]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Fileinternationalmorsecodesvg]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Fileinternationalmorsecodesvg] (
          [FileinternationalmorsecodesvgId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Fileinternationalmorsecodesvg] PRIMARY KEY CLUSTERED
          (
            [FileinternationalmorsecodesvgId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Chart
        -- ****** Object:  Table [dbo].[Chart]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Chart]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Chart] (
          [ChartId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Chart] PRIMARY KEY CLUSTERED
          (
            [ChartId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Code
        -- ****** Object:  Table [dbo].[Code]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Code]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Code] (
          [CodeId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Code] PRIMARY KEY CLUSTERED
          (
            [CodeId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Itur
        -- ****** Object:  Table [dbo].[Itur]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Itur]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Itur] (
          [IturId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Itur] PRIMARY KEY CLUSTERED
          (
            [IturId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Method
        -- ****** Object:  Table [dbo].[Method]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Method]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Method] (
          [MethodId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Method] PRIMARY KEY CLUSTERED
          (
            [MethodId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Text
        -- ****** Object:  Table [dbo].[Text]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Text]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Text] (
          [TextId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Text] PRIMARY KEY CLUSTERED
          (
            [TextId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Writtenlanguage
        -- ****** Object:  Table [dbo].[Writtenlanguage]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Writtenlanguage]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Writtenlanguage] (
          [WrittenlanguageId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Writtenlanguage] PRIMARY KEY CLUSTERED
          (
            [WrittenlanguageId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Information
        -- ****** Object:  Table [dbo].[Information]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Information]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Information] (
          [InformationId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Information] PRIMARY KEY CLUSTERED
          (
            [InformationId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Series
        -- ****** Object:  Table [dbo].[Series]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Series]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Series] (
          [SeriesId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Series] PRIMARY KEY CLUSTERED
          (
            [SeriesId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Listener
        -- ****** Object:  Table [dbo].[Listener]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Listener]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Listener] (
          [ListenerId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Listener] PRIMARY KEY CLUSTERED
          (
            [ListenerId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Observer
        -- ****** Object:  Table [dbo].[Observer]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Observer]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Observer] (
          [ObserverId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Observer] PRIMARY KEY CLUSTERED
          (
            [ObserverId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Equipment
        -- ****** Object:  Table [dbo].[Equipment]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Equipment]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Equipment] (
          [EquipmentId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Equipment] PRIMARY KEY CLUSTERED
          (
            [EquipmentId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Inventor
        -- ****** Object:  Table [dbo].[Inventor]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Inventor]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Inventor] (
          [InventorId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Inventor] PRIMARY KEY CLUSTERED
          (
            [InventorId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Telegraph
        -- ****** Object:  Table [dbo].[Telegraph]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Telegraph]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Telegraph] (
          [TelegraphId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Telegraph] PRIMARY KEY CLUSTERED
          (
            [TelegraphId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Iso
        -- ****** Object:  Table [dbo].[Iso]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Iso]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Iso] (
          [IsoId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Iso] PRIMARY KEY CLUSTERED
          (
            [IsoId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Alphabet
        -- ****** Object:  Table [dbo].[Alphabet]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Alphabet]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Alphabet] (
          [AlphabetId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Alphabet] PRIMARY KEY CLUSTERED
          (
            [AlphabetId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Isobasiclatinalphabet
        -- ****** Object:  Table [dbo].[Isobasiclatinalphabet]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Isobasiclatinalphabet]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Isobasiclatinalphabet] (
          [IsobasiclatinalphabetId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Isobasiclatinalphabet] PRIMARY KEY CLUSTERED
          (
            [IsobasiclatinalphabetId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Arabicnumeral
        -- ****** Object:  Table [dbo].[Arabicnumeral]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Arabicnumeral]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Arabicnumeral] (
          [ArabicnumeralId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Arabicnumeral] PRIMARY KEY CLUSTERED
          (
            [ArabicnumeralId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Set
        -- ****** Object:  Table [dbo].[Set]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Set]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Set] (
          [SetId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Set] PRIMARY KEY CLUSTERED
          (
            [SetId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Punctuation
        -- ****** Object:  Table [dbo].[Punctuation]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Punctuation]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Punctuation] (
          [PunctuationId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Punctuation] PRIMARY KEY CLUSTERED
          (
            [PunctuationId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Prosignsformorsecode
        -- ****** Object:  Table [dbo].[Prosignsformorsecode]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Prosignsformorsecode]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Prosignsformorsecode] (
          [ProsignsformorsecodeId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Prosignsformorsecode] PRIMARY KEY CLUSTERED
          (
            [ProsignsformorsecodeId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Radio
        -- ****** Object:  Table [dbo].[Radio]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Radio]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Radio] (
          [RadioId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Radio] PRIMARY KEY CLUSTERED
          (
            [RadioId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Amateurradio
        -- ****** Object:  Table [dbo].[Amateurradio]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Amateurradio]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Amateurradio] (
          [AmateurradioId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Amateurradio] PRIMARY KEY CLUSTERED
          (
            [AmateurradioId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Practice
        -- ****** Object:  Table [dbo].[Practice]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Practice]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Practice] (
          [PracticeId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Practice] PRIMARY KEY CLUSTERED
          (
            [PracticeId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Symbol
        -- ****** Object:  Table [dbo].[Symbol]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Symbol]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Symbol] (
          [SymbolId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Symbol] PRIMARY KEY CLUSTERED
          (
            [SymbolId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Character
        -- ****** Object:  Table [dbo].[Character]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Character]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Character] (
          [CharacterId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Character] PRIMARY KEY CLUSTERED
          (
            [CharacterId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Duration
        -- ****** Object:  Table [dbo].[Duration]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Duration]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Duration] (
          [DurationId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Duration] PRIMARY KEY CLUSTERED
          (
            [DurationId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Unit
        -- ****** Object:  Table [dbo].[Unit]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Unit]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Unit] (
          [UnitId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Unit] PRIMARY KEY CLUSTERED
          (
            [UnitId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Time
        -- ****** Object:  Table [dbo].[Time]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Time]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Time] (
          [TimeId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Time] PRIMARY KEY CLUSTERED
          (
            [TimeId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Measurement
        -- ****** Object:  Table [dbo].[Measurement]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Measurement]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Measurement] (
          [MeasurementId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Measurement] PRIMARY KEY CLUSTERED
          (
            [MeasurementId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Transmission
        -- ****** Object:  Table [dbo].[Transmission]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Transmission]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Transmission] (
          [TransmissionId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Transmission] PRIMARY KEY CLUSTERED
          (
            [TransmissionId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Silence
        -- ****** Object:  Table [dbo].[Silence]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Silence]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Silence] (
          [SilenceId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Silence] PRIMARY KEY CLUSTERED
          (
            [SilenceId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Word
        -- ****** Object:  Table [dbo].[Word]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Word]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Word] (
          [WordId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Word] PRIMARY KEY CLUSTERED
          (
            [WordId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Delimiter
        -- ****** Object:  Table [dbo].[Delimiter]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Delimiter]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Delimiter] (
          [DelimiterId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Delimiter] PRIMARY KEY CLUSTERED
          (
            [DelimiterId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Space
        -- ****** Object:  Table [dbo].[Space]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Space]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Space] (
          [SpaceId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Space] PRIMARY KEY CLUSTERED
          (
            [SpaceId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Speed
        -- ****** Object:  Table [dbo].[Speed]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Speed]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Speed] (
          [SpeedId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Speed] PRIMARY KEY CLUSTERED
          (
            [SpeedId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Communication
        -- ****** Object:  Table [dbo].[Communication]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Communication]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Communication] (
          [CommunicationId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Communication] PRIMARY KEY CLUSTERED
          (
            [CommunicationId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Length
        -- ****** Object:  Table [dbo].[Length]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Length]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Length] (
          [LengthId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Length] PRIMARY KEY CLUSTERED
          (
            [LengthId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Frequency
        -- ****** Object:  Table [dbo].[Frequency]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Frequency]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Frequency] (
          [FrequencyId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Frequency] PRIMARY KEY CLUSTERED
          (
            [FrequencyId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Occurrence
        -- ****** Object:  Table [dbo].[Occurrence]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Occurrence]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Occurrence] (
          [OccurrenceId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Occurrence] PRIMARY KEY CLUSTERED
          (
            [OccurrenceId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Entropyencoding
        -- ****** Object:  Table [dbo].[Entropyencoding]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Entropyencoding]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Entropyencoding] (
          [EntropyencodingId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Entropyencoding] PRIMARY KEY CLUSTERED
          (
            [EntropyencodingId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Amateurradiooperator
        -- ****** Object:  Table [dbo].[Amateurradiooperator]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Amateurradiooperator]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Amateurradiooperator] (
          [AmateurradiooperatorId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Amateurradiooperator] PRIMARY KEY CLUSTERED
          (
            [AmateurradiooperatorId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Knowledge
        -- ****** Object:  Table [dbo].[Knowledge]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Knowledge]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Knowledge] (
          [KnowledgeId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Knowledge] PRIMARY KEY CLUSTERED
          (
            [KnowledgeId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Proficiency
        -- ****** Object:  Table [dbo].[Proficiency]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proficiency]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Proficiency] (
          [ProficiencyId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Proficiency] PRIMARY KEY CLUSTERED
          (
            [ProficiencyId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Licensing
        -- ****** Object:  Table [dbo].[Licensing]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Licensing]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Licensing] (
          [LicensingId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Licensing] PRIMARY KEY CLUSTERED
          (
            [LicensingId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Amateurradiolicense
        -- ****** Object:  Table [dbo].[Amateurradiolicense]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Amateurradiolicense]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Amateurradiolicense] (
          [AmateurradiolicenseId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Amateurradiolicense] PRIMARY KEY CLUSTERED
          (
            [AmateurradiolicenseId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Aviator
        -- ****** Object:  Table [dbo].[Aviator]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Aviator]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Aviator] (
          [AviatorId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Aviator] PRIMARY KEY CLUSTERED
          (
            [AviatorId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Air
        -- ****** Object:  Table [dbo].[Air]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Air]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Air] (
          [AirId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Air] PRIMARY KEY CLUSTERED
          (
            [AirId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Traffic
        -- ****** Object:  Table [dbo].[Traffic]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Traffic]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Traffic] (
          [TrafficId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Traffic] PRIMARY KEY CLUSTERED
          (
            [TrafficId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Airtrafficcontroller
        -- ****** Object:  Table [dbo].[Airtrafficcontroller]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Airtrafficcontroller]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Airtrafficcontroller] (
          [AirtrafficcontrollerId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Airtrafficcontroller] PRIMARY KEY CLUSTERED
          (
            [AirtrafficcontrollerId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Understanding
        -- ****** Object:  Table [dbo].[Understanding]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Understanding]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Understanding] (
          [UnderstandingId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Understanding] PRIMARY KEY CLUSTERED
          (
            [UnderstandingId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Navigationalaid
        -- ****** Object:  Table [dbo].[Navigationalaid]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Navigationalaid]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Navigationalaid] (
          [NavigationalaidId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Navigationalaid] PRIMARY KEY CLUSTERED
          (
            [NavigationalaidId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Vhfomnidirectionalrange
        -- ****** Object:  Table [dbo].[Vhfomnidirectionalrange]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Vhfomnidirectionalrange]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Vhfomnidirectionalrange] (
          [VhfomnidirectionalrangeId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Vhfomnidirectionalrange] PRIMARY KEY CLUSTERED
          (
            [VhfomnidirectionalrangeId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Nondirectionalbeacon
        -- ****** Object:  Table [dbo].[Nondirectionalbeacon]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Nondirectionalbeacon]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Nondirectionalbeacon] (
          [NondirectionalbeaconId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Nondirectionalbeacon] PRIMARY KEY CLUSTERED
          (
            [NondirectionalbeaconId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Voice
        -- ****** Object:  Table [dbo].[Voice]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Voice]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Voice] (
          [VoiceId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Voice] PRIMARY KEY CLUSTERED
          (
            [VoiceId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Decoding
        -- ****** Object:  Table [dbo].[Decoding]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Decoding]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Decoding] (
          [DecodingId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Decoding] PRIMARY KEY CLUSTERED
          (
            [DecodingId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Device
        -- ****** Object:  Table [dbo].[Device]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Device]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Device] (
          [DeviceId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Device] PRIMARY KEY CLUSTERED
          (
            [DeviceId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Alternative
        -- ****** Object:  Table [dbo].[Alternative]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Alternative]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Alternative] (
          [AlternativeId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Alternative] PRIMARY KEY CLUSTERED
          (
            [AlternativeId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Speech
        -- ****** Object:  Table [dbo].[Speech]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Speech]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Speech] (
          [SpeechId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Speech] PRIMARY KEY CLUSTERED
          (
            [SpeechId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Amateurradiorepeater
        -- ****** Object:  Table [dbo].[Amateurradiorepeater]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Amateurradiorepeater]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Amateurradiorepeater] (
          [AmateurradiorepeaterId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Amateurradiorepeater] PRIMARY KEY CLUSTERED
          (
            [AmateurradiorepeaterId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Example
        -- ****** Object:  Table [dbo].[Example]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Example]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Example] (
          [ExampleId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Example] PRIMARY KEY CLUSTERED
          (
            [ExampleId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng
        -- ****** Object:  Table [dbo].[Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng] (
          [UploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng] PRIMARY KEY CLUSTERED
          (
            [UploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Filesossvg
        -- ****** Object:  Table [dbo].[Filesossvg]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Filesossvg]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Filesossvg] (
          [FilesossvgId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Filesossvg] PRIMARY KEY CLUSTERED
          (
            [FilesossvgId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Emergency
        -- ****** Object:  Table [dbo].[Emergency]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Emergency]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Emergency] (
          [EmergencyId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Emergency] PRIMARY KEY CLUSTERED
          (
            [EmergencyId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Telecommunication
        -- ****** Object:  Table [dbo].[Telecommunication]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Telecommunication]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Telecommunication] (
          [TelecommunicationId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Telecommunication] PRIMARY KEY CLUSTERED
          (
            [TelecommunicationId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Distress
        -- ****** Object:  Table [dbo].[Distress]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Distress]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Distress] (
          [DistressId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Distress] PRIMARY KEY CLUSTERED
          (
            [DistressId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Treaty
        -- ****** Object:  Table [dbo].[Treaty]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Treaty]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Treaty] (
          [TreatyId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Treaty] PRIMARY KEY CLUSTERED
          (
            [TreatyId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Development
        -- ****** Object:  Table [dbo].[Development]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Development]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Development] (
          [DevelopmentId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Development] PRIMARY KEY CLUSTERED
          (
            [DevelopmentId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: History
        -- ****** Object:  Table [dbo].[History]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[History]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[History] (
          [HistoryId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_History] PRIMARY KEY CLUSTERED
          (
            [HistoryId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Developmentandhistory
        -- ****** Object:  Table [dbo].[Developmentandhistory]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Developmentandhistory]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Developmentandhistory] (
          [DevelopmentandhistoryId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Developmentandhistory] PRIMARY KEY CLUSTERED
          (
            [DevelopmentandhistoryId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: User
        -- ****** Object:  Table [dbo].[User]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[User]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[User] (
          [UserId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED
          (
            [UserId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Userproficiency
        -- ****** Object:  Table [dbo].[Userproficiency]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Userproficiency]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Userproficiency] (
          [UserproficiencyId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Userproficiency] PRIMARY KEY CLUSTERED
          (
            [UserproficiencyId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Internationalmorsecode
        -- ****** Object:  Table [dbo].[Internationalmorsecode]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Internationalmorsecode]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Internationalmorsecode] (
          [InternationalmorsecodeId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Internationalmorsecode] PRIMARY KEY CLUSTERED
          (
            [InternationalmorsecodeId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Technology
        -- ****** Object:  Table [dbo].[Technology]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Technology]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Technology] (
          [TechnologyId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Technology] PRIMARY KEY CLUSTERED
          (
            [TechnologyId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Morsecodeasanassistivetechnology
        -- ****** Object:  Table [dbo].[Morsecodeasanassistivetechnology]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Morsecodeasanassistivetechnology]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Morsecodeasanassistivetechnology] (
          [MorsecodeasanassistivetechnologyId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Morsecodeasanassistivetechnology] PRIMARY KEY CLUSTERED
          (
            [MorsecodeasanassistivetechnologyId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Representation
        -- ****** Object:  Table [dbo].[Representation]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Representation]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Representation] (
          [RepresentationId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Representation] PRIMARY KEY CLUSTERED
          (
            [RepresentationId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Timing
        -- ****** Object:  Table [dbo].[Timing]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Timing]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Timing] (
          [TimingId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Timing] PRIMARY KEY CLUSTERED
          (
            [TimingId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Cablecode
        -- ****** Object:  Table [dbo].[Cablecode]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Cablecode]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Cablecode] (
          [CablecodeId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Cablecode] PRIMARY KEY CLUSTERED
          (
            [CablecodeId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Spokenrepresentation
        -- ****** Object:  Table [dbo].[Spokenrepresentation]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Spokenrepresentation]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Spokenrepresentation] (
          [SpokenrepresentationId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Spokenrepresentation] PRIMARY KEY CLUSTERED
          (
            [SpokenrepresentationId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Minute
        -- ****** Object:  Table [dbo].[Minute]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Minute]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Minute] (
          [MinuteId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Minute] PRIMARY KEY CLUSTERED
          (
            [MinuteId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Speedinwordsperminute
        -- ****** Object:  Table [dbo].[Speedinwordsperminute]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Speedinwordsperminute]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Speedinwordsperminute] (
          [SpeedinwordsperminuteId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Speedinwordsperminute] PRIMARY KEY CLUSTERED
          (
            [SpeedinwordsperminuteId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Farnsworthspeed
        -- ****** Object:  Table [dbo].[Farnsworthspeed]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Farnsworthspeed]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Farnsworthspeed] (
          [FarnsworthspeedId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Farnsworthspeed] PRIMARY KEY CLUSTERED
          (
            [FarnsworthspeedId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Display
        -- ****** Object:  Table [dbo].[Display]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Display]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Display] (
          [DisplayId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Display] PRIMARY KEY CLUSTERED
          (
            [DisplayId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Alternativedisplayofcommoncharactersininternationalmorsecode
        -- ****** Object:  Table [dbo].[Alternativedisplayofcommoncharactersininternationalmorsecode]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Alternativedisplayofcommoncharactersininternationalmorsecode]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Alternativedisplayofcommoncharactersininternationalmorsecode] (
          [AlternativedisplayofcommoncharactersininternationalmorsecodeId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Alternativedisplayofcommoncharactersininternationalmorsecode] PRIMARY KEY CLUSTERED
          (
            [AlternativedisplayofcommoncharactersininternationalmorsecodeId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Link
        -- ****** Object:  Table [dbo].[Link]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Link]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Link] (
          [LinkId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Link] PRIMARY KEY CLUSTERED
          (
            [LinkId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Budget
        -- ****** Object:  Table [dbo].[Budget]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Budget]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Budget] (
          [BudgetId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Budget] PRIMARY KEY CLUSTERED
          (
            [BudgetId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Non
        -- ****** Object:  Table [dbo].[Non]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Non]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Non] (
          [NonId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Non] PRIMARY KEY CLUSTERED
          (
            [NonId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Latinextension
        -- ****** Object:  Table [dbo].[Latinextension]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Latinextension]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Latinextension] (
          [LatinextensionId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Latinextension] PRIMARY KEY CLUSTERED
          (
            [LatinextensionId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Software
        -- ****** Object:  Table [dbo].[Software]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Software]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Software] (
          [SoftwareId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Software] PRIMARY KEY CLUSTERED
          (
            [SoftwareId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Decodingsoftware
        -- ****** Object:  Table [dbo].[Decodingsoftware]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Decodingsoftware]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Decodingsoftware] (
          [DecodingsoftwareId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Decodingsoftware] PRIMARY KEY CLUSTERED
          (
            [DecodingsoftwareId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Seealso
        -- ****** Object:  Table [dbo].[Seealso]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Seealso]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Seealso] (
          [SeealsoId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Seealso] PRIMARY KEY CLUSTERED
          (
            [SeealsoId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Bibliography
        -- ****** Object:  Table [dbo].[Bibliography]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Bibliography]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Bibliography] (
          [BibliographyId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Bibliography] PRIMARY KEY CLUSTERED
          (
            [BibliographyId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Enwikipediaorgwikispecialcentralautologinstarttypex
        -- ****** Object:  Table [dbo].[Enwikipediaorgwikispecialcentralautologinstarttypex]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Enwikipediaorgwikispecialcentralautologinstarttypex]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Enwikipediaorgwikispecialcentralautologinstarttypex] (
          [EnwikipediaorgwikispecialcentralautologinstarttypexId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Enwikipediaorgwikispecialcentralautologinstarttypex] PRIMARY KEY CLUSTERED
          (
            [EnwikipediaorgwikispecialcentralautologinstarttypexId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Httpsenwikipediaorgwindexphptitlemorsecodeoldid
        -- ****** Object:  Table [dbo].[Httpsenwikipediaorgwindexphptitlemorsecodeoldid]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Httpsenwikipediaorgwindexphptitlemorsecodeoldid]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Httpsenwikipediaorgwindexphptitlemorsecodeoldid] (
          [HttpsenwikipediaorgwindexphptitlemorsecodeoldidId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Httpsenwikipediaorgwindexphptitlemorsecodeoldid] PRIMARY KEY CLUSTERED
          (
            [HttpsenwikipediaorgwindexphptitlemorsecodeoldidId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Letter
        -- ****** Object:  Table [dbo].[Letter]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Letter]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Letter] (
          [LetterId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Letter] PRIMARY KEY CLUSTERED
          (
            [LetterId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Numeral
        -- ****** Object:  Table [dbo].[Numeral]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Numeral]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Numeral] (
          [NumeralId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Numeral] PRIMARY KEY CLUSTERED
          (
            [NumeralId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Tone
        -- ****** Object:  Table [dbo].[Tone]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tone]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Tone] (
          [ToneId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Tone] PRIMARY KEY CLUSTERED
          (
            [ToneId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Light
        -- ****** Object:  Table [dbo].[Light]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Light]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Light] (
          [LightId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Light] PRIMARY KEY CLUSTERED
          (
            [LightId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Click
        -- ****** Object:  Table [dbo].[Click]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Click]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Click] (
          [ClickId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Click] PRIMARY KEY CLUSTERED
          (
            [ClickId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Signal
        -- ****** Object:  Table [dbo].[Signal]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Signal]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Signal] (
          [SignalId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Signal] PRIMARY KEY CLUSTERED
          (
            [SignalId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Prosign
        -- ****** Object:  Table [dbo].[Prosign]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Prosign]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Prosign] (
          [ProsignId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Prosign] PRIMARY KEY CLUSTERED
          (
            [ProsignId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Sequence
        -- ****** Object:  Table [dbo].[Sequence]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Sequence]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Sequence] (
          [SequenceId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Sequence] PRIMARY KEY CLUSTERED
          (
            [SequenceId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Dot
        -- ****** Object:  Table [dbo].[Dot]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Dot]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Dot] (
          [DotId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Dot] PRIMARY KEY CLUSTERED
          (
            [DotId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Dash
        -- ****** Object:  Table [dbo].[Dash]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Dash]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Dash] (
          [DashId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Dash] PRIMARY KEY CLUSTERED
          (
            [DashId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Language
        -- ****** Object:  Table [dbo].[Language]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Language]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Language] (
          [LanguageId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Language] PRIMARY KEY CLUSTERED
          (
            [LanguageId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Extension
        -- ****** Object:  Table [dbo].[Extension]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Extension]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Extension] (
          [ExtensionId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Extension] PRIMARY KEY CLUSTERED
          (
            [ExtensionId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: TelegraphOperator
        -- ****** Object:  Table [dbo].[TelegraphOperator]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TelegraphOperator]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[TelegraphOperator] (
          [TelegraphOperatorId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_TelegraphOperator] PRIMARY KEY CLUSTERED
          (
            [TelegraphOperatorId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Country
        -- ****** Object:  Table [dbo].[Country]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Country]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Country] (
          [CountryId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED
          (
            [CountryId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Pilot
        -- ****** Object:  Table [dbo].[Pilot]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pilot]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Pilot] (
          [PilotId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Pilot] PRIMARY KEY CLUSTERED
          (
            [PilotId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Controller
        -- ****** Object:  Table [dbo].[Controller]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Controller]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Controller] (
          [ControllerId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Controller] PRIMARY KEY CLUSTERED
          (
            [ControllerId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Aid
        -- ****** Object:  Table [dbo].[Aid]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Aid]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Aid] (
          [AidId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Aid] PRIMARY KEY CLUSTERED
          (
            [AidId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Vor
        -- ****** Object:  Table [dbo].[Vor]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Vor]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Vor] (
          [VorId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Vor] PRIMARY KEY CLUSTERED
          (
            [VorId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Ndb
        -- ****** Object:  Table [dbo].[Ndb]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Ndb]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Ndb] (
          [NdbId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Ndb] PRIMARY KEY CLUSTERED
          (
            [NdbId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Condition
        -- ****** Object:  Table [dbo].[Condition]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Condition]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Condition] (
          [ConditionId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Condition] PRIMARY KEY CLUSTERED
          (
            [ConditionId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Human
        -- ****** Object:  Table [dbo].[Human]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Human]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Human] (
          [HumanId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Human] PRIMARY KEY CLUSTERED
          (
            [HumanId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Datum
        -- ****** Object:  Table [dbo].[Datum]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Datum]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Datum] (
          [DatumId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Datum] PRIMARY KEY CLUSTERED
          (
            [DatumId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Channel
        -- ****** Object:  Table [dbo].[Channel]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Channel]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Channel] (
          [ChannelId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Channel] PRIMARY KEY CLUSTERED
          (
            [ChannelId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Repeater
        -- ****** Object:  Table [dbo].[Repeater]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Repeater]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Repeater] (
          [RepeaterId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Repeater] PRIMARY KEY CLUSTERED
          (
            [RepeaterId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Content
        -- ****** Object:  Table [dbo].[Content]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Content]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Content] (
          [ContentId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Content] PRIMARY KEY CLUSTERED
          (
            [ContentId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Us
        -- ****** Object:  Table [dbo].[Us]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Us]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Us] (
          [UsId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Us] PRIMARY KEY CLUSTERED
          (
            [UsId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Otheru
        -- ****** Object:  Table [dbo].[Otheru]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Otheru]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Otheru] (
          [OtheruId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Otheru] PRIMARY KEY CLUSTERED
          (
            [OtheruId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Application
        -- ****** Object:  Table [dbo].[Application]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Application]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Application] (
          [ApplicationId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Application] PRIMARY KEY CLUSTERED
          (
            [ApplicationId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Andspeed
        -- ****** Object:  Table [dbo].[Andspeed]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Andspeed]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Andspeed] (
          [AndspeedId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Andspeed] PRIMARY KEY CLUSTERED
          (
            [AndspeedId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Issue
        -- ****** Object:  Table [dbo].[Issue]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Issue]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Issue] (
          [IssueId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Issue] PRIMARY KEY CLUSTERED
          (
            [IssueId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Linkbudgetissue
        -- ****** Object:  Table [dbo].[Linkbudgetissue]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Linkbudgetissue]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Linkbudgetissue] (
          [LinkbudgetissueId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Linkbudgetissue] PRIMARY KEY CLUSTERED
          (
            [LinkbudgetissueId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Learningmethod
        -- ****** Object:  Table [dbo].[Learningmethod]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Learningmethod]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Learningmethod] (
          [LearningmethodId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Learningmethod] PRIMARY KEY CLUSTERED
          (
            [LearningmethodId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Number
        -- ****** Object:  Table [dbo].[Number]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Number]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Number] (
          [NumberId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Number] PRIMARY KEY CLUSTERED
          (
            [NumberId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Variant
        -- ****** Object:  Table [dbo].[Variant]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Variant]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Variant] (
          [VariantId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Variant] PRIMARY KEY CLUSTERED
          (
            [VariantId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Prosignsformorsecodeandnonenglishvariant
        -- ****** Object:  Table [dbo].[Prosignsformorsecodeandnonenglishvariant]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Prosignsformorsecodeandnonenglishvariant]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Prosignsformorsecodeandnonenglishvariant] (
          [ProsignsformorsecodeandnonenglishvariantId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Prosignsformorsecodeandnonenglishvariant] PRIMARY KEY CLUSTERED
          (
            [ProsignsformorsecodeandnonenglishvariantId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Symbolrepresentation
        -- ****** Object:  Table [dbo].[Symbolrepresentation]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Symbolrepresentation]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Symbolrepresentation] (
          [SymbolrepresentationId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Symbolrepresentation] PRIMARY KEY CLUSTERED
          (
            [SymbolrepresentationId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Unusualvariant
        -- ****** Object:  Table [dbo].[Unusualvariant]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Unusualvariant]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Unusualvariant] (
          [UnusualvariantId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Unusualvariant] PRIMARY KEY CLUSTERED
          (
            [UnusualvariantId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Reference
        -- ****** Object:  Table [dbo].[Reference]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Reference]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Reference] (
          [ReferenceId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Reference] PRIMARY KEY CLUSTERED
          (
            [ReferenceId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO

        -- TABLE: Externallink
        -- ****** Object:  Table [dbo].[Externallink]   Script Date:  ******
        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Externallink]') AND type in (N'U')) 
        BEGIN
        CREATE TABLE [dbo].[Externallink] (
          [ExternallinkId] UNIQUEIDENTIFIER NOT NULL,
          [Name] NVARCHAR(100) NOT NULL,
          [Description] NVARCHAR(100) NOT NULL,
        
        CONSTRAINT [PK_Externallink] PRIMARY KEY CLUSTERED
          (
            [ExternallinkId] ASC
          )
        
        ) ON [PRIMARY]
        END
        GO


              -- ****** KEYS FOR Table [dbo].[Wikipedia]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Wikipedia_WikipediaId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Wikipedia] ADD  CONSTRAINT [DF_Wikipedia_WikipediaId]  DEFAULT (newid()) FOR [WikipediaId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Morse]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Morse_MorseId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Morse] ADD  CONSTRAINT [DF_Morse_MorseId]  DEFAULT (newid()) FOR [MorseId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Samuel]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Samuel_SamuelId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Samuel] ADD  CONSTRAINT [DF_Samuel_SamuelId]  DEFAULT (newid()) FOR [SamuelId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Samuelfbmorse]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Samuelfbmorse_SamuelfbmorseId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Samuelfbmorse] ADD  CONSTRAINT [DF_Samuelfbmorse_SamuelfbmorseId]  DEFAULT (newid()) FOR [SamuelfbmorseId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[International]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_International_InternationalId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[International] ADD  CONSTRAINT [DF_International_InternationalId]  DEFAULT (newid()) FOR [InternationalId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Roman]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Roman_RomanId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Roman] ADD  CONSTRAINT [DF_Roman_RomanId]  DEFAULT (newid()) FOR [RomanId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[English]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_English_EnglishId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[English] ADD  CONSTRAINT [DF_English_EnglishId]  DEFAULT (newid()) FOR [EnglishId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Aeronautical]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Aeronautical_AeronauticalId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Aeronautical] ADD  CONSTRAINT [DF_Aeronautical_AeronauticalId]  DEFAULT (newid()) FOR [AeronauticalId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Aviation]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Aviation_AviationId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Aviation] ADD  CONSTRAINT [DF_Aviation_AviationId]  DEFAULT (newid()) FOR [AviationId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Cable]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Cable_CableId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Cable] ADD  CONSTRAINT [DF_Cable_CableId]  DEFAULT (newid()) FOR [CableId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Farnsworth]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Farnsworth_FarnsworthId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Farnsworth] ADD  CONSTRAINT [DF_Farnsworth_FarnsworthId]  DEFAULT (newid()) FOR [FarnsworthId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Learning]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Learning_LearningId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Learning] ADD  CONSTRAINT [DF_Learning_LearningId]  DEFAULT (newid()) FOR [LearningId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Mnemonic]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Mnemonic_MnemonicId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Mnemonic] ADD  CONSTRAINT [DF_Mnemonic_MnemonicId]  DEFAULT (newid()) FOR [MnemonicId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Encyclopedia]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Encyclopedia_EncyclopediaId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Encyclopedia] ADD  CONSTRAINT [DF_Encyclopedia_EncyclopediaId]  DEFAULT (newid()) FOR [EncyclopediaId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Jump]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Jump_JumpId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Jump] ADD  CONSTRAINT [DF_Jump_JumpId]  DEFAULT (newid()) FOR [JumpId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Navigation]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Navigation_NavigationId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Navigation] ADD  CONSTRAINT [DF_Navigation_NavigationId]  DEFAULT (newid()) FOR [NavigationId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Head]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Head_HeadId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Head] ADD  CONSTRAINT [DF_Head_HeadId]  DEFAULT (newid()) FOR [HeadId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Search]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Search_SearchId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Search] ADD  CONSTRAINT [DF_Search_SearchId]  DEFAULT (newid()) FOR [SearchId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng_UploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng] ADD  CONSTRAINT [DF_Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng_UploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngId]  DEFAULT (newid()) FOR [UploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Fileinternationalmorsecodesvg]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Fileinternationalmorsecodesvg_FileinternationalmorsecodesvgId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Fileinternationalmorsecodesvg] ADD  CONSTRAINT [DF_Fileinternationalmorsecodesvg_FileinternationalmorsecodesvgId]  DEFAULT (newid()) FOR [FileinternationalmorsecodesvgId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Chart]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Chart_ChartId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Chart] ADD  CONSTRAINT [DF_Chart_ChartId]  DEFAULT (newid()) FOR [ChartId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Code]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Code_CodeId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Code] ADD  CONSTRAINT [DF_Code_CodeId]  DEFAULT (newid()) FOR [CodeId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Itur]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Itur_IturId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Itur] ADD  CONSTRAINT [DF_Itur_IturId]  DEFAULT (newid()) FOR [IturId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Method]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Method_MethodId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Method] ADD  CONSTRAINT [DF_Method_MethodId]  DEFAULT (newid()) FOR [MethodId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Text]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Text_TextId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Text] ADD  CONSTRAINT [DF_Text_TextId]  DEFAULT (newid()) FOR [TextId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Writtenlanguage]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Writtenlanguage_WrittenlanguageId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Writtenlanguage] ADD  CONSTRAINT [DF_Writtenlanguage_WrittenlanguageId]  DEFAULT (newid()) FOR [WrittenlanguageId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Information]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Information_InformationId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Information] ADD  CONSTRAINT [DF_Information_InformationId]  DEFAULT (newid()) FOR [InformationId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Series]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Series_SeriesId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Series] ADD  CONSTRAINT [DF_Series_SeriesId]  DEFAULT (newid()) FOR [SeriesId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Listener]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Listener_ListenerId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Listener] ADD  CONSTRAINT [DF_Listener_ListenerId]  DEFAULT (newid()) FOR [ListenerId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Observer]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Observer_ObserverId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Observer] ADD  CONSTRAINT [DF_Observer_ObserverId]  DEFAULT (newid()) FOR [ObserverId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Equipment]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Equipment_EquipmentId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Equipment] ADD  CONSTRAINT [DF_Equipment_EquipmentId]  DEFAULT (newid()) FOR [EquipmentId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Inventor]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Inventor_InventorId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Inventor] ADD  CONSTRAINT [DF_Inventor_InventorId]  DEFAULT (newid()) FOR [InventorId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Telegraph]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Telegraph_TelegraphId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Telegraph] ADD  CONSTRAINT [DF_Telegraph_TelegraphId]  DEFAULT (newid()) FOR [TelegraphId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Iso]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Iso_IsoId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Iso] ADD  CONSTRAINT [DF_Iso_IsoId]  DEFAULT (newid()) FOR [IsoId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Alphabet]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Alphabet_AlphabetId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Alphabet] ADD  CONSTRAINT [DF_Alphabet_AlphabetId]  DEFAULT (newid()) FOR [AlphabetId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Isobasiclatinalphabet]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Isobasiclatinalphabet_IsobasiclatinalphabetId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Isobasiclatinalphabet] ADD  CONSTRAINT [DF_Isobasiclatinalphabet_IsobasiclatinalphabetId]  DEFAULT (newid()) FOR [IsobasiclatinalphabetId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Arabicnumeral]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Arabicnumeral_ArabicnumeralId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Arabicnumeral] ADD  CONSTRAINT [DF_Arabicnumeral_ArabicnumeralId]  DEFAULT (newid()) FOR [ArabicnumeralId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Set]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Set_SetId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Set] ADD  CONSTRAINT [DF_Set_SetId]  DEFAULT (newid()) FOR [SetId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Punctuation]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Punctuation_PunctuationId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Punctuation] ADD  CONSTRAINT [DF_Punctuation_PunctuationId]  DEFAULT (newid()) FOR [PunctuationId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Prosignsformorsecode]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Prosignsformorsecode_ProsignsformorsecodeId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Prosignsformorsecode] ADD  CONSTRAINT [DF_Prosignsformorsecode_ProsignsformorsecodeId]  DEFAULT (newid()) FOR [ProsignsformorsecodeId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Radio]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Radio_RadioId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Radio] ADD  CONSTRAINT [DF_Radio_RadioId]  DEFAULT (newid()) FOR [RadioId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Amateurradio]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Amateurradio_AmateurradioId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Amateurradio] ADD  CONSTRAINT [DF_Amateurradio_AmateurradioId]  DEFAULT (newid()) FOR [AmateurradioId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Practice]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Practice_PracticeId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Practice] ADD  CONSTRAINT [DF_Practice_PracticeId]  DEFAULT (newid()) FOR [PracticeId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Symbol]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Symbol_SymbolId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Symbol] ADD  CONSTRAINT [DF_Symbol_SymbolId]  DEFAULT (newid()) FOR [SymbolId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Character]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Character_CharacterId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Character] ADD  CONSTRAINT [DF_Character_CharacterId]  DEFAULT (newid()) FOR [CharacterId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Duration]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Duration_DurationId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Duration] ADD  CONSTRAINT [DF_Duration_DurationId]  DEFAULT (newid()) FOR [DurationId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Unit]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Unit_UnitId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Unit] ADD  CONSTRAINT [DF_Unit_UnitId]  DEFAULT (newid()) FOR [UnitId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Time]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Time_TimeId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Time] ADD  CONSTRAINT [DF_Time_TimeId]  DEFAULT (newid()) FOR [TimeId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Measurement]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Measurement_MeasurementId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Measurement] ADD  CONSTRAINT [DF_Measurement_MeasurementId]  DEFAULT (newid()) FOR [MeasurementId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Transmission]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Transmission_TransmissionId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Transmission] ADD  CONSTRAINT [DF_Transmission_TransmissionId]  DEFAULT (newid()) FOR [TransmissionId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Silence]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Silence_SilenceId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Silence] ADD  CONSTRAINT [DF_Silence_SilenceId]  DEFAULT (newid()) FOR [SilenceId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Word]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Word_WordId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Word] ADD  CONSTRAINT [DF_Word_WordId]  DEFAULT (newid()) FOR [WordId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Delimiter]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Delimiter_DelimiterId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Delimiter] ADD  CONSTRAINT [DF_Delimiter_DelimiterId]  DEFAULT (newid()) FOR [DelimiterId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Space]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Space_SpaceId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Space] ADD  CONSTRAINT [DF_Space_SpaceId]  DEFAULT (newid()) FOR [SpaceId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Speed]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Speed_SpeedId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Speed] ADD  CONSTRAINT [DF_Speed_SpeedId]  DEFAULT (newid()) FOR [SpeedId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Communication]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Communication_CommunicationId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Communication] ADD  CONSTRAINT [DF_Communication_CommunicationId]  DEFAULT (newid()) FOR [CommunicationId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Length]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Length_LengthId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Length] ADD  CONSTRAINT [DF_Length_LengthId]  DEFAULT (newid()) FOR [LengthId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Frequency]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Frequency_FrequencyId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Frequency] ADD  CONSTRAINT [DF_Frequency_FrequencyId]  DEFAULT (newid()) FOR [FrequencyId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Occurrence]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Occurrence_OccurrenceId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Occurrence] ADD  CONSTRAINT [DF_Occurrence_OccurrenceId]  DEFAULT (newid()) FOR [OccurrenceId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Entropyencoding]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Entropyencoding_EntropyencodingId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Entropyencoding] ADD  CONSTRAINT [DF_Entropyencoding_EntropyencodingId]  DEFAULT (newid()) FOR [EntropyencodingId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Amateurradiooperator]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Amateurradiooperator_AmateurradiooperatorId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Amateurradiooperator] ADD  CONSTRAINT [DF_Amateurradiooperator_AmateurradiooperatorId]  DEFAULT (newid()) FOR [AmateurradiooperatorId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Knowledge]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Knowledge_KnowledgeId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Knowledge] ADD  CONSTRAINT [DF_Knowledge_KnowledgeId]  DEFAULT (newid()) FOR [KnowledgeId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Proficiency]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Proficiency_ProficiencyId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Proficiency] ADD  CONSTRAINT [DF_Proficiency_ProficiencyId]  DEFAULT (newid()) FOR [ProficiencyId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Licensing]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Licensing_LicensingId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Licensing] ADD  CONSTRAINT [DF_Licensing_LicensingId]  DEFAULT (newid()) FOR [LicensingId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Amateurradiolicense]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Amateurradiolicense_AmateurradiolicenseId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Amateurradiolicense] ADD  CONSTRAINT [DF_Amateurradiolicense_AmateurradiolicenseId]  DEFAULT (newid()) FOR [AmateurradiolicenseId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Aviator]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Aviator_AviatorId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Aviator] ADD  CONSTRAINT [DF_Aviator_AviatorId]  DEFAULT (newid()) FOR [AviatorId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Air]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Air_AirId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Air] ADD  CONSTRAINT [DF_Air_AirId]  DEFAULT (newid()) FOR [AirId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Traffic]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Traffic_TrafficId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Traffic] ADD  CONSTRAINT [DF_Traffic_TrafficId]  DEFAULT (newid()) FOR [TrafficId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Airtrafficcontroller]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Airtrafficcontroller_AirtrafficcontrollerId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Airtrafficcontroller] ADD  CONSTRAINT [DF_Airtrafficcontroller_AirtrafficcontrollerId]  DEFAULT (newid()) FOR [AirtrafficcontrollerId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Understanding]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Understanding_UnderstandingId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Understanding] ADD  CONSTRAINT [DF_Understanding_UnderstandingId]  DEFAULT (newid()) FOR [UnderstandingId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Navigationalaid]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Navigationalaid_NavigationalaidId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Navigationalaid] ADD  CONSTRAINT [DF_Navigationalaid_NavigationalaidId]  DEFAULT (newid()) FOR [NavigationalaidId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Vhfomnidirectionalrange]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Vhfomnidirectionalrange_VhfomnidirectionalrangeId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Vhfomnidirectionalrange] ADD  CONSTRAINT [DF_Vhfomnidirectionalrange_VhfomnidirectionalrangeId]  DEFAULT (newid()) FOR [VhfomnidirectionalrangeId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Nondirectionalbeacon]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Nondirectionalbeacon_NondirectionalbeaconId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Nondirectionalbeacon] ADD  CONSTRAINT [DF_Nondirectionalbeacon_NondirectionalbeaconId]  DEFAULT (newid()) FOR [NondirectionalbeaconId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Voice]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Voice_VoiceId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Voice] ADD  CONSTRAINT [DF_Voice_VoiceId]  DEFAULT (newid()) FOR [VoiceId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Decoding]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Decoding_DecodingId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Decoding] ADD  CONSTRAINT [DF_Decoding_DecodingId]  DEFAULT (newid()) FOR [DecodingId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Device]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Device_DeviceId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Device] ADD  CONSTRAINT [DF_Device_DeviceId]  DEFAULT (newid()) FOR [DeviceId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Alternative]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Alternative_AlternativeId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Alternative] ADD  CONSTRAINT [DF_Alternative_AlternativeId]  DEFAULT (newid()) FOR [AlternativeId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Speech]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Speech_SpeechId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Speech] ADD  CONSTRAINT [DF_Speech_SpeechId]  DEFAULT (newid()) FOR [SpeechId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Amateurradiorepeater]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Amateurradiorepeater_AmateurradiorepeaterId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Amateurradiorepeater] ADD  CONSTRAINT [DF_Amateurradiorepeater_AmateurradiorepeaterId]  DEFAULT (newid()) FOR [AmateurradiorepeaterId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Example]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Example_ExampleId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Example] ADD  CONSTRAINT [DF_Example_ExampleId]  DEFAULT (newid()) FOR [ExampleId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng_UploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng] ADD  CONSTRAINT [DF_Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng_UploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngId]  DEFAULT (newid()) FOR [UploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Filesossvg]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Filesossvg_FilesossvgId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Filesossvg] ADD  CONSTRAINT [DF_Filesossvg_FilesossvgId]  DEFAULT (newid()) FOR [FilesossvgId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Emergency]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Emergency_EmergencyId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Emergency] ADD  CONSTRAINT [DF_Emergency_EmergencyId]  DEFAULT (newid()) FOR [EmergencyId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Telecommunication]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Telecommunication_TelecommunicationId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Telecommunication] ADD  CONSTRAINT [DF_Telecommunication_TelecommunicationId]  DEFAULT (newid()) FOR [TelecommunicationId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Distress]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Distress_DistressId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Distress] ADD  CONSTRAINT [DF_Distress_DistressId]  DEFAULT (newid()) FOR [DistressId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Treaty]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Treaty_TreatyId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Treaty] ADD  CONSTRAINT [DF_Treaty_TreatyId]  DEFAULT (newid()) FOR [TreatyId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Development]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Development_DevelopmentId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Development] ADD  CONSTRAINT [DF_Development_DevelopmentId]  DEFAULT (newid()) FOR [DevelopmentId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[History]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_History_HistoryId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[History] ADD  CONSTRAINT [DF_History_HistoryId]  DEFAULT (newid()) FOR [HistoryId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Developmentandhistory]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Developmentandhistory_DevelopmentandhistoryId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Developmentandhistory] ADD  CONSTRAINT [DF_Developmentandhistory_DevelopmentandhistoryId]  DEFAULT (newid()) FOR [DevelopmentandhistoryId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[User]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_User_UserId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_UserId]  DEFAULT (newid()) FOR [UserId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Userproficiency]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Userproficiency_UserproficiencyId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Userproficiency] ADD  CONSTRAINT [DF_Userproficiency_UserproficiencyId]  DEFAULT (newid()) FOR [UserproficiencyId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Internationalmorsecode]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Internationalmorsecode_InternationalmorsecodeId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Internationalmorsecode] ADD  CONSTRAINT [DF_Internationalmorsecode_InternationalmorsecodeId]  DEFAULT (newid()) FOR [InternationalmorsecodeId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Technology]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Technology_TechnologyId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Technology] ADD  CONSTRAINT [DF_Technology_TechnologyId]  DEFAULT (newid()) FOR [TechnologyId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Morsecodeasanassistivetechnology]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Morsecodeasanassistivetechnology_MorsecodeasanassistivetechnologyId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Morsecodeasanassistivetechnology] ADD  CONSTRAINT [DF_Morsecodeasanassistivetechnology_MorsecodeasanassistivetechnologyId]  DEFAULT (newid()) FOR [MorsecodeasanassistivetechnologyId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Representation]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Representation_RepresentationId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Representation] ADD  CONSTRAINT [DF_Representation_RepresentationId]  DEFAULT (newid()) FOR [RepresentationId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Timing]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Timing_TimingId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Timing] ADD  CONSTRAINT [DF_Timing_TimingId]  DEFAULT (newid()) FOR [TimingId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Cablecode]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Cablecode_CablecodeId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Cablecode] ADD  CONSTRAINT [DF_Cablecode_CablecodeId]  DEFAULT (newid()) FOR [CablecodeId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Spokenrepresentation]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Spokenrepresentation_SpokenrepresentationId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Spokenrepresentation] ADD  CONSTRAINT [DF_Spokenrepresentation_SpokenrepresentationId]  DEFAULT (newid()) FOR [SpokenrepresentationId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Minute]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Minute_MinuteId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Minute] ADD  CONSTRAINT [DF_Minute_MinuteId]  DEFAULT (newid()) FOR [MinuteId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Speedinwordsperminute]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Speedinwordsperminute_SpeedinwordsperminuteId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Speedinwordsperminute] ADD  CONSTRAINT [DF_Speedinwordsperminute_SpeedinwordsperminuteId]  DEFAULT (newid()) FOR [SpeedinwordsperminuteId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Farnsworthspeed]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Farnsworthspeed_FarnsworthspeedId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Farnsworthspeed] ADD  CONSTRAINT [DF_Farnsworthspeed_FarnsworthspeedId]  DEFAULT (newid()) FOR [FarnsworthspeedId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Display]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Display_DisplayId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Display] ADD  CONSTRAINT [DF_Display_DisplayId]  DEFAULT (newid()) FOR [DisplayId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Alternativedisplayofcommoncharactersininternationalmorsecode]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Alternativedisplayofcommoncharactersininternationalmorsecode_AlternativedisplayofcommoncharactersininternationalmorsecodeId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Alternativedisplayofcommoncharactersininternationalmorsecode] ADD  CONSTRAINT [DF_Alternativedisplayofcommoncharactersininternationalmorsecode_AlternativedisplayofcommoncharactersininternationalmorsecodeId]  DEFAULT (newid()) FOR [AlternativedisplayofcommoncharactersininternationalmorsecodeId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Link]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Link_LinkId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Link] ADD  CONSTRAINT [DF_Link_LinkId]  DEFAULT (newid()) FOR [LinkId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Budget]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Budget_BudgetId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Budget] ADD  CONSTRAINT [DF_Budget_BudgetId]  DEFAULT (newid()) FOR [BudgetId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Non]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Non_NonId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Non] ADD  CONSTRAINT [DF_Non_NonId]  DEFAULT (newid()) FOR [NonId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Latinextension]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Latinextension_LatinextensionId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Latinextension] ADD  CONSTRAINT [DF_Latinextension_LatinextensionId]  DEFAULT (newid()) FOR [LatinextensionId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Software]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Software_SoftwareId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Software] ADD  CONSTRAINT [DF_Software_SoftwareId]  DEFAULT (newid()) FOR [SoftwareId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Decodingsoftware]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Decodingsoftware_DecodingsoftwareId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Decodingsoftware] ADD  CONSTRAINT [DF_Decodingsoftware_DecodingsoftwareId]  DEFAULT (newid()) FOR [DecodingsoftwareId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Seealso]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Seealso_SeealsoId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Seealso] ADD  CONSTRAINT [DF_Seealso_SeealsoId]  DEFAULT (newid()) FOR [SeealsoId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Bibliography]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Bibliography_BibliographyId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Bibliography] ADD  CONSTRAINT [DF_Bibliography_BibliographyId]  DEFAULT (newid()) FOR [BibliographyId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Enwikipediaorgwikispecialcentralautologinstarttypex]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Enwikipediaorgwikispecialcentralautologinstarttypex_EnwikipediaorgwikispecialcentralautologinstarttypexId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Enwikipediaorgwikispecialcentralautologinstarttypex] ADD  CONSTRAINT [DF_Enwikipediaorgwikispecialcentralautologinstarttypex_EnwikipediaorgwikispecialcentralautologinstarttypexId]  DEFAULT (newid()) FOR [EnwikipediaorgwikispecialcentralautologinstarttypexId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Httpsenwikipediaorgwindexphptitlemorsecodeoldid]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Httpsenwikipediaorgwindexphptitlemorsecodeoldid_HttpsenwikipediaorgwindexphptitlemorsecodeoldidId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Httpsenwikipediaorgwindexphptitlemorsecodeoldid] ADD  CONSTRAINT [DF_Httpsenwikipediaorgwindexphptitlemorsecodeoldid_HttpsenwikipediaorgwindexphptitlemorsecodeoldidId]  DEFAULT (newid()) FOR [HttpsenwikipediaorgwindexphptitlemorsecodeoldidId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Letter]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Letter_LetterId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Letter] ADD  CONSTRAINT [DF_Letter_LetterId]  DEFAULT (newid()) FOR [LetterId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Numeral]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Numeral_NumeralId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Numeral] ADD  CONSTRAINT [DF_Numeral_NumeralId]  DEFAULT (newid()) FOR [NumeralId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Tone]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Tone_ToneId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Tone] ADD  CONSTRAINT [DF_Tone_ToneId]  DEFAULT (newid()) FOR [ToneId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Light]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Light_LightId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Light] ADD  CONSTRAINT [DF_Light_LightId]  DEFAULT (newid()) FOR [LightId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Click]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Click_ClickId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Click] ADD  CONSTRAINT [DF_Click_ClickId]  DEFAULT (newid()) FOR [ClickId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Signal]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Signal_SignalId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Signal] ADD  CONSTRAINT [DF_Signal_SignalId]  DEFAULT (newid()) FOR [SignalId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Prosign]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Prosign_ProsignId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Prosign] ADD  CONSTRAINT [DF_Prosign_ProsignId]  DEFAULT (newid()) FOR [ProsignId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Sequence]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Sequence_SequenceId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Sequence] ADD  CONSTRAINT [DF_Sequence_SequenceId]  DEFAULT (newid()) FOR [SequenceId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Dot]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Dot_DotId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Dot] ADD  CONSTRAINT [DF_Dot_DotId]  DEFAULT (newid()) FOR [DotId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Dash]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Dash_DashId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Dash] ADD  CONSTRAINT [DF_Dash_DashId]  DEFAULT (newid()) FOR [DashId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Language]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Language_LanguageId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Language] ADD  CONSTRAINT [DF_Language_LanguageId]  DEFAULT (newid()) FOR [LanguageId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Extension]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Extension_ExtensionId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Extension] ADD  CONSTRAINT [DF_Extension_ExtensionId]  DEFAULT (newid()) FOR [ExtensionId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[TelegraphOperator]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_TelegraphOperator_TelegraphOperatorId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[TelegraphOperator] ADD  CONSTRAINT [DF_TelegraphOperator_TelegraphOperatorId]  DEFAULT (newid()) FOR [TelegraphOperatorId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Country]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Country_CountryId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Country] ADD  CONSTRAINT [DF_Country_CountryId]  DEFAULT (newid()) FOR [CountryId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Pilot]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Pilot_PilotId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Pilot] ADD  CONSTRAINT [DF_Pilot_PilotId]  DEFAULT (newid()) FOR [PilotId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Controller]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Controller_ControllerId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Controller] ADD  CONSTRAINT [DF_Controller_ControllerId]  DEFAULT (newid()) FOR [ControllerId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Aid]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Aid_AidId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Aid] ADD  CONSTRAINT [DF_Aid_AidId]  DEFAULT (newid()) FOR [AidId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Vor]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Vor_VorId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Vor] ADD  CONSTRAINT [DF_Vor_VorId]  DEFAULT (newid()) FOR [VorId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Ndb]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Ndb_NdbId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Ndb] ADD  CONSTRAINT [DF_Ndb_NdbId]  DEFAULT (newid()) FOR [NdbId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Condition]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Condition_ConditionId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Condition] ADD  CONSTRAINT [DF_Condition_ConditionId]  DEFAULT (newid()) FOR [ConditionId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Human]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Human_HumanId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Human] ADD  CONSTRAINT [DF_Human_HumanId]  DEFAULT (newid()) FOR [HumanId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Datum]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Datum_DatumId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Datum] ADD  CONSTRAINT [DF_Datum_DatumId]  DEFAULT (newid()) FOR [DatumId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Channel]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Channel_ChannelId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Channel] ADD  CONSTRAINT [DF_Channel_ChannelId]  DEFAULT (newid()) FOR [ChannelId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Repeater]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Repeater_RepeaterId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Repeater] ADD  CONSTRAINT [DF_Repeater_RepeaterId]  DEFAULT (newid()) FOR [RepeaterId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Content]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Content_ContentId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Content] ADD  CONSTRAINT [DF_Content_ContentId]  DEFAULT (newid()) FOR [ContentId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Us]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Us_UsId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Us] ADD  CONSTRAINT [DF_Us_UsId]  DEFAULT (newid()) FOR [UsId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Otheru]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Otheru_OtheruId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Otheru] ADD  CONSTRAINT [DF_Otheru_OtheruId]  DEFAULT (newid()) FOR [OtheruId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Application]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Application_ApplicationId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Application] ADD  CONSTRAINT [DF_Application_ApplicationId]  DEFAULT (newid()) FOR [ApplicationId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Andspeed]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Andspeed_AndspeedId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Andspeed] ADD  CONSTRAINT [DF_Andspeed_AndspeedId]  DEFAULT (newid()) FOR [AndspeedId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Issue]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Issue_IssueId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Issue] ADD  CONSTRAINT [DF_Issue_IssueId]  DEFAULT (newid()) FOR [IssueId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Linkbudgetissue]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Linkbudgetissue_LinkbudgetissueId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Linkbudgetissue] ADD  CONSTRAINT [DF_Linkbudgetissue_LinkbudgetissueId]  DEFAULT (newid()) FOR [LinkbudgetissueId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Learningmethod]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Learningmethod_LearningmethodId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Learningmethod] ADD  CONSTRAINT [DF_Learningmethod_LearningmethodId]  DEFAULT (newid()) FOR [LearningmethodId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Number]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Number_NumberId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Number] ADD  CONSTRAINT [DF_Number_NumberId]  DEFAULT (newid()) FOR [NumberId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Variant]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Variant_VariantId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Variant] ADD  CONSTRAINT [DF_Variant_VariantId]  DEFAULT (newid()) FOR [VariantId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Prosignsformorsecodeandnonenglishvariant]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Prosignsformorsecodeandnonenglishvariant_ProsignsformorsecodeandnonenglishvariantId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Prosignsformorsecodeandnonenglishvariant] ADD  CONSTRAINT [DF_Prosignsformorsecodeandnonenglishvariant_ProsignsformorsecodeandnonenglishvariantId]  DEFAULT (newid()) FOR [ProsignsformorsecodeandnonenglishvariantId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Symbolrepresentation]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Symbolrepresentation_SymbolrepresentationId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Symbolrepresentation] ADD  CONSTRAINT [DF_Symbolrepresentation_SymbolrepresentationId]  DEFAULT (newid()) FOR [SymbolrepresentationId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Unusualvariant]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Unusualvariant_UnusualvariantId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Unusualvariant] ADD  CONSTRAINT [DF_Unusualvariant_UnusualvariantId]  DEFAULT (newid()) FOR [UnusualvariantId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Reference]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Reference_ReferenceId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Reference] ADD  CONSTRAINT [DF_Reference_ReferenceId]  DEFAULT (newid()) FOR [ReferenceId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Externallink]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Externallink_ExternallinkId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Externallink] ADD  CONSTRAINT [DF_Externallink_ExternallinkId]  DEFAULT (newid()) FOR [ExternallinkId]
          END
          GO
        


            SELECT 'Successful' as Value
            FROM (SELECT NULL AS FIELD) as Result
            FOR XML AUTO

          