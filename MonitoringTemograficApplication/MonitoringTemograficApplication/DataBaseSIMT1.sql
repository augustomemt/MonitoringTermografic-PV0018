USE [SIMT1]
GO
/****** Object:  User [IIS APPPOOL\.NET v4.5]    Script Date: 09/11/2022 11:40:24 ******/
CREATE USER [IIS APPPOOL\.NET v4.5] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [LadleCheck]    Script Date: 09/11/2022 11:40:24 ******/
CREATE USER [LadleCheck] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Mgr.Rad]    Script Date: 09/11/2022 11:40:24 ******/
CREATE USER [Mgr.Rad] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Sql.LADLECHECK.Appl.PROD]    Script Date: 09/11/2022 11:40:24 ******/
CREATE USER [Sql.LADLECHECK.Appl.PROD]
GO
/****** Object:  User [Sql.LADLECHECK.Dr.PROD]    Script Date: 09/11/2022 11:40:24 ******/
CREATE USER [Sql.LADLECHECK.Dr.PROD]
GO
/****** Object:  User [Sql.LADLECHECK.Rlm]    Script Date: 09/11/2022 11:40:24 ******/
CREATE USER [Sql.LADLECHECK.Rlm]
GO
/****** Object:  DatabaseRole [uRole_Appl]    Script Date: 09/11/2022 11:40:24 ******/
CREATE ROLE [uRole_Appl]
GO
/****** Object:  DatabaseRole [uRole_DataReader]    Script Date: 09/11/2022 11:40:24 ******/
CREATE ROLE [uRole_DataReader]
GO
/****** Object:  DatabaseRole [uRole_RelMgr]    Script Date: 09/11/2022 11:40:24 ******/
CREATE ROLE [uRole_RelMgr]
GO
ALTER ROLE [db_owner] ADD MEMBER [IIS APPPOOL\.NET v4.5]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [IIS APPPOOL\.NET v4.5]
GO
ALTER ROLE [db_datareader] ADD MEMBER [IIS APPPOOL\.NET v4.5]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [IIS APPPOOL\.NET v4.5]
GO
ALTER ROLE [db_owner] ADD MEMBER [LadleCheck]
GO
ALTER ROLE [db_owner] ADD MEMBER [Mgr.Rad]
GO
ALTER ROLE [uRole_Appl] ADD MEMBER [Sql.LADLECHECK.Appl.PROD]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Sql.LADLECHECK.Appl.PROD]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Sql.LADLECHECK.Appl.PROD]
GO
ALTER ROLE [uRole_DataReader] ADD MEMBER [Sql.LADLECHECK.Dr.PROD]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Sql.LADLECHECK.Dr.PROD]
GO
ALTER ROLE [uRole_RelMgr] ADD MEMBER [Sql.LADLECHECK.Rlm]
GO
ALTER ROLE [db_owner] ADD MEMBER [Sql.LADLECHECK.Rlm]
GO
ALTER ROLE [db_datareader] ADD MEMBER [uRole_Appl]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [uRole_Appl]
GO
ALTER ROLE [db_datareader] ADD MEMBER [uRole_DataReader]
GO
ALTER ROLE [db_owner] ADD MEMBER [uRole_RelMgr]
GO
/****** Object:  Table [dbo].[SourceLoc]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SourceLoc](
	[ID] [nvarchar](50) NOT NULL,
	[LangID] [nvarchar](10) NOT NULL,
	[Source] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Test] PRIMARY KEY CLUSTERED 
(
	[LangID] ASC,
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Source]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Source]
AS
SELECT DISTINCT ID
FROM         dbo.SourceLoc
GO
/****** Object:  Table [dbo].[MeasurementResultStatusText]    Script Date: 09/11/2022 11:40:25 ******/
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
/****** Object:  Table [dbo].[MeasurementResults]    Script Date: 09/11/2022 11:40:25 ******/
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
/****** Object:  Table [dbo].[Measurements]    Script Date: 09/11/2022 11:40:25 ******/
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
/****** Object:  View [dbo].[MeasurementResultStatusView]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[MeasurementResultStatusView]
AS
SELECT     dbo.Measurements.MeasurementKey, dbo.Measurements.Time, 2 * MAX(dbo.MeasurementResults.Alarm) + MAX(dbo.MeasurementResults.Prealarm) 
                      AS Status,
                          (SELECT     Text
                            FROM          dbo.MeasurementResultStatusText
                            WHERE      (2 * MAX(dbo.MeasurementResults.Alarm) + MAX(dbo.MeasurementResults.Prealarm) = Status)) AS StatusText
FROM         dbo.Measurements INNER JOIN
                      dbo.MeasurementResults ON dbo.Measurements.MeasurementKey = dbo.MeasurementResults.MeasurementKey
GROUP BY dbo.Measurements.MeasurementKey, dbo.Measurements.Time, dbo.Measurements.TestMode, dbo.Measurements.LadleID
HAVING      (dbo.Measurements.TestMode IS NULL OR
                      dbo.Measurements.TestMode = 0) AND (dbo.Measurements.LadleID IS NOT NULL)
GO
/****** Object:  Table [dbo].[MeasurementResultImages]    Script Date: 09/11/2022 11:40:25 ******/
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
/****** Object:  Table [dbo].[AOIPathLoc]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AOIPathLoc](
	[EvalPath] [nvarchar](50) NOT NULL,
	[LangID] [nvarchar](10) NOT NULL,
	[ZoneID] [nvarchar](10) NOT NULL,
	[AOIID] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_AOIPathLoc] PRIMARY KEY CLUSTERED 
(
	[EvalPath] ASC,
	[LangID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[MeasurementDataView]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[MeasurementDataView]
AS
SELECT DISTINCT 
                         dbo.Measurements.MeasurementKey, dbo.MeasurementResults.Alarm, dbo.MeasurementResults.Prealarm, dbo.MeasurementResults.Max, dbo.MeasurementResults.Mean, 
                         dbo.MeasurementResults.Max - dbo.MeasurementResults.Mean AS Diff, dbo.MeasurementResults.ThresholdPrealarm, dbo.MeasurementResults.ThresholdAlarm, dbo.MeasurementResultImages.ImagePath, 
                         dbo.MeasurementResults.Time AS EvaluationTime, dbo.AOIPathLoc.ZoneID AS Source, dbo.MeasurementResults.Source AS EvaluationSource, dbo.AOIPathLoc.AOIID AS AOI, dbo.Measurements.Origin, 
                         dbo.Measurements.SteelTemperature, dbo.Measurements.LadleID, dbo.Measurements.LadleAge, dbo.Measurements.LadleCampaign, dbo.Measurements.CalcHeatContent, dbo.Measurements.TestMode, 
                         dbo.Measurements.Location, dbo.Measurements.CraneID
FROM            dbo.Measurements INNER JOIN
                         dbo.MeasurementResults ON dbo.Measurements.MeasurementKey = dbo.MeasurementResults.MeasurementKey INNER JOIN
                         dbo.MeasurementResultImages ON dbo.MeasurementResults.MeasurementKey = dbo.MeasurementResultImages.MeasurementKey INNER JOIN
                         dbo.AOIPathLoc ON dbo.MeasurementResults.Source = dbo.AOIPathLoc.EvalPath INNER JOIN
                         dbo.SourceLoc ON dbo.MeasurementResultImages.Source = dbo.SourceLoc.Source AND dbo.SourceLoc.ID = dbo.AOIPathLoc.ZoneID AND dbo.SourceLoc.LangID = dbo.AOIPathLoc.LangID
WHERE        (dbo.Measurements.TestMode IS NULL OR
                         dbo.Measurements.TestMode = 0) AND (dbo.Measurements.LadleID IS NOT NULL)

GO
/****** Object:  Table [dbo].[HardwareLoc]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HardwareLoc](
	[ID] [nvarchar](50) NOT NULL,
	[LangID] [nvarchar](50) NOT NULL,
	[Hardware] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ConnectedHardware]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ConnectedHardware]
AS
SELECT     ID, LangID, Source
FROM         dbo.SourceLoc
UNION
SELECT     ID, LangID, Hardware
FROM         dbo.HardwareLoc
GO
/****** Object:  Table [dbo].[AOILoc]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AOILoc](
	[ID] [nvarchar](50) NOT NULL,
	[LangID] [nvarchar](10) NOT NULL,
	[AOI] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Test2] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[LangID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[AOI]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[AOI]
AS
SELECT DISTINCT ID
FROM         dbo.AOILoc
GO
/****** Object:  View [dbo].[CrosstabAOIBySourceByMeasurementKey]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[CrosstabAOIBySourceByMeasurementKey]
AS
SELECT     dbo.Measurements.MeasurementKey, dbo.Source.ID AS Source, dbo.AOI.ID AS AOI
FROM         dbo.AOI CROSS JOIN
                      dbo.Source CROSS JOIN
                      dbo.Measurements
WHERE     (NOT (dbo.Source.ID = 'Base')) AND (NOT (dbo.AOI.ID = 'Base')) AND (dbo.Measurements.TestMode IS NULL OR dbo.Measurements.TestMode = 0)
UNION
SELECT     Measurements_1.MeasurementKey, Source_1.ID AS Source, AOI_1.ID AS AOI
FROM         dbo.AOI AS AOI_1 CROSS JOIN
                      dbo.Source AS Source_1 CROSS JOIN
                      dbo.Measurements AS Measurements_1
WHERE     (Source_1.ID = 'Base') AND (AOI_1.ID = 'Base') AND (Measurements_1.TestMode IS NULL OR
                      Measurements_1.TestMode = 0) AND (Measurements_1.LadleID IS NOT NULL)
GO
/****** Object:  View [dbo].[View_2]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_2]
AS
SELECT     MAX(Max) AS MaxOfMax
FROM         dbo.MeasurementDataView
GROUP BY MeasurementKey
HAVING      (MeasurementKey = 100)
GO
/****** Object:  View [dbo].[View_1]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_1]
AS
SELECT     dbo.MeasurementDataView.MeasurementKey, dbo.MeasurementDataView.Alarm, dbo.MeasurementDataView.Prealarm, 
                      dbo.MeasurementDataView.Max, dbo.SourceLoc.Source, dbo.AOILoc.AOI, dbo.AOILoc.LangID, dbo.SourceLoc.LangID AS Expr1
FROM         dbo.MeasurementDataView INNER JOIN
                      dbo.SourceLoc ON dbo.MeasurementDataView.Source = dbo.SourceLoc.ID INNER JOIN
                      dbo.AOILoc ON dbo.MeasurementDataView.AOI = dbo.AOILoc.ID
GROUP BY dbo.MeasurementDataView.MeasurementKey, dbo.MeasurementDataView.Alarm, dbo.MeasurementDataView.Prealarm, 
                      dbo.MeasurementDataView.Max, dbo.AOILoc.AOI, dbo.SourceLoc.Source, dbo.AOILoc.LangID, dbo.SourceLoc.LangID
HAVING      (dbo.MeasurementDataView.MeasurementKey = 4393) AND (dbo.AOILoc.LangID = 'de-DE') AND (dbo.SourceLoc.LangID = 'de-DE') AND 
                      (dbo.MeasurementDataView.Max =
                          (SELECT     MAX(Max) AS MaxOfMax
                            FROM          dbo.MeasurementDataView AS MeasurementDataView_1
                            GROUP BY MeasurementKey
                            HAVING      (MeasurementKey = 4393)))
GO
/****** Object:  Table [dbo].[SystemLog]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SystemLog](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Time] [datetime] NOT NULL,
	[Source] [nvarchar](80) NOT NULL,
	[Status] [int] NOT NULL,
	[Level] [int] NOT NULL,
	[Message] [nvarchar](max) NOT NULL,
	[SourceType] [int] NOT NULL,
	[Hostname] [nvarchar](255) NULL,
 CONSTRAINT [PK_SystemLog] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[SystemStatusView]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[SystemStatusView]
AS
SELECT     subqry.Hostname, subqry.ID, ConnectedHardware_1.LangID, ConnectedHardware_1.Source AS SourceLoc, subqry.Time, subqry.Status, subqry.[Level], 
                      subqry.Message
FROM         (SELECT DISTINCT 
                                              dbo.SystemLog.Hostname, dbo.ConnectedHardware.ID, dbo.SystemLog.Status, dbo.SystemLog.[Level], dbo.SystemLog.Message, 
                                              dbo.SystemLog.Time
                       FROM          dbo.SystemLog INNER JOIN
                                                  (SELECT     Hostname, MAX(ID) AS ID, Source
                                                    FROM          dbo.SystemLog AS SystemLog_1
                                                    GROUP BY Hostname, Source
                                                    HAVING      (Hostname IS NOT NULL)) AS laststate ON dbo.SystemLog.ID = laststate.ID AND dbo.SystemLog.Source = laststate.Source INNER JOIN
                                              dbo.ConnectedHardware ON dbo.SystemLog.Source = dbo.ConnectedHardware.Source) AS subqry INNER JOIN
                      dbo.ConnectedHardware AS ConnectedHardware_1 ON subqry.ID = ConnectedHardware_1.ID
GROUP BY subqry.ID, subqry.Status, subqry.[Level], subqry.Message, subqry.Time, ConnectedHardware_1.Source, ConnectedHardware_1.LangID, subqry.Hostname
GO
/****** Object:  Table [dbo].[MeasurementStatus]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MeasurementStatus](
	[Hostname] [nvarchar](255) NOT NULL,
	[StatusID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[MeasurementStatusView]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[MeasurementStatusView]
AS
SELECT        subqry.MeasurementKey, dbo.MeasurementStatus.Hostname, subqry.CraneID, dbo.MeasurementStatus.StatusID, subqry.Location, subqry.TestMode
FROM            (SELECT        MAX(MeasurementKey) AS MeasurementKey, CraneID, Location, TestMode
                          FROM            dbo.Measurements
                          GROUP BY CraneID, Location, TestMode) AS subqry INNER JOIN
                         dbo.Measurements AS Measurements_1 ON subqry.MeasurementKey = Measurements_1.MeasurementKey INNER JOIN
                         dbo.MeasurementStatus ON Measurements_1.Hostname = dbo.MeasurementStatus.Hostname

GO
/****** Object:  Table [dbo].[MeasurementThresholds]    Script Date: 09/11/2022 11:40:25 ******/
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
/****** Object:  View [dbo].[DiffTemperatureDetectionView]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DiffTemperatureDetectionView]
AS
SELECT     MeasurementKey, AOI, SUM(North) AS North, SUM(West) AS West, SUM(Base) AS Base, SUM(East) AS East, SUM(South) AS South, 
                      MAX(MaxTempDifference) AS MaxTempDifference, MAX(Status) AS Status
FROM         (SELECT     MeasurementKey, AOI, [North] AS North, [West] AS West, [Base] AS Base, [East] AS East, [South] AS South, MaxTempDifference, 
                                              Status
                       FROM          (SELECT DISTINCT 
                                                                      (CASE WHEN (dbo.MeasurementDataView.Diff <= dbo.MeasurementThresholds.MaxTempDiff) 
                                                                      THEN 0 WHEN (dbo.MeasurementDataView.Diff > dbo.MeasurementThresholds.MaxTempDiff) THEN 1 ELSE 0 END) AS Status, 
                                                                      MeasurementDataView.Diff, dbo.MeasurementThresholds.MaxTempDiff AS MaxTempDifference, 
                                                                      dbo.CrosstabAOIBySourceByMeasurementKey.MeasurementKey, dbo.CrosstabAOIBySourceByMeasurementKey.Source, 
                                                                      dbo.CrosstabAOIBySourceByMeasurementKey.AOI
                                               FROM          dbo.MeasurementThresholds RIGHT OUTER JOIN
                                                                      dbo.CrosstabAOIBySourceByMeasurementKey ON 
                                                                      dbo.MeasurementThresholds.MeasurementKey = dbo.CrosstabAOIBySourceByMeasurementKey.MeasurementKey AND 
                                                                      dbo.MeasurementThresholds.AOI = dbo.CrosstabAOIBySourceByMeasurementKey.AOI LEFT OUTER JOIN
                                                                      dbo.MeasurementDataView ON 
                                                                      dbo.CrosstabAOIBySourceByMeasurementKey.MeasurementKey = dbo.MeasurementDataView.MeasurementKey AND 
                                                                      dbo.CrosstabAOIBySourceByMeasurementKey.Source = dbo.MeasurementDataView.Source AND 
                                                                      dbo.CrosstabAOIBySourceByMeasurementKey.AOI = dbo.MeasurementDataView.AOI) ps PIVOT (SUM(Diff) FOR Source IN ([North],
                                               [West], [Base], [East], [South])) AS pvt) AS Mainqry
GROUP BY MeasurementKey, AOI
GO
/****** Object:  View [dbo].[MeasurementResultStatusBySourceView]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[MeasurementResultStatusBySourceView]
AS
SELECT     dbo.CrosstabAOIBySourceByMeasurementKey.MeasurementKey, dbo.CrosstabAOIBySourceByMeasurementKey.Source, 
                      2 * MAX(dbo.MeasurementDataView.Alarm) + MAX(dbo.MeasurementDataView.Prealarm) AS Status
FROM         dbo.MeasurementDataView RIGHT OUTER JOIN
                      dbo.CrosstabAOIBySourceByMeasurementKey ON 
                      dbo.MeasurementDataView.MeasurementKey = dbo.CrosstabAOIBySourceByMeasurementKey.MeasurementKey AND 
                      dbo.MeasurementDataView.Source = dbo.CrosstabAOIBySourceByMeasurementKey.Source AND 
                      dbo.MeasurementDataView.AOI = dbo.CrosstabAOIBySourceByMeasurementKey.AOI
GROUP BY dbo.CrosstabAOIBySourceByMeasurementKey.Source, dbo.CrosstabAOIBySourceByMeasurementKey.MeasurementKey
GO
/****** Object:  View [dbo].[MeasurementResultStatusByAOIView]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[MeasurementResultStatusByAOIView]
AS
SELECT     dbo.CrosstabAOIBySourceByMeasurementKey.MeasurementKey, 2 * MAX(dbo.MeasurementDataView.Alarm) 
                      + MAX(dbo.MeasurementDataView.Prealarm) AS Status, dbo.CrosstabAOIBySourceByMeasurementKey.AOI
FROM         dbo.CrosstabAOIBySourceByMeasurementKey LEFT OUTER JOIN
                      dbo.MeasurementDataView ON dbo.CrosstabAOIBySourceByMeasurementKey.MeasurementKey = dbo.MeasurementDataView.MeasurementKey AND 
                      dbo.CrosstabAOIBySourceByMeasurementKey.Source = dbo.MeasurementDataView.Source AND 
                      dbo.CrosstabAOIBySourceByMeasurementKey.AOI = dbo.MeasurementDataView.AOI
GROUP BY dbo.CrosstabAOIBySourceByMeasurementKey.MeasurementKey, dbo.CrosstabAOIBySourceByMeasurementKey.AOI
GO
/****** Object:  View [dbo].[MeasurementResultStatusByAOIOverview]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[MeasurementResultStatusByAOIOverview]
AS
SELECT     MeasurementKey, LadleID, LadleAge, Time, LadleType, LadleCampaign, Location, Origin, CalcHeatContent, HeatNumber, FerrotronNumber, [Top], [Middle] AS Middle, 
                      [Bottom] AS Bottom, [Base] AS Base, [Nozzle] AS Nozzle
FROM         (SELECT     dbo.Measurements.MeasurementKey, dbo.Measurements.LadleID, dbo.MeasurementResultStatusByAOIView.Status, 
                                              dbo.MeasurementResultStatusByAOIView.AOI, dbo.Measurements.LadleAge, dbo.Measurements.LadleType, dbo.Measurements.LadleCampaign, 
                                              dbo.Measurements.Time, dbo.Measurements.Location, dbo.Measurements.Origin, dbo.Measurements.CalcHeatContent, dbo.Measurements.HeatNumber, 
                                              dbo.Measurements.FerrotronNumber
                       FROM          dbo.Measurements INNER JOIN
                                              dbo.MeasurementResultStatusByAOIView ON dbo.Measurements.MeasurementKey = dbo.MeasurementResultStatusByAOIView.MeasurementKey
                       WHERE      ((dbo.Measurements.TestMode IS NULL OR
                                              dbo.Measurements.TestMode = 0) AND dbo.Measurements.LadleID IS NOT NULL)) ps PIVOT (SUM(Status) FOR AOI IN ([Top], [Middle], [Bottom], [Base], 
                      [Nozzle])) AS pvt
GO
/****** Object:  View [dbo].[HotTemperatureDetectionView]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[HotTemperatureDetectionView]
AS
SELECT     MeasurementKey, AOI, SUM(North) AS North, SUM(West) AS West, SUM(Base) AS Base, SUM(East) AS East, SUM(South) AS South, MAX(T_HotSpot) 
                      AS T_HotSpot, MAX(T_HotTemperature) AS T_HotTemperature, MAX(Status) AS Status
FROM         (SELECT     MeasurementKey, AOI, [North] AS North, [West] AS West, [Base] AS Base, [East] AS East, [South] AS South, T_HotSpot, T_HotTemperature, 
                                              Status
                       FROM          (SELECT DISTINCT 
                                                                      dbo.MeasurementDataView.Max, dbo.MeasurementThresholds.MaxTempDet AS T_HotSpot, 
                                                                      dbo.MeasurementThresholds.HotTempDet AS T_HotTemperature, dbo.MeasurementResultStatusByAOIView.Status, 
                                                                      dbo.CrosstabAOIBySourceByMeasurementKey.MeasurementKey, dbo.CrosstabAOIBySourceByMeasurementKey.Source, 
                                                                      dbo.CrosstabAOIBySourceByMeasurementKey.AOI
                                               FROM          dbo.MeasurementDataView RIGHT OUTER JOIN
                                                                      dbo.MeasurementThresholds RIGHT OUTER JOIN
                                                                      dbo.CrosstabAOIBySourceByMeasurementKey INNER JOIN
                                                                      dbo.MeasurementResultStatusByAOIView ON 
                                                                      dbo.CrosstabAOIBySourceByMeasurementKey.MeasurementKey = dbo.MeasurementResultStatusByAOIView.MeasurementKey AND
                                                                       dbo.CrosstabAOIBySourceByMeasurementKey.AOI = dbo.MeasurementResultStatusByAOIView.AOI ON 
                                                                      dbo.MeasurementThresholds.AOI = dbo.CrosstabAOIBySourceByMeasurementKey.AOI AND 
                                                                      dbo.MeasurementThresholds.MeasurementKey = dbo.CrosstabAOIBySourceByMeasurementKey.MeasurementKey ON 
                                                                      dbo.MeasurementDataView.MeasurementKey = dbo.CrosstabAOIBySourceByMeasurementKey.MeasurementKey AND 
                                                                      dbo.MeasurementDataView.Source = dbo.CrosstabAOIBySourceByMeasurementKey.Source AND 
                                                                      dbo.MeasurementDataView.AOI = dbo.CrosstabAOIBySourceByMeasurementKey.AOI) ps PIVOT (SUM(Max) FOR 
                                              Source IN ([North], [West], [Base], [East], [South])) AS pvt) AS Mainqry
GROUP BY MeasurementKey, AOI
GO
/****** Object:  Table [dbo].[Crane]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Crane](
	[CraneID] [nvarchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hosts]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hosts](
	[Host] [nvarchar](255) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Language]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Language](
	[LangID] [nvarchar](10) NOT NULL,
	[Language] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Locations]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Locations](
	[Location] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MeasurementStatusText]    Script Date: 09/11/2022 11:40:25 ******/
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
/****** Object:  Table [dbo].[Origin]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Origin](
	[Origin] [nvarchar](50) NOT NULL,
	[GroupID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Query]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Query](
	[MeasurementKey] [bigint] NOT NULL,
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
	[Hostname] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RaceNrMap]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RaceNrMap](
	[LadleCampaign] [int] IDENTITY(1,1) NOT NULL,
	[RaceNumber] [nchar](20) NOT NULL,
 CONSTRAINT [PK_RaceNrMap] PRIMARY KEY CLUSTERED 
(
	[LadleCampaign] ASC,
	[RaceNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusFilter2Config]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusFilter2Config](
	[Hostname] [nvarchar](255) NOT NULL,
	[Location] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_StatusFilter2Config] PRIMARY KEY CLUSTERED 
(
	[Hostname] ASC,
	[Location] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusFilterConfig]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusFilterConfig](
	[Hostname] [nvarchar](255) NOT NULL,
	[CraneID] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_StatusFilterConfig] PRIMARY KEY CLUSTERED 
(
	[Hostname] ASC,
	[CraneID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TemplateMatchs]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TemplateMatchs](
	[MeasurementKey] [bigint] NOT NULL,
	[ZoneID] [nchar](10) NULL,
	[MatchIndex] [int] NULL,
	[MatchValue] [float] NULL,
	[ShiftX] [int] NULL,
	[ShiftY] [int] NULL,
 CONSTRAINT [PK_TemplateMatchs] PRIMARY KEY CLUSTERED 
(
	[MeasurementKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_get_status_by_aoi_overview]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_get_status_by_aoi_overview]
	-- Add the parameters for the stored procedure here
	@LadleID int,
	@LadleCampaign int
AS
BEGIN

	declare @userData TABLE(
		MeasurementKey bigint NOT NULL,
		LadleID int NULL,
		LadleCampaign int NULL,
		LadleAge int NULL,
		[Time] datetime NOT NULL,
		HeatNumber int NULL,
		Location nvarchar(10) NULL,
		Origin nvarchar(10) NULL,
		FerrotronNumber int NULL,
		[Top] int NULL,
		Middle int NULL,
		Bottom int NULL,
		Base int NULL,
		Nozzle int NULL
	)

	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO @userData
	SELECT [MeasurementKey], [LadleID], [LadleCampaign], [LadleAge], [Time], [HeatNumber], [Location], [Origin], [FerrotronNumber], [Top], [Middle], [Bottom], [Base], [Nozzle]
	FROM dbo.MeasurementResultStatusByAOIOverview


	IF (@LadleCampaign > -1)
		SELECT * FROM @userData
		WHERE [LadleID] = @LadleID AND [LadleCampaign] = @LadleCampaign
		ORDER BY [Time] DESC
	ELse
		SELECT * FROM @userData
		WHERE [LadleID] = @LadleID
		ORDER BY [Time] DESC
END
GO
/****** Object:  StoredProcedure [dbo].[sp_get_status_by_aoi_overview2]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_get_status_by_aoi_overview2]
	-- Add the parameters for the stored procedure here
	@LadleID int,
	@LadleCampaign int,
	@FilterCond nvarchar(MAX),
	@MaxRowCount int
AS
BEGIN

DECLARE @WhereCond nvarchar(MAX) = '(LadleID IS NOT NULL)'

IF @LadleID >= 0
	SET @WhereCond = @WhereCond + ' AND ([LadleID] = @LadleID)'

if @LadleCampaign >= 0
	SET @WhereCond = @WhereCond + ' AND ([LadleCampaign] = @LadleCampaign)'

IF @FilterCond IS NULL OR @FilterCond = ''
	SET @FilterCond = '((TestMode IS NULL) OR (TestMode = 0))'

SET @WhereCond = @WhereCond + ' AND ' + @FilterCond


DECLARE @Limit nvarchar(MAX) = ''

IF @MaxRowCount >= 0
BEGIN
	SET @Limit = 'TOP(' + CONVERT( varchar(80), @MaxRowCount ) + ')'
	SET @WhereCond = @WhereCond + ' ORDER BY MeasurementKey DESC'
END

DECLARE @Keys TABLE(
		[MeasurementKey] bigint NOT NULL
	)

	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

DECLARE @cmd nvarchar(MAX) =
'SELECT ' + @Limit
+ ' MeasurementKey FROM dbo.Measurements WHERE '
+ @WhereCond

INSERT INTO @Keys
EXEC sp_executesql @cmd, N'@LadleID int, @LadleCampaign int', @LadleID, @LadleCampaign


SELECT Keys.MeasurementKey, 
	   LadleID, LadleAge, [Time], LadleType, LadleCampaign, [Location], CraneID,
	   Origin, CalcHeatContent, HeatNumber, FerrotronNumber, 
	   [Top], Middle, Bottom, Base, Nozzle
FROM (dbo.Measurements
	  INNER JOIN @Keys AS Keys ON Keys.MeasurementKey=dbo.Measurements.MeasurementKey
	 )
	 LEFT JOIN 
	 (SELECT sub.MeasurementKey, 2 * sub.Alarm + sub.Prealarm AS [Top]
	  FROM (SELECT sub.MeasurementKey, MAX(sub.Alarm) AS Alarm, MAX(sub.Prealarm) AS Prealarm
			FROM  (SELECT Keys.MeasurementKey, Alarm, Prealarm
				   FROM	dbo.MeasurementResults
						INNER JOIN @Keys AS Keys ON Keys.MeasurementKey=dbo.MeasurementResults.MeasurementKey
						INNER JOIN dbo.AOIPathLoc ON dbo.MeasurementResults.Source=EvalPath AND AOIID='Top'
				  ) AS sub
			GROUP BY sub.MeasurementKey
		   ) AS sub
	 ) AS subTop ON subTop.MeasurementKey=Measurements.MeasurementKey
	 LEFT JOIN 
	 (SELECT sub.MeasurementKey, 2 * sub.Alarm + sub.Prealarm AS [Middle]
	  FROM (SELECT sub.MeasurementKey, MAX(sub.Alarm) AS Alarm, MAX(sub.Prealarm) AS Prealarm
			FROM  (SELECT Keys.MeasurementKey, Alarm, Prealarm
				   FROM	dbo.MeasurementResults
						INNER JOIN @Keys AS Keys ON Keys.MeasurementKey=dbo.MeasurementResults.MeasurementKey
						INNER JOIN dbo.AOIPathLoc ON dbo.MeasurementResults.Source=EvalPath AND AOIID='Middle'
				  ) AS sub
			GROUP BY sub.MeasurementKey
		   ) AS sub
	 ) AS subMiddle ON subMiddle.MeasurementKey=Measurements.MeasurementKey
	 LEFT JOIN 
	 (SELECT sub.MeasurementKey, 2 * sub.Alarm + sub.Prealarm AS [Bottom]
	  FROM (SELECT sub.MeasurementKey, MAX(sub.Alarm) AS Alarm, MAX(sub.Prealarm) AS Prealarm
			FROM  (SELECT Keys.MeasurementKey, Alarm, Prealarm
				   FROM	dbo.MeasurementResults
						INNER JOIN @Keys AS Keys ON Keys.MeasurementKey=dbo.MeasurementResults.MeasurementKey
						INNER JOIN dbo.AOIPathLoc ON dbo.MeasurementResults.Source=EvalPath AND AOIID='Bottom'
				  ) AS sub
			GROUP BY sub.MeasurementKey
		   ) AS sub
	 ) AS subBottom ON subBottom.MeasurementKey=Measurements.MeasurementKey
	 LEFT JOIN 
	 (SELECT sub.MeasurementKey, 2 * sub.Alarm + sub.Prealarm AS [Base]
	  FROM (SELECT sub.MeasurementKey, MAX(sub.Alarm) AS Alarm, MAX(sub.Prealarm) AS Prealarm
			FROM  (SELECT Keys.MeasurementKey, Alarm, Prealarm
				   FROM	dbo.MeasurementResults
					   INNER JOIN @Keys AS Keys ON Keys.MeasurementKey=dbo.MeasurementResults.MeasurementKey
					   INNER JOIN dbo.AOIPathLoc ON dbo.MeasurementResults.Source=EvalPath AND AOIID='Base'
				  ) AS sub
			GROUP BY sub.MeasurementKey
		   ) AS sub
	 ) AS subBase ON subBase.MeasurementKey=Measurements.MeasurementKey
	 LEFT JOIN 
	 (SELECT sub.MeasurementKey, 2 * sub.Alarm + sub.Prealarm AS [Nozzle]
	  FROM (SELECT sub.MeasurementKey, MAX(sub.Alarm) AS Alarm, MAX(sub.Prealarm) AS Prealarm
			FROM  (SELECT Keys.MeasurementKey, Alarm, Prealarm
				   FROM	dbo.MeasurementResults
						INNER JOIN @Keys AS Keys ON Keys.MeasurementKey=dbo.MeasurementResults.MeasurementKey
						INNER JOIN dbo.AOIPathLoc ON dbo.MeasurementResults.Source=EvalPath AND AOIID='Nozzle'
				  ) AS sub
			GROUP BY sub.MeasurementKey
		   ) AS sub
	 ) AS subNozzle ON subNozzle.MeasurementKey=Measurements.MeasurementKey
ORDER BY MeasurementKey DESC 

END


GO
/****** Object:  StoredProcedure [dbo].[sp_get_status_by_aoi_overview3]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[sp_get_status_by_aoi_overview3]
	-- Add the parameters for the stored procedure here
	@LadleID int,
	@RaceNumber nvarchar(MAX),
	@FilterCond nvarchar(MAX),
	@MaxRowCount int
AS
BEGIN

DECLARE @WhereCond nvarchar(MAX) = '(LadleID IS NOT NULL)'

IF @LadleID >= 0
	SET @WhereCond = @WhereCond + ' AND ([LadleID] = @LadleID)'

if @RaceNumber <> ''
	SET @WhereCond = @WhereCond + ' AND ([RaceNumber] = @RaceNumber)'

IF @FilterCond IS NULL OR @FilterCond = ''
	SET @FilterCond = '((TestMode IS NULL) OR (TestMode = 0))'

SET @WhereCond = @WhereCond + ' AND ' + @FilterCond


DECLARE @Limit nvarchar(MAX) = ''

IF @MaxRowCount >= 0
BEGIN
	SET @Limit = 'TOP(' + CONVERT( varchar(80), @MaxRowCount ) + ')'
	SET @WhereCond = @WhereCond + ' ORDER BY MeasurementKey DESC'
END

DECLARE @Keys TABLE(
		[MeasurementKey] bigint NOT NULL
	)

	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

DECLARE @cmd nvarchar(MAX) =
'SELECT ' + @Limit
+ ' MeasurementKey FROM dbo.Measurements WHERE '
+ @WhereCond

INSERT INTO @Keys
EXEC sp_executesql @cmd, N'@LadleID int, @RaceNumber nvarchar(MAX)', @LadleID, @RaceNumber


SELECT Keys.MeasurementKey, 
	   LadleID, LadleAge, [Time], LadleType, LadleCampaign, [Location], CraneID,
	   Origin, CalcHeatContent, HeatNumber, FerrotronNumber, 
	   [Top], Middle, Bottom, Base, Nozzle,
	   RaceNumber
FROM (dbo.Measurements
	  INNER JOIN @Keys AS Keys ON Keys.MeasurementKey=dbo.Measurements.MeasurementKey
	 )
	 LEFT JOIN 
	 (SELECT sub.MeasurementKey, 2 * sub.Alarm + sub.Prealarm AS [Top]
	  FROM (SELECT sub.MeasurementKey, MAX(sub.Alarm) AS Alarm, MAX(sub.Prealarm) AS Prealarm
			FROM  (SELECT Keys.MeasurementKey, Alarm, Prealarm
				   FROM	dbo.MeasurementResults
						INNER JOIN @Keys AS Keys ON Keys.MeasurementKey=dbo.MeasurementResults.MeasurementKey
						INNER JOIN dbo.AOIPathLoc ON dbo.MeasurementResults.Source=EvalPath AND AOIID='Top'
				  ) AS sub
			GROUP BY sub.MeasurementKey
		   ) AS sub
	 ) AS subTop ON subTop.MeasurementKey=Measurements.MeasurementKey
	 LEFT JOIN 
	 (SELECT sub.MeasurementKey, 2 * sub.Alarm + sub.Prealarm AS [Middle]
	  FROM (SELECT sub.MeasurementKey, MAX(sub.Alarm) AS Alarm, MAX(sub.Prealarm) AS Prealarm
			FROM  (SELECT Keys.MeasurementKey, Alarm, Prealarm
				   FROM	dbo.MeasurementResults
						INNER JOIN @Keys AS Keys ON Keys.MeasurementKey=dbo.MeasurementResults.MeasurementKey
						INNER JOIN dbo.AOIPathLoc ON dbo.MeasurementResults.Source=EvalPath AND AOIID='Middle'
				  ) AS sub
			GROUP BY sub.MeasurementKey
		   ) AS sub
	 ) AS subMiddle ON subMiddle.MeasurementKey=Measurements.MeasurementKey
	 LEFT JOIN 
	 (SELECT sub.MeasurementKey, 2 * sub.Alarm + sub.Prealarm AS [Bottom]
	  FROM (SELECT sub.MeasurementKey, MAX(sub.Alarm) AS Alarm, MAX(sub.Prealarm) AS Prealarm
			FROM  (SELECT Keys.MeasurementKey, Alarm, Prealarm
				   FROM	dbo.MeasurementResults
						INNER JOIN @Keys AS Keys ON Keys.MeasurementKey=dbo.MeasurementResults.MeasurementKey
						INNER JOIN dbo.AOIPathLoc ON dbo.MeasurementResults.Source=EvalPath AND AOIID='Bottom'
				  ) AS sub
			GROUP BY sub.MeasurementKey
		   ) AS sub
	 ) AS subBottom ON subBottom.MeasurementKey=Measurements.MeasurementKey
	 LEFT JOIN 
	 (SELECT sub.MeasurementKey, 2 * sub.Alarm + sub.Prealarm AS [Base]
	  FROM (SELECT sub.MeasurementKey, MAX(sub.Alarm) AS Alarm, MAX(sub.Prealarm) AS Prealarm
			FROM  (SELECT Keys.MeasurementKey, Alarm, Prealarm
				   FROM	dbo.MeasurementResults
					   INNER JOIN @Keys AS Keys ON Keys.MeasurementKey=dbo.MeasurementResults.MeasurementKey
					   INNER JOIN dbo.AOIPathLoc ON dbo.MeasurementResults.Source=EvalPath AND AOIID='Base'
				  ) AS sub
			GROUP BY sub.MeasurementKey
		   ) AS sub
	 ) AS subBase ON subBase.MeasurementKey=Measurements.MeasurementKey
	 LEFT JOIN 
	 (SELECT sub.MeasurementKey, 2 * sub.Alarm + sub.Prealarm AS [Nozzle]
	  FROM (SELECT sub.MeasurementKey, MAX(sub.Alarm) AS Alarm, MAX(sub.Prealarm) AS Prealarm
			FROM  (SELECT Keys.MeasurementKey, Alarm, Prealarm
				   FROM	dbo.MeasurementResults
						INNER JOIN @Keys AS Keys ON Keys.MeasurementKey=dbo.MeasurementResults.MeasurementKey
						INNER JOIN dbo.AOIPathLoc ON dbo.MeasurementResults.Source=EvalPath AND AOIID='Nozzle'
				  ) AS sub
			GROUP BY sub.MeasurementKey
		   ) AS sub
	 ) AS subNozzle ON subNozzle.MeasurementKey=Measurements.MeasurementKey
ORDER BY MeasurementKey DESC 

END


GO
/****** Object:  StoredProcedure [dbo].[sp_ir_cleanup_all_measurement_data]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_ir_cleanup_all_measurement_data]
AS
BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

DELETE FROM [dbo].[Measurements]
DELETE FROM [dbo].[MeasurementResultImages]
DELETE FROM [dbo].[MeasurementResults]
DELETE FROM [dbo].[MeasurementThresholds]
DELETE FROM [dbo].[SystemLog]

END
GO
/****** Object:  StoredProcedure [dbo].[sp_ir_database_cleanup_expired_data]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[sp_ir_database_cleanup_expired_data]
	@expireDate		datetime,
	@host			nvarchar(MAX),
	@tooId			int,
	@onlyTestData	int
AS
BEGIN

/*
	@tooId hier ungenutzt genutzt
*/
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

