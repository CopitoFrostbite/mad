USE MAD_PF;

GO

IF OBJECT_ID('spGestionUsuarios') IS NOT NULL
BEGIN
	DROP PROCEDURE spGestionUsuarios;
END;
GO

CREATE PROCEDURE spGestionUsuarios
	(
	@Accion			CHAR(3),
	@ID				INT				=NULL,
	@Usuario		VARCHAR(30)		=NULL,
	@Nombre			VARCHAR(30)		=NULL,
	@Ap_Pat			VARCHAR(30)		=NULL,
	@Ap_Mat			VARCHAR(30)		=NULL,
	@Contrasenia	VARCHAR(30)		=NULL,
	@CURP			VARCHAR(18)		=NULL,
	@F_Nac			DATE			=NULL,
	@Nomina			VARCHAR(30)		=NULL,
	@Correo			VARCHAR(30)		=NULL,
	@Fec_Ing		DATE			=NULL,
	@Nivel_cuenta	BIT				=NULL,
	@Estado			BIT				=NULL
	)
AS
BEGIN
	
	

	IF @Accion = 'IN'
	BEGIN
		SET @Fec_Ing = GETDATE();
		INSERT INTO Usuarios(Usuario,Nombre,Ap_Pat,Ap_Mat,Contrasenia,CURP,F_Nac,Nomina,Correo,Fec_Ing,Nivel_cuenta,Estado)
			VALUES(@Usuario,@Nombre,@Ap_Pat,@Ap_Mat,@Contrasenia,@CURP,@F_Nac,@Nomina,@Correo,@Fec_Ing,@Nivel_cuenta,1)
	END;

	IF @Accion = 'UP'
	BEGIN
		UPDATE Usuarios
			SET
				Usuario			= @Usuario,
				Nombre			= @Nombre,	
				Ap_Pat			= @Ap_Pat,
				Ap_Mat			= @Ap_Mat,
				Contrasenia		= @Contrasenia,
				CURP			= @CURP,
				F_Nac			= @F_Nac,
				Nomina			= @Nomina,
				Correo			= @Correo,
				Fec_Ing			= @Fec_Ing,
				Nivel_cuenta	= @Nivel_cuenta
			WHERE ID			= @ID;			
	END;

	IF @Accion = 'DE'
	BEGIN
		DELETE FROM Usuarios
		WHERE ID = @ID; 
	END;

	IF @Accion = 'BO'
	BEGIN
		UPDATE Usuarios
			SET Estado = 0
		WHERE ID = @ID; 
	END;

	IF @Accion = 'SE'
	BEGIN
		SELECT  ID,Usuario,Nombre,Ap_Pat,Ap_Mat,Contrasenia,CURP,F_Nac,Nomina,Correo,Fec_Ing,Nivel_cuenta,Estado
		FROM Usuarios
		WHERE ID = @ID;
	END;

	IF @Accion = 'SE2'
	BEGIN
		SELECT  ID,Usuario,Nombre,Ap_Pat,Ap_Mat,Contrasenia,CURP,F_Nac,Nomina,Correo,Fec_Ing,Nivel_cuenta,Estado
		FROM Usuarios
		WHERE Estado = 1;
	END;

	IF @Accion = 'SE3'
	BEGIN
		SELECT  Nivel_cuenta
		FROM Usuarios
		WHERE Usuario = @Usuario;
	END;

	IF @Accion = 'SE4'
	BEGIN
		SELECT  ID,Usuario,Nombre,Ap_Pat,Ap_Mat,Contrasenia,CURP,F_Nac,Nomina,Correo,Fec_Ing,Nivel_cuenta,Estado
		FROM Usuarios
	
	END;

	IF @Accion = 'SE5'
	BEGIN
		SELECT  ID,Usuario,Nombre
		FROM viGestionUsuarios
	
	END;
END;
GO