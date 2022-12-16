<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOG))
        Me.logText = New System.Windows.Forms.RichTextBox()
        Me.logHide = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.SuspendLayout
        '
        'logText
        '
        Me.logText.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(42,Byte),Integer))
        Me.logText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.logText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.logText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.logText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(158,Byte),Integer))
        Me.logText.Location = New System.Drawing.Point(0, 0)
        Me.logText.Name = "logText"
        Me.logText.Size = New System.Drawing.Size(800, 450)
        Me.logText.TabIndex = 0
        Me.logText.Text = ""
        '
        'logHide
        '
        Me.logHide.AnimationHoverSpeed = 0.07!
        Me.logHide.AnimationSpeed = 0.03!
        Me.logHide.BaseColor = System.Drawing.Color.Crimson
        Me.logHide.BorderColor = System.Drawing.Color.Black
        Me.logHide.CheckedBaseColor = System.Drawing.Color.Gray
        Me.logHide.CheckedBorderColor = System.Drawing.Color.Black
        Me.logHide.CheckedForeColor = System.Drawing.Color.White
        Me.logHide.CheckedImage = CType(resources.GetObject("logHide.CheckedImage"),System.Drawing.Image)
        Me.logHide.CheckedLineColor = System.Drawing.Color.DimGray
        Me.logHide.FocusedColor = System.Drawing.Color.Empty
        Me.logHide.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.logHide.ForeColor = System.Drawing.Color.White
        Me.logHide.Image = Nothing
        Me.logHide.ImageSize = New System.Drawing.Size(20, 20)
        Me.logHide.LineColor = System.Drawing.Color.Crimson
        Me.logHide.Location = New System.Drawing.Point(754, 0)
        Me.logHide.Name = "logHide"
        Me.logHide.OnHoverBaseColor = System.Drawing.Color.Crimson
        Me.logHide.OnHoverBorderColor = System.Drawing.Color.Black
        Me.logHide.OnHoverForeColor = System.Drawing.Color.White
        Me.logHide.OnHoverImage = Nothing
        Me.logHide.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.logHide.OnPressedColor = System.Drawing.Color.Black
        Me.logHide.Size = New System.Drawing.Size(46, 42)
        Me.logHide.TabIndex = 1
        Me.logHide.Text = "Kapat"
        '
        'LOG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.logHide)
        Me.Controls.Add(Me.logText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LOG"
        Me.Text = "LOG"
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents logText As RichTextBox
    Friend WithEvents logHide As Guna.UI.WinForms.GunaAdvenceButton
End Class
