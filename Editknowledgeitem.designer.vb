
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editknowledgeitem
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.txtknowledgetext = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttype = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtchildtype = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtfontsize = New System.Windows.Forms.TextBox()
        Me.cbfontname = New System.Windows.Forms.ComboBox()
        Me.btnforecolor = New System.Windows.Forms.Button()
        Me.ckfontunderline = New System.Windows.Forms.CheckBox()
        Me.ckfontstrikeout = New System.Windows.Forms.CheckBox()
        Me.ckfontitalic = New System.Windows.Forms.CheckBox()
        Me.ckfontbold = New System.Windows.Forms.CheckBox()
        Me.bttnbackcolor = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.hperlink = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(354, -17)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(170, 33)
        Me.TableLayoutPanel1.TabIndex = 0
        Me.TableLayoutPanel1.Visible = False
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK_Button.Location = New System.Drawing.Point(455, 239)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(93, 47)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(455, 189)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(93, 36)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'txtknowledgetext
        '
        Me.txtknowledgetext.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtknowledgetext.Location = New System.Drawing.Point(110, 6)
        Me.txtknowledgetext.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtknowledgetext.Name = "txtknowledgetext"
        Me.txtknowledgetext.Size = New System.Drawing.Size(438, 23)
        Me.txtknowledgetext.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Knowledge text"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Type"
        '
        'txttype
        '
        Me.txttype.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttype.Location = New System.Drawing.Point(110, 35)
        Me.txttype.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txttype.Name = "txttype"
        Me.txttype.Size = New System.Drawing.Size(335, 23)
        Me.txttype.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 71)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Child Type"
        '
        'txtchildtype
        '
        Me.txtchildtype.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtchildtype.Location = New System.Drawing.Point(110, 68)
        Me.txtchildtype.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtchildtype.Name = "txtchildtype"
        Me.txtchildtype.Size = New System.Drawing.Size(438, 23)
        Me.txtchildtype.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtfontsize)
        Me.GroupBox1.Controls.Add(Me.cbfontname)
        Me.GroupBox1.Controls.Add(Me.btnforecolor)
        Me.GroupBox1.Controls.Add(Me.ckfontunderline)
        Me.GroupBox1.Controls.Add(Me.ckfontstrikeout)
        Me.GroupBox1.Controls.Add(Me.ckfontitalic)
        Me.GroupBox1.Controls.Add(Me.ckfontbold)
        Me.GroupBox1.Controls.Add(Me.bttnbackcolor)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 180)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(422, 114)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Format Node"
        '
        'txtfontsize
        '
        Me.txtfontsize.Location = New System.Drawing.Point(329, 22)
        Me.txtfontsize.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtfontsize.Name = "txtfontsize"
        Me.txtfontsize.Size = New System.Drawing.Size(58, 23)
        Me.txtfontsize.TabIndex = 7
        '
        'cbfontname
        '
        Me.cbfontname.FormattingEnabled = True
        Me.cbfontname.Location = New System.Drawing.Point(139, 22)
        Me.cbfontname.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbfontname.Name = "cbfontname"
        Me.cbfontname.Size = New System.Drawing.Size(179, 23)
        Me.cbfontname.TabIndex = 6
        '
        'btnforecolor
        '
        Me.btnforecolor.Location = New System.Drawing.Point(8, 61)
        Me.btnforecolor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnforecolor.Name = "btnforecolor"
        Me.btnforecolor.Size = New System.Drawing.Size(124, 27)
        Me.btnforecolor.TabIndex = 5
        Me.btnforecolor.Text = "Change ForeColor"
        Me.btnforecolor.UseVisualStyleBackColor = True
        '
        'ckfontunderline
        '
        Me.ckfontunderline.AutoSize = True
        Me.ckfontunderline.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ckfontunderline.Location = New System.Drawing.Point(274, 90)
        Me.ckfontunderline.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ckfontunderline.Name = "ckfontunderline"
        Me.ckfontunderline.Size = New System.Drawing.Size(95, 17)
        Me.ckfontunderline.TabIndex = 4
        Me.ckfontunderline.Text = "Font Underline"
        Me.ckfontunderline.UseVisualStyleBackColor = True
        '
        'ckfontstrikeout
        '
        Me.ckfontstrikeout.AutoSize = True
        Me.ckfontstrikeout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point)
        Me.ckfontstrikeout.Location = New System.Drawing.Point(156, 90)
        Me.ckfontstrikeout.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ckfontstrikeout.Name = "ckfontstrikeout"
        Me.ckfontstrikeout.Size = New System.Drawing.Size(92, 17)
        Me.ckfontstrikeout.TabIndex = 3
        Me.ckfontstrikeout.Text = "Font Strikeout"
        Me.ckfontstrikeout.UseVisualStyleBackColor = True
        '
        'ckfontitalic
        '
        Me.ckfontitalic.AutoSize = True
        Me.ckfontitalic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.ckfontitalic.Location = New System.Drawing.Point(274, 61)
        Me.ckfontitalic.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ckfontitalic.Name = "ckfontitalic"
        Me.ckfontitalic.Size = New System.Drawing.Size(72, 17)
        Me.ckfontitalic.TabIndex = 2
        Me.ckfontitalic.Text = "Font Italic"
        Me.ckfontitalic.UseVisualStyleBackColor = True
        '
        'ckfontbold
        '
        Me.ckfontbold.AutoSize = True
        Me.ckfontbold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ckfontbold.Location = New System.Drawing.Point(156, 64)
        Me.ckfontbold.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ckfontbold.Name = "ckfontbold"
        Me.ckfontbold.Size = New System.Drawing.Size(80, 17)
        Me.ckfontbold.TabIndex = 1
        Me.ckfontbold.Text = "Font Bold"
        Me.ckfontbold.UseVisualStyleBackColor = True
        '
        'bttnbackcolor
        '
        Me.bttnbackcolor.Location = New System.Drawing.Point(7, 22)
        Me.bttnbackcolor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bttnbackcolor.Name = "bttnbackcolor"
        Me.bttnbackcolor.Size = New System.Drawing.Size(124, 27)
        Me.bttnbackcolor.TabIndex = 0
        Me.bttnbackcolor.Text = "Change BackColor"
        Me.bttnbackcolor.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 107)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "HyperLink"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(453, 35)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(95, 23)
        Me.TextBox1.TabIndex = 10
        '
        'hperlink
        '
        Me.hperlink.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hperlink.Location = New System.Drawing.Point(110, 100)
        Me.hperlink.Name = "hperlink"
        Me.hperlink.Size = New System.Drawing.Size(438, 74)
        Me.hperlink.TabIndex = 11
        Me.hperlink.Text = ""
        '
        'Editknowledgeitem
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(559, 303)
        Me.Controls.Add(Me.hperlink)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtchildtype)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txttype)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtknowledgetext)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Editknowledgeitem"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Editknowledgeitem"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents txtknowledgetext As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txttype As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtchildtype As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bttnbackcolor As System.Windows.Forms.Button
    Friend WithEvents ckfontunderline As System.Windows.Forms.CheckBox
    Friend WithEvents ckfontstrikeout As System.Windows.Forms.CheckBox
    Friend WithEvents ckfontitalic As System.Windows.Forms.CheckBox
    Friend WithEvents ckfontbold As System.Windows.Forms.CheckBox
    Friend WithEvents btnforecolor As System.Windows.Forms.Button
    Friend WithEvents txtfontsize As System.Windows.Forms.TextBox
    Friend WithEvents cbfontname As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents hperlink As RichTextBox
End Class
