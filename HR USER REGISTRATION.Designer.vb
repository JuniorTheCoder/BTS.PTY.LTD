<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRegFullName = New System.Windows.Forms.TextBox()
        Me.txtRegSurname = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtRegUsername = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRegHRID = New System.Windows.Forms.TextBox()
        Me.txtRegIDNumber = New System.Windows.Forms.TextBox()
        Me.txtRegPhone = New System.Windows.Forms.TextBox()
        Me.txtRegEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRegPassword = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Full Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Surname:"
        '
        'txtRegFullName
        '
        Me.txtRegFullName.Location = New System.Drawing.Point(154, 28)
        Me.txtRegFullName.Name = "txtRegFullName"
        Me.txtRegFullName.Size = New System.Drawing.Size(254, 20)
        Me.txtRegFullName.TabIndex = 2
        '
        'txtRegSurname
        '
        Me.txtRegSurname.Location = New System.Drawing.Point(154, 64)
        Me.txtRegSurname.Name = "txtRegSurname"
        Me.txtRegSurname.Size = New System.Drawing.Size(254, 20)
        Me.txtRegSurname.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRegPassword)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtRegUsername)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtRegHRID)
        Me.GroupBox1.Controls.Add(Me.txtRegIDNumber)
        Me.GroupBox1.Controls.Add(Me.txtRegPhone)
        Me.GroupBox1.Controls.Add(Me.txtRegEmail)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtRegSurname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtRegFullName)
        Me.GroupBox1.Location = New System.Drawing.Point(100, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(454, 303)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REGISTRATION"
        '
        'txtRegUsername
        '
        Me.txtRegUsername.Location = New System.Drawing.Point(154, 229)
        Me.txtRegUsername.Name = "txtRegUsername"
        Me.txtRegUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRegUsername.Size = New System.Drawing.Size(254, 20)
        Me.txtRegUsername.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 265)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Password:"
        '
        'txtRegHRID
        '
        Me.txtRegHRID.Location = New System.Drawing.Point(154, 197)
        Me.txtRegHRID.Name = "txtRegHRID"
        Me.txtRegHRID.Size = New System.Drawing.Size(254, 20)
        Me.txtRegHRID.TabIndex = 11
        '
        'txtRegIDNumber
        '
        Me.txtRegIDNumber.Location = New System.Drawing.Point(154, 163)
        Me.txtRegIDNumber.Name = "txtRegIDNumber"
        Me.txtRegIDNumber.Size = New System.Drawing.Size(254, 20)
        Me.txtRegIDNumber.TabIndex = 10
        '
        'txtRegPhone
        '
        Me.txtRegPhone.Location = New System.Drawing.Point(154, 132)
        Me.txtRegPhone.Name = "txtRegPhone"
        Me.txtRegPhone.Size = New System.Drawing.Size(254, 20)
        Me.txtRegPhone.TabIndex = 9
        '
        'txtRegEmail
        '
        Me.txtRegEmail.Location = New System.Drawing.Point(154, 98)
        Me.txtRegEmail.Name = "txtRegEmail"
        Me.txtRegEmail.Size = New System.Drawing.Size(254, 20)
        Me.txtRegEmail.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Username:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "ID Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Personal Phone No:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Registered Company Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poor Richard", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(199, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(292, 41)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "PLEASE REGISTER"
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnRegister.Location = New System.Drawing.Point(100, 457)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(144, 23)
        Me.btnRegister.TabIndex = 5
        Me.btnRegister.Text = "REGISTER"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(410, 457)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(144, 23)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(386, 429)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Already Have An Account?"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 200)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "HR Employee ID"
        '
        'txtRegPassword
        '
        Me.txtRegPassword.Location = New System.Drawing.Point(154, 262)
        Me.txtRegPassword.Name = "txtRegPassword"
        Me.txtRegPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRegPassword.Size = New System.Drawing.Size(254, 20)
        Me.txtRegPassword.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 492)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "HR USER REGISTRATION"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRegFullName As System.Windows.Forms.TextBox
    Friend WithEvents txtRegSurname As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRegUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtRegHRID As System.Windows.Forms.TextBox
    Friend WithEvents txtRegIDNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtRegPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtRegEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtRegPassword As System.Windows.Forms.TextBox

End Class
