Public Class CEAuto
    Private id As Integer
    Private placa As String
    Private idModelo As Integer
    Private color As String
    Private potenciaMotor As String
    Private cilindrada As String
    Private numAsientos As Integer
    Private peso As Decimal
    Private idCombustible As Integer
    Private idMarca As Integer
    Private estado As Char
    Private precioVenta As Decimal
    Private foto As String

    Public Sub New()
    End Sub

    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Placa1 As String
        Get
            Return placa
        End Get
        Set(value As String)
            placa = value
        End Set
    End Property

    Public Property IdModelo1 As Integer
        Get
            Return idModelo
        End Get
        Set(value As Integer)
            idModelo = value
        End Set
    End Property

    Public Property Color1 As String
        Get
            Return color
        End Get
        Set(value As String)
            color = value
        End Set
    End Property

    Public Property PotenciaMotor1 As String
        Get
            Return potenciaMotor
        End Get
        Set(value As String)
            potenciaMotor = value
        End Set
    End Property

    Public Property Cilindrada1 As String
        Get
            Return cilindrada
        End Get
        Set(value As String)
            cilindrada = value
        End Set
    End Property

    Public Property NumAsientos1 As Integer
        Get
            Return numAsientos
        End Get
        Set(value As Integer)
            numAsientos = value
        End Set
    End Property

    Public Property Peso1 As Decimal
        Get
            Return peso
        End Get
        Set(value As Decimal)
            peso = value
        End Set
    End Property

    Public Property IdCombustible1 As Integer
        Get
            Return idCombustible
        End Get
        Set(value As Integer)
            idCombustible = value
        End Set
    End Property

    Public Property IdMarca1 As Integer
        Get
            Return idMarca
        End Get
        Set(value As Integer)
            idMarca = value
        End Set
    End Property

    Public Property Estado1 As Char
        Get
            Return estado
        End Get
        Set(value As Char)
            estado = value
        End Set
    End Property

    Public Property PrecioVenta1 As Decimal
        Get
            Return precioVenta
        End Get
        Set(value As Decimal)
            precioVenta = value
        End Set
    End Property

    Public Property Foto1 As String
        Get
            Return foto
        End Get
        Set(value As String)
            foto = value
        End Set
    End Property
End Class
