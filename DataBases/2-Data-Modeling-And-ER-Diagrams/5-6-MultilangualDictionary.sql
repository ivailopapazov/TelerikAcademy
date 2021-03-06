USE [master]
GO
/****** Object:  Database [DictionaryDB]    Script Date: 24/08/2014 22:27:05 ******/
CREATE DATABASE [DictionaryDB]
GO
ALTER DATABASE [DictionaryDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DictionaryDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DictionaryDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DictionaryDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DictionaryDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DictionaryDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DictionaryDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [DictionaryDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DictionaryDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DictionaryDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DictionaryDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DictionaryDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DictionaryDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DictionaryDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DictionaryDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DictionaryDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DictionaryDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DictionaryDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DictionaryDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DictionaryDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DictionaryDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DictionaryDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DictionaryDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DictionaryDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DictionaryDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DictionaryDB] SET  MULTI_USER 
GO
ALTER DATABASE [DictionaryDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DictionaryDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DictionaryDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DictionaryDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DictionaryDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DictionaryDB]
GO
/****** Object:  Table [dbo].[Explanations]    Script Date: 24/08/2014 22:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Explanations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Explanation] [ntext] NOT NULL,
	[WordId] [int] NOT NULL,
	[LanguageId] [int] NOT NULL,
 CONSTRAINT [PK_Explanations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HypernymGroups]    Script Date: 24/08/2014 22:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HypernymGroups](
	[HypernymId] [int] NOT NULL,
	[HyponymId] [int] NOT NULL,
 CONSTRAINT [PK_HypernymGroups] PRIMARY KEY CLUSTERED 
(
	[HypernymId] ASC,
	[HyponymId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Languages]    Script Date: 24/08/2014 22:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Languages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Language] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Languages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PartOfSpeechGroups]    Script Date: 24/08/2014 22:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PartOfSpeechGroups](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PartOfSpeech] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PartOfSpeechGroups] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Synonyms]    Script Date: 24/08/2014 22:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Synonyms](
	[WordId] [int] NOT NULL,
	[SynonymId] [int] NOT NULL,
 CONSTRAINT [PK_Synonyms] PRIMARY KEY CLUSTERED 
(
	[WordId] ASC,
	[SynonymId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Translations]    Script Date: 24/08/2014 22:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Translations](
	[WordId] [int] NOT NULL,
	[TranslationId] [int] NOT NULL,
 CONSTRAINT [PK_Translations] PRIMARY KEY CLUSTERED 
(
	[WordId] ASC,
	[TranslationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Words]    Script Date: 24/08/2014 22:27:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Words](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Word] [nvarchar](50) NOT NULL,
	[LanguageId] [int] NOT NULL,
	[PartOfSpeechGroupId] [int] NULL,
	[HypernymGroupsId] [int] NULL,
	[AntonymId] [int] NULL,
 CONSTRAINT [PK_Words] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Explanations] ON 

INSERT [dbo].[Explanations] ([Id], [Explanation], [WordId], [LanguageId]) VALUES (1, N'To move fast', 1, 1)
INSERT [dbo].[Explanations] ([Id], [Explanation], [WordId], [LanguageId]) VALUES (2, N'Dvizha se mnogo byrzo', 1, 2)
INSERT [dbo].[Explanations] ([Id], [Explanation], [WordId], [LanguageId]) VALUES (3, N'To observe something', 2, 1)
INSERT [dbo].[Explanations] ([Id], [Explanation], [WordId], [LanguageId]) VALUES (4, N'Da nabliudawam neshto', 2, 2)
SET IDENTITY_INSERT [dbo].[Explanations] OFF
SET IDENTITY_INSERT [dbo].[Languages] ON 

INSERT [dbo].[Languages] ([Id], [Language]) VALUES (1, N'English')
INSERT [dbo].[Languages] ([Id], [Language]) VALUES (2, N'Bulgarian')
SET IDENTITY_INSERT [dbo].[Languages] OFF
SET IDENTITY_INSERT [dbo].[PartOfSpeechGroups] ON 

INSERT [dbo].[PartOfSpeechGroups] ([Id], [PartOfSpeech]) VALUES (1, N'verb')
INSERT [dbo].[PartOfSpeechGroups] ([Id], [PartOfSpeech]) VALUES (2, N'noun')
INSERT [dbo].[PartOfSpeechGroups] ([Id], [PartOfSpeech]) VALUES (3, N'adjective')
SET IDENTITY_INSERT [dbo].[PartOfSpeechGroups] OFF
SET IDENTITY_INSERT [dbo].[Words] ON 

INSERT [dbo].[Words] ([Id], [Word], [LanguageId], [PartOfSpeechGroupId], [HypernymGroupsId], [AntonymId]) VALUES (1, N'ticham', 2, 1, NULL, NULL)
INSERT [dbo].[Words] ([Id], [Word], [LanguageId], [PartOfSpeechGroupId], [HypernymGroupsId], [AntonymId]) VALUES (2, N'watching', 1, 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Words] OFF
ALTER TABLE [dbo].[Explanations]  WITH CHECK ADD  CONSTRAINT [FK_Explanations_Languages] FOREIGN KEY([LanguageId])
REFERENCES [dbo].[Languages] ([Id])
GO
ALTER TABLE [dbo].[Explanations] CHECK CONSTRAINT [FK_Explanations_Languages]
GO
ALTER TABLE [dbo].[Explanations]  WITH CHECK ADD  CONSTRAINT [FK_Explanations_Words] FOREIGN KEY([WordId])
REFERENCES [dbo].[Words] ([Id])
GO
ALTER TABLE [dbo].[Explanations] CHECK CONSTRAINT [FK_Explanations_Words]
GO
ALTER TABLE [dbo].[HypernymGroups]  WITH CHECK ADD  CONSTRAINT [FK_HypernymGroups_Words] FOREIGN KEY([HypernymId])
REFERENCES [dbo].[Words] ([Id])
GO
ALTER TABLE [dbo].[HypernymGroups] CHECK CONSTRAINT [FK_HypernymGroups_Words]
GO
ALTER TABLE [dbo].[HypernymGroups]  WITH CHECK ADD  CONSTRAINT [FK_HypernymGroups_Words1] FOREIGN KEY([HyponymId])
REFERENCES [dbo].[Words] ([Id])
GO
ALTER TABLE [dbo].[HypernymGroups] CHECK CONSTRAINT [FK_HypernymGroups_Words1]
GO
ALTER TABLE [dbo].[Synonyms]  WITH CHECK ADD  CONSTRAINT [FK_Synonyms_Words] FOREIGN KEY([WordId])
REFERENCES [dbo].[Words] ([Id])
GO
ALTER TABLE [dbo].[Synonyms] CHECK CONSTRAINT [FK_Synonyms_Words]
GO
ALTER TABLE [dbo].[Synonyms]  WITH CHECK ADD  CONSTRAINT [FK_Synonyms_Words1] FOREIGN KEY([SynonymId])
REFERENCES [dbo].[Words] ([Id])
GO
ALTER TABLE [dbo].[Synonyms] CHECK CONSTRAINT [FK_Synonyms_Words1]
GO
ALTER TABLE [dbo].[Translations]  WITH CHECK ADD  CONSTRAINT [FK_Translations_Words] FOREIGN KEY([WordId])
REFERENCES [dbo].[Words] ([Id])
GO
ALTER TABLE [dbo].[Translations] CHECK CONSTRAINT [FK_Translations_Words]
GO
ALTER TABLE [dbo].[Translations]  WITH CHECK ADD  CONSTRAINT [FK_Translations_Words1] FOREIGN KEY([TranslationId])
REFERENCES [dbo].[Words] ([Id])
GO
ALTER TABLE [dbo].[Translations] CHECK CONSTRAINT [FK_Translations_Words1]
GO
ALTER TABLE [dbo].[Words]  WITH CHECK ADD  CONSTRAINT [FK_Words_Languages] FOREIGN KEY([LanguageId])
REFERENCES [dbo].[Languages] ([Id])
GO
ALTER TABLE [dbo].[Words] CHECK CONSTRAINT [FK_Words_Languages]
GO
ALTER TABLE [dbo].[Words]  WITH CHECK ADD  CONSTRAINT [FK_Words_PartOfSpeechGroups] FOREIGN KEY([PartOfSpeechGroupId])
REFERENCES [dbo].[PartOfSpeechGroups] ([Id])
GO
ALTER TABLE [dbo].[Words] CHECK CONSTRAINT [FK_Words_PartOfSpeechGroups]
GO
ALTER TABLE [dbo].[Words]  WITH CHECK ADD  CONSTRAINT [FK_Words_Words] FOREIGN KEY([AntonymId])
REFERENCES [dbo].[Words] ([Id])
GO
ALTER TABLE [dbo].[Words] CHECK CONSTRAINT [FK_Words_Words]
GO
USE [master]
GO
ALTER DATABASE [DictionaryDB] SET  READ_WRITE 
GO