DELETE MeasurementThresholds FROM dbo.MeasurementThresholds
	INNER JOIN dbo.Measurements ON Measurements.MeasurementKey=MeasurementThresholds.MeasurementKey
	WHERE Measurements.[Time]<@expireDate 
		  AND Measurements.Hostname=@host 
		  AND (@onlyTestData=0 OR Measurements.TestMode=1)


DELETE MeasurementResultImages FROM dbo.MeasurementResultImages
	INNER JOIN dbo.Measurements ON Measurements.MeasurementKey=MeasurementResultImages.MeasurementKey
	WHERE Measurements.[Time]<@expireDate 
		  AND Measurements.Hostname=@host 
		  AND (@onlyTestData=0 OR Measurements.TestMode=1)


DELETE MeasurementResults FROM dbo.MeasurementResults
	INNER JOIN dbo.Measurements ON Measurements.MeasurementKey=MeasurementResults.MeasurementKey
	WHERE Measurements.[Time]<@expireDate 
		  AND Measurements.Hostname=@host 
		  AND (@onlyTestData=0 OR Measurements.TestMode=1)


DELETE FROM dbo.Measurements
	WHERE [Time]<@expireDate 
		  AND Hostname=@host 
		  AND (@onlyTestData=0 OR Measurements.TestMode=1)


