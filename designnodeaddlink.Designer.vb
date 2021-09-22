<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class designnodeaddlink
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtresourcename = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtresourcelink = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.opt_folder = New System.Windows.Forms.RadioButton()
        Me.opt_file = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "reource name"
        '
        'txtresourcename
        '
        Me.txtresourcename.Location = New System.Drawing.Point(122, 27)
        Me.txtresourcename.Name = "txtresourcename"
        Me.txtresourcename.Size = New System.Drawing.Size(306, 20)
        Me.txtresourcename.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(436, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 22)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Browser"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtresourcelink
        '
        Me.txtresourcelink.Location = New System.Drawing.Point(124, 63)
        Me.txtresourcelink.Name = "txtresourcelink"
        Me.txtresourcelink.Size = New System.Drawing.Size(306, 20)
        Me.txtresourcelink.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "reource link"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(242, 175)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 22)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(348, 175)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 22)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "CANCEL"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.opt_folder)
        Me.GroupBox1.Controls.Add(Me.opt_file)
        Me.GroupBox1.Location = New System.Drawing.Point(124, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 59)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "browser option"
        '
        'opt_folder
        '
        Me.opt_folder.AutoSize = True
        Me.opt_folder.Location = New System.Drawing.Point(110, 21)
        Me.opt_folder.Name = "opt_folder"
        Me.opt_folder.Size = New System.Drawing.Size(54, 17)
        Me.opt_folder.TabIndex = 1
        Me.opt_folder.Text = "Folder"
        Me.opt_folder.UseVisualStyleBackColor = True
        '
        'opt_file
        '
        Me.opt_file.AutoSize = True
        Me.opt_file.Checked = True
        Me.opt_file.Location = New System.Drawing.Point(15, 19)
        Me.opt_file.Name = "opt_file"
        Me.opt_file.Size = New System.Drawing.Size(41, 17)
        Me.opt_file.TabIndex = 0
        Me.opt_file.TabStop = True
        Me.opt_file.Text = "File"
        Me.opt_file.UseVisualStyleBackColor = True
        '
        'designnodeaddlink
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 209)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtresourcelink)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtresourcename)
        Me.Controls.Add(Me.Label1)
        Me.Name = "designnodeaddlink"
        Me.Text = "designnodeaddlink"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtresourcename As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtresourcelink As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents opt_folder As System.Windows.Forms.RadioButton
    Friend WithEvents opt_file As System.Windows.Forms.RadioButton
End Class
