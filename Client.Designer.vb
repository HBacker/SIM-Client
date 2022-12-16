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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.elipseForm = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.elipseLeftSidebar = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.elipseHeader = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.elipseMainSection = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.mainSection = New Guna.UI.WinForms.GunaGradientPanel()
        Me.formHeader = New Guna.UI.WinForms.GunaGradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.leftSidebar = New Guna.UI.WinForms.GunaGradientPanel()
        Me.btnSEND = New Guna.UI.WinForms.GunaGradientButton()
        Me.vText = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnJSON = New Guna.UI.WinForms.GunaGradientButton()
        Me.btnSET = New Guna.UI.WinForms.GunaGradientButton()
        Me.DbSettings1 = New SIM_Client.dbSettings()
        Me.ListData1 = New SIM_Client.ListData()
        Me.mainSection.SuspendLayout
        Me.formHeader.SuspendLayout
        Me.leftSidebar.SuspendLayout
        Me.SuspendLayout
        '
        'elipseForm
        '
        Me.elipseForm.Radius = 5
        Me.elipseForm.TargetControl = Me
        '
        'elipseLeftSidebar
        '
        Me.elipseLeftSidebar.Radius = 5
        Me.elipseLeftSidebar.TargetControl = Me.leftSidebar
        '
        'elipseHeader
        '
        Me.elipseHeader.Radius = 10
        Me.elipseHeader.TargetControl = Me.formHeader
        '
        'elipseMainSection
        '
        Me.elipseMainSection.Radius = 5
        Me.elipseMainSection.TargetControl = Me.mainSection
        '
        'mainSection
        '
        Me.mainSection.BackgroundImage = CType(resources.GetObject("mainSection.BackgroundImage"),System.Drawing.Image)
        Me.mainSection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mainSection.Controls.Add(Me.DbSettings1)
        Me.mainSection.Controls.Add(Me.ListData1)
        Me.mainSection.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.mainSection.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(42,Byte),Integer))
        Me.mainSection.GradientColor3 = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(42,Byte),Integer))
        Me.mainSection.GradientColor4 = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.mainSection.Location = New System.Drawing.Point(122, 73)
        Me.mainSection.Name = "mainSection"
        Me.mainSection.Size = New System.Drawing.Size(850, 639)
        Me.mainSection.TabIndex = 1
        Me.mainSection.Text = "GunaGradientPanel1"
        '
        'formHeader
        '
        Me.formHeader.BackgroundImage = CType(resources.GetObject("formHeader.BackgroundImage"),System.Drawing.Image)
        Me.formHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.formHeader.Controls.Add(Me.Label1)
        Me.formHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.formHeader.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(61,Byte),Integer), CType(CType(59,Byte),Integer))
        Me.formHeader.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(42,Byte),Integer))
        Me.formHeader.GradientColor3 = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(42,Byte),Integer))
        Me.formHeader.GradientColor4 = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(42,Byte),Integer))
        Me.formHeader.Location = New System.Drawing.Point(0, 0)
        Me.formHeader.Name = "formHeader"
        Me.formHeader.Size = New System.Drawing.Size(984, 57)
        Me.formHeader.TabIndex = 1
        Me.formHeader.Text = "GunaGradientPanel2"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(391, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SIM Client"
        '
        'leftSidebar
        '
        Me.leftSidebar.BackgroundImage = CType(resources.GetObject("leftSidebar.BackgroundImage"),System.Drawing.Image)
        Me.leftSidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.leftSidebar.Controls.Add(Me.btnSEND)
        Me.leftSidebar.Controls.Add(Me.vText)
        Me.leftSidebar.Controls.Add(Me.Label3)
        Me.leftSidebar.Controls.Add(Me.Label2)
        Me.leftSidebar.Controls.Add(Me.btnJSON)
        Me.leftSidebar.Controls.Add(Me.btnSET)
        Me.leftSidebar.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.leftSidebar.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(42,Byte),Integer))
        Me.leftSidebar.GradientColor3 = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(42,Byte),Integer))
        Me.leftSidebar.GradientColor4 = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.leftSidebar.Location = New System.Drawing.Point(-5, 73)
        Me.leftSidebar.Name = "leftSidebar"
        Me.leftSidebar.Size = New System.Drawing.Size(121, 639)
        Me.leftSidebar.TabIndex = 0
        Me.leftSidebar.Text = "GunaGradientPanel1"
        '
        'btnSEND
        '
        Me.btnSEND.AnimationHoverSpeed = 0.07!
        Me.btnSEND.AnimationSpeed = 0.03!
        Me.btnSEND.BackColor = System.Drawing.Color.Transparent
        Me.btnSEND.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(61,Byte),Integer), CType(CType(59,Byte),Integer))
        Me.btnSEND.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(29,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.btnSEND.BorderColor = System.Drawing.Color.Black
        Me.btnSEND.Enabled = false
        Me.btnSEND.FocusedColor = System.Drawing.Color.Empty
        Me.btnSEND.Font = New System.Drawing.Font("Nirmala UI", 12!, System.Drawing.FontStyle.Bold)
        Me.btnSEND.ForeColor = System.Drawing.Color.White
        Me.btnSEND.Image = Nothing
        Me.btnSEND.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSEND.Location = New System.Drawing.Point(3, 158)
        Me.btnSEND.Name = "btnSEND"
        Me.btnSEND.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155,Byte),Integer), CType(CType(145,Byte),Integer), CType(CType(221,Byte),Integer))
        Me.btnSEND.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(85,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.btnSEND.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSEND.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSEND.OnHoverImage = Nothing
        Me.btnSEND.OnPressedColor = System.Drawing.Color.Black
        Me.btnSEND.Size = New System.Drawing.Size(101, 62)
        Me.btnSEND.TabIndex = 5
        Me.btnSEND.Text = "Gönder"
        '
        'vText
        '
        Me.vText.AutoSize = true
        Me.vText.BackColor = System.Drawing.Color.Transparent
        Me.vText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.vText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.vText.Location = New System.Drawing.Point(22, 612)
        Me.vText.Name = "vText"
        Me.vText.Size = New System.Drawing.Size(96, 17)
        Me.vText.TabIndex = 4
        Me.vText.Text = "~~ Version ~~"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 575)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Gökhan"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 592)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SIM Bilgisayar"
        '
        'btnJSON
        '
        Me.btnJSON.AnimationHoverSpeed = 0.07!
        Me.btnJSON.AnimationSpeed = 0.03!
        Me.btnJSON.BackColor = System.Drawing.Color.Transparent
        Me.btnJSON.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(61,Byte),Integer), CType(CType(59,Byte),Integer))
        Me.btnJSON.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(29,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.btnJSON.BorderColor = System.Drawing.Color.Black
        Me.btnJSON.Enabled = false
        Me.btnJSON.FocusedColor = System.Drawing.Color.Empty
        Me.btnJSON.Font = New System.Drawing.Font("Nirmala UI", 12!, System.Drawing.FontStyle.Bold)
        Me.btnJSON.ForeColor = System.Drawing.Color.White
        Me.btnJSON.Image = Nothing
        Me.btnJSON.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnJSON.Location = New System.Drawing.Point(5, 90)
        Me.btnJSON.Name = "btnJSON"
        Me.btnJSON.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155,Byte),Integer), CType(CType(145,Byte),Integer), CType(CType(221,Byte),Integer))
        Me.btnJSON.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(85,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.btnJSON.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnJSON.OnHoverForeColor = System.Drawing.Color.White
        Me.btnJSON.OnHoverImage = Nothing
        Me.btnJSON.OnPressedColor = System.Drawing.Color.Black
        Me.btnJSON.Size = New System.Drawing.Size(101, 62)
        Me.btnJSON.TabIndex = 1
        Me.btnJSON.Text = "JSON"
        '
        'btnSET
        '
        Me.btnSET.AnimationHoverSpeed = 0.07!
        Me.btnSET.AnimationSpeed = 0.03!
        Me.btnSET.BackColor = System.Drawing.Color.Transparent
        Me.btnSET.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(61,Byte),Integer), CType(CType(59,Byte),Integer))
        Me.btnSET.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(29,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.btnSET.BorderColor = System.Drawing.Color.Black
        Me.btnSET.FocusedColor = System.Drawing.Color.Empty
        Me.btnSET.Font = New System.Drawing.Font("Nirmala UI", 12!, System.Drawing.FontStyle.Bold)
        Me.btnSET.ForeColor = System.Drawing.Color.White
        Me.btnSET.Image = Nothing
        Me.btnSET.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSET.Location = New System.Drawing.Point(5, 22)
        Me.btnSET.Name = "btnSET"
        Me.btnSET.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155,Byte),Integer), CType(CType(145,Byte),Integer), CType(CType(221,Byte),Integer))
        Me.btnSET.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(85,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.btnSET.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSET.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSET.OnHoverImage = Nothing
        Me.btnSET.OnPressedColor = System.Drawing.Color.Black
        Me.btnSET.Size = New System.Drawing.Size(101, 62)
        Me.btnSET.TabIndex = 0
        Me.btnSET.Text = "DB Ayarlar"
        '
        'DbSettings1
        '
        Me.DbSettings1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23,Byte),Integer), CType(CType(28,Byte),Integer), CType(CType(33,Byte),Integer))
        Me.DbSettings1.Location = New System.Drawing.Point(175, 52)
        Me.DbSettings1.Name = "DbSettings1"
        Me.DbSettings1.Size = New System.Drawing.Size(521, 489)
        Me.DbSettings1.TabIndex = 1
        '
        'ListData1
        '
        Me.ListData1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23,Byte),Integer), CType(CType(28,Byte),Integer), CType(CType(33,Byte),Integer))
        Me.ListData1.Location = New System.Drawing.Point(9, 11)
        Me.ListData1.Name = "ListData1"
        Me.ListData1.Size = New System.Drawing.Size(833, 619)
        Me.ListData1.TabIndex = 0
        Me.ListData1.Visible = false
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23,Byte),Integer), CType(CType(28,Byte),Integer), CType(CType(33,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(984, 724)
        Me.Controls.Add(Me.mainSection)
        Me.Controls.Add(Me.formHeader)
        Me.Controls.Add(Me.leftSidebar)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(158,Byte),Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIM Client"
        Me.mainSection.ResumeLayout(false)
        Me.formHeader.ResumeLayout(false)
        Me.formHeader.PerformLayout
        Me.leftSidebar.ResumeLayout(false)
        Me.leftSidebar.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents leftSidebar As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents formHeader As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents elipseForm As Guna.UI.WinForms.GunaElipse
    Friend WithEvents elipseLeftSidebar As Guna.UI.WinForms.GunaElipse
    Friend WithEvents elipseHeader As Guna.UI.WinForms.GunaElipse
    Friend WithEvents elipseMainSection As Guna.UI.WinForms.GunaElipse
    Friend WithEvents mainSection As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents btnSET As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ListData1 As ListData
    Friend WithEvents btnJSON As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Label2 As Label
    Friend WithEvents vText As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSEND As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents DbSettings1 As dbSettings
End Class
