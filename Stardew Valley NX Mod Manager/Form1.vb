Imports System.IO
Imports SevenZip

Public Class Form1
    Private _7zFileList As New List(Of String) 'list to store .7z files
    Private _outputDirectory As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'initialize SevenZipExtractor
        SevenZipExtractor.SetLibraryPath("7z.dll")
        MessageBox.Show("When Exporting It'll Create A New Folder 0100E65002BB8000 Containing The Merged Mods Anywhere You Define!", "Stardew Valley NX Mod Manager")
    End Sub

    Private Sub CreditsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditsToolStripMenuItem.Click
        MessageBox.Show("Version 0.1.3, Developed By Cod3xDev.", "About")
    End Sub

    Private Sub OpenModToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenModToolStripMenuItem.Click
        'open file dialog to select .7z file
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "7-Zip files (*.7z)|*.7z"
        openFileDialog.Title = "Select 7-Zip File"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            'add selected file to list and listbox with a prefix indicating its priority
            _7zFileList.Add(openFileDialog.FileName)
            UpdateListBox()
        End If
    End Sub

    Private Sub ExportModsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportModsToolStripMenuItem.Click
        'prompt user for output directory
        Dim folderDialog As New FolderBrowserDialog()
        folderDialog.Description = "Select Output Directory"
        If folderDialog.ShowDialog() = DialogResult.OK Then
            Dim fileDict As New Dictionary(Of String, String)

            For Each archivePath In _7zFileList
                Dim extractor As New SevenZipExtractor(archivePath)

                For Each entry In extractor.ArchiveFileData
                    If Not entry.IsDirectory AndAlso fileDict.ContainsKey(entry.FileName) Then
                        Dim message As String = $"Duplicate file found: {entry.FileName}" & vbCrLf &
                                            $"1. {fileDict(entry.FileName)}" & vbCrLf &
                                            $"2. {archivePath}" & vbCrLf & vbCrLf &
                                            "Select the version you want to keep (1 or 2):"

                        Dim result As String = InputBox(message, "Duplicate File Found", "1")
                        If result = "2" Then
                            fileDict(entry.FileName) = archivePath
                        End If
                    ElseIf Not entry.IsDirectory Then
                        fileDict(entry.FileName) = archivePath
                    End If
                Next
            Next

            ' Extract only the selected files
            For Each file In fileDict.Keys
                Dim archivePath As String = fileDict(file)
                Using extractor As New SevenZipExtractor(archivePath)
                    extractor.ExtractFiles(folderDialog.SelectedPath, file)
                End Using
            Next

            MessageBox.Show("Successfully Exported Merged Mods!")
        End If
    End Sub


    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        'prompt user for profile name
        Dim name As String = InputBox("Enter a name for the profile:", "Save Profile")
        If name <> "" Then
            'create a new profile and save it to a file
            Dim profile As New Profile(name, _outputDirectory, _7zFileList)
            profile.Save($"{name}.xml")
        End If
    End Sub

    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        'display a list of available profiles
        Dim profiles As New List(Of String)
        For Each file As String In Directory.GetFiles(".", "*.xml")
            Dim profile As Profile = Profile.Load(file)
            profiles.Add(profile.Name)
        Next
        Dim result As String = InputBox("Select a profile:", "Load Profile", String.Join(", ", profiles))
        If result <> "" Then
            'load the selected profile
            Dim profile As Profile = Profile.Load($"{result}.xml")
            _7zFileList = profile.Files
            _outputDirectory = profile.OutputDirectory
            'update the listbox
            UpdateListBox()
        End If
    End Sub

    Private Sub UpdateListBox()
        lbfiles.Items.Clear()
        For i = 0 To _7zFileList.Count - 1
            lbfiles.Items.Add($"[{i + 1}] {_7zFileList(i)}")
        Next
    End Sub


    Private Sub btnMoveUp_Click(sender As Object, e As EventArgs) Handles btnMoveUp.Click
        'move selected item up in list and listbox
        Dim index As Integer = lbfiles.SelectedIndex
        If index > 0 Then
            Dim temp As String = _7zFileList(index)
            _7zFileList(index) = _7zFileList(index - 1)
            _7zFileList(index - 1) = temp
            lbfiles.Items.RemoveAt(index)
            lbfiles.Items.Insert(index - 1, $"[{index}] {temp}")
            lbfiles.SelectedIndex = index - 1
            'update the prefixes of all the items in the list box
            For i = 0 To _7zFileList.Count - 1
                lbfiles.Items(i) = $"[{i + 1}] {_7zFileList(i)}"
            Next
        End If
    End Sub

    Private Sub btnMoveDown_Click(sender As Object, e As EventArgs) Handles btnMoveDown.Click
        'move selected item down in list and listbox
        Dim index As Integer = lbfiles.SelectedIndex
        If index < _7zFileList.Count - 1 Then
            Dim temp As String = _7zFileList(index)
            _7zFileList(index) = _7zFileList(index + 1)
            _7zFileList(index + 1) = temp
            lbfiles.Items.RemoveAt(index)
            lbfiles.Items.Insert(index + 1, temp)
            lbfiles.SelectedIndex = index + 1
            'update the prefixes of all the items in the list box
            For i = 0 To _7zFileList.Count - 1
                lbfiles.Items(i) = $"[{i + 1}] {_7zFileList(i)}"
            Next
        End If
    End Sub
End Class
