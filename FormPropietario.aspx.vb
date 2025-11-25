Public Class FormPropietario
    Inherits System.Web.UI.Page
    Protected dbHelper As New dbPersona()


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CargarPersonas()
        End If
    End Sub

    Public Sub CargarPersonas()
        ddlPersona.DataSource = dbHelper.Consulta()
        ddlPersona.DataTextField = "NombreCompleto"
        ddlPersona.DataValueField = "IdPersona"
        ddlPersona.DataBind()
        ddlPersona.Items.Insert(0, New ListItem("-- Seleccione una persona --", "0"))
    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs)
        Dim propietario As New Propietario()

        ' Validar que se haya seleccionado una persona
        If ddlPersona.SelectedValue = "0" Then
            lblMensaje.Text = "Debe seleccionar una persona."
            Return
        End If

        propietario.IdPersona = Convert.ToInt32(ddlPersona.SelectedValue)

        ' Validar y asignar número de vehículos
        If String.IsNullOrEmpty(txtVehiculo.Text.Trim()) Then
            propietario.NumVehiculos = "0"  ' Valor por defecto si no se ingresa nada
        Else
            propietario.NumVehiculos = txtVehiculo.Text.Trim()
        End If

        Dim db As New dbPropietario()
        lblMensaje.Text = db.Create(propietario)

    End Sub
End Class