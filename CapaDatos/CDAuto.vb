Imports System.Data.SqlClient
Imports CapaEntidades

Public Class CDAuto
    Inherits CDConexion

    Public Function ListarAutos() As DataTable
        Dim data As New DataTable
        Dim con As New CDConexion
        Dim da As New SqlDataAdapter("sp_listarAutos", con.SqlCon1)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(data)
        Return data
    End Function

    Public Function buscarAuto(placa As String)
        Dim con As New CDConexion
        Dim com As New SqlCommand("sp_buscarAuto", con.SqlCon1)
        Dim res As SqlDataReader
        Dim tabla As New DataTable

        com.CommandType = CommandType.StoredProcedure
        com.Parameters.Add("@placa", SqlDbType.VarChar).Value = placa

        con.SqlCon1.Open()
        res = com.ExecuteReader()
        tabla.Load(res)

        con.SqlCon1.Close()
        Return tabla
    End Function

    Public Sub registrarAuto(auto As CEAuto)
        Try
            Dim con As New CDConexion
            Dim comando As New SqlCommand("sp_InsertAutomovil", con.SqlCon1)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@IDAuto", SqlDbType.Int).Value = auto.Id1
            comando.Parameters.Add("@Placa", SqlDbType.NVarChar).Value = auto.Placa1
            comando.Parameters.Add("@IDModelo", SqlDbType.Int).Value = auto.IdModelo1
            comando.Parameters.Add("@Color", SqlDbType.VarChar).Value = auto.Color1
            comando.Parameters.Add("@PotenciaMotor", SqlDbType.VarChar).Value = auto.PotenciaMotor1
            comando.Parameters.Add("@Cilindrada", SqlDbType.VarChar).Value = auto.Cilindrada1
            comando.Parameters.Add("@NroAsientos", SqlDbType.TinyInt).Value = auto.NumAsientos1
            comando.Parameters.Add("@Peso", SqlDbType.Float).Value = auto.Peso1
            comando.Parameters.Add("@IDCombustible", SqlDbType.Int).Value = auto.IdCombustible1
            comando.Parameters.Add("@IDMarca", SqlDbType.Int).Value = auto.IdMarca1
            comando.Parameters.Add("@Estado", SqlDbType.Char).Value = auto.Estado1
            comando.Parameters.Add("@PrecioVenta", SqlDbType.Money).Value = auto.PrecioVenta1
            comando.Parameters.Add("@Foto", SqlDbType.VarChar).Value = auto.Foto1

            con.SqlCon1.Open()
            comando.ExecuteNonQuery()
            con.SqlCon1.Close()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub actualizarAuto(auto As CEAuto)
        Try
            Dim con As New CDConexion
            Dim comando As New SqlCommand("ActualizarAuto", con.SqlCon1)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@IDAuto", SqlDbType.Int).Value = auto.Id1
            comando.Parameters.Add("@Placa", SqlDbType.NVarChar).Value = auto.Placa1
            comando.Parameters.Add("@IDModelo", SqlDbType.Int).Value = auto.IdModelo1
            comando.Parameters.Add("@Color", SqlDbType.VarChar).Value = auto.Color1
            comando.Parameters.Add("@PotenciaMotor", SqlDbType.VarChar).Value = auto.PotenciaMotor1
            comando.Parameters.Add("@Cilindrada", SqlDbType.VarChar).Value = auto.Cilindrada1
            comando.Parameters.Add("@NroAsientos", SqlDbType.TinyInt).Value = auto.NumAsientos1
            comando.Parameters.Add("@Peso", SqlDbType.Float).Value = auto.Peso1
            comando.Parameters.Add("@IDCombustible", SqlDbType.Int).Value = auto.IdCombustible1
            comando.Parameters.Add("@IDMarca", SqlDbType.Int).Value = auto.IdMarca1
            comando.Parameters.Add("@Estado", SqlDbType.Char).Value = auto.Estado1
            comando.Parameters.Add("@PrecioVenta", SqlDbType.Money).Value = auto.PrecioVenta1
            comando.Parameters.Add("@Foto", SqlDbType.VarChar).Value = auto.Foto1

            con.SqlCon1.Open()
            comando.ExecuteNonQuery()
            con.SqlCon1.Close()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
