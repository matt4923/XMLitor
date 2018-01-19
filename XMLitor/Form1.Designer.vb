<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.grdView = New System.Windows.Forms.DataGridView
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.SaveFD = New System.Windows.Forms.SaveFileDialog
        Me.cmbTableNames = New System.Windows.Forms.ComboBox
        Me.OpenFD = New System.Windows.Forms.OpenFileDialog
        Me.pbSkeletor = New System.Windows.Forms.PictureBox
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutXMLitorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.grdView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pbSkeletor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenXMLToolStripMenuItem, Me.SaveXMLToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenXMLToolStripMenuItem
        '
        Me.OpenXMLToolStripMenuItem.Name = "OpenXMLToolStripMenuItem"
        Me.OpenXMLToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.OpenXMLToolStripMenuItem.Text = "&Open XML"
        '
        'SaveXMLToolStripMenuItem
        '
        Me.SaveXMLToolStripMenuItem.Name = "SaveXMLToolStripMenuItem"
        Me.SaveXMLToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.SaveXMLToolStripMenuItem.Text = "&Save XML"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'grdView
        '
        Me.grdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grdView.Location = New System.Drawing.Point(0, 54)
        Me.grdView.Name = "grdView"
        Me.grdView.Size = New System.Drawing.Size(593, 526)
        Me.grdView.TabIndex = 5
        Me.grdView.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(593, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SaveFD
        '
        Me.SaveFD.Filter = "XML Files|*.xml"
        '
        'cmbTableNames
        '
        Me.cmbTableNames.FormattingEnabled = True
        Me.cmbTableNames.Location = New System.Drawing.Point(12, 27)
        Me.cmbTableNames.Name = "cmbTableNames"
        Me.cmbTableNames.Size = New System.Drawing.Size(276, 21)
        Me.cmbTableNames.TabIndex = 7
        Me.cmbTableNames.Visible = False
        '
        'OpenFD
        '
        Me.OpenFD.Filter = "XML Files|*.xml"
        '
        'pbSkeletor
        '
        Me.pbSkeletor.Image = CType(resources.GetObject("pbSkeletor.Image"), System.Drawing.Image)
        Me.pbSkeletor.Location = New System.Drawing.Point(0, 26)
        Me.pbSkeletor.Name = "pbSkeletor"
        Me.pbSkeletor.Size = New System.Drawing.Size(593, 569)
        Me.pbSkeletor.TabIndex = 10
        Me.pbSkeletor.TabStop = False
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutXMLitorToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutXMLitorToolStripMenuItem
        '
        Me.AboutXMLitorToolStripMenuItem.Name = "AboutXMLitorToolStripMenuItem"
        Me.AboutXMLitorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutXMLitorToolStripMenuItem.Text = "&About XMLitor"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 580)
        Me.Controls.Add(Me.grdView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.cmbTableNames)
        Me.Controls.Add(Me.pbSkeletor)
        Me.MinimumSize = New System.Drawing.Size(609, 618)
        Me.Name = "Form1"
        Me.Text = "Select an XML File"
        CType(Me.grdView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pbSkeletor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenXMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grdView As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SaveFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmbTableNames As System.Windows.Forms.ComboBox
    Friend WithEvents OpenFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveXMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pbSkeletor As System.Windows.Forms.PictureBox
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutXMLitorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
