Public Class designnodeaddlink
    Public action As String
    Public command As String
    Public resoucename As String
    Public resourcelink As String
    Private FFX As FolderAndFile = New FolderAndFile
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        action = "OK"
        resoucename = txtresourcename.Text
        resourcelink = txtresourcelink.Text
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        action = "CANCEL"
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If opt_file.Checked = True Then
            FFX.showFileSelection()
            txtresourcelink.Text = FFX.fileselection
        End If
        If opt_folder.Checked = True Then
            FFX.showfolderSelection()
            txtresourcelink.Text = FFX.Folderselect
        End If
    End Sub


    Private Sub designnodeaddlink_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If command = "addnew" Then
            txtresourcelink.Text = ""
            txtresourcename.Text = ""
        Else
            txtresourcelink.Text = resourcelink
            txtresourcename.Text = resoucename

        End If
    End Sub
End Class