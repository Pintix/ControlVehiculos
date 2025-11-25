Imports System.Data.SqlClient

Public Class dbVehiculo
    Private ReadOnly dbHelper As New DbHelper()

    Public Function Create(vehiculo As Vehiculo) As String
        Try
            Dim sql As String = "INSERT INTO Vehiculos (IdPropietario, Placa, Marca, Modelo) " &
                                "VALUES (@IdPropietario, @Placa, @Marca, @Modelo)"

            Dim parametros As New List(Of SqlParameter) From {
                New SqlParameter("@IdPropietario", vehiculo.IdPropietario),
                New SqlParameter("@Placa", If(String.IsNullOrEmpty(vehiculo.Placa), DBNull.Value, vehiculo.Placa)),
                New SqlParameter("@Marca", If(String.IsNullOrEmpty(vehiculo.Marca), DBNull.Value, vehiculo.Marca)),
                New SqlParameter("@Modelo", If(String.IsNullOrEmpty(vehiculo.Modelo), DBNull.Value, vehiculo.Modelo))
            }

            dbHelper.ExecuteNonQuery(sql, parametros)

            Return "Vehículo guardado correctamente"

        Catch ex As Exception
            Return "Error al guardar el vehículo: " & ex.Message
        End Try
    End Function
End Class
