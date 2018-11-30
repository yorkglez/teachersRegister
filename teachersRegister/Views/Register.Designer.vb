<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.cboxExtensions = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboxType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtboxCode = New System.Windows.Forms.TextBox()
        Me.txtboxName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtboxLastname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtboxEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboxGenere = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnGetfinger = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Extension: "
        '
        'cboxExtensions
        '
        Me.cboxExtensions.FormattingEnabled = True
        Me.cboxExtensions.Location = New System.Drawing.Point(173, 220)
        Me.cboxExtensions.Name = "cboxExtensions"
        Me.cboxExtensions.Size = New System.Drawing.Size(121, 21)
        Me.cboxExtensions.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Registro de docentes"
        '
        'cboxType
        '
        Me.cboxType.FormattingEnabled = True
        Me.cboxType.Location = New System.Drawing.Point(173, 193)
        Me.cboxType.Name = "cboxType"
        Me.cboxType.Size = New System.Drawing.Size(121, 21)
        Me.cboxType.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(97, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tipo: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(105, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Codigo: "
        '
        'txtboxCode
        '
        Me.txtboxCode.Location = New System.Drawing.Point(173, 63)
        Me.txtboxCode.Name = "txtboxCode"
        Me.txtboxCode.Size = New System.Drawing.Size(121, 20)
        Me.txtboxCode.TabIndex = 6
        '
        'txtboxName
        '
        Me.txtboxName.Location = New System.Drawing.Point(173, 89)
        Me.txtboxName.Name = "txtboxName"
        Me.txtboxName.Size = New System.Drawing.Size(121, 20)
        Me.txtboxName.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(104, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Nombre:"
        '
        'txtboxLastname
        '
        Me.txtboxLastname.Location = New System.Drawing.Point(173, 115)
        Me.txtboxLastname.Name = "txtboxLastname"
        Me.txtboxLastname.Size = New System.Drawing.Size(121, 20)
        Me.txtboxLastname.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(104, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Apellido: "
        '
        'txtboxEmail
        '
        Me.txtboxEmail.Location = New System.Drawing.Point(173, 141)
        Me.txtboxEmail.Name = "txtboxEmail"
        Me.txtboxEmail.Size = New System.Drawing.Size(121, 20)
        Me.txtboxEmail.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(104, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Email: "
        '
        'cboxGenere
        '
        Me.cboxGenere.FormattingEnabled = True
        Me.cboxGenere.Location = New System.Drawing.Point(173, 166)
        Me.cboxGenere.Name = "cboxGenere"
        Me.cboxGenere.Size = New System.Drawing.Size(121, 21)
        Me.cboxGenere.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(97, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Genero: "
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(173, 291)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(97, 257)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Huella: "
        '
        'btnGetfinger
        '
        Me.btnGetfinger.Location = New System.Drawing.Point(173, 252)
        Me.btnGetfinger.Name = "btnGetfinger"
        Me.btnGetfinger.Size = New System.Drawing.Size(121, 23)
        Me.btnGetfinger.TabIndex = 17
        Me.btnGetfinger.Text = "Obtener huella"
        Me.btnGetfinger.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnGetfinger)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cboxGenere)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtboxEmail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtboxLastname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtboxName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtboxCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboxType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboxExtensions)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Register"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboxExtensions As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboxType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtboxCode As TextBox
    Friend WithEvents txtboxName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtboxLastname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtboxEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboxGenere As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnGetfinger As Button
End Class