DELETE FROM [dbo].[SystemLog]
	WHERE [Time]<@expireDate 
		  AND [Hostname]=@host
		  AND @onlyTestData=0

END
GO
/****** Object:  StoredProcedure [dbo].[spMEMT_UpdateMeasurement]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ====================================================================================================
-- Author:		Davi Hilário 
-- Create date: 18/07/2022
-- Description:	Lê os dados da tabela remota ([VM-MEMT-14\CSPNIVEL02].[EXT].[dbo].[TB_EXT_LD_INFO]) e
--              efetua a gravação incremental na tabela local (SIMT1..Measurements)
--              o campo Data/Hora é utilizado para sincronismo entre as Tabelas.
--              Rotina de execução:
--              1) Conversão/Compatibilidade de Tipo de Dados
--              2) Pesquisa dados a serem adicionados pela Data
--              3) Insere na tabela de destino
-- ===================================================================================================
CREATE PROCEDURE [dbo].[spMEMT_UpdateMeasurement]
AS
BEGIN
	SET NOCOUNT ON;
	;WITH CTE(Time,LadleID,RaceNumber,LadleAge,Origin,LadleType,LadleDescription,Location,CraneID) as (
       SELECT 
	     CAST(SUBSTRING(cTim,1,4)+'-'+SUBSTRING(cTim,5,2)+'-'+SUBSTRING(cTim,7,2)+' '+SUBSTRING(cTim,9,2)+':'+SUBSTRING(cTim,11,2)+':'+SUBSTRING(cTim,13,2) AS DATETIME) as dTime	--Time
         ,CAST([nLdNo] AS int)																																						--LadleID
         ,CAST([cHeatNo] AS char(6))																																				--RaceNumber
         ,CAST([nUseCnt] AS int)																																					--LadleAge
         ,CAST([cWayCode] AS nvarchar(10))																																			--Origin
		 ,CAST([GroupID] AS int)																																					--LadleType
		 ,CAST((CASE [GroupID] WHEN 1 THEN 'Charging Ladle' WHEN 2 THEN 'Teeming Ladle' WHEN 3 THEN 'Teeming Ladle' END) AS nvarchar(20))												--LadleDescription
		 ,CAST((CASE [GroupID] WHEN 1 THEN 'SIMTA' WHEN 2 THEN 'SIMTB' WHEN 3 THEN 'SIMTC' END) AS nvarchar(10))																		--Location 
		 ,CAST((CASE [GroupID] WHEN 1 THEN ' 450T_80T_CRANE_SIMTA' WHEN 2 THEN ' 450T_80T_CRANE_SIMTB' WHEN 3 THEN ' 450T_80T_CRANE_SIMTC' END) AS nvarchar(50))						--CraneID
       FROM [VM-MEMT-14\CSPNIVEL02].[EXT].[dbo].[TB_EXT_LD_INFO] I
	   INNER JOIN [SIMT1].[dbo].[Origin] O on O.Origin = I.cWayCode
	   )

    --insert into SIMT1..Measurements(Time,LadleID,RaceNumber,LadleAge,Origin,LadleType,LadleDescription,Location,CraneID)
    SELECT Time,LadleID,RaceNumber,LadleAge,Origin,LadleType,LadleDescription,Location,CraneID from CTE --Where Time > (select top 1 Time from SIMT1..Measurements order by Time DESC)
END
GO
/****** Object:  DdlTrigger [ddlDatabaseTriggerLog]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [ddlDatabaseTriggerLog] 
ON DATABASE 
FOR DDL_DATABASE_LEVEL_EVENTS 
AS 
BEGIN
    SET NOCOUNT ON;

    DECLARE @data XML;
    DECLARE @schema sysname;
    DECLARE @object sysname;
    DECLARE @eventType sysname;
    declare @db_id int;
    declare @db_name sysname;

	select @db_id = db_id();
    select @db_name = db_name();

    SET @data = EVENTDATA();
    SET @eventType = @data.value('(/EVENT_INSTANCE/EventType)[1]', 'sysname');
    SET @schema = @data.value('(/EVENT_INSTANCE/SchemaName)[1]', 'sysname');
    SET @object = @data.value('(/EVENT_INSTANCE/ObjectName)[1]', 'sysname') 

    IF @object IS NOT NULL
        PRINT '  ' + @eventType + ' - ' + @schema + '.' + @object;
    ELSE
        PRINT '  ' + @eventType + ' - ' + @schema;

    IF @eventType IS NULL
        PRINT CONVERT(nvarchar(max), @data);
    if @eventType not like '%statistics%'
		INSERT [admin].[dbo].[T_ATechDatabaseLog] 
        ([DatabaseID],
         [DatabaseName],
        [PostTime], 
        [DatabaseUser], 
        [Event], 
        [Schema], 
        [Object], 
        [TSQL], 
        [XmlEvent]
        ) 
    VALUES 
        (@db_id,
         @db_name,
        GETDATE(), 
        CONVERT(sysname, CURRENT_USER), 
        @eventType, 
        CONVERT(sysname, @schema), 
        CONVERT(sysname, @object), 
        @data.value('(/EVENT_INSTANCE/TSQLCommand)[1]', 'nvarchar(max)'), 
        @data
        );
END;




GO
DISABLE TRIGGER [ddlDatabaseTriggerLog] ON DATABASE
GO
/****** Object:  DdlTrigger [ddlDatabaseTriggerNonSA]    Script Date: 09/11/2022 11:40:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- Restrict DDL to Func and Sproc for non-sa
CREATE TRIGGER [ddlDatabaseTriggerNonSA] 
ON DATABASE 
FOR DDL_DATABASE_LEVEL_EVENTS 
AS 
-- Restrict DDL to Func and Sproc for non-sa
BEGIN
    SET NOCOUNT ON;

    DECLARE @data XML;
    DECLARE @schema sysname;
    DECLARE @object sysname;
    DECLARE @eventtype sysname;
    DECLARE @objecttype sysname;
    declare @db_id int;
    declare @db_name sysname;

	select @db_id = db_id();
    select @db_name = db_name();
    
    SET @data = EVENTDATA();
    SET @eventtype = @data.value('(/EVENT_INSTANCE/EventType)[1]', 'sysname');
    SET @objecttype = @data.value('(/EVENT_INSTANCE/ObjectType)[1]', 'sysname');
    SET @schema = @data.value('(/EVENT_INSTANCE/SchemaName)[1]', 'sysname');
    SET @object = @data.value('(/EVENT_INSTANCE/ObjectName)[1]', 'sysname') 

    IF @object IS NOT NULL
        PRINT '  ' + @eventtype + ' - ' + @schema + '.' + @object;
    ELSE
        PRINT '  ' + @eventtype + ' - ' + @schema;

    IF @eventtype IS NULL
        PRINT CONVERT(nvarchar(max), @data);

    IF not ( @eventtype LIKE '%function%'
			OR @eventtype LIKE '%procedure%' )
        and
       not (@eventtype = 'Grant_Database' and (@objecttype = 'procedure' or @objecttype = 'function'))
      
      BEGIN 
       IF (SUSER_SNAME() <> 'DOSIM000\Mgr.Rad')		
         BEGIN 
         IF (IS_SRVROLEMEMBER ('sysadmin') = 0)
         BEGIN
           RAISERROR ('You are not entitled to perform this modification [d]' , 1,1,@eventtype) WITH log
           ROLLBACK TRAN            
         END 
		 END
      END
    if @eventtype not like '%statistics%'
     INSERT [admin].[dbo].[T_ATechDatabaseLog] 
        ([DatabaseID],
         [DatabaseName],
        [PostTime], 
        [DatabaseUser], 
        [Event], 
        [Schema], 
        [Object], 
        [TSQL], 
        [XmlEvent]
        ) 
    VALUES 
         (@db_id,
         @db_name,
        GETDATE(), 
        CONVERT(sysname, CURRENT_USER), 
        @eventtype, 
        CONVERT(sysname, @schema), 
        CONVERT(sysname, @object), 
        @data.value('(/EVENT_INSTANCE/TSQLCommand)[1]', 'nvarchar(max)'), 
        @data
        );
END;







GO
DISABLE TRIGGER [ddlDatabaseTriggerNonSA] ON DATABASE
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Database trigger to Restrict DDL to Func and Sproc for non-sa.' , @level0type=N'TRIGGER',@level0name=N'ddlDatabaseTriggerNonSA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "AOILoc"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 123
               Right = 192
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'AOI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'AOI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4[30] 2[40] 3) )"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 3
   End
   Begin DiagramPane = 
      PaneHidden = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 5
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ConnectedHardware'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ConnectedHardware'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4[30] 2[40] 3) )"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 3
   End
   Begin DiagramPane = 
      PaneHidden = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'CrosstabAOIBySourceByMeasurementKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'CrosstabAOIBySourceByMeasurementKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[42] 4[7] 2[38] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -384
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DiffTemperatureDetectionView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DiffTemperatureDetectionView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[25] 4[27] 2[30] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -672
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'HotTemperatureDetectionView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'HotTemperatureDetectionView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[52] 4[6] 2[35] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Measurements"
            Begin Extent = 
               Top = 154
               Left = 183
               Bottom = 405
               Right = 392
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MeasurementResults"
            Begin Extent = 
               Top = 153
               Left = 617
               Bottom = 408
               Right = 825
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MeasurementResultImages"
            Begin Extent = 
               Top = 13
               Left = 424
               Bottom = 131
               Right = 588
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "AOILoc"
            Begin Extent = 
               Top = 36
               Left = 0
               Bottom = 136
               Right = 154
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SourceLoc"
            Begin Extent = 
               Top = 161
               Left = 0
               Bottom = 261
               Right = 154
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 3900
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
     ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MeasurementDataView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'    Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MeasurementDataView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MeasurementDataView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MeasurementResultStatusByAOIOverview'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MeasurementResultStatusByAOIOverview'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "MeasurementDataView"
            Begin Extent = 
               Top = 13
               Left = 462
               Bottom = 276
               Right = 719
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "CrosstabAOIBySourceByMeasurementKey"
            Begin Extent = 
               Top = 61
               Left = 114
               Bottom = 181
               Right = 294
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MeasurementResultStatusByAOIView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MeasurementResultStatusByAOIView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "MeasurementDataView"
            Begin Extent = 
               Top = 8
               Left = 444
               Bottom = 264
               Right = 675
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CrosstabAOIBySourceByMeasurementKey"
            Begin Extent = 
               Top = 21
               Left = 104
               Bottom = 126
               Right = 284
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MeasurementResultStatusBySourceView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MeasurementResultStatusBySourceView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[28] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Measurements"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 233
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MeasurementResults"
            Begin Extent = 
               Top = 6
               Left = 285
               Bottom = 268
               Right = 537
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MeasurementResultStatusView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MeasurementResultStatusView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "subqry"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 84
               Right = 201
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Measurements_1"
            Begin Extent = 
               Top = 6
               Left = 239
               Bottom = 211
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 9
         End
         Begin Table = "MeasurementStatus"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 84
               Right = 605
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MeasurementStatusView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MeasurementStatusView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "SourceLoc"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 106
               Right = 192
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Source'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Source'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ConnectedHardware_1"
            Begin Extent = 
               Top = 6
               Left = 243
               Bottom = 99
               Right = 410
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "subqry"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 114
               Right = 205
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'SystemStatusView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'SystemStatusView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[42] 4[12] 2[21] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "MeasurementDataView"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 307
               Right = 224
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SourceLoc"
            Begin Extent = 
               Top = 0
               Left = 317
               Bottom = 100
               Right = 487
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "AOILoc"
            Begin Extent = 
               Top = 208
               Left = 312
               Bottom = 308
               Right = 482
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "MeasurementDataView"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 228
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_2'
GO
