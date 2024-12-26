Imports System.Data.SqlClient

Public Class CDModelo
    Public Function listarModelo() As DataTable
        Try
            Dim tabla As New DataTable
            Dim con As New CDConexion
            Dim da As New SqlDataAdapter("sp_listarModelos", con.SqlCon1)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(tabla)
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
