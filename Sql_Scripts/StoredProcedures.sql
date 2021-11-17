USE [Crud_App_Esp]
GO

CREATE PROC listado_colaboradores
AS
	SELECT * FROM [dbo].[Colaboradores] ORDER BY [Nombres]
GO

CREATE PROC obtener_colaborador_por_id
@id_colaborador int
AS
	SELECT * FROM [dbo].[Colaboradores] WHERE [ID_Colaborador] = @id_colaborador
GO

CREATE PROC crear_nuevo_colaborador
@nombres nvarchar(50),
@apellidos nvarchar(50),
@fecha_nacimiento datetime,
@estado_civil nvarchar(10),
@grado_academico nvarchar(20),
@direccion nvarchar(200),
@fecha_creacion datetime
AS
	SET @fecha_creacion = GETDATE();

	INSERT INTO [dbo].[Colaboradores]
           ([Nombres]
           ,[Apellidos]
           ,[FechaNacimiento]
           ,[EstadoCivil]
           ,[GradoAcademico]
           ,[Direccion]
           ,[Fecha_Creacion])
     VALUES
           (@nombres
           ,@apellidos
           ,@fecha_nacimiento
           ,@estado_civil
           ,@grado_academico
           ,@direccion
           ,@fecha_creacion)
GO

CREATE PROC actualizar_colaborador_por_id
@id_colaborador int,
@nombres nvarchar(50),
@apellidos nvarchar(50),
@fecha_nacimiento datetime,
@estado_civil nvarchar(10),
@grado_academico nvarchar(20),
@direccion nvarchar(200),
@fecha_modificacion datetime
AS
	SET @fecha_modificacion = GETDATE();

	UPDATE [dbo].[Colaboradores]
	SET [Nombres] = @nombres
      ,[Apellidos] = @apellidos
      ,[FechaNacimiento] = @fecha_nacimiento
      ,[EstadoCivil] = @estado_civil
      ,[GradoAcademico] = @grado_academico
      ,[Direccion] = @direccion
      ,[Fecha_Modificacion] = @fecha_modificacion
	WHERE [ID_Colaborador] = @id_colaborador
GO

CREATE PROC	eliminar_colaborador_por_id
@id_colaborador int
AS	
	DELETE FROM [dbo].[Colaboradores]
      WHERE [ID_Colaborador] = @id_colaborador
GO
