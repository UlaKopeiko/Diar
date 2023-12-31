USE [master]
GO
/****** Object:  Database [Diary]    Script Date: 10.03.2023 11:16:25 ******/
CREATE DATABASE [Diary]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Diary', FILENAME = N'D:\Sql\MSSQL16.MSSQLSERVER\MSSQL\DATA\Diary.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Diary_log', FILENAME = N'D:\Sql\MSSQL16.MSSQLSERVER\MSSQL\DATA\Diary_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Diary] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Diary].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Diary] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Diary] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Diary] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Diary] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Diary] SET ARITHABORT OFF 
GO
ALTER DATABASE [Diary] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Diary] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Diary] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Diary] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Diary] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Diary] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Diary] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Diary] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Diary] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Diary] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Diary] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Diary] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Diary] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Diary] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Diary] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Diary] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Diary] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Diary] SET RECOVERY FULL 
GO
ALTER DATABASE [Diary] SET  MULTI_USER 
GO
ALTER DATABASE [Diary] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Diary] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Diary] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Diary] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Diary] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Diary] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Diary', N'ON'
GO
ALTER DATABASE [Diary] SET QUERY_STORE = ON
GO
ALTER DATABASE [Diary] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Diary]
GO
/****** Object:  Table [dbo].[Answer]    Script Date: 10.03.2023 11:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Answer](
	[ID] [int] NOT NULL,
	[Text] [nvarchar](50) NOT NULL,
	[Question] [int] NOT NULL,
 CONSTRAINT [PK_Answer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CharacterAccentuation]    Script Date: 10.03.2023 11:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CharacterAccentuation](
	[Id] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [text] NOT NULL,
 CONSTRAINT [PK_CharacterAccentuation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 10.03.2023 11:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[ID] [int] NOT NULL,
	[Photo] [varbinary](max) NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NULL,
	[Birthday] [date] NOT NULL,
	[Position] [int] NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HealthStatus]    Script Date: 10.03.2023 11:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HealthStatus](
	[ID] [int] NOT NULL,
	[CurrentDeviations] [nvarchar](max) NULL,
	[Temperament] [nvarchar](50) NOT NULL,
	[Employee] [int] NOT NULL,
	[Family] [nvarchar](50) NULL,
	[Motivation] [nvarchar](max) NULL,
	[CharacterAccentuation] [int] NOT NULL,
 CONSTRAINT [PK_HealthStatus] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Journal]    Script Date: 10.03.2023 11:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Journal](
	[ID] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[Test] [int] NULL,
	[Employee] [int] NOT NULL,
	[ResultFile] [nvarchar](50) NULL,
 CONSTRAINT [PK_Journal] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Position]    Script Date: 10.03.2023 11:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Position](
	[ID] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Position] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Question]    Script Date: 10.03.2023 11:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Question](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Text] [nvarchar](50) NOT NULL,
	[Test] [int] NOT NULL,
 CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Test]    Script Date: 10.03.2023 11:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Test](
	[ID] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[StartDate] [datetime] NULL,
	[ExpirationDate] [datetime] NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Test] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TestStatus]    Script Date: 10.03.2023 11:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestStatus](
	[ID] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TestStatus] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CharacterAccentuation] ([Id], [Title], [Description]) VALUES (1, N'Истероидный тип', N'Стремление привлечь внимание. Повышенная эмоциональность. Артистизм. Развитое воображение. Боязливы(склонны преувеличивать). Открыты к общению. Хорошо адаптируются. Желание славы мощный мотиватор.')
INSERT [dbo].[CharacterAccentuation] ([Id], [Title], [Description]) VALUES (2, N'Эпилептоидный тип', N'Недовольдство и раздражительность. Склонность к ранее установленному порядку. Легкое отношение к моральным нормам. Структурированное мышление. Недоверчивость. Тяжелая адаптация. Скрупулезность. Способность отстаивать свои интересы.')
INSERT [dbo].[CharacterAccentuation] ([Id], [Title], [Description]) VALUES (3, N'Шизоидный тип', N'Замкнутость. Сочетание противоречивых свойств(застенчивость и бестактность и т.д.). Недостаточное понимание чувств других. Скрытны. Креативность.')
INSERT [dbo].[CharacterAccentuation] ([Id], [Title], [Description]) VALUES (4, N'Циклоидный тип', N'Волнообразная смена настроения. Период подъема(Общительный, позитивный, стремится к лидерству). Период спада(Сонливость, отсутствие желания общаться).')
INSERT [dbo].[CharacterAccentuation] ([Id], [Title], [Description]) VALUES (5, N'Параноидный тип', N'Зацикленность на собственной личности. Чрезмерная чувствительность к замечаниям. Сварливость. Необоснованная ревность. Неумение отказывать. Склонность к эксклюзивности. Настойчивостью. Целеустремленность.')
INSERT [dbo].[CharacterAccentuation] ([Id], [Title], [Description]) VALUES (6, N'Неустойчивый', N'Лень. Слабоволие. Неустойчивость эмоций. Необходимость в строгом контроле. Склонность подчиняться неформальному лидеру. Оптимистичность. Любознательность.')
INSERT [dbo].[CharacterAccentuation] ([Id], [Title], [Description]) VALUES (7, N'Лабильный тип', N'Перепады настроения. Высокая чувствительность к похвале и критике. Общительность. Позитивность. Низкая стрессоустойчивость.')
INSERT [dbo].[CharacterAccentuation] ([Id], [Title], [Description]) VALUES (8, N'Конформный тип', N'Подчинение мнению большинства. Следование моде. Консерватизм. Тяжелое переживание конфликтов.')
INSERT [dbo].[CharacterAccentuation] ([Id], [Title], [Description]) VALUES (9, N'Астено-невротический тип', N'Тяжело переносят умственные и физические нагрузки. Раздражительность на фоне усталости. Склонность к ипохондрии. Доброта. Хорошее интелектуальное развитие. Высокая утомляемость.')
INSERT [dbo].[CharacterAccentuation] ([Id], [Title], [Description]) VALUES (10, N'Психастенический тип', N'Рефлексия. Нерешительность. Стремление оправдать надежды. Развитие навязчивостей. Педантизм. Доброта. Креативность. Нерешительность.')
INSERT [dbo].[CharacterAccentuation] ([Id], [Title], [Description]) VALUES (11, N'Гипертимный тип', N'Оптимизм. Энергичность. Общительность. Неусидчивость. Расточительность.')
INSERT [dbo].[CharacterAccentuation] ([Id], [Title], [Description]) VALUES (12, N'Сенситивный тип', N'Впечатлительность. Сложность в управлении собой. Неуверенность. Пессимизм. Исполнительность. Пассивность.')
GO
INSERT [dbo].[Employee] ([ID], [Photo], [LastName], [FirstName], [Surname], [Birthday], [Position], [Login], [Password]) VALUES (1, NULL, N'Калинина', N'Ангелина', N'Евгеньевна', CAST(N'2003-12-31' AS Date), 9, N'ang', N'ang')
INSERT [dbo].[Employee] ([ID], [Photo], [LastName], [FirstName], [Surname], [Birthday], [Position], [Login], [Password]) VALUES (2, NULL, N'Ефанова', N'Екатерина', N'Евгеньевна', CAST(N'2003-08-01' AS Date), 11, N'ekat', N'ekat')
INSERT [dbo].[Employee] ([ID], [Photo], [LastName], [FirstName], [Surname], [Birthday], [Position], [Login], [Password]) VALUES (3, NULL, N'Митягина', N'Наталья', N'Павловна', CAST(N'2003-09-08' AS Date), 3, N'nat', N'nat')
INSERT [dbo].[Employee] ([ID], [Photo], [LastName], [FirstName], [Surname], [Birthday], [Position], [Login], [Password]) VALUES (4, NULL, N'Копейко', N'Юлия', N'Александровна', CAST(N'2003-07-15' AS Date), 12, N'jul', N'jul')
GO
INSERT [dbo].[HealthStatus] ([ID], [CurrentDeviations], [Temperament], [Employee], [Family], [Motivation], [CharacterAccentuation]) VALUES (1, N'Нет', N'Нет', 1, N'Нет', N'Нет', 1)
GO
INSERT [dbo].[Position] ([ID], [Title]) VALUES (1, N'Оператор')
INSERT [dbo].[Position] ([ID], [Title]) VALUES (2, N'Секретарь')
INSERT [dbo].[Position] ([ID], [Title]) VALUES (3, N'Программист')
INSERT [dbo].[Position] ([ID], [Title]) VALUES (4, N'Бухгалтер')
INSERT [dbo].[Position] ([ID], [Title]) VALUES (5, N'Менеджер по продажам')
INSERT [dbo].[Position] ([ID], [Title]) VALUES (6, N'Контент-менеджер')
INSERT [dbo].[Position] ([ID], [Title]) VALUES (7, N'Модератор комментариев')
INSERT [dbo].[Position] ([ID], [Title]) VALUES (8, N'Копирайтер')
INSERT [dbo].[Position] ([ID], [Title]) VALUES (9, N'Графический дизайнер')
INSERT [dbo].[Position] ([ID], [Title]) VALUES (10, N'Менеджер проектов')
INSERT [dbo].[Position] ([ID], [Title]) VALUES (11, N'Аналитик')
INSERT [dbo].[Position] ([ID], [Title]) VALUES (12, N'Региональный представитель')
INSERT [dbo].[Position] ([ID], [Title]) VALUES (13, N'Помощник руководителя')
INSERT [dbo].[Position] ([ID], [Title]) VALUES (14, N'Маркетолог')
INSERT [dbo].[Position] ([ID], [Title]) VALUES (15, N'Помощник бухгалтера')
INSERT [dbo].[Position] ([ID], [Title]) VALUES (16, N'Экономист')
INSERT [dbo].[Position] ([ID], [Title]) VALUES (17, N'Специалист чат-поддержки')
INSERT [dbo].[Position] ([ID], [Title]) VALUES (18, N'Тестировщик')
INSERT [dbo].[Position] ([ID], [Title]) VALUES (19, N'Системный администратор')
INSERT [dbo].[Position] ([ID], [Title]) VALUES (20, N'Специалист по защите информации')
GO
SET IDENTITY_INSERT [dbo].[Question] ON 

INSERT [dbo].[Question] ([ID], [Text], [Test]) VALUES (1, N'Есть ли у вас какие-нибудь жалобы?', 1)
INSERT [dbo].[Question] ([ID], [Text], [Test]) VALUES (1007, N'Ghj,f', 456855)
INSERT [dbo].[Question] ([ID], [Text], [Test]) VALUES (1008, N'вым', 6545)
SET IDENTITY_INSERT [dbo].[Question] OFF
GO
INSERT [dbo].[Test] ([ID], [Title], [StartDate], [ExpirationDate], [Status]) VALUES (1, N'Самочувствие', CAST(N'2023-02-06T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[Test] ([ID], [Title], [StartDate], [ExpirationDate], [Status]) VALUES (2, N'Конец дня', CAST(N'2023-02-05T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[Test] ([ID], [Title], [StartDate], [ExpirationDate], [Status]) VALUES (54, N'LK', NULL, NULL, 3)
INSERT [dbo].[Test] ([ID], [Title], [StartDate], [ExpirationDate], [Status]) VALUES (231, N'Ffd', NULL, NULL, 3)
INSERT [dbo].[Test] ([ID], [Title], [StartDate], [ExpirationDate], [Status]) VALUES (456, N'Проба', NULL, NULL, 3)
INSERT [dbo].[Test] ([ID], [Title], [StartDate], [ExpirationDate], [Status]) VALUES (6545, N'Проба', NULL, NULL, 3)
INSERT [dbo].[Test] ([ID], [Title], [StartDate], [ExpirationDate], [Status]) VALUES (456855, N'HGF', NULL, NULL, 3)
GO
INSERT [dbo].[TestStatus] ([ID], [Title]) VALUES (1, N'Активный')
INSERT [dbo].[TestStatus] ([ID], [Title]) VALUES (2, N'Ожидает')
INSERT [dbo].[TestStatus] ([ID], [Title]) VALUES (3, N'Отключен')
GO
ALTER TABLE [dbo].[Answer]  WITH CHECK ADD  CONSTRAINT [FK_Answer_Question] FOREIGN KEY([Question])
REFERENCES [dbo].[Question] ([ID])
GO
ALTER TABLE [dbo].[Answer] CHECK CONSTRAINT [FK_Answer_Question]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Position] FOREIGN KEY([Position])
REFERENCES [dbo].[Position] ([ID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Position]
GO
ALTER TABLE [dbo].[HealthStatus]  WITH CHECK ADD  CONSTRAINT [FK_HealthStatus_CharacterAccentuation] FOREIGN KEY([CharacterAccentuation])
REFERENCES [dbo].[CharacterAccentuation] ([Id])
GO
ALTER TABLE [dbo].[HealthStatus] CHECK CONSTRAINT [FK_HealthStatus_CharacterAccentuation]
GO
ALTER TABLE [dbo].[HealthStatus]  WITH CHECK ADD  CONSTRAINT [FK_HealthStatus_Employee] FOREIGN KEY([Employee])
REFERENCES [dbo].[Employee] ([ID])
GO
ALTER TABLE [dbo].[HealthStatus] CHECK CONSTRAINT [FK_HealthStatus_Employee]
GO
ALTER TABLE [dbo].[Journal]  WITH CHECK ADD  CONSTRAINT [FK_Journal_Employee] FOREIGN KEY([Employee])
REFERENCES [dbo].[Employee] ([ID])
GO
ALTER TABLE [dbo].[Journal] CHECK CONSTRAINT [FK_Journal_Employee]
GO
ALTER TABLE [dbo].[Journal]  WITH CHECK ADD  CONSTRAINT [FK_Journal_Test] FOREIGN KEY([Test])
REFERENCES [dbo].[Test] ([ID])
GO
ALTER TABLE [dbo].[Journal] CHECK CONSTRAINT [FK_Journal_Test]
GO
ALTER TABLE [dbo].[Question]  WITH CHECK ADD  CONSTRAINT [FK_Question_Test] FOREIGN KEY([Test])
REFERENCES [dbo].[Test] ([ID])
GO
ALTER TABLE [dbo].[Question] CHECK CONSTRAINT [FK_Question_Test]
GO
ALTER TABLE [dbo].[Test]  WITH CHECK ADD  CONSTRAINT [FK_Test_TestStatus] FOREIGN KEY([Status])
REFERENCES [dbo].[TestStatus] ([ID])
GO
ALTER TABLE [dbo].[Test] CHECK CONSTRAINT [FK_Test_TestStatus]
GO
USE [master]
GO
ALTER DATABASE [Diary] SET  READ_WRITE 
GO
