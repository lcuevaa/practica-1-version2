Imports System.Data.SqlClient

Public Class CDConexion
    Private server As String
    Private user As String
    Private base As String
    Private pass As String
    Private sqlCon As SqlConnection

    Public Property Server1 As String
        Get
            Return server
        End Get
        Set(value As String)
            server = value
        End Set
    End Property

    Public Property User1 As String
        Get
            Return user
        End Get
        Set(value As String)
            user = value
        End Set
    End Property

    Public Property Base1 As String
        Get
            Return base
        End Get
        Set(value As String)
            base = value
        End Set
    End Property

    Public Property Pass1 As String
        Get
            Return pass
        End Get
        Set(value As String)
            pass = value
        End Set
    End Property

    Public Property SqlCon1 As SqlConnection
        Get
            Return sqlCon
        End Get
        Set(value As SqlConnection)
            sqlCon = value
        End Set
    End Property

    Public Sub New()

        Me.server = "LAPTOP-QC06Q25L"
        Me.user = ""
        Me.pass = ""
        Me.base = "BDAutos"
        Dim cadena As String

        cadena = "Data source=" & Me.server &
           ";Initial Catalog=" & Me.base &
           ";Integrated security= true;"

        'cadena = Configuration.ConfigurationManager.ConnectionStrings("Datos.My.MySettings.cnConexion").ConnectionString
        Me.SqlCon1 = New SqlConnection(cadena)
    End Sub
End Class
