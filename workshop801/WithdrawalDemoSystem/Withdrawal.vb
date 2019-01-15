Public Class Withdrawal
    Private _withdraw, _balance As Double
    Public Sub New(withdraw)
        _withdraw = withdraw
    End Sub
    Public Function FC1000() As Double
        Return _withdraw \ 1000
    End Function

    Public Function FC500() As Double
        Return (_withdraw Mod 1000) \ 500
    End Function

    Public Function FC100() As Double
        Return ((_withdraw Mod 1000) Mod 500) \ 100
    End Function

    Public Function FCunder100() As Double
        Return ((_withdraw Mod 1000) Mod 500) Mod 100
    End Function
End Class
