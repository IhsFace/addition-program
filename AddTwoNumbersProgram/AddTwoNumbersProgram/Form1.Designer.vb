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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txt1stNumber = New TextBox()
        txt2ndNumber = New TextBox()
        lblAnswer = New TextBox()
        btnAdd = New Button()
        btnClear = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(200, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(192, 26)
        Label1.TabIndex = 0
        Label1.Text = "Add Two Numbers"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(150, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(200, 24)
        Label2.TabIndex = 1
        Label2.Text = "Enter the First Number"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(119, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(231, 24)
        Label3.TabIndex = 2
        Label3.Text = "Enter the Second Number"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(167, 200)
        Label4.Name = "Label4"
        Label4.Size = New Size(183, 24)
        Label4.TabIndex = 3
        Label4.Text = "Sum of the Numbers"' 
        ' txt1stNumber
        ' 
        txt1stNumber.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txt1stNumber.Location = New Point(375, 100)
        txt1stNumber.Name = "txt1stNumber"
        txt1stNumber.Size = New Size(100, 29)
        txt1stNumber.TabIndex = 4
        ' 
        ' txt2ndNumber
        ' 
        txt2ndNumber.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txt2ndNumber.Location = New Point(375, 150)
        txt2ndNumber.Name = "txt2ndNumber"
        txt2ndNumber.Size = New Size(100, 29)
        txt2ndNumber.TabIndex = 5
        ' 
        ' lblAnswer
        ' 
        lblAnswer.BackColor = Color.White
        lblAnswer.BorderStyle = BorderStyle.FixedSingle
        lblAnswer.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lblAnswer.Location = New Point(375, 200)
        lblAnswer.Name = "lblAnswer"
        lblAnswer.ReadOnly = True
        lblAnswer.Size = New Size(100, 29)
        lblAnswer.TabIndex = 6
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnAdd.Location = New Point(200, 275)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(150, 30)
        btnAdd.TabIndex = 7
        btnAdd.Text = "Add Numbers"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnClear.Location = New Point(385, 275)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 30)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gold
        ClientSize = New Size(584, 361)
        Controls.Add(btnClear)
        Controls.Add(btnAdd)
        Controls.Add(lblAnswer)
        Controls.Add(txt2ndNumber)
        Controls.Add(txt1stNumber)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Addition Program"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt1stNumber As TextBox
    Friend WithEvents txt2ndNumber As TextBox
    Friend WithEvents lblAnswer As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
End Class
