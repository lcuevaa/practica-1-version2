Imports capaDatos

Public Class CNMarca

    Function listarMarca() As DataTable
        Try
            Dim marca As New CDMarca
            Return marca.listarMarca()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
