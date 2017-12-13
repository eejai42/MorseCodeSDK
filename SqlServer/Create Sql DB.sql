
    SET ANSI_NULLS ON
    GO

    SET QUOTED_IDENTIFIER ON
    GO
    
    
      -- TABLE: Cable
      -- TABLE: Mnemonic
      -- TABLE: Chart
      -- TABLE: Code
      -- TABLE: Listener
      -- TABLE: Observer
      -- TABLE: Equipment
      -- TABLE: Inventor
      -- TABLE: Telegraph
      -- TABLE: Alphabet
      -- TABLE: Punctuation
      -- TABLE: Radio
      -- TABLE: Character
      -- TABLE: Duration
      -- TABLE: Unit
      -- TABLE: Transmission
      -- TABLE: Word
      -- TABLE: Delimiter
      -- TABLE: Space
      -- TABLE: Speed
      -- TABLE: Occurrence
      -- TABLE: Decoding
      -- TABLE: Device
      -- TABLE: Alternative
      -- TABLE: Speech
      -- TABLE: Example
      -- TABLE: Emergency
      -- TABLE: Telecommunication
      -- TABLE: User
      -- TABLE: Technology
      -- TABLE: Timing
      -- TABLE: Cablecode
      -- TABLE: Display
      -- TABLE: Tone
      -- TABLE: Light
      -- TABLE: Click
      -- TABLE: Signal
      -- TABLE: Sequence
      -- TABLE: TelegraphOperator
      -- TABLE: Country
      -- TABLE: Content
      -- TABLE: Variant
      /*
      -- CREATE DATABASE
      IF NOT EXISTS (SELECT * from sys.databases WHERE name = 'MorseCodeSDK')
      BEGIN
          CREATE DATABASE [MorseCodeSDK];
      END
        GO
        
     USE [MorseCodeSDK];
     */
      
      
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


              -- ****** KEYS FOR Table [dbo].[Cable]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Cable_CableId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Cable] ADD  CONSTRAINT [DF_Cable_CableId]  DEFAULT (newid()) FOR [CableId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Mnemonic]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Mnemonic_MnemonicId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Mnemonic] ADD  CONSTRAINT [DF_Mnemonic_MnemonicId]  DEFAULT (newid()) FOR [MnemonicId]
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
        

              -- ****** KEYS FOR Table [dbo].[Alphabet]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Alphabet_AlphabetId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Alphabet] ADD  CONSTRAINT [DF_Alphabet_AlphabetId]  DEFAULT (newid()) FOR [AlphabetId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Punctuation]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Punctuation_PunctuationId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Punctuation] ADD  CONSTRAINT [DF_Punctuation_PunctuationId]  DEFAULT (newid()) FOR [PunctuationId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Radio]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Radio_RadioId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Radio] ADD  CONSTRAINT [DF_Radio_RadioId]  DEFAULT (newid()) FOR [RadioId]
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
        

              -- ****** KEYS FOR Table [dbo].[Transmission]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Transmission_TransmissionId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Transmission] ADD  CONSTRAINT [DF_Transmission_TransmissionId]  DEFAULT (newid()) FOR [TransmissionId]
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
        

              -- ****** KEYS FOR Table [dbo].[Occurrence]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Occurrence_OccurrenceId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Occurrence] ADD  CONSTRAINT [DF_Occurrence_OccurrenceId]  DEFAULT (newid()) FOR [OccurrenceId]
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
        

              -- ****** KEYS FOR Table [dbo].[Example]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Example_ExampleId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Example] ADD  CONSTRAINT [DF_Example_ExampleId]  DEFAULT (newid()) FOR [ExampleId]
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
        

              -- ****** KEYS FOR Table [dbo].[User]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_User_UserId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_UserId]  DEFAULT (newid()) FOR [UserId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Technology]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Technology_TechnologyId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Technology] ADD  CONSTRAINT [DF_Technology_TechnologyId]  DEFAULT (newid()) FOR [TechnologyId]
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
        

              -- ****** KEYS FOR Table [dbo].[Display]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Display_DisplayId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Display] ADD  CONSTRAINT [DF_Display_DisplayId]  DEFAULT (newid()) FOR [DisplayId]
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
        

              -- ****** KEYS FOR Table [dbo].[Sequence]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Sequence_SequenceId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Sequence] ADD  CONSTRAINT [DF_Sequence_SequenceId]  DEFAULT (newid()) FOR [SequenceId]
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
        

              -- ****** KEYS FOR Table [dbo].[Content]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Content_ContentId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Content] ADD  CONSTRAINT [DF_Content_ContentId]  DEFAULT (newid()) FOR [ContentId]
          END
          GO
        

              -- ****** KEYS FOR Table [dbo].[Variant]
          -- Primary Key
          IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Variant_VariantId]') AND type = 'D')
          BEGIN
            ALTER TABLE [dbo].[Variant] ADD  CONSTRAINT [DF_Variant_VariantId]  DEFAULT (newid()) FOR [VariantId]
          END
          GO
        


            SELECT 'Successful' as Value
            FROM (SELECT NULL AS FIELD) as Result
            FOR XML AUTO

          