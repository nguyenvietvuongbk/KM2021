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
        Me.hperlink = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(292, 367)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'txtknowledgetext
        '
        Me.txtknowledgetext.Location = New System.Drawing.Point(36, 50)
        Me.txtknowledgetext.Name = "txtknowledgetext"
        Me.txtknowledgetext.Size = New System.Drawing.Size(376, 20)
        Me.txtknowledgetext.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Knowledge text"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Type"
        '
        'txttype
        '
        Me.txttype.Location = New System.Drawing.Point(36, 89)
        Me.txttype.Name = "txttype"
        Me.txttype.Size = New System.Drawing.Size(257, 20)
        Me.txttype.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Child Type"
        '
        'txtchildtype
        '
        Me.txtchildtype.Location = New System.Drawing.Point(36, 128)
        Me.txtchildtype.Name = "txtchildtype"
        Me.txtchildtype.Size = New System.Drawing.Size(257, 20)
        Me.txtchildtype.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtfontsize)
        Me.GroupBox1.Controls.Add(Me.cbfontname)
        Me.GroupBox1.Controls.Add(Me.btnforecolor)
        Me.GroupBox1.Controls.Add(Me.ckfontunderline)
        Me.GroupBox1.Controls.Add(Me.ckfontstrikeout)
        Me.GroupBox1.Controls.Add(Me.ckfontitalic)
        Me.GroupBox1.Controls.Add(Me.ckfontbold)
        Me.GroupBox1.Controls.Add(Me.bttnbackcolor)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 206)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 128)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Format Node"
        '
        'txtfontsize
        '
        Me.txtfontsize.Location = New System.Drawing.Point(294, 29)
        Me.txtfontsize.Name = "txtfontsize"
        Me.txtfontsize.Size = New System.Drawing.Size(50, 20)
        Me.txtfontsize.TabIndex = 7
        '
        'cbfontname
        '
        Me.cbfontname.FormattingEnabled = True
        Me.cbfontname.Location = New System.Drawing.Point(134, 29)
        Me.cbfontname.Name = "cbfontname"
        Me.cbfontname.Size = New System.Drawing.Size(154, 21)
        Me.cbfontname.TabIndex = 6
        '
        'btnforecolor
        '
        Me.btnforecolor.Location = New System.Drawing.Point(6, 56)
        Me.btnforecolor.Name = "btnforecolor"
        Me.btnforecolor.Size = New System.Drawing.Size(106, 23)
        Me.btnforecolor.TabIndex = 5
        Me.btnforecolor.Text = "Change ForeColor"
        Me.btnforecolor.UseVisualStyleBackColor = True
        '
        'ckfontunderline
        '
        Me.ckfontunderline.AutoSize = True
        Me.ckfontunderline.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckfontunderline.Location = New System.Drawing.Point(235, 85)
        Me.ckfontunderline.Name = "ckfontunderline"
        Me.ckfontunderline.Size = New System.Drawing.Size(95, 17)
        Me.ckfontunderline.TabIndex = 4
        Me.ckfontunderline.Text = "Font Underline"
        Me.ckfontunderline.UseVisualStyleBackColor = True
        '
        'ckfontstrikeout
        '
        Me.ckfontstrikeout.AutoSize = True
        Me.ckfontstrikeout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckfontstrikeout.Location = New System.Drawing.Point(134, 85)
        Me.ckfontstrikeout.Name = "ckfontstrikeout"
        Me.ckfontstrikeout.Size = New System.Drawing.Size(92, 17)
        Me.ckfontstrikeout.TabIndex = 3
        Me.ckfontstrikeout.Text = "Font Strikeout"
        Me.ckfontstrikeout.UseVisualStyleBackColor = True
        '
        'ckfontitalic
        '
        Me.ckfontitalic.AutoSize = True
        Me.ckfontitalic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckfontitalic.Location = New System.Drawing.Point(235, 60)
        Me.ckfontitalic.Name = "ckfontitalic"
        Me.ckfontitalic.Size = New System.Drawing.Size(72, 17)
        Me.ckfontitalic.TabIndex = 2
        Me.ckfontitalic.Text = "Font Italic"
        Me.ckfontitalic.UseVisualStyleBackColor = True
        '
        'ckfontbold
        '
        Me.ckfontbold.AutoSize = True
        Me.ckfontbold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckfontbold.Location = New System.Drawing.Point(134, 62)
        Me.ckfontbold.Name = "ckfontbold"
        Me.ckfontbold.Size = New System.Drawing.Size(80, 17)
        Me.ckfontbold.TabIndex = 1
        Me.ckfontbold.Text = "Font Bold"
        Me.ckfontbold.UseVisualStyleBackColor = True
        '
        'bttnbackcolor
        '
        Me.bttnbackcolor.Location = New System.Drawing.Point(6, 29)
        Me.bttnbackcolor.Name = "bttnbackcolor"
        Me.bttnbackcolor.Size = New System.Drawing.Size(106, 23)
        Me.bttnbackcolor.TabIndex = 0
        Me.bttnbackcolor.Text = "Change BackColor"
        Me.bttnbackcolor.UseVisualStyleBackColor = True
        '
        'hperlink
        '
        Me.hperlink.Location = New System.Drawing.Point(36, 168)
        Me.hperlink.Name = "hperlink"
        Me.hperlink.Size = New System.Drawing.Size(257, 20)
        Me.hperlink.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "HyperLink"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(310, 89)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(82, 20)
        Me.TextBox1.TabIndex = 10
        '
        'Editknowledgeitem
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(450, 408)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.hperlink)
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
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Editknowledgeitem"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Editknowledgeitem"
        Me.TableLayoutPanel1.ResumeLayout(False)
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
    Friend WithEvents hperlink As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
