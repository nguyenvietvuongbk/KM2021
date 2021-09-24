Imports System.Xml
Public Class InsertDesignNode
    Public pressbutton As String
    Public designtitle As String
    Public designdes As String
    Public designfinish As Boolean
    Public designnode As XmlNode
    Public folderfordesignnode As String
    'Public filetocreatenewaddtoresourcelink As String
    Public xmlhandle As KnowledgeManagement
    Public resourcelinkstring As String
    Private action As String
    Dim WithEvents LVF As New ListViewFunction
    Dim wfc As windowformcontrol
    Dim internalvar As Boolean = False
    Dim FF As FolderAndFile = New FolderAndFile()
    Dim AL As Algorithm = New Algorithm()

    Private Structure resourcelink
        Dim resourcename
        Dim resourcelink
    End Structure
    Private Function resourcelinklist(xnode As XmlNode) As resourcelink()
        Dim rs As resourcelink() = Nothing
        Dim resourcelinkstring As String = xmlhandle.xmlknowledge.GetAttribute(xnode, "resourcelinkstring")
        If resourcelinkstring = "" Then
            Return Nothing
        End If
        Dim resourcecouple As String() = Split(resourcelinkstring, AL.resourseperate)
        For Each Str As String In resourcecouple
            Dim rsl As resourcelink
            rsl.resourcename = Split(Str, AL.rsnamesep)(0)
            rsl.resourcelink = Split(Str, AL.rsnamesep)(1)
            If rs Is Nothing Then
                ReDim rs(0)
            Else
                ReDim Preserve rs(UBound(rs) + 1)
            End If
            rs(UBound(rs)) = rsl
        Next
        Return rs
    End Function
    Private Function resourcelinklist(resourcelinkstring As String) As resourcelink()
        Dim rs As resourcelink() = Nothing
        'Dim resourcelinkstring As String = xmlhandle.xmlknowledge.GetAttribute(xnode, "resourcelinkstring")
        If resourcelinkstring = "" Then
            Return Nothing
        End If
        Dim resourcecouple As String() = Split(resourcelinkstring, AL.resourseperate)
        For Each Str As String In resourcecouple
            Dim rsl As resourcelink
            rsl.resourcename = Split(Str, AL.rsnamesep)(0)
            rsl.resourcelink = Split(Str, AL.rsnamesep)(1)
            If rs Is Nothing Then
                ReDim rs(0)
            Else
                ReDim Preserve rs(UBound(rs) + 1)
            End If
            rs(UBound(rs)) = rsl
        Next
        Return rs
    End Function
    Private Sub ShowresourceLink(LVFx As ListViewFunction, xnode As XmlNode)
        Dim reourcelist As resourcelink() = resourcelinklist(xnode)
        LVFx.ClearContent()
        LVF.SetupActionForListView(ImageList1, {"ID", "resource name", "resource link"}, {50, 200, 100}, True, False, )
        Dim resourcelist As resourcelink() = resourcelinklist(xnode)
        If resourcelist Is Nothing Then
            Exit Sub
        End If
        For i As Integer = 0 To UBound(resourcelist)
            LVF.AddnewItem({(i + 1).ToString(), resourcelist(i).resourcename, resourcelist(i).resourcelink})
        Next
        loadLVFwidth(LVFx, "insertdesignnodeLVF1")
    End Sub
    Private Sub ShowresourceLink(LVFx As ListViewFunction, resourcelinkstring As String)
        'Dim reourcelist As resourcelink() = resourcelinklist(xnode)
        LVFx.ClearContent()
        LVF.SetupActionForListView(ImageList1, {"ID", "resource name", "resource link"}, {50, 200, 100}, True, False, )
        loadLVFwidth(LVFx, "insertdesignnodeLVF1")
        Dim resourcelist As resourcelink() = resourcelinklist(resourcelinkstring)
        If resourcelist Is Nothing Then
            Exit Sub
        End If
        For i As Integer = 0 To UBound(resourcelist)
            LVF.AddnewItem({(i + 1).ToString(), resourcelist(i).resourcename, resourcelist(i).resourcelink})
        Next

    End Sub
    Private Sub LVF_ColumnWidthChanged(sender As Object, e As ColumnWidthChangedEventArgs) Handles LVF.ColumnWidthChanged
        If internalvar = True Then
            'MsgBox("Test workrecipe.LVF_ColumnWidthChanged")
            'Label1.Text = LVF.Columns(0).Width
            Dim widthstring As String = getLVFwidstring(LVF)

            'call update this string to a row have LVFname = "insertdesignnodeLVF1"
            If regobj.Filtering("lVFwidthstring", "LVFname", "LVFname", "insertdesignnodeLVF1").Count > 1 Then
                regobj.UpdateRows("lVFwidthstring", {"LVFname"}, {"insertdesignnodeLVF1"}, {"LVFwidthstring"}, {widthstring})
                'MsgBox("Test workrecipe.LVF_ColumnWidthChanged " & regobj.Filtering("lVFwidthstring", "LVFwidthstring", "LVFname", "workrecipeLVF1")(1))
            Else
                regobj.addnewrow("lVFwidthstring", {"insertdesignnodeLVF1", widthstring})
            End If
        End If
    End Sub
    Private Function decodetoLVFwidth(LVFwidthstring As String) As Integer()
        Dim rsstr As String() = Split(LVFwidthstring, "xxx")
        Dim ws As Integer()
        ReDim ws(UBound(rsstr))
        For i As Integer = 0 To UBound(rsstr)
            ws(i) = CInt(rsstr(i))
        Next
        Return ws
    End Function
    Private Sub LVF_DoubleClick(sender As Object, e As EventArgs) Handles LVF.DoubleClick
        'Dim selnode As Xml.XmlNode = getxmlnodefromLVFitem(LVF)
        'If KM_.xmlknowledge.GetAttribute(selnode, "href") <> "" Then
        Dim HyperLink = LVF.SelectedItems(0).SubItems(2).Text
        'saveworkrecipe(KM_.xmlknowledge.getxmlnodenameInfor(selnode))
        Process.Start(HyperLink)
        'End If
    End Sub
    Private Sub loadLVFwidth(LVFx As ListViewFunction, LVFname As String)
        Dim widthstring As String = ""

        If regobj.Filtering("lVFwidthstring", "LVFwidthstring", "LVFname", LVFname).Count > 1 Then
            widthstring = regobj.Filtering("lVFwidthstring", "LVFwidthstring", "LVFname", LVFname)(1)
            'MsgBox("Test workrecipe.loadLVFwidth " & widthstring)
            Dim widtharr As Integer() = decodetoLVFwidth(widthstring)
            For i As Integer = 0 To UBound(widtharr)
                LVFx.Columns(i).Width = widtharr(i)
            Next
        End If
    End Sub
    Private Function getLVFwidstring(LVFx As ListViewFunction) As String
        Dim rs As String = ""
        For i = 0 To LVFx.Columns.Count - 1
            If i = 0 Then
                rs = rs & LVFx.Columns(i).Width.ToString
            Else
                rs = rs & "xxx" & LVFx.Columns(i).Width.ToString
            End If
        Next
        Return rs
    End Function

    Private Sub InsertDesignNode_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        wfc = Nothing
        ' wfc = New wfc()
    End Sub
    Private Sub InsertDesignNode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'preparing the LVF
        'MsgBox("hello")
        wfc = New windowformcontrol()
        Panel1.Controls.Add(LVF)
        'LVF.SetupActionForListView(ImageList1, {"ID", "resource name", "resource link"}, {50, 200, 100}, True, False, )

        'preparing the database
        wfc.AdddockingObjectToForm(Me, txtworktitle, windowformcontrol.DockingType.KeepRight)
        'wfc.AdddockingObjectToForm(Me, txtworkdescription, windowformcontrol.DockingType.KeepRight)
        wfc.AdddockingObjectToForm(Me, ckfinish, windowformcontrol.DockingType.keepbottomwidthheight)
        wfc.AdddockingObjectToForm(Me, bttnOK, windowformcontrol.DockingType.keepbottomwidthHeighRight)
        wfc.AdddockingObjectToForm(Me, bttnCANCEL, windowformcontrol.DockingType.keepbottomwidthHeighRight)
        wfc.AdddockingObjectToForm(Me, SplitContainer1, windowformcontrol.DockingType.KeepBottomandRight)
        wfc.AdddockingObjectToForm(Me, bttn_addlink, windowformcontrol.DockingType.keepbottomwidthHeighRight)
        wfc.AdddockingObjectToForm(Me, bttnremovelink, windowformcontrol.DockingType.keepbottomwidthHeighRight)
        wfc.AdddockingObjectToForm(Me, bttnmodifylink, windowformcontrol.DockingType.keepbottomwidthHeighRight)
        wfc.AdddockingObjectToForm(Me, Button1, windowformcontrol.DockingType.keepbottomwidthHeighRight)
        wfc.AdddockingObjectToForm(Me, Button2, windowformcontrol.DockingType.keepbottomwidthHeighRight)
        wfc.AdddockingObjectToForm(Me, Button3, windowformcontrol.DockingType.keepbottomwidthHeighRight)

        If designtitle <> "" Then
            txtworktitle.Text = designtitle
        End If
        If action = "insertnew" Then
            txtworkdescription.Text = ""
            ckfinish.Checked = False
            resourcelinkstring = ""
        Else
            txtworkdescription.Text = designdes
            ckfinish.Checked = designfinish
        End If
        ToolStripStatusLabel2.Text = "Design Folder: " & folderfordesignnode
        ShowresourceLink(LVF, resourcelinkstring)
    End Sub
    Public Sub PrepareForInsertNew()
        action = "insertnew"
        folderfordesignnode = ""
        resourcelinkstring = ""
        'txtworktitle.Text = "New Design Item"
        'txtworkdescription.Text = ""
        'ckfinish.Checked = False
        'txtworktitle.Focus()
    End Sub
    Public Sub PrepareForEdit()
        action = "edit"
    End Sub
    Private Sub bttnCANCEL_Click(sender As Object, e As EventArgs) Handles bttnCANCEL.Click
        'Cancel button
        pressbutton = "CANCEL"
        '///////////////////////////////////////////////code here

        '///close the form
        Me.Close()
    End Sub

    Private Sub bttnOK_Click(sender As Object, e As EventArgs) Handles bttnOK.Click
        'Ok button
        pressbutton = "OK"
        '/////////////////////////////////////////////////code here
        designtitle = txtworktitle.Text
        designdes = txtworkdescription.Text
        designfinish = ckfinish.Checked
        Me.Close()
    End Sub
    'add new link to design node
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bttn_addlink.Click
        'preparing the workdesingnode 
        designnodeaddlink.command = "addnew"
        designnodeaddlink.ShowDialog()
        If designnodeaddlink.action = "OK" Then
            If designnodeaddlink.resoucename <> "" And designnodeaddlink.resourcelink <> "" Then
                'update resourcelinkstring attribute to the designnode
                Dim resourcename As String = designnodeaddlink.resoucename
                Dim resourcelink As String = designnodeaddlink.resourcelink
                'Dim resourcelinkstring = xmlhandle.xmlknowledge.GetAttribute(designnode, "resourcelinkstring")

                AL.AddNewPartToResourceLinkString(resourcelinkstring, resourcename, resourcelink)
                'xmlhandle.xmlknowledge.AppendAttribute(designnode, "resourcelinkstring", resourcelinkstring)
                ShowresourceLink(LVF, resourcelinkstring)
                'xmlhandle.Save()
            End If
        End If
    End Sub
    'modify a link of a design node
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles bttnmodifylink.Click
        If LVF.SelectedItems IsNot Nothing Then
            Dim rsname As String = LVF.SelectedItems(0).SubItems(1).Text
            Dim rslink As String = LVF.SelectedItems(0).SubItems(2).Text
            designnodeaddlink.command = "edit"
            designnodeaddlink.resoucename = rsname
            designnodeaddlink.resourcelink = rslink
            designnodeaddlink.ShowDialog()
            If designnodeaddlink.action = "OK" Then
                Dim newrsname As String = designnodeaddlink.resoucename
                Dim newrslink As String = designnodeaddlink.resourcelink
                AL.updateresourcelink(resourcelinkstring, rsname, rslink, newrsname, newrslink)
                'MsgBox(resourcelinkstring)
                ShowresourceLink(LVF, resourcelinkstring)
            End If
        Else
            MsgBox("you need select an item")
        End If

    End Sub
    'remove selected link
    Private Sub bttnremovelink_Click(sender As Object, e As EventArgs) Handles bttnremovelink.Click
        If LVF.SelectedItems IsNot Nothing Then
            'MsgBox(resourcelinkstring)
            Dim rsname As String = LVF.SelectedItems(0).SubItems(1).Text
            Dim rslink As String = LVF.SelectedItems(0).SubItems(2).Text
            AL.deleteresourcelink(resourcelinkstring, rsname, rslink)
            'MsgBox(resourcelinkstring)
            ShowresourceLink(LVF, resourcelinkstring)
        Else
            MsgBox("you need select an item")
        End If
    End Sub
    'select 
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        selectdesignfolder.folderselect = folderfordesignnode
        selectdesignfolder.ShowDialog()
        If selectdesignfolder.folderselect <> "" Then
            folderfordesignnode = selectdesignfolder.folderselect
            ToolStripStatusLabel2.Text = folderfordesignnode
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If FF.checkIsFolder(folderfordesignnode) = True Then
            Process.Start(folderfordesignnode)
        End If
    End Sub
    'create a file to be member of resourcelink of the designnode
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        InsertDocumentFile.ClearInput()
        InsertDocumentFile.filename = "" 'at the createnew time the filename of file is not defined
        InsertDocumentFile.InitDir = folderfordesignnode
        Dim rs = InsertDocumentFile.ShowDialog()
        If rs = DialogResult.OK Then
            If InsertDocumentFile.CreateNewFile = True Then
                ' the newfile is created baseon the Filetype and filename following a subroutine(filetype, filename)_. create and open this file for user edit information
                Dim filename As String = InsertDocumentFile.filename
                Dim fullpath As String = InsertDocumentFile.ExistingFilePath
                Dim filetype As Long = InsertDocumentFile.Filetype
                Dim createnewfile As Boolean = InsertDocumentFile.CreateNewFile
                Dim selectexistedfile As Boolean = InsertDocumentFile.SelectExisting
                If createnewfile = True Then
                    Dim filepath As String = FF.CreateFileAndOpen(folderfordesignnode, filename, filetype)
                    'append filepath to resource link
                    AL.AddNewPartToResourceLinkString(resourcelinkstring, filename, filepath)
                    'show the resourcelink to listview
                    ShowresourceLink(LVF, resourcelinkstring)
                Else
                    If FF.checkIsFIle(fullpath) = True Then
                        AL.AddNewPartToResourceLinkString(resourcelinkstring, filename, fullpath)
                        'show the resourcelink to listview
                        ShowresourceLink(LVF, resourcelinkstring)
                    Else
                        MsgBox("You need select right file path !")
                    End If
       
                End If
            End If
        End If
    End Sub

End Class
