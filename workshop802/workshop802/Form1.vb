Public Class Form1

    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        Dim customer As Integer
        Dim price As Double
        Dim discount As Double
        If Integer.TryParse(TextBoxNum.Text, customer) = False Or customer <= 0 Then
            MessageBox.Show("กรุณาป้อนจำนวนลูกค้าเป็นตัวเลข", "Error", MessageBoxButtons.OK,
                                                MessageBoxIcon.Error)
            TextBoxNum.Text = ""
            LabelTotal.Text = ""
            rdBuddy.Checked = False
            rdNo.Checked = False
            rdFriend.Checked = False
            Exit Sub
        End If
        price = customer * 299

        Dim BBQ As New BBQ(customer, price, discount)

        If rdNo.Checked = True Then

            LabelTotal.Text = Format(BBQ.calculate, "#,###.00") & " บาท"

        ElseIf rdFriend.Checked = True Then

            LabelTotal.Text = Format(BBQ.calculate5, "#,###.00") & " บาท"

        ElseIf rdBuddy.Checked = True Then
            LabelTotal.Text = Format(BBQ.calculate10, "#,###.00") & " บาท"

        Else
            MessageBox.Show("กรุณาเลือกประเภทสมาชิก", "Error", MessageBoxButtons.OK,
                                                MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxNum.Text = ""
        LabelTotal.Text = ""
        rdFriend.Checked = False
        rdBuddy.Checked = False
        rdNo.Checked = False
        ButtonCalculate.Enabled = False
        ButtonClear.Enabled = False
    End Sub

    Private Sub TextBoxNum_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNum.TextChanged
        If TextBoxNum.Text <> "" Then
            ButtonCalculate.Enabled = True
            ButtonClear.Enabled = True
        End If
        If TextBoxNum.Text = "" Then
            ButtonCalculate.Enabled = True
            ButtonClear.Enabled = False
            ButtonCalculate.Enabled = False
        End If
    End Sub
End Class