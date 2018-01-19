Public Class Form1
    Public ds As New DataSet

    Private Sub cmbTableNames_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTableNames.SelectedIndexChanged
        grdView.DataSource = ds.Tables(cmbTableNames.Text)
    End Sub

    Private Sub frmGridView_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = "XMLitor!"
    End Sub

    Private Sub OpenXMLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenXMLToolStripMenuItem.Click
        OpenFD.Title = "Select an XML file"
        Dim result As Integer = OpenFD.ShowDialog
        Dim FileName As String = OpenFD.FileName
        If result <> DialogResult.Cancel Then
            ds.Clear()
            cmbTableNames.Items.Clear()
            Me.Text = FileName.ToString
            Try
                ds.ReadXml(FileName)
                Dim i As Integer
                Do Until i = ds.Tables.Count
                    cmbTableNames.Items.Add(CType(ds.Tables(i).ToString, String))
                    i = i + 1
                Loop
                cmbTableNames.Text = cmbTableNames.Items(0).ToString
                SkeletorChange(False)
            Catch X As Xml.XmlException
                cmbTableNames.Items.Clear()
                ds.Clear()
                MsgBox("The selected file is not formatted correctly as an XML", MsgBoxStyle.Exclamation, "Bad File Format")
                SkeletorChange(True)
            End Try

            'Else
            '    MsgBox("Please select an XML file")
        End If
    End Sub

    Private Sub SkeletorChange(ByVal SkeletorOn As Boolean)
        If SkeletorOn Then
            grdView.Visible = False
            cmbTableNames.Visible = False
            pbSkeletor.Visible = True
            Me.Size = New Size(609, 618)
            Me.Text = ("Please select an XML file")
        Else
            grdView.Visible = True
            cmbTableNames.Visible = True
            pbSkeletor.Visible = False
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SaveXMLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveXMLToolStripMenuItem.Click
        SaveFD.Title = "Save to XML"
        Dim result As Integer = SaveFD.ShowDialog
        If result <> DialogResult.Cancel Then
            Try
                ds.WriteXml(SaveFD.FileName, XmlWriteMode.WriteSchema)
            Catch
                MsgBox("The edits made have caused an incorrect XML format structure.  The saved file will NOT contain edits.", MsgBoxStyle.Exclamation, "Bad File Format")
            End Try
        End If
    End Sub

    Private Sub AboutXMLitorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutXMLitorToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub
End Class
