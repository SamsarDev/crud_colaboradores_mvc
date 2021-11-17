USE [Crud_App_Esp]
GO

/****** Object:  Table [dbo].[Colaboradores]    Script Date: 16/11/2021 19:00:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Colaboradores]') AND type in (N'U'))
DROP TABLE [dbo].[Colaboradores]
GO

/****** Object:  Table [dbo].[Colaboradores]    Script Date: 16/11/2021 19:00:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Colaboradores](
	[ID_Colaborador] [int] IDENTITY(1,1) PRIMARY KEY,
	[Nombres] [nvarchar](50) NOT NULL,
	[Apellidos] [nvarchar](50) NOT NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[EstadoCivil] [nvarchar](10) NULL,
	[GradoAcademico] [nvarchar](20) NULL,
	[Direccion] [nvarchar](200) NULL,
	[Fecha_Creacion] [datetime] NULL,
	[Fecha_Modificacion] [datetime] NULL,
) ON [PRIMARY]
GO


