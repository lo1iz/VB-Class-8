Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pro As New Product("P-001", "Pen", 200, 12.5)
        'pro.Id = "P-001"
        'pro.Name = "Pen"
        'pro.Item = 200
        'pro.Price = 12.5
        Dim message As String = "รหัสสินค้า: " & pro.Id & "(" & pro.Name & ")" & vbNewLine &
                                "จำนวนชิ้น: " & pro.Item & ", ราคาต่อขิ้น: " & pro.Price &
                                vbNewLine & "ราคารวมทั้งหมด: " & pro.calculate() & " บาท"

        MessageBox.Show(message)
    End Sub
End Class
