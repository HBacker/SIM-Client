<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dbSettings
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dbSettings))
        Me.dbPath = New Guna.UI.WinForms.GunaLineTextBox()
        Me.dbUID = New Guna.UI.WinForms.GunaLineTextBox()
        Me.dbPwd = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLinkLabel1 = New Guna.UI.WinForms.GunaLinkLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.dbTest = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.output = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout
        '
        'dbPath
        '
        Me.dbPath.BackColor = System.Drawing.Color.White
        Me.dbPath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dbPath.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.dbPath.Font = New System.Drawing.Font("Segoe UI", 12!)
        Me.dbPath.ForeColor = System.Drawing.Color.Black
        Me.dbPath.LineColor = System.Drawing.Color.Gainsboro
        Me.dbPath.Location = New System.Drawing.Point(47, 181)
        Me.dbPath.Name = "dbPath"
        Me.dbPath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.dbPath.Size = New System.Drawing.Size(413, 34)
        Me.dbPath.TabIndex = 0
        Me.dbPath.Text = "Veritabanı Konumu"
        Me.dbPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dbUID
        '
        Me.dbUID.BackColor = System.Drawing.Color.White
        Me.dbUID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dbUID.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.dbUID.Font = New System.Drawing.Font("Segoe UI", 12!)
        Me.dbUID.ForeColor = System.Drawing.Color.Black
        Me.dbUID.LineColor = System.Drawing.Color.Gainsboro
        Me.dbUID.Location = New System.Drawing.Point(47, 221)
        Me.dbUID.Name = "dbUID"
        Me.dbUID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.dbUID.Size = New System.Drawing.Size(226, 34)
        Me.dbUID.TabIndex = 1
        Me.dbUID.Text = "Kullanıcı Adı"
        Me.dbUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dbPwd
        '
        Me.dbPwd.BackColor = System.Drawing.Color.White
        Me.dbPwd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dbPwd.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.dbPwd.Font = New System.Drawing.Font("Segoe UI", 12!)
        Me.dbPwd.ForeColor = System.Drawing.Color.Black
        Me.dbPwd.LineColor = System.Drawing.Color.Gainsboro
        Me.dbPwd.Location = New System.Drawing.Point(279, 221)
        Me.dbPwd.Name = "dbPwd"
        Me.dbPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.dbPwd.Size = New System.Drawing.Size(181, 34)
        Me.dbPwd.TabIndex = 2
        Me.dbPwd.Text = "Şifre"
        Me.dbPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLinkLabel1
        '
        Me.GunaLinkLabel1.AutoSize = true
        Me.GunaLinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLinkLabel1.Font = New System.Drawing.Font("Segoe UI", 10!)
        Me.GunaLinkLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GunaLinkLabel1.LinkColor = System.Drawing.Color.Silver
        Me.GunaLinkLabel1.Location = New System.Drawing.Point(420, 160)
        Me.GunaLinkLabel1.Name = "GunaLinkLabel1"
        Me.GunaLinkLabel1.Size = New System.Drawing.Size(45, 19)
        Me.GunaLinkLabel1.TabIndex = 3
        Me.GunaLinkLabel1.TabStop = true
        Me.GunaLinkLabel1.Text = "Gözat"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'dbTest
        '
        Me.dbTest.AnimationHoverSpeed = 0.07!
        Me.dbTest.AnimationSpeed = 0.03!
        Me.dbTest.BackColor = System.Drawing.Color.Transparent
        Me.dbTest.BaseColor = System.Drawing.Color.FromArgb(CType(CType(2,Byte),Integer), CType(CType(6,Byte),Integer), CType(CType(32,Byte),Integer))
        Me.dbTest.BorderColor = System.Drawing.Color.Black
        Me.dbTest.CheckedBaseColor = System.Drawing.Color.Gray
        Me.dbTest.CheckedBorderColor = System.Drawing.Color.Black
        Me.dbTest.CheckedForeColor = System.Drawing.Color.White
        Me.dbTest.CheckedImage = CType(resources.GetObject("dbTest.CheckedImage"),System.Drawing.Image)
        Me.dbTest.CheckedLineColor = System.Drawing.Color.DimGray
        Me.dbTest.FocusedColor = System.Drawing.Color.Empty
        Me.dbTest.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.dbTest.ForeColor = System.Drawing.Color.White
        Me.dbTest.Image = Nothing
        Me.dbTest.ImageSize = New System.Drawing.Size(36, 36)
        Me.dbTest.LineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.dbTest.Location = New System.Drawing.Point(153, 273)
        Me.dbTest.Name = "dbTest"
        Me.dbTest.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151,Byte),Integer), CType(CType(143,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.dbTest.OnHoverBorderColor = System.Drawing.Color.Black
        Me.dbTest.OnHoverForeColor = System.Drawing.Color.White
        Me.dbTest.OnHoverImage = Nothing
        Me.dbTest.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.dbTest.OnPressedColor = System.Drawing.Color.Black
        Me.dbTest.Radius = 5
        Me.dbTest.Size = New System.Drawing.Size(226, 52)
        Me.dbTest.TabIndex = 4
        Me.dbTest.Text = "Bağlantıyı Test et!"
        Me.dbTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = true
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 16!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(158,Byte),Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(112, 20)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(283, 30)
        Me.GunaLabel1.TabIndex = 5
        Me.GunaLabel1.Text = "Veritabanı Bağlantısı Sınama"
        '
        'output
        '
        Me.output.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(42,Byte),Integer))
        Me.output.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.output.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.output.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(158,Byte),Integer))
        Me.output.Location = New System.Drawing.Point(20, 409)
        Me.output.Name = "output"
        Me.output.Size = New System.Drawing.Size(480, 64)
        Me.output.TabIndex = 6
        Me.output.Text = ""
        '
        'dbSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(42,Byte),Integer))
        Me.Controls.Add(Me.output)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.dbTest)
        Me.Controls.Add(Me.GunaLinkLabel1)
        Me.Controls.Add(Me.dbPwd)
        Me.Controls.Add(Me.dbUID)
        Me.Controls.Add(Me.dbPath)
        Me.Name = "dbSettings"
        Me.Size = New System.Drawing.Size(521, 489)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents dbPath As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents dbUID As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents dbPwd As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLinkLabel1 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents dbTest As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents output As RichTextBox
End Class
