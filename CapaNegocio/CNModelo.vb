Imports capaDatos

Public Class CNModelo
    Function listarModelo() As DataTable
        Try
            Dim modelo As New CDModelo
            Return modelo.listarModelo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
