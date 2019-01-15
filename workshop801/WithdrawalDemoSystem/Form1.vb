Public Class Form1
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBalance_TextChanged(sender As Object, e As EventArgs) Handles TextBalance.TextChanged

    End Sub

    Private Sub TextWithdraw_TextChanged(sender As Object, e As EventArgs) Handles TextWithdraw.TextChanged
        If TextWithdraw.Text <> "" Then
            ButtonOK.Enabled = True
        Else
            ButtonOK.Enabled = False
        End If
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click

        Dim balance As Double = CDbl(TextBalance.Text)
        If Double.TryParse(TextWithdraw.Text, 0) = False Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextWithdraw.Text = ""
            LabelResult.Text = ""
            Exit Sub
        End If

        Dim wd As New Withdrawal(CDbl(TextWithdraw.Text))
        Dim withdraw As Double = CDbl(TextWithdraw.Text)
        Dim message As String = ""


        If withdraw > balance Then
            MessageBox.Show("ยอดเงินคงเหลือไม่พอ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextWithdraw.Text = ""
            LabelResult.Text = ""
        ElseIf withdraw > 20000 Then
            MessageBox.Show("ถอนได้ไม่เกิน 20,000 บาท", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextWithdraw.Text = ""
            LabelResult.Text = ""
        ElseIf withdraw < 100 Then
            MessageBox.Show("ยอดขั้นต่ำต้องเป็นหลกร้อยเท่านั้น", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextWithdraw.Text = ""
            LabelResult.Text = ""
        ElseIf wd.FCunder100 Mod 100 Then
            MessageBox.Show("ไม่สามารถถอนเศษน้อยกว่า 100 บาท", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextWithdraw.Text = ""
            LabelResult.Text = ""
        Else
            LabelResult.Text = "1000 : " & wd.FC1000 & vbNewLine &
                                "500 : " & wd.FC500 & vbNewLine &
                                 "100 : " & wd.FC100
            TextBalance.Text = balance - withdraw
        End If

    End Sub

    Private Sub LabelResult_Click(sender As Object, e As EventArgs) Handles LabelResult.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ran As Random = New Random
        TextBalance.Text = ran.Next(1, 9) * 100000
        TextWithdraw.Select()
    End Sub
End Class
