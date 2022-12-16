<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListData
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListData))
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.statusText = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.newFile = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboTable = New Guna.UI.WinForms.GunaComboBox()
        Me.TabloGrid = New Guna.UI.WinForms.GunaDataGridView()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaGroupBox1.SuspendLayout
        CType(Me.TabloGrid,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(42,Byte),Integer))
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.statusText)
        Me.GunaGroupBox1.Controls.Add(Me.Label2)
        Me.GunaGroupBox1.Controls.Add(Me.newFile)
        Me.GunaGroupBox1.Controls.Add(Me.Label1)
        Me.GunaGroupBox1.Controls.Add(Me.comboTable)
        Me.GunaGroupBox1.Controls.Add(Me.GunaAdvenceButton1)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GunaGroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GunaGroupBox1.LineBottom = 1
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.GunaGroupBox1.LineLeft = 1
        Me.GunaGroupBox1.LineRight = 1
        Me.GunaGroupBox1.Location = New System.Drawing.Point(14, 513)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(816, 101)
        Me.GunaGroupBox1.TabIndex = 1
        Me.GunaGroupBox1.Text = "İşlemler"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'statusText
        '
        Me.statusText.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.statusText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.statusText.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.statusText.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.statusText.LineColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.statusText.LineSize = 1
        Me.statusText.Location = New System.Drawing.Point(76, 3)
        Me.statusText.Name = "statusText"
        Me.statusText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.statusText.Size = New System.Drawing.Size(663, 26)
        Me.statusText.TabIndex = 8
        Me.statusText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(326, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Dosya İsmi"
        '
        'newFile
        '
        Me.newFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.newFile.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.newFile.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.newFile.Font = New System.Drawing.Font("Segoe UI", 17!)
        Me.newFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.newFile.LineColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.newFile.LineSize = 1
        Me.newFile.Location = New System.Drawing.Point(224, 50)
        Me.newFile.Name = "newFile"
        Me.newFile.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.newFile.Size = New System.Drawing.Size(307, 42)
        Me.newFile.TabIndex = 6
        Me.newFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Aktarılacak Tablo"
        '
        'comboTable
        '
        Me.comboTable.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.comboTable.BaseColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.comboTable.BorderColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.comboTable.BorderSize = 1
        Me.comboTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboTable.FocusedColor = System.Drawing.Color.Indigo
        Me.comboTable.Font = New System.Drawing.Font("Segoe UI", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.comboTable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.comboTable.FormattingEnabled = true
        Me.comboTable.Items.AddRange(New Object() {"Seçiniz...", "STOK", "CARI", "FATURA", "IRSALIYE", "DEPO", "CARIHR", "CEK_SENET", "GUN_SONU", "KASA", "SIPARIS", "STOK_DEPO", "STOK_FIYAT", "STOK_FIYAT_LISTE"})
        Me.comboTable.Location = New System.Drawing.Point(22, 51)
        Me.comboTable.Name = "comboTable"
        Me.comboTable.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.comboTable.OnHoverItemForeColor = System.Drawing.Color.White
        Me.comboTable.Size = New System.Drawing.Size(182, 40)
        Me.comboTable.TabIndex = 4
        '
        'TabloGrid
        '
        Me.TabloGrid.AllowUserToAddRows = false
        Me.TabloGrid.AllowUserToDeleteRows = false
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(39,Byte),Integer), CType(CType(50,Byte),Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.TabloGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TabloGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TabloGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        Me.TabloGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TabloGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TabloGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.TabloGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(10,Byte),Integer), CType(CType(18,Byte),Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TabloGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.TabloGrid.ColumnHeadersHeight = 27
        Me.TabloGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(61,Byte),Integer), CType(CType(59,Byte),Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TabloGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.TabloGrid.EnableHeadersVisualStyles = false
        Me.TabloGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231,Byte),Integer), CType(CType(229,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.TabloGrid.Location = New System.Drawing.Point(3, 3)
        Me.TabloGrid.Name = "TabloGrid"
        Me.TabloGrid.ReadOnly = true
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254,Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TabloGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.TabloGrid.RowHeadersVisible = false
        Me.TabloGrid.RowTemplate.Height = 31
        Me.TabloGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TabloGrid.Size = New System.Drawing.Size(827, 504)
        Me.TabloGrid.TabIndex = 77
        Me.TabloGrid.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.TabloGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.TabloGrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.TabloGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(39,Byte),Integer), CType(CType(50,Byte),Integer))
        Me.TabloGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        Me.TabloGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.TabloGrid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        Me.TabloGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231,Byte),Integer), CType(CType(229,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.TabloGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.TabloGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TabloGrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.TabloGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.TabloGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TabloGrid.ThemeStyle.HeaderStyle.Height = 27
        Me.TabloGrid.ThemeStyle.ReadOnly = true
        Me.TabloGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.TabloGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TabloGrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.TabloGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(61,Byte),Integer), CType(CType(59,Byte),Integer))
        Me.TabloGrid.ThemeStyle.RowsStyle.Height = 31
        Me.TabloGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        Me.TabloGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(2,Byte),Integer), CType(CType(6,Byte),Integer), CType(CType(32,Byte),Integer))
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"),System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.Image = Global.SIM_Client.My.Resources.Resources._1320_json_outline
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(36, 36)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(576, 40)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151,Byte),Integer), CType(CType(143,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Radius = 5
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(226, 52)
        Me.GunaAdvenceButton1.TabIndex = 0
        Me.GunaAdvenceButton1.Text = "JSON Verisi olarak kaydet"
        '
        'ListData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23,Byte),Integer), CType(CType(28,Byte),Integer), CType(CType(33,Byte),Integer))
        Me.Controls.Add(Me.TabloGrid)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Name = "ListData"
        Me.Size = New System.Drawing.Size(833, 619)
        Me.GunaGroupBox1.ResumeLayout(false)
        Me.GunaGroupBox1.PerformLayout
        CType(Me.TabloGrid,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents comboTable As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label2 As Label
    Friend WithEvents newFile As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents statusText As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents TabloGrid As Guna.UI.WinForms.GunaDataGridView
End Class
