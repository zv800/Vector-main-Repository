Imports System.IO

Public Class Functions
    Public Shared Sub PopulateListBox(ByVal lsb As ListBox, ByVal Folder As String, ByVal FileType As String)
        Dim dinfo As DirectoryInfo = New DirectoryInfo(Folder)
        Dim Files As FileInfo() = dinfo.GetFiles(FileType)

        For Each file As FileInfo In Files
            lsb.Items.Add(file.Name)
        Next
    End Sub
End Class
