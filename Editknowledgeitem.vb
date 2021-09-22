Imports System.Windows.Forms

Public Class Editknowledgeitem
    Public knowledgetext As String
    Public knowledgeNodeType As String
    Public knowledgeChildType As String
    Public hyperlink As String
    Public BackColorSel As String
    Public ForeColorSel As String
    Public fontname As String
    Public fontsize As String
    Public FontBlod As Boolean
    Public fontItalic As Boolean
    Public fontstrikeout As Boolean
    Public fontunderline As Boolean
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If txtknowledgetext.Text = "" Then
            MsgBox("Knowledgetext must not be empty string", vbInformation, "Notice")
            Exit Sub
        Else
            knowledgetext = txtknowledgetext.Text
        End If
        If txttype.Text = "" Then
            MsgBox("knowledgeNodeType must not be empty string", vbInformation, "Notice")
            Exit Sub
        Else
            knowledgeNodeType = txttype.Text
        End If
        If txtchildtype.Text = "" Then
            MsgBox("knowledgeChildType must not be empty string", vbInformation, "Notice")
            Exit Sub
        Else
            knowledgeChildType = txtchildtype.Text
        End If
        BackColorSel = bttnbackcolor.BackColor.ToArgb.ToString
        ForeColorSel = btnforecolor.BackColor.ToArgb.ToString
        fontname = cbfontname.Text
        fontsize = txtfontsize.Text
        FontBlod = ckfontbold.Checked
        fontItalic = ckfontitalic.Checked
        fontstrikeout = ckfontstrikeout.Checked
        fontunderline = ckfontunderline.Checked
        hyperlink = hperlink.Text
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Editknowledgeitem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtknowledgetext.Text = knowledgetext
        txttype.Text = knowledgeNodeType
        txtchildtype.Text = knowledgeChildType
        hperlink.Text = hyperlink
        'style
        listallfontname(cbfontname)
        If fontname <> "" Then
            cbfontname.Text = fontname
        Else
            cbfontname.Text = FrmMain.KM.treeviewControl.Font.Name
        End If
        If fontsize <> "" Then
            txtfontsize.Text = fontsize
        Else
            txtfontsize.Text = FrmMain.KM.treeviewControl.Font.Size
        End If

        ckfontbold.Checked = FontBlod
        ckfontitalic.Checked = fontItalic
        ckfontstrikeout.Checked = fontstrikeout
        ckfontunderline.Checked = fontunderline

        If BackColorSel <> "" Then
            bttnbackcolor.BackColor = Color.FromArgb(CInt(BackColorSel))
        End If
        If ForeColorSel <> "" Then
            btnforecolor.BackColor = Color.FromArgb(CInt(ForeColorSel))
        End If

    End Sub

    Private Sub listallfontname(cb As ComboBox)
        cb.Items.Clear()
        'foreach ff as FontFamily  in FontFamily.Families
        For Each ff As FontFamily In FontFamily.Families
            If ff.IsStyleAvailable(FontStyle.Regular) Then
                cb.Items.Add(ff.Name)
            End If
        Next
        cb.SelectedIndex = 0
        'If (ff.IsStyleAvailable(FontStyle.Regular)) Then
        'Items.Add(ff.Name);                                             

    End Sub
    Private Sub bttnbackcolor_Click(sender As Object, e As EventArgs) Handles bttnbackcolor.Click
        Dim dlg As ColorDialog
        dlg = New ColorDialog
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            bttnbackcolor.BackColor = dlg.Color
        End If
        dlg = Nothing
    End Sub

    Private Sub btnforecolor_Click(sender As Object, e As EventArgs) Handles btnforecolor.Click
        Dim dlg As ColorDialog
        dlg = New ColorDialog
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            btnforecolor.BackColor = dlg.Color
        End If
        dlg = Nothing
    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles hperlink.TextChanged

    End Sub
End Class
