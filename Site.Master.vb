Public Class SiteMaster
    Inherits MasterPage
    Protected Autenticado As Boolean = False
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim Usuario As Usuario = Session("Usuario")
        Autenticado = Usuario IsNot Nothing ' verifica si el usuario está autenticado
        Dim esAdmin As Boolean = Usuario?.Rol = "2" ' verifica si el usuario es admin
        liAdmin.Visible = esAdmin ' muestra el enlace de admin solo si es admin
    End Sub

    Protected Sub Logout_Click1(sender As Object, e As EventArgs)
        Session.Clear()
        Session.Abandon()
        Response.Redirect("Login.aspx")
    End Sub
End Class