USE [SIMT1]
GO
/****** Object:  Table [dbo].[Locations]    Script Date: 09/11/2022 11:46:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Locations](
	[Location] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MeasurementResultImages]    Script Date: 09/11/2022 11:46:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MeasurementResultImages](
	[MeasurementKey] [bigint] NOT NULL,
	[Source] [nchar](64) NOT NULL,
	[Time] [datetime] NOT NULL,
	[ImagePath] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_MeasurementResultImages_1] PRIMARY KEY CLUSTERED 
(
	[MeasurementKey] ASC,
	[Source] ASC,
	[Time] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MeasurementResults]    Script Date: 09/11/2022 11:46:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MeasurementResults](
	[MeasurementKey] [bigint] NOT NULL,
	[Source] [nvarchar](50) NOT NULL,
	[Time] [datetime] NOT NULL,
	[Alarm] [int] NULL,
	[Prealarm] [int] NULL,
	[Min] [decimal](18, 2) NULL,
	[Max] [decimal](18, 2) NULL,
	[Mean] [decimal](18, 2) NULL,
	[Range] [decimal](18, 2) NULL,
	[Var] [decimal](18, 2) NULL,
	[STD] [decimal](18, 2) NULL,
	[ThresholdPrealarm] [decimal](18, 2) NULL,
	[ThresholdAlarm] [decimal](18, 2) NULL,
 CONSTRAINT [PK_MeasurementResults_1] PRIMARY KEY CLUSTERED 
(
	[MeasurementKey] ASC,
	[Source] ASC,
	[Time] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MeasurementResultStatusText]    Script Date: 09/11/2022 11:46:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MeasurementResultStatusText](
	[Status] [int] NOT NULL,
	[Text] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_ResultStatusText] PRIMARY KEY CLUSTERED 
(
	[Status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Measurements]    Script Date: 09/11/2022 11:46:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Measurements](
	[MeasurementKey] [bigint] IDENTITY(1,1) NOT NULL,
	[Time] [datetime] NOT NULL,
	[TestMode] [int] NULL,
	[LadleID] [int] NULL,
	[LadleCampaign] [int] NULL,
	[LadleType] [int] NULL,
	[LadleAge] [int] NULL,
	[Location] [nvarchar](10) NULL,
	[Origin] [nvarchar](10) NULL,
	[CalcHeatContent] [decimal](18, 2) NULL,
	[HeatNumber] [int] NULL,
	[FerrotronNumber] [int] NULL,
	[SteelTemperature] [decimal](18, 2) NULL,
	[SteelTemperatureID] [nvarchar](10) NULL,
	[LadleCycle] [int] NULL,
	[HeatID] [nvarchar](10) NULL,
	[LadleDescription] [nvarchar](20) NULL,
	[CraneID] [nvarchar](50) NULL,
	[Hostname] [nvarchar](255) NULL,
	[MaxTempDet] [decimal](18, 2) NULL,
	[HotTempDet] [decimal](18, 2) NULL,
	[MaxTempDiff] [decimal](18, 2) NULL,
	[RaceNumber] [nvarchar](20) NULL,
	[cHeatNo] [nchar](50) NULL,
 CONSTRAINT [PK_Measurements] PRIMARY KEY CLUSTERED 
(
	[MeasurementKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MeasurementStatus]    Script Date: 09/11/2022 11:46:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MeasurementStatus](
	[Hostname] [nvarchar](255) NOT NULL,
	[StatusID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MeasurementStatusText]    Script Date: 09/11/2022 11:46:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MeasurementStatusText](
	[StatusID] [int] NOT NULL,
	[Text] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SystemStatusText] PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MeasurementThresholds]    Script Date: 09/11/2022 11:46:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MeasurementThresholds](
	[MeasurementKey] [bigint] NOT NULL,
	[AOI] [nchar](10) NOT NULL,
	[MaxTempDiff] [decimal](18, 2) NOT NULL,
	[MaxTempDet] [decimal](18, 2) NOT NULL,
	[HotTempDet] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_MeasurementThresholds] PRIMARY KEY CLUSTERED 
(
	[MeasurementKey] ASC,
	[AOI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
