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
        Me.txtlink = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.opt_workingdesignnode = New System.Windows.Forms.RadioButton()
        Me.opt_schedulenode = New System.Windows.Forms.RadioButton()
        Me.opt_deploypath = New System.Windows.Forms.RadioButton()
        Me.opt_deploygroup = New System.Windows.Forms.RadioButton()
        Me.opt_documentfile = New System.Windows.Forms.RadioButton()
        Me.opt_documentgroup = New System.Windows.Forms.RadioButton()
        Me.opt_hyperlinktype = New System.Windows.Forms.RadioButton()
        Me.opt_generaltype = New System.Windows.Forms.RadioButton()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(387, 290)
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
        'lblnodetype
        '
        Me.lblnodetype.AutoSize = True
        Me.lblnodetype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnodetype.ForeColor = System.Drawing.Color.Aqua
        Me.lblnodetype.Location = New System.Drawing.Point(37, 9)
        Me.lblnodetype.Name = "lblnodetype"
        Me.lblnodetype.Size = New System.Drawing.Size(63, 20)
        Me.lblnodetype.TabIndex = 1
        Me.lblnodetype.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "node text"
        '
        'txtnodetext
        '
        Me.txtnodetext.Location = New System.Drawing.Point(134, 47)
        Me.txtnodetext.Name = "txtnodetext"
        Me.txtnodetext.Size = New System.Drawing.Size(249, 20)
        Me.txtnodetext.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(396, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 21)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "...."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(380, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "File browser"
        '
        'bttnselectlink
        '
        Me.bttnselectlink.Enabled = False
        Me.bttnselectlink.Location = New System.Drawing.Point(134, 80)
        Me.bttnselectlink.Name = "bttnselectlink"
        Me.bttnselectlink.Size = New System.Drawing.Size(77, 24)
        Me.bttnselectlink.TabIndex = 8
        Me.bttnselectlink.Text = "Select Link"
        Me.bttnselectlink.UseVisualStyleBackColor = True
        '
        'txtlink
        '
        Me.txtlink.Enabled = False
        Me.txtlink.Location = New System.Drawing.Point(134, 111)
        Me.txtlink.Name = "txtlink"
        Me.txtlink.Size = New System.Drawing.Size(396, 20)
        Me.txtlink.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.opt_workingdesignnode)
        Me.GroupBox1.Controls.Add(Me.opt_schedulenode)
        Me.GroupBox1.Controls.Add(Me.opt_deploypath)
        Me.GroupBox1.Controls.Add(Me.opt_deploygroup)
        Me.GroupBox1.Controls.Add(Me.opt_documentfile)
        Me.GroupBox1.Controls.Add(Me.opt_documentgroup)
        Me.GroupBox1.Controls.Add(Me.opt_hyperlinktype)
        Me.GroupBox1.Controls.Add(Me.opt_generaltype)
        Me.GroupBox1.Location = New System.Drawing.Point(134, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(396, 122)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "KnowLeadge Item Type"
        '
        'opt_workingdesignnode
        '
        Me.opt_workingdesignnode.AutoSize = True
        Me.opt_workingdesignnode.Location = New System.Drawing.Point(179, 88)
        Me.opt_workingdesignnode.Name = "opt_workingdesignnode"
        Me.opt_workingdesignnode.Size = New System.Drawing.Size(124, 17)
        Me.opt_workingdesignnode.TabIndex = 7
        Me.opt_workingdesignnode.Text = "Working Design Item"
        Me.opt_workingdesignnode.UseVisualStyleBackColor = True
        '
        'opt_schedulenode
        '
        Me.opt_schedulenode.AutoSize = True
        Me.opt_schedulenode.Location = New System.Drawing.Point(16, 88)
        Me.opt_schedulenode.Name = "opt_schedulenode"
        Me.opt_schedulenode.Size = New System.Drawing.Size(116, 17)
        Me.opt_schedulenode.TabIndex = 6
        Me.opt_schedulenode.Text = "Schedule Item type"
        Me.opt_schedulenode.UseVisualStyleBackColor = True
        '
        'opt_deploypath
        '
        Me.opt_deploypath.AutoSize = True
        Me.opt_deploypath.Location = New System.Drawing.Point(179, 65)
        Me.opt_deploypath.Name = "opt_deploypath"
        Me.opt_deploypath.Size = New System.Drawing.Size(83, 17)
        Me.opt_deploypath.TabIndex = 5
        Me.opt_deploypath.Text = "Deploy Path"
        Me.opt_deploypath.UseVisualStyleBackColor = True
        '
        'opt_deploygroup
        '
        Me.opt_deploygroup.AutoSize = True
        Me.opt_deploygroup.Location = New System.Drawing.Point(179, 42)
        Me.opt_deploygroup.Name = "opt_deploygroup"
        Me.opt_deploygroup.Size = New System.Drawing.Size(90, 17)
        Me.opt_deploygroup.TabIndex = 4
        Me.opt_deploygroup.Text = "Deploy Group"
        Me.opt_deploygroup.UseVisualStyleBackColor = True
        '
        'opt_documentfile
        '
        Me.opt_documentfile.AutoSize = True
        Me.opt_documentfile.Location = New System.Drawing.Point(179, 19)
        Me.opt_documentfile.Name = "opt_documentfile"
        Me.opt_documentfile.Size = New System.Drawing.Size(93, 17)
        Me.opt_documentfile.TabIndex = 3
        Me.opt_documentfile.Text = "Document File"
        Me.opt_documentfile.UseVisualStyleBackColor = True
        '
        'opt_documentgroup
        '
        Me.opt_documentgroup.AutoSize = True
        Me.opt_documentgroup.Location = New System.Drawing.Point(16, 65)
        Me.opt_documentgroup.Name = "opt_documentgroup"
        Me.opt_documentgroup.Size = New System.Drawing.Size(106, 17)
        Me.opt_documentgroup.TabIndex = 2
        Me.opt_documentgroup.Text = "Document Group"
        Me.opt_documentgroup.UseVisualStyleBackColor = True
        '
        'opt_hyperlinktype
        '
        Me.opt_hyperlinktype.AutoSize = True
        Me.opt_hyperlinktype.Location = New System.Drawing.Point(16, 42)
        Me.opt_hyperlinktype.Name = "opt_hyperlinktype"
        Me.opt_hyperlinktype.Size = New System.Drawing.Size(147, 17)
        Me.opt_hyperlinktype.TabIndex = 1
        Me.opt_hyperlinktype.Text = "Hyperlink knowledge type"
        Me.opt_hyperlinktype.UseVisualStyleBackColor = True
        '
        'opt_generaltype
        '
        Me.opt_generaltype.AutoSize = True
        Me.opt_generaltype.Checked = True
        Me.opt_generaltype.Location = New System.Drawing.Point(16, 19)
        Me.opt_generaltype.Name = "opt_generaltype"
        Me.opt_generaltype.Size = New System.Drawing.Size(140, 17)
        Me.opt_generaltype.TabIndex = 0
        Me.opt_generaltype.TabStop = True
        Me.opt_generaltype.Text = "General knowledge type"
        Me.opt_generaltype.UseVisualStyleBackColor = True
        '
        'insertknowledgeitem
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(545, 331)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtlink)
        Me.Controls.Add(Me.bttnselectlink)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtnodetext)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblnodetype)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "insertknowledgeitem"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "insertknowledgeitem"
        Me.TableLayoutPanel1.ResumeLayout(False)
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
    Friend WithEvents txtlink As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents opt_hyperlinktype As System.Windows.Forms.RadioButton
    Friend WithEvents opt_generaltype As System.Windows.Forms.RadioButton
    Friend WithEvents opt_documentgroup As System.Windows.Forms.RadioButton
    Friend WithEvents opt_workingdesignnode As System.Windows.Forms.RadioButton
    Friend WithEvents opt_schedulenode As System.Windows.Forms.RadioButton
    Friend WithEvents opt_deploypath As System.Windows.Forms.RadioButton
    Friend WithEvents opt_deploygroup As System.Windows.Forms.RadioButton
    Friend WithEvents opt_documentfile As System.Windows.Forms.RadioButton

End Class
