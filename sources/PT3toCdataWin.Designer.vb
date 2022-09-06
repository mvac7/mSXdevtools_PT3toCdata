<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PT3toCdataWin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PT3toCdataWin))
        Me.OutputText = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ProjectToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ProjectNameTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.OutputToolsPanel = New System.Windows.Forms.Panel()
        Me.PiXelGroupBox1 = New mSXdevtools.PT3toCdata.piXelGroupBox()
        Me.NoteTableTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SongInfo_CheckBox = New System.Windows.Forms.CheckBox()
        Me.NoteTableLabel = New System.Windows.Forms.Label()
        Me.Author_TextBox = New System.Windows.Forms.TextBox()
        Me.HeaderCheckBox = New System.Windows.Forms.CheckBox()
        Me.Name_TextBox = New System.Windows.Forms.TextBox()
        Me.LabelTextBox = New System.Windows.Forms.TextBox()
        Me.LabelLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CopyAllButton = New System.Windows.Forms.Button()
        Me.SaveSourceButton = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.NewButton = New System.Windows.Forms.ToolStripButton()
        Me.Help_Button = New System.Windows.Forms.ToolStripButton()
        Me.About_Button = New System.Windows.Forms.ToolStripButton()
        Me.Load_Button = New System.Windows.Forms.Button()
        Me.ProjectToolStrip.SuspendLayout()
        Me.OutputToolsPanel.SuspendLayout()
        Me.PiXelGroupBox1.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OutputText
        '
        Me.OutputText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OutputText.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputText.Location = New System.Drawing.Point(12, 298)
        Me.OutputText.Multiline = True
        Me.OutputText.Name = "OutputText"
        Me.OutputText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.OutputText.Size = New System.Drawing.Size(740, 187)
        Me.OutputText.TabIndex = 8
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolTip1.ForeColor = System.Drawing.Color.Black
        Me.ToolTip1.IsBalloon = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(764, 22)
        Me.StatusStrip1.TabIndex = 70
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ProjectToolStrip
        '
        Me.ProjectToolStrip.BackColor = System.Drawing.Color.Gainsboro
        Me.ProjectToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ProjectToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewButton, Me.ProjectNameTextBox, Me.Help_Button, Me.About_Button})
        Me.ProjectToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ProjectToolStrip.Name = "ProjectToolStrip"
        Me.ProjectToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ProjectToolStrip.Size = New System.Drawing.Size(764, 31)
        Me.ProjectToolStrip.TabIndex = 71
        Me.ProjectToolStrip.Text = "ToolStrip1"
        '
        'ProjectNameTextBox
        '
        Me.ProjectNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ProjectNameTextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProjectNameTextBox.ForeColor = System.Drawing.Color.Black
        Me.ProjectNameTextBox.MaxLength = 128
        Me.ProjectNameTextBox.Name = "ProjectNameTextBox"
        Me.ProjectNameTextBox.Size = New System.Drawing.Size(330, 31)
        '
        'OutputToolsPanel
        '
        Me.OutputToolsPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.OutputToolsPanel.BackColor = System.Drawing.Color.Transparent
        Me.OutputToolsPanel.Controls.Add(Me.CopyAllButton)
        Me.OutputToolsPanel.Controls.Add(Me.SaveSourceButton)
        Me.OutputToolsPanel.Location = New System.Drawing.Point(12, 492)
        Me.OutputToolsPanel.Name = "OutputToolsPanel"
        Me.OutputToolsPanel.Size = New System.Drawing.Size(736, 44)
        Me.OutputToolsPanel.TabIndex = 74
        '
        'PiXelGroupBox1
        '
        Me.PiXelGroupBox1.Controls.Add(Me.NoteTableTextBox)
        Me.PiXelGroupBox1.Controls.Add(Me.Label1)
        Me.PiXelGroupBox1.Controls.Add(Me.SongInfo_CheckBox)
        Me.PiXelGroupBox1.Controls.Add(Me.NoteTableLabel)
        Me.PiXelGroupBox1.Controls.Add(Me.Author_TextBox)
        Me.PiXelGroupBox1.Controls.Add(Me.HeaderCheckBox)
        Me.PiXelGroupBox1.Controls.Add(Me.Name_TextBox)
        Me.PiXelGroupBox1.Controls.Add(Me.LabelTextBox)
        Me.PiXelGroupBox1.Controls.Add(Me.LabelLabel)
        Me.PiXelGroupBox1.Controls.Add(Me.Label2)
        Me.PiXelGroupBox1.Location = New System.Drawing.Point(157, 134)
        Me.PiXelGroupBox1.Name = "PiXelGroupBox1"
        Me.PiXelGroupBox1.Padding = New System.Windows.Forms.Padding(10)
        Me.PiXelGroupBox1.Size = New System.Drawing.Size(590, 143)
        Me.PiXelGroupBox1.TabIndex = 75
        Me.PiXelGroupBox1.TabStop = False
        Me.PiXelGroupBox1.Text = "Config PT3 file"
        '
        'NoteTableTextBox
        '
        Me.NoteTableTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NoteTableTextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoteTableTextBox.ForeColor = System.Drawing.Color.Black
        Me.NoteTableTextBox.Location = New System.Drawing.Point(125, 78)
        Me.NoteTableTextBox.MaxLength = 16
        Me.NoteTableTextBox.Name = "NoteTableTextBox"
        Me.NoteTableTextBox.ReadOnly = True
        Me.NoteTableTextBox.Size = New System.Drawing.Size(97, 23)
        Me.NoteTableTextBox.TabIndex = 4
        Me.NoteTableTextBox.Text = "0"
        Me.NoteTableTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.NoteTableTextBox, "up to 16 characters")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Song Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SongInfo_CheckBox
        '
        Me.SongInfo_CheckBox.AutoSize = True
        Me.SongInfo_CheckBox.BackColor = System.Drawing.Color.Transparent
        Me.SongInfo_CheckBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SongInfo_CheckBox.Location = New System.Drawing.Point(248, 107)
        Me.SongInfo_CheckBox.Name = "SongInfo_CheckBox"
        Me.SongInfo_CheckBox.Size = New System.Drawing.Size(220, 20)
        Me.SongInfo_CheckBox.TabIndex = 7
        Me.SongInfo_CheckBox.Text = "Add Name and Author strings"
        Me.SongInfo_CheckBox.UseVisualStyleBackColor = False
        '
        'NoteTableLabel
        '
        Me.NoteTableLabel.BackColor = System.Drawing.Color.Transparent
        Me.NoteTableLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoteTableLabel.Location = New System.Drawing.Point(10, 79)
        Me.NoteTableLabel.Name = "NoteTableLabel"
        Me.NoteTableLabel.Size = New System.Drawing.Size(110, 23)
        Me.NoteTableLabel.TabIndex = 70
        Me.NoteTableLabel.Text = "Note Table:"
        Me.NoteTableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Author_TextBox
        '
        Me.Author_TextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Author_TextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Author_TextBox.ForeColor = System.Drawing.Color.Black
        Me.Author_TextBox.Location = New System.Drawing.Point(125, 50)
        Me.Author_TextBox.MaxLength = 32
        Me.Author_TextBox.Name = "Author_TextBox"
        Me.Author_TextBox.ReadOnly = True
        Me.Author_TextBox.Size = New System.Drawing.Size(343, 23)
        Me.Author_TextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Author_TextBox, "up to 32 characters")
        '
        'HeaderCheckBox
        '
        Me.HeaderCheckBox.AutoSize = True
        Me.HeaderCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.HeaderCheckBox.Checked = True
        Me.HeaderCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HeaderCheckBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderCheckBox.Location = New System.Drawing.Point(248, 80)
        Me.HeaderCheckBox.Name = "HeaderCheckBox"
        Me.HeaderCheckBox.Size = New System.Drawing.Size(197, 20)
        Me.HeaderCheckBox.TabIndex = 6
        Me.HeaderCheckBox.Text = "Extract 100 Bytes Header"
        Me.HeaderCheckBox.UseVisualStyleBackColor = False
        '
        'Name_TextBox
        '
        Me.Name_TextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Name_TextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_TextBox.ForeColor = System.Drawing.Color.Black
        Me.Name_TextBox.Location = New System.Drawing.Point(125, 22)
        Me.Name_TextBox.MaxLength = 32
        Me.Name_TextBox.Name = "Name_TextBox"
        Me.Name_TextBox.ReadOnly = True
        Me.Name_TextBox.Size = New System.Drawing.Size(343, 23)
        Me.Name_TextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Name_TextBox, "up to 32 characters")
        '
        'LabelTextBox
        '
        Me.LabelTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelTextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTextBox.ForeColor = System.Drawing.Color.Black
        Me.LabelTextBox.Location = New System.Drawing.Point(125, 106)
        Me.LabelTextBox.MaxLength = 16
        Me.LabelTextBox.Name = "LabelTextBox"
        Me.LabelTextBox.Size = New System.Drawing.Size(97, 23)
        Me.LabelTextBox.TabIndex = 5
        Me.LabelTextBox.Text = "SONG00"
        Me.ToolTip1.SetToolTip(Me.LabelTextBox, "up to 16 characters")
        '
        'LabelLabel
        '
        Me.LabelLabel.BackColor = System.Drawing.Color.Transparent
        Me.LabelLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLabel.Location = New System.Drawing.Point(10, 105)
        Me.LabelLabel.Name = "LabelLabel"
        Me.LabelLabel.Size = New System.Drawing.Size(110, 23)
        Me.LabelLabel.TabIndex = 68
        Me.LabelLabel.Text = "Field name:"
        Me.LabelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Author:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CopyAllButton
        '
        Me.CopyAllButton.BackColor = System.Drawing.Color.Transparent
        Me.CopyAllButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.CopyAllButton.FlatAppearance.BorderSize = 0
        Me.CopyAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CopyAllButton.Image = Global.mSXdevtools.PT3toCdata.My.Resources.Resources.button_CopyAll
        Me.CopyAllButton.Location = New System.Drawing.Point(377, 0)
        Me.CopyAllButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CopyAllButton.Name = "CopyAllButton"
        Me.CopyAllButton.Size = New System.Drawing.Size(155, 44)
        Me.CopyAllButton.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.CopyAllButton, "Copy Output Data to Clipboard")
        Me.CopyAllButton.UseVisualStyleBackColor = False
        '
        'SaveSourceButton
        '
        Me.SaveSourceButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveSourceButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SaveSourceButton.FlatAppearance.BorderSize = 0
        Me.SaveSourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveSourceButton.Image = Global.mSXdevtools.PT3toCdata.My.Resources.Resources.button_savesource
        Me.SaveSourceButton.Location = New System.Drawing.Point(532, 0)
        Me.SaveSourceButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveSourceButton.Name = "SaveSourceButton"
        Me.SaveSourceButton.Padding = New System.Windows.Forms.Padding(4)
        Me.SaveSourceButton.Size = New System.Drawing.Size(204, 44)
        Me.SaveSourceButton.TabIndex = 9
        Me.SaveSourceButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.SaveSourceButton, "Save source code to .h file")
        Me.SaveSourceButton.UseVisualStyleBackColor = False
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.LogoPictureBox.Image = Global.mSXdevtools.PT3toCdata.My.Resources.Resources.PT3toCdata_logo
        Me.LogoPictureBox.Location = New System.Drawing.Point(424, 44)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(328, 75)
        Me.LogoPictureBox.TabIndex = 73
        Me.LogoPictureBox.TabStop = False
        '
        'NewButton
        '
        Me.NewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewButton.Image = Global.mSXdevtools.PT3toCdata.My.Resources.Resources.new_24
        Me.NewButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(28, 28)
        Me.NewButton.Text = "ToolStripButton1"
        '
        'Help_Button
        '
        Me.Help_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Help_Button.Enabled = False
        Me.Help_Button.Image = Global.mSXdevtools.PT3toCdata.My.Resources.Resources.help_x24
        Me.Help_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Help_Button.Name = "Help_Button"
        Me.Help_Button.Size = New System.Drawing.Size(28, 28)
        Me.Help_Button.Text = "ToolStripButton1"
        Me.Help_Button.ToolTipText = "Help!"
        '
        'About_Button
        '
        Me.About_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.About_Button.Image = Global.mSXdevtools.PT3toCdata.My.Resources.Resources.about_24
        Me.About_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.About_Button.Name = "About_Button"
        Me.About_Button.Size = New System.Drawing.Size(28, 28)
        Me.About_Button.Text = "ToolStripButton1"
        '
        'Load_Button
        '
        Me.Load_Button.Image = Global.mSXdevtools.PT3toCdata.My.Resources.Resources.Load_64
        Me.Load_Button.Location = New System.Drawing.Point(12, 147)
        Me.Load_Button.Name = "Load_Button"
        Me.Load_Button.Size = New System.Drawing.Size(126, 126)
        Me.Load_Button.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Load_Button, "File dialog for loading PT3 files." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can also drag and drop on the window.")
        Me.Load_Button.UseVisualStyleBackColor = True
        '
        'PT3toCdataWin
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(764, 561)
        Me.Controls.Add(Me.PiXelGroupBox1)
        Me.Controls.Add(Me.OutputToolsPanel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.ProjectToolStrip)
        Me.Controls.Add(Me.OutputText)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Load_Button)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximumSize = New System.Drawing.Size(780, 1920)
        Me.MinimumSize = New System.Drawing.Size(780, 500)
        Me.Name = "PT3toCdataWin"
        Me.Text = "PT3toCdata"
        Me.ProjectToolStrip.ResumeLayout(False)
        Me.ProjectToolStrip.PerformLayout()
        Me.OutputToolsPanel.ResumeLayout(False)
        Me.PiXelGroupBox1.ResumeLayout(False)
        Me.PiXelGroupBox1.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Name_TextBox As TextBox
    Friend WithEvents Author_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents HeaderCheckBox As CheckBox
    Friend WithEvents SongInfo_CheckBox As CheckBox
    Friend WithEvents OutputText As TextBox
    Friend WithEvents Load_Button As Button
    Friend WithEvents LabelTextBox As TextBox
    Friend WithEvents LabelLabel As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents NoteTableTextBox As TextBox
    Friend WithEvents NoteTableLabel As Label
    Friend WithEvents ProjectToolStrip As ToolStrip
    Friend WithEvents NewButton As ToolStripButton
    Friend WithEvents ProjectNameTextBox As ToolStripTextBox
    Friend WithEvents About_Button As ToolStripButton
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents OutputToolsPanel As Panel
    Friend WithEvents CopyAllButton As Button
    Friend WithEvents SaveSourceButton As Button
    Friend WithEvents PiXelGroupBox1 As piXelGroupBox
    Friend WithEvents Help_Button As ToolStripButton
End Class
