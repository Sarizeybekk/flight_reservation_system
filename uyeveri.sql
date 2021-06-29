USE [Uyeler]
GO
/****** Object:  Table [dbo].[Bilgi]    Script Date: 26.06.2021 15:29:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bilgi](
	[uyeid] [int] IDENTITY(1,1) NOT NULL,
	[adi] [varchar](50) NULL,
	[soyadi] [varchar](50) NULL,
	[telefon] [varchar](50) NULL,
	[e_posta] [varchar](50) NULL,
	[sifre] [varchar](50) NULL,
	[giris_type] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[uyeid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
