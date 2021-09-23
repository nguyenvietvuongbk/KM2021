<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertDesignNode
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtworktitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtworkdescription = New System.Windows.Forms.TextBox()
        Me.ckfinish = New System.Windows.Forms.CheckBox()
        Me.bttnOK = New System.Windows.Forms.Button()
        Me.bttnCANCEL = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bttn_addlink = New System.Windows.Forms.Button()
        Me.bttnremovelink = New System.Windows.Forms.Button()
        Me.bttnmodifylink = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Design title"
        '
        'txtworktitle
        '
        Me.txtworktitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtworktitle.Location = New System.Drawing.Point(86, 9)
        Me.txtworktitle.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtworktitle.Name = "txtworktitle"
        Me.txtworktitle.Size = New System.Drawing.Size(529, 23)
        Me.txtworktitle.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Design Description"
        '
        'txtworkdescription
        '
        Me.txtworkdescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtworkdescription.Location = New System.Drawing.Point(0, 0)
        Me.txtworkdescription.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtworkdescription.Multiline = True
        Me.txtworkdescription.Name = "txtworkdescription"
        Me.txtworkdescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtworkdescription.Size = New System.Drawing.Size(603, 195)
        Me.txtworkdescription.TabIndex = 3
        '
        'ckfinish
        '
        Me.ckfinish.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckfinish.AutoSize = True
        Me.ckfinish.Location = New System.Drawing.Point(384, 39)
        Me.ckfinish.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ckfinish.Name = "ckfinish"
        Me.ckfinish.Size = New System.Drawing.Size(57, 19)
        Me.ckfinish.TabIndex = 4
        Me.ckfinish.Text = "Finish"
        Me.ckfinish.UseVisualStyleBackColor = True
        '
        'bttnOK
        '
        Me.bttnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnOK.Location = New System.Drawing.Point(473, 423)
        Me.bttnOK.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bttnOK.Name = "bttnOK"
        Me.bttnOK.Size = New System.Drawing.Size(142, 30)
        Me.bttnOK.TabIndex = 5
        Me.bttnOK.Text = "OK"
        Me.bttnOK.UseVisualStyleBackColor = True
        '
        'bttnCANCEL
        '
        Me.bttnCANCEL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnCANCEL.Location = New System.Drawing.Point(473, 394)
        Me.bttnCANCEL.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bttnCANCEL.Name = "bttnCANCEL"
        Me.bttnCANCEL.Size = New System.Drawing.Size(142, 23)
        Me.bttnCANCEL.TabIndex = 6
        Me.bttnCANCEL.Text = "CANCEL"
        Me.bttnCANCEL.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(603, 126)
        Me.Panel1.TabIndex = 7
        '
        'bttn_addlink
        '
        Me.bttn_addlink.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttn_addlink.Location = New System.Drawing.Point(11, 394)
        Me.bttn_addlink.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bttn_addlink.Name = "bttn_addlink"
        Me.bttn_addlink.Size = New System.Drawing.Size(106, 30)
        Me.bttn_addlink.TabIndex = 8
        Me.bttn_addlink.Text = "add link"
        Me.bttn_addlink.UseVisualStyleBackColor = True
        '
        'bttnremovelink
        '
        Me.bttnremovelink.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttnremovelink.Location = New System.Drawing.Point(147, 394)
        Me.bttnremovelink.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bttnremovelink.Name = "bttnremovelink"
        Me.bttnremovelink.Size = New System.Drawing.Size(100, 30)
        Me.bttnremovelink.TabIndex = 9
        Me.bttnremovelink.Text = "remove link"
        Me.bttnremovelink.UseVisualStyleBackColor = True
        '
        'bttnmodifylink
        '
        Me.bttnmodifylink.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttnmodifylink.Location = New System.Drawing.Point(279, 394)
        Me.bttnmodifylink.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bttnmodifylink.Name = "bttnmodifylink"
        Me.bttnmodifylink.Size = New System.Drawing.Size(96, 30)
        Me.bttnmodifylink.TabIndex = 10
        Me.bttnmodifylink.Text = "modify link"
        Me.bttnmodifylink.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(279, 430)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Select Design Folder"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(11, 430)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Open Folder"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(123, 430)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(148, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Create Design Document"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(500, 39)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Adding resourcelink"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 460)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(626, 22)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(128, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 62)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtworkdescription)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(603, 326)
        Me.SplitContainer1.SplitterDistance = 195
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 16
        '
        'InsertDesignNode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 482)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bttnmodifylink)
        Me.Controls.Add(Me.bttnremovelink)
        Me.Controls.Add(Me.bttn_addlink)
        Me.Controls.Add(Me.bttnCANCEL)
        Me.Controls.Add(Me.bttnOK)
        Me.Controls.Add(Me.ckfinish)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtworktitle)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "InsertDesignNode"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtworktitle As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtworkdescription As System.Windows.Forms.TextBox
    Friend WithEvents ckfinish As System.Windows.Forms.CheckBox
    Friend WithEvents bttnOK As System.Windows.Forms.Button
    Friend WithEvents bttnCANCEL As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bttn_addlink As System.Windows.Forms.Button
    Friend WithEvents bttnremovelink As System.Windows.Forms.Button
    Friend WithEvents bttnmodifylink As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
End Class
