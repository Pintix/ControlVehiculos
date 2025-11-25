Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls

Public Class FormVehiculo
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

    Protected Sub btnGuardarVehiculo_Click(sender As Object, e As EventArgs)
        Dim vehiculo As New Vehiculo()

        ' Validar propietario
        If ddlPersona.SelectedValue = "0" Then
            lblMensajeVehiculo.Text = "Debe seleccionar un propietario."
            Return
        End If
        vehiculo.IdPropietario = Convert.ToInt32(ddlPersona.SelectedValue)

        ' Validar y asignar datos del vehículo
        vehiculo.Placa = If(String.IsNullOrEmpty(txtPlaca.Text.Trim()), "Sin Placa", txtPlaca.Text.Trim())
        vehiculo.Marca = If(String.IsNullOrEmpty(txtMarca.Text.Trim()), "Sin Marca", txtMarca.Text.Trim())
        vehiculo.Modelo = If(String.IsNullOrEmpty(txtModelo.Text.Trim()), "Sin Modelo", txtModelo.Text.Trim())

        ' Guardar en BD
        Dim db As New dbVehiculo()
        lblMensajeVehiculo.Text = db.Create(vehiculo)
    End Sub


End Class
