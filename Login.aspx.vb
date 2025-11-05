Imports ControlVehiculos.Utils
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub btnIniciarSesion_Click(sender As Object, e As EventArgs)
        Dim Usuario As String = txtUsuario.Text
        Dim Password As String = txtPassword.Text
        Dim encrypter As New Simple3Des("MiClaveSecreta123") ' Clave secreta para la encriptación
        Dim Pass As String = encrypter.EncryptData(Password) ' Encriptar la contraseña
        Dim dbHelper As New dbLogin()
        Dim isValid As Boolean = dbHelper.ValidateLogin(Usuario, Pass)
        If isValid Then
            ' Inicio de sesión exitoso
            Dim User As Usuario = dbHelper.GetUser(Usuario) ' Obtener el Usuario desde la base de datos
            Session("Usuario") = User ' Guardar el Usuario en la sesión
            If User.Rol = "2" Then
                Response.Redirect("Admin.aspx") ' Redirigir a la página de administración si es admin
                Return
            End If

            Response.Redirect("Home.aspx") ' Redirigir a la página principal después del inicio de sesión
        Else
            ' Credenciales incorrectas
            SwalUtils.ShowSwalError(Me, "Credenciales incorrectas.")
        End If
    End Sub

End Class