Imports capaDatos

Public Class CNCombustible
    Function listarCombustible() As DataTable
        Try
            Dim combustible As New CDCombustible
            Return combustible.listarCombustible
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
