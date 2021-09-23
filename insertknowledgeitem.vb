Imports System.Windows.Forms


Public Class insertknowledgeitem
    Public Enum KnowleadgeType
        none
        Generalknowledgetype
        hyperlink
        documentgroup
        documentfile
        deploygroup
        deploypath
        scheduletype
        workingdesigntype
    End Enum
    Public nodetype As KnowleadgeType
    Public ParentNode As String
    Public childnodetype As String
    Public nodetext As String
    Public hyperlinkchecked As Boolean
    Public hyperlinkstring As String
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If txtnodetext.Text = "" Then
            MsgBox(" nodetext must not be empty")
            Exit Sub
        Else
            'childnodetype = txtchildnodetype.Text
            nodetext = txtnodetext.Text
        End If
        nodetype = KnowleadgeType.none
        If opt_generaltype.Checked = True Then
            nodetype = KnowleadgeType.Generalknowledgetype
        End If
        If opt_hyperlinktype.Checked = True Then
            nodetype = KnowleadgeType.hyperlink
        End If
        If opt_documentgroup.Checked = True Then
            nodetype = KnowleadgeType.documentgroup
        End If
        If opt_documentfile.Checked = True Then
            nodetype = KnowleadgeType.documentfile
        End If
        If opt_deploygroup.Checked = True Then
            nodetype = KnowleadgeType.deploygroup
        End If
        If opt_deploypath.Checked = True Then
            nodetype = KnowleadgeType.deploypath
        End If
        If opt_schedulenode.Checked = True Then
            nodetype = KnowleadgeType.scheduletype
        End If
        If opt_workingdesignnode.Checked = True Then
            nodetype = KnowleadgeType.workingdesigntype
        End If

        hyperlinkstring = txtlink.Text
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        childnodetype = ""
        nodetext = ""
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub insertknowledgeitem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblnodetype.Text = "Insert to " & ParentNode
        'txtchildnodetype.Text = childnodetype
    End Sub
    Public Sub disallopt()
        opt_deploygroup.Enabled = False
        opt_deploypath.Enabled = False
        opt_documentfile.Enabled = False
        opt_documentgroup.Enabled = False
        opt_generaltype.Enabled = False
        opt_hyperlinktype.Enabled = False
        opt_schedulenode.Enabled = False
        opt_workingdesignnode.Enabled = False
        opt_deploygroup.Checked = False
        opt_deploypath.Checked = False
        opt_documentfile.Checked = False
        opt_documentgroup.Checked = False
        opt_generaltype.Checked = False
        opt_hyperlinktype.Checked = False
        opt_schedulenode.Checked = False
        opt_workingdesignnode.Checked = False

    End Sub
    Public Sub enallopt()
        opt_deploygroup.Enabled = True
        opt_deploypath.Enabled = True
        opt_documentfile.Enabled = True
        opt_documentgroup.Enabled = True
        opt_generaltype.Enabled = True
        opt_hyperlinktype.Enabled = True
        opt_schedulenode.Enabled = True
        opt_workingdesignnode.Enabled = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newtv As New FolderAndFile
        newtv.showFileSelection()
        If newtv.fileselection <> "" Then
            txtnodetext.Text = newtv.fileselection
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bttnselectlink.Click
        Dim FF As New FolderAndFile
        Dim xmlnodeselect As Xml.XmlNode
        xmlnodeselect = FrmMain.KM.xmlknowledge.FindXMLnode(FrmMain.KM.treeviewControl.SelectedNode)

        FF.showFileFolderSelection()
        If FF.FolderAndFileSelection <> "" Then
            txtlink.Text = FF.FolderAndFileSelection
            'FrmMain.KM.xmlknowledge.AppendAttribute(xmlnodeselect, "href", FF.FolderAndFileSelection)
            'FrmMain.KM.xmlknowledge.AppendAttribute(xmlnodeselect, "nodetype", "hyperlink")
            'do the nodetype appearence update here'///////////
            '///////////////////////////////////////////////
            'FrmMain.KM.xmlknowledge.SetNodeAsHyPerlinkNode(FrmMain.KM.treeviewControl.SelectedNode, FrmMain.KM.treeviewControl.Font.Name, FrmMain.KM.treeviewControl.Font.Size)
            '///////////////////////////////////////////////
            'DOMchange = True
            'FrmMain.KM.RefreshKM()
        End If
        FF = Nothing
    End Sub

    Private Sub opt_hyperlinktype_CheckedChanged(sender As Object, e As EventArgs) Handles opt_hyperlinktype.CheckedChanged
        'MsgBox("Test opt_hyperlinktype_CheckedChanged Checkchange")
        If opt_hyperlinktype.Checked = True Then
            bttnselectlink.Enabled = True
            txtlink.Enabled = True
        Else
            bttnselectlink.Enabled = False
            txtlink.Enabled = False
        End If
    End Sub
End Class
