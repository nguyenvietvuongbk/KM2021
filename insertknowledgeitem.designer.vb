<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class insertknowledgeitem
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
        Me.lblnodetype = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnodetext = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bttnselectlink = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.opt_workingdesignnode = New System.Windows.Forms.RadioButton()
        Me.opt_schedulenode = New System.Windows.Forms.RadioButton()
        Me.opt_deploypath = New System.Windows.Forms.RadioButton()
        Me.opt_deploygroup = New System.Windows.Forms.RadioButton()
        Me.opt_documentfile = New System.Windows.Forms.RadioButton()
        Me.opt_documentgroup = New System.Windows.Forms.RadioButton()
        Me.opt_hyperlinktype = New System.Windows.Forms.RadioButton()
        Me.opt_generaltype = New System.Windows.Forms.RadioButton()
        Me.txtlink = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(221, 34)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(170, 33)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK_Button.Location = New System.Drawing.Point(510, 217)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(77, 39)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(509, 147)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(77, 27)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'lblnodetype
        '
        Me.lblnodetype.AutoSize = True
        Me.lblnodetype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblnodetype.ForeColor = System.Drawing.Color.Aqua
        Me.lblnodetype.Location = New System.Drawing.Point(7, 9)
        Me.lblnodetype.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnodetype.Name = "lblnodetype"
        Me.lblnodetype.Size = New System.Drawing.Size(63, 20)
        Me.lblnodetype.TabIndex = 1
        Me.lblnodetype.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "node text"
        '
        'txtnodetext
        '
        Me.txtnodetext.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnodetext.Location = New System.Drawing.Point(90, 33)
        Me.txtnodetext.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtnodetext.Name = "txtnodetext"
        Me.txtnodetext.Size = New System.Drawing.Size(496, 23)
        Me.txtnodetext.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(531, 8)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 24)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "...."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(455, 13)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "File browser"
        '
        'bttnselectlink
        '
        Me.bttnselectlink.Enabled = False
        Me.bttnselectlink.Location = New System.Drawing.Point(7, 65)
        Me.bttnselectlink.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bttnselectlink.Name = "bttnselectlink"
        Me.bttnselectlink.Size = New System.Drawing.Size(75, 23)
        Me.bttnselectlink.TabIndex = 8
        Me.bttnselectlink.Text = "Select Link"
        Me.bttnselectlink.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.opt_workingdesignnode)
        Me.GroupBox1.Controls.Add(Me.opt_schedulenode)
        Me.GroupBox1.Controls.Add(Me.opt_deploypath)
        Me.GroupBox1.Controls.Add(Me.opt_deploygroup)
        Me.GroupBox1.Controls.Add(Me.opt_documentfile)
        Me.GroupBox1.Controls.Add(Me.opt_documentgroup)
        Me.GroupBox1.Controls.Add(Me.opt_hyperlinktype)
        Me.GroupBox1.Controls.Add(Me.opt_generaltype)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(90, 127)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(399, 141)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "KnowLeadge Item Type"
        '
        'opt_workingdesignnode
        '
        Me.opt_workingdesignnode.AutoSize = True
        Me.opt_workingdesignnode.Location = New System.Drawing.Point(209, 102)
        Me.opt_workingdesignnode.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.opt_workingdesignnode.Name = "opt_workingdesignnode"
        Me.opt_workingdesignnode.Size = New System.Drawing.Size(136, 19)
        Me.opt_workingdesignnode.TabIndex = 7
        Me.opt_workingdesignnode.Text = "Working Design Item"
        Me.opt_workingdesignnode.UseVisualStyleBackColor = True
        '
        'opt_schedulenode
        '
        Me.opt_schedulenode.AutoSize = True
        Me.opt_schedulenode.Location = New System.Drawing.Point(19, 102)
        Me.opt_schedulenode.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.opt_schedulenode.Name = "opt_schedulenode"
        Me.opt_schedulenode.Size = New System.Drawing.Size(126, 19)
        Me.opt_schedulenode.TabIndex = 6
        Me.opt_schedulenode.Text = "Schedule Item type"
        Me.opt_schedulenode.UseVisualStyleBackColor = True
        '
        'opt_deploypath
        '
        Me.opt_deploypath.AutoSize = True
        Me.opt_deploypath.Location = New System.Drawing.Point(209, 75)
        Me.opt_deploypath.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.opt_deploypath.Name = "opt_deploypath"
        Me.opt_deploypath.Size = New System.Drawing.Size(89, 19)
        Me.opt_deploypath.TabIndex = 5
        Me.opt_deploypath.Text = "Deploy Path"
        Me.opt_deploypath.UseVisualStyleBackColor = True
        '
        'opt_deploygroup
        '
        Me.opt_deploygroup.AutoSize = True
        Me.opt_deploygroup.Location = New System.Drawing.Point(209, 48)
        Me.opt_deploygroup.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.opt_deploygroup.Name = "opt_deploygroup"
        Me.opt_deploygroup.Size = New System.Drawing.Size(98, 19)
        Me.opt_deploygroup.TabIndex = 4
        Me.opt_deploygroup.Text = "Deploy Group"
        Me.opt_deploygroup.UseVisualStyleBackColor = True
        '
        'opt_documentfile
        '
        Me.opt_documentfile.AutoSize = True
        Me.opt_documentfile.Location = New System.Drawing.Point(209, 22)
        Me.opt_documentfile.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.opt_documentfile.Name = "opt_documentfile"
        Me.opt_documentfile.Size = New System.Drawing.Size(102, 19)
        Me.opt_documentfile.TabIndex = 3
        Me.opt_documentfile.Text = "Document File"
        Me.opt_documentfile.UseVisualStyleBackColor = True
        '
        'opt_documentgroup
        '
        Me.opt_documentgroup.AutoSize = True
        Me.opt_documentgroup.Location = New System.Drawing.Point(19, 75)
        Me.opt_documentgroup.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.opt_documentgroup.Name = "opt_documentgroup"
        Me.opt_documentgroup.Size = New System.Drawing.Size(117, 19)
        Me.opt_documentgroup.TabIndex = 2
        Me.opt_documentgroup.Text = "Document Group"
        Me.opt_documentgroup.UseVisualStyleBackColor = True
        '
        'opt_hyperlinktype
        '
        Me.opt_hyperlinktype.AutoSize = True
        Me.opt_hyperlinktype.Location = New System.Drawing.Point(19, 48)
        Me.opt_hyperlinktype.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.opt_hyperlinktype.Name = "opt_hyperlinktype"
        Me.opt_hyperlinktype.Size = New System.Drawing.Size(163, 19)
        Me.opt_hyperlinktype.TabIndex = 1
        Me.opt_hyperlinktype.Text = "Hyperlink knowledge type"
        Me.opt_hyperlinktype.UseVisualStyleBackColor = True
        '
        'opt_generaltype
        '
        Me.opt_generaltype.AutoSize = True
        Me.opt_generaltype.Checked = True
        Me.opt_generaltype.Location = New System.Drawing.Point(19, 22)
        Me.opt_generaltype.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.opt_generaltype.Name = "opt_generaltype"
        Me.opt_generaltype.Size = New System.Drawing.Size(152, 19)
        Me.opt_generaltype.TabIndex = 0
        Me.opt_generaltype.TabStop = True
        Me.opt_generaltype.Text = "General knowledge type"
        Me.opt_generaltype.UseVisualStyleBackColor = True
        '
        'txtlink
        '
        Me.txtlink.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtlink.Location = New System.Drawing.Point(90, 65)
        Me.txtlink.Name = "txtlink"
        Me.txtlink.Size = New System.Drawing.Size(497, 45)
        Me.txtlink.TabIndex = 11
        Me.txtlink.Text = ""
        '
        'insertknowledgeitem
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(599, 289)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.txtlink)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bttnselectlink)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtnodetext)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblnodetype)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "insertknowledgeitem"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "insertknowledgeitem"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents lblnodetype As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnodetext As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bttnselectlink As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents opt_hyperlinktype As System.Windows.Forms.RadioButton
    Friend WithEvents opt_generaltype As System.Windows.Forms.RadioButton
    Friend WithEvents opt_documentgroup As System.Windows.Forms.RadioButton
    Friend WithEvents opt_workingdesignnode As System.Windows.Forms.RadioButton
    Friend WithEvents opt_schedulenode As System.Windows.Forms.RadioButton
    Friend WithEvents opt_deploypath As System.Windows.Forms.RadioButton
    Friend WithEvents opt_deploygroup As System.Windows.Forms.RadioButton
    Friend WithEvents opt_documentfile As System.Windows.Forms.RadioButton
    Friend WithEvents txtlink As RichTextBox
End Class
