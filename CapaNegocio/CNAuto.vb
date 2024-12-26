Imports System.Runtime.InteropServices.JavaScript.JSType
Imports capaDatos
Imports capaEntidades

Public Class CNAuto
    Sub registrarAuto(auto As CEAuto)
        Try
            Dim datosAuto As New CDAuto
            datosAuto.registrarAuto(auto)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub actualizarAuto(auto As CEAuto)
        Try
            Dim datosAuto As New CDAuto
            datosAuto.actualizarAuto(auto)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
