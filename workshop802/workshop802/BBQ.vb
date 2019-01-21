Public Class BBQ
    Private _customer As Integer
    Private _price As Integer
    Private _discount As Double

    Public Sub New()
        _customer = 0
        _price = 0
        _discount = 0
    End Sub

    Public Sub New(customer As Integer, price As Integer, discount As Double)
        _customer = customer
        _price = price
        _discount = discount
    End Sub

    '--------------------------------------------------'
    Public Property customer As Integer
        Get
            Return _customer
        End Get
        Set(value As Integer)
            _customer = value
        End Set
    End Property

    Public Property price As Integer
        Get
            Return _price
        End Get
        Set(value As Integer)
            _price = value
        End Set
    End Property

    Public Property discount As Double
        Get
            Return _discount
        End Get
        Set(value As Double)
            _discount = value
        End Set
    End Property
    '--------------------------------------------------'
    Public Function checkppl() As Boolean
        Return _customer <= 0
    End Function
    '--------------------------------------------------------------------'
    Public Function calculate() As Double
        Return _price
    End Function

    Public Function calculate5() As Double
        Return _price - ((_price * 5) / 100)
    End Function


    Public Function calculate10() As Double
        Return _price - ((_price * 10) / 100)
    End Function
End Class