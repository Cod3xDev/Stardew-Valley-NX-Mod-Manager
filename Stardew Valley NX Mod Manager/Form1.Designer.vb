<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpenModToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportModsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbfiles = New System.Windows.Forms.ListBox()
        Me.btnMoveDown = New System.Windows.Forms.Button()
        Me.btnMoveUp = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenModToolStripMenuItem, Me.ExportModsToolStripMenuItem, Me.ProfilesToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1244, 56)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpenModToolStripMenuItem
        '
        Me.OpenModToolStripMenuItem.Image = Global.Stardew_Valley_NX_Mod_Manager.My.Resources.Resources.file_arrow_up_solid
        Me.OpenModToolStripMenuItem.Name = "OpenModToolStripMenuItem"
        Me.OpenModToolStripMenuItem.Size = New System.Drawing.Size(267, 52)
        Me.OpenModToolStripMenuItem.Text = "Open Mod"
        '
        'ExportModsToolStripMenuItem
        '
        Me.ExportModsToolStripMenuItem.Image = Global.Stardew_Valley_NX_Mod_Manager.My.Resources.Resources.file_arrow_down_solid
        Me.ExportModsToolStripMenuItem.Name = "ExportModsToolStripMenuItem"
        Me.ExportModsToolStripMenuItem.Size = New System.Drawing.Size(297, 52)
        Me.ExportModsToolStripMenuItem.Text = "Export Mods"
        '
        'ProfilesToolStripMenuItem
        '
        Me.ProfilesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.LoadToolStripMenuItem})
        Me.ProfilesToolStripMenuItem.Image = Global.Stardew_Valley_NX_Mod_Manager.My.Resources.Resources.user_solid
        Me.ProfilesToolStripMenuItem.Name = "ProfilesToolStripMenuItem"
        Me.ProfilesToolStripMenuItem.Size = New System.Drawing.Size(213, 52)
        Me.ProfilesToolStripMenuItem.Text = "Profiles"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = Global.Stardew_Valley_NX_Mod_Manager.My.Resources.Resources.file_arrow_down_solid
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(538, 66)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Image = Global.Stardew_Valley_NX_Mod_Manager.My.Resources.Resources.file_arrow_up_solid
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(538, 66)
        Me.LoadToolStripMenuItem.Text = "Load"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreditsToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(145, 52)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'CreditsToolStripMenuItem
        '
        Me.CreditsToolStripMenuItem.Name = "CreditsToolStripMenuItem"
        Me.CreditsToolStripMenuItem.Size = New System.Drawing.Size(538, 66)
        Me.CreditsToolStripMenuItem.Text = "Credits"
        '
        'lbfiles
        '
        Me.lbfiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbfiles.FormattingEnabled = True
        Me.lbfiles.ItemHeight = 48
        Me.lbfiles.Location = New System.Drawing.Point(12, 73)
        Me.lbfiles.Name = "lbfiles"
        Me.lbfiles.Size = New System.Drawing.Size(1163, 532)
        Me.lbfiles.TabIndex = 1
        '
        'btnMoveDown
        '
        Me.btnMoveDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMoveDown.Location = New System.Drawing.Point(1181, 555)
        Me.btnMoveDown.Name = "btnMoveDown"
        Me.btnMoveDown.Size = New System.Drawing.Size(50, 50)
        Me.btnMoveDown.TabIndex = 2
        Me.btnMoveDown.Text = "V"
        Me.btnMoveDown.UseVisualStyleBackColor = True
        '
        'btnMoveUp
        '
        Me.btnMoveUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMoveUp.Location = New System.Drawing.Point(1182, 499)
        Me.btnMoveUp.Name = "btnMoveUp"
        Me.btnMoveUp.Size = New System.Drawing.Size(50, 50)
        Me.btnMoveUp.TabIndex = 3
        Me.btnMoveUp.Text = "Ʌ"
        Me.btnMoveUp.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(20.0!, 48.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 617)
        Me.Controls.Add(Me.btnMoveUp)
        Me.Controls.Add(Me.btnMoveDown)
        Me.Controls.Add(Me.lbfiles)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stardew Valley NX Mod Manager"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpenModToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportModsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbfiles As ListBox
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreditsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnMoveDown As Button
    Friend WithEvents btnMoveUp As Button
End Class
