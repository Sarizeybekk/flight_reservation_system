USE [sirket]
GO
/****** Object:  Table [dbo].[ANADOLU_JET]    Script Date: 26.06.2021 15:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ANADOLU_JET](
	[id] [int] NOT NULL,
	[nereden] [varchar](50) NULL,
	[nereye] [varchar](50) NULL,
	[gidis_tarihi] [varchar](50) NULL,
	[dönüs_tarihi] [varchar](50) NULL,
	[ucret] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PEGASUS]    Script Date: 26.06.2021 15:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PEGASUS](
	[id] [nchar](10) NULL,
	[nereden] [varchar](20) NULL,
	[nereye] [varchar](50) NULL,
	[gidis_tarihi] [varchar](50) NULL,
	[dönüs_tarihi] [varchar](50) NULL,
	[ucret] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THY]    Script Date: 26.06.2021 15:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THY](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nereden] [varchar](20) NULL,
	[nereye] [varchar](20) NULL,
	[gidis_tarihi] [date] NULL,
	[dönüs_tarihi] [date] NULL,
	[ucret] [int] NULL,
	[adi_soyadi] [varchar](50) NULL,
	[tc] [int] NULL,
	[telefon] [varchar](50) NULL,
	[koltuk_no] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ANADOLU_JET] ([id], [nereden], [nereye], [gidis_tarihi], [dönüs_tarihi], [ucret]) VALUES (1, N'BOLU', N'İSTANBUL', N'12.06.2021', N'14.06.2021', 150)
INSERT [dbo].[ANADOLU_JET] ([id], [nereden], [nereye], [gidis_tarihi], [dönüs_tarihi], [ucret]) VALUES (2, N'BURSA', N'ESKİŞEHİR', N'20.06.2021', N'25.06.2021', 100)
INSERT [dbo].[ANADOLU_JET] ([id], [nereden], [nereye], [gidis_tarihi], [dönüs_tarihi], [ucret]) VALUES (3, N'MUGLA', N'TRABZON', N'26.06.2021', N'28.06.2021', 400)
GO
INSERT [dbo].[PEGASUS] ([id], [nereden], [nereye], [gidis_tarihi], [dönüs_tarihi], [ucret]) VALUES (N'1         ', N'ANTALYA', N'İZMİT', N'14.06.2021', N'16.06.21', N'150')
INSERT [dbo].[PEGASUS] ([id], [nereden], [nereye], [gidis_tarihi], [dönüs_tarihi], [ucret]) VALUES (N'2         ', N'ZONGULDAK', N'AYDIN', N'28.06.2021', N'30.06.2021', N'550')
INSERT [dbo].[PEGASUS] ([id], [nereden], [nereye], [gidis_tarihi], [dönüs_tarihi], [ucret]) VALUES (N'3         ', N'SİVAS', N'MERSİN', N'17.06.2021', N'17.06.2021', N'355')
GO
SET IDENTITY_INSERT [dbo].[THY] ON 

INSERT [dbo].[THY] ([id], [nereden], [nereye], [gidis_tarihi], [dönüs_tarihi], [ucret], [adi_soyadi], [tc], [telefon], [koltuk_no]) VALUES (1, N'ANKARA', N'BARTIN', CAST(N'2021-06-25' AS Date), CAST(N'2021-06-26' AS Date), 100, NULL, NULL, NULL, NULL)
INSERT [dbo].[THY] ([id], [nereden], [nereye], [gidis_tarihi], [dönüs_tarihi], [ucret], [adi_soyadi], [tc], [telefon], [koltuk_no]) VALUES (2, N'BARTIN', N'İZMİR', CAST(N'2021-06-14' AS Date), CAST(N'2021-06-15' AS Date), 400, NULL, NULL, NULL, NULL)
INSERT [dbo].[THY] ([id], [nereden], [nereye], [gidis_tarihi], [dönüs_tarihi], [ucret], [adi_soyadi], [tc], [telefon], [koltuk_no]) VALUES (3, N'İZMİR', N'BARTIN', CAST(N'2021-06-12' AS Date), CAST(N'2021-06-12' AS Date), 350, NULL, NULL, NULL, NULL)
INSERT [dbo].[THY] ([id], [nereden], [nereye], [gidis_tarihi], [dönüs_tarihi], [ucret], [adi_soyadi], [tc], [telefon], [koltuk_no]) VALUES (4, N'BARTIN', N'ANKARA', CAST(N'2021-05-14' AS Date), CAST(N'2021-09-17' AS Date), 160, NULL, NULL, NULL, NULL)
INSERT [dbo].[THY] ([id], [nereden], [nereye], [gidis_tarihi], [dönüs_tarihi], [ucret], [adi_soyadi], [tc], [telefon], [koltuk_no]) VALUES (5, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[THY] ([id], [nereden], [nereye], [gidis_tarihi], [dönüs_tarihi], [ucret], [adi_soyadi], [tc], [telefon], [koltuk_no]) VALUES (6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[THY] OFF
GO
