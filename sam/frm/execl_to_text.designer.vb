<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class execl_to_text
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(execl_to_text))
        Me.excel_sheet = New System.Windows.Forms.TextBox()
        Me.pn_connect = New System.Windows.Forms.Panel()
        Me.export_txt = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.excel_old = New System.Windows.Forms.TextBox()
        Me.return_lnk = New System.Windows.Forms.LinkLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.grw = New System.Windows.Forms.DataGridView()
        Me.PN_HEAD = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.text3 = New System.Windows.Forms.TextBox()
        Me.text2 = New System.Windows.Forms.TextBox()
        Me.text1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Pn_not_show = New System.Windows.Forms.Panel()
        Me.result_amt = New System.Windows.Forms.TextBox()
        Me.result_text = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pn_connect.SuspendLayout()
        CType(Me.grw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PN_HEAD.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Pn_not_show.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'excel_sheet
        '
        Me.excel_sheet.BackColor = System.Drawing.Color.LightSteelBlue
        Me.excel_sheet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.excel_sheet.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.excel_sheet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.excel_sheet.Location = New System.Drawing.Point(604, 655)
        Me.excel_sheet.Name = "excel_sheet"
        Me.excel_sheet.Size = New System.Drawing.Size(132, 23)
        Me.excel_sheet.TabIndex = 489
        '
        'pn_connect
        '
        Me.pn_connect.Controls.Add(Me.export_txt)
        Me.pn_connect.Controls.Add(Me.LinkLabel2)
        Me.pn_connect.Controls.Add(Me.Label1)
        Me.pn_connect.Controls.Add(Me.excel_old)
        Me.pn_connect.Location = New System.Drawing.Point(5, 6)
        Me.pn_connect.Name = "pn_connect"
        Me.pn_connect.Size = New System.Drawing.Size(605, 34)
        Me.pn_connect.TabIndex = 493
        '
        'export_txt
        '
        Me.export_txt.ActiveLinkColor = System.Drawing.Color.LightSeaGreen
        Me.export_txt.AutoSize = True
        Me.export_txt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.export_txt.ForeColor = System.Drawing.Color.LightGray
        Me.export_txt.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.export_txt.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.export_txt.Location = New System.Drawing.Point(482, 6)
        Me.export_txt.Name = "export_txt"
        Me.export_txt.Size = New System.Drawing.Size(57, 16)
        Me.export_txt.TabIndex = 519
        Me.export_txt.TabStop = True
        Me.export_txt.Text = "-Export"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.ActiveLinkColor = System.Drawing.Color.LightSeaGreen
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.ForeColor = System.Drawing.Color.LightGray
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.LinkLabel2.Location = New System.Drawing.Point(444, 6)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(33, 16)
        Me.LinkLabel2.TabIndex = 492
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "-เลือก"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 16)
        Me.Label1.TabIndex = 511
        Me.Label1.Text = "ไฟล์"
        '
        'excel_old
        '
        Me.excel_old.BackColor = System.Drawing.Color.LightSteelBlue
        Me.excel_old.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.excel_old.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.excel_old.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.excel_old.Location = New System.Drawing.Point(37, 2)
        Me.excel_old.Name = "excel_old"
        Me.excel_old.Size = New System.Drawing.Size(404, 23)
        Me.excel_old.TabIndex = 488
        '
        'return_lnk
        '
        Me.return_lnk.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.return_lnk.AutoSize = True
        Me.return_lnk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.return_lnk.ForeColor = System.Drawing.Color.LightGray
        Me.return_lnk.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.return_lnk.Location = New System.Drawing.Point(683, 19)
        Me.return_lnk.Name = "return_lnk"
        Me.return_lnk.Size = New System.Drawing.Size(52, 16)
        Me.return_lnk.TabIndex = 418
        Me.return_lnk.TabStop = True
        Me.return_lnk.Text = "Refresh"
        Me.return_lnk.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'grw
        '
        Me.grw.AllowUserToAddRows = False
        Me.grw.AllowUserToDeleteRows = False
        Me.grw.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grw.BackgroundColor = System.Drawing.Color.Lavender
        Me.grw.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grw.ColumnHeadersVisible = False
        Me.grw.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grw.DefaultCellStyle = DataGridViewCellStyle3
        Me.grw.EnableHeadersVisualStyles = False
        Me.grw.Location = New System.Drawing.Point(42, 78)
        Me.grw.Name = "grw"
        Me.grw.ReadOnly = True
        Me.grw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grw.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grw.RowHeadersVisible = False
        Me.grw.RowHeadersWidth = 50
        Me.grw.Size = New System.Drawing.Size(421, 412)
        Me.grw.TabIndex = 299
        '
        'PN_HEAD
        '
        Me.PN_HEAD.BackColor = System.Drawing.Color.CadetBlue
        Me.PN_HEAD.Controls.Add(Me.Label3)
        Me.PN_HEAD.Controls.Add(Me.text3)
        Me.PN_HEAD.Controls.Add(Me.text2)
        Me.PN_HEAD.Controls.Add(Me.text1)
        Me.PN_HEAD.Controls.Add(Me.Label2)
        Me.PN_HEAD.Controls.Add(Me.return_lnk)
        Me.PN_HEAD.Controls.Add(Me.Label17)
        Me.PN_HEAD.Controls.Add(Me.ShapeContainer2)
        Me.PN_HEAD.Dock = System.Windows.Forms.DockStyle.Top
        Me.PN_HEAD.Location = New System.Drawing.Point(0, 0)
        Me.PN_HEAD.Name = "PN_HEAD"
        Me.PN_HEAD.Size = New System.Drawing.Size(857, 66)
        Me.PN_HEAD.TabIndex = 509
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(528, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 522
        Me.Label3.Text = "ค่าคงที่"
        '
        'text3
        '
        Me.text3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.text3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.text3.Location = New System.Drawing.Point(757, 40)
        Me.text3.Name = "text3"
        Me.text3.Size = New System.Drawing.Size(92, 20)
        Me.text3.TabIndex = 514
        '
        'text2
        '
        Me.text2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.text2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.text2.Location = New System.Drawing.Point(661, 40)
        Me.text2.Name = "text2"
        Me.text2.Size = New System.Drawing.Size(90, 20)
        Me.text2.TabIndex = 513
        '
        'text1
        '
        Me.text1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.text1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.text1.Location = New System.Drawing.Point(570, 40)
        Me.text1.Name = "text1"
        Me.text1.Size = New System.Drawing.Size(85, 20)
        Me.text1.TabIndex = 512
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.PowderBlue
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(9, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 485
        Me.Label2.Text = "EXCEL TO TEXT"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(4, 15)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(187, 23)
        Me.Label17.TabIndex = 482
        Me.Label17.Text = "โปรแกรมแปลงข้อมูล"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(857, 66)
        Me.ShapeContainer2.TabIndex = 484
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.MediumTurquoise
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 931
        Me.LineShape1.Y1 = 65
        Me.LineShape1.Y2 = 65
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Lavender
        Me.Panel3.Controls.Add(Me.Pn_not_show)
        Me.Panel3.Controls.Add(Me.pn_connect)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 496)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(857, 45)
        Me.Panel3.TabIndex = 510
        '
        'Pn_not_show
        '
        Me.Pn_not_show.Controls.Add(Me.result_amt)
        Me.Pn_not_show.Controls.Add(Me.result_text)
        Me.Pn_not_show.Location = New System.Drawing.Point(616, 10)
        Me.Pn_not_show.Name = "Pn_not_show"
        Me.Pn_not_show.Size = New System.Drawing.Size(223, 32)
        Me.Pn_not_show.TabIndex = 512
        '
        'result_amt
        '
        Me.result_amt.Location = New System.Drawing.Point(3, 4)
        Me.result_amt.Name = "result_amt"
        Me.result_amt.Size = New System.Drawing.Size(89, 20)
        Me.result_amt.TabIndex = 511
        Me.result_amt.TabStop = False
        '
        'result_text
        '
        Me.result_text.Location = New System.Drawing.Point(98, 4)
        Me.result_text.Name = "result_text"
        Me.result_text.Size = New System.Drawing.Size(82, 20)
        Me.result_text.TabIndex = 522
        Me.result_text.TabStop = False
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog1"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.LightSeaGreen
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.LightGray
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.LinkLabel1.Location = New System.Drawing.Point(10, 295)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(63, 16)
        Me.LinkLabel1.TabIndex = 520
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "-read ini"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(13, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(253, 289)
        Me.RichTextBox1.TabIndex = 521
        Me.RichTextBox1.Text = ""
        '
        'LinkLabel3
        '
        Me.LinkLabel3.ActiveLinkColor = System.Drawing.Color.LightSeaGreen
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.ForeColor = System.Drawing.Color.LightGray
        Me.LinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel3.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.LinkLabel3.Location = New System.Drawing.Point(139, 295)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(129, 16)
        Me.LinkLabel3.TabIndex = 522
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "-read text encode"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Controls.Add(Me.LinkLabel3)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Location = New System.Drawing.Point(570, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(286, 320)
        Me.Panel1.TabIndex = 523
        Me.Panel1.Visible = False
        '
        'execl_to_text
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.CancelButton = Me.return_lnk
        Me.ClientSize = New System.Drawing.Size(857, 541)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.excel_sheet)
        Me.Controls.Add(Me.PN_HEAD)
        Me.Controls.Add(Me.grw)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "execl_to_text"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EXPORT DATA"
        Me.pn_connect.ResumeLayout(False)
        Me.pn_connect.PerformLayout()
        CType(Me.grw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PN_HEAD.ResumeLayout(False)
        Me.PN_HEAD.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Pn_not_show.ResumeLayout(False)
        Me.Pn_not_show.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents return_lnk As System.Windows.Forms.LinkLabel
    Friend WithEvents excel_sheet As System.Windows.Forms.TextBox
    Friend WithEvents excel_old As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pn_connect As System.Windows.Forms.Panel
    Friend WithEvents grw As System.Windows.Forms.DataGridView
    Friend WithEvents PN_HEAD As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents result_amt As System.Windows.Forms.TextBox
    Friend WithEvents export_txt As System.Windows.Forms.LinkLabel
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Pn_not_show As System.Windows.Forms.Panel
    Friend WithEvents text1 As System.Windows.Forms.TextBox
    Friend WithEvents text2 As System.Windows.Forms.TextBox
    Friend WithEvents text3 As System.Windows.Forms.TextBox
    Friend WithEvents result_text As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
