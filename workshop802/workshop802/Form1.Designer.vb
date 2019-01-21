<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBoxNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdFriend = New System.Windows.Forms.RadioButton()
        Me.rdBuddy = New System.Windows.Forms.RadioButton()
        Me.rdNo = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxNum
        '
        Me.TextBoxNum.Location = New System.Drawing.Point(208, 26)
        Me.TextBoxNum.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxNum.MaxLength = 6
        Me.TextBoxNum.Name = "TextBoxNum"
        Me.TextBoxNum.Size = New System.Drawing.Size(72, 22)
        Me.TextBoxNum.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "จำนวนลูกค้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(289, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "คน ต่อโต๊ะ"
        '
        'rdFriend
        '
        Me.rdFriend.AutoSize = True
        Me.rdFriend.Location = New System.Drawing.Point(208, 70)
        Me.rdFriend.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdFriend.Name = "rdFriend"
        Me.rdFriend.Size = New System.Drawing.Size(109, 21)
        Me.rdFriend.TabIndex = 3
        Me.rdFriend.TabStop = True
        Me.rdFriend.Text = "BBQ Friends"
        Me.rdFriend.UseVisualStyleBackColor = True
        '
        'rdBuddy
        '
        Me.rdBuddy.AutoSize = True
        Me.rdBuddy.Location = New System.Drawing.Point(208, 101)
        Me.rdBuddy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdBuddy.Name = "rdBuddy"
        Me.rdBuddy.Size = New System.Drawing.Size(102, 21)
        Me.rdBuddy.TabIndex = 4
        Me.rdBuddy.TabStop = True
        Me.rdBuddy.Text = "BBQ Buddy"
        Me.rdBuddy.UseVisualStyleBackColor = True
        '
        'rdNo
        '
        Me.rdNo.AutoSize = True
        Me.rdNo.Location = New System.Drawing.Point(208, 129)
        Me.rdNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdNo.Name = "rdNo"
        Me.rdNo.Size = New System.Drawing.Size(112, 21)
        Me.rdNo.TabIndex = 5
        Me.rdNo.TabStop = True
        Me.rdNo.Text = "ไม่มีบัตรสมาชิก"
        Me.rdNo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 73)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ประเภทบัตรสมาชิก"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(135, 171)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ราคารวม"
        '
        'LabelTotal
        '
        Me.LabelTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTotal.Location = New System.Drawing.Point(208, 170)
        Me.LabelTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(140, 27)
        Me.LabelTotal.TabIndex = 8
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.Enabled = False
        Me.ButtonCalculate.Location = New System.Drawing.Point(140, 233)
        Me.ButtonCalculate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(100, 28)
        Me.ButtonCalculate.TabIndex = 9
        Me.ButtonCalculate.Text = "คำนวณราคา"
        Me.ButtonCalculate.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Enabled = False
        Me.ButtonClear.Location = New System.Drawing.Point(248, 233)
        Me.ButtonClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(100, 28)
        Me.ButtonClear.TabIndex = 10
        Me.ButtonClear.TabStop = False
        Me.ButtonClear.Text = "ล้างข้อมูล"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 289)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonCalculate)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rdNo)
        Me.Controls.Add(Me.rdBuddy)
        Me.Controls.Add(Me.rdFriend)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxNum)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BBQ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxNum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rdFriend As RadioButton
    Friend WithEvents rdBuddy As RadioButton
    Friend WithEvents rdNo As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents ButtonCalculate As Button
    Friend WithEvents ButtonClear As Button
End Class