Imports System.Data.SqlClient

Public Class dbPropietario
    Private ReadOnly dbHelper = New DbHelper() ' Clase para manejar conexiones y consultas
    Public Function Create(propietario As Propietario) As String
        Try
            Dim sql As String = "INSERT INTO Propietarios (IdPersona, Vehiculos) VALUES (@IdPersona, @Vehiculos)"

            Dim parametros As New List(Of SqlParameter) From {
                New SqlParameter("@IdPersona", propietario.IdPersona),
                New SqlParameter("@Vehiculos", If(propietario.NumVehiculos, DBNull.Value))
            }

            dbHelper.ExecuteNonQuery(sql, parametros)

            Return "Propietario guardado correctamente"

        Catch ex As Exception
            Return "Error al guardar el propietario: " & ex.Message
        End Try
    End Function
End Class