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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Name_TextBox = New System.Windows.Forms.TextBox()
        Me.Author_TextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HeaderCheckBox = New System.Windows.Forms.CheckBox()
        Me.SongInfo_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Config_GroupBox = New System.Windows.Forms.GroupBox()
        Me.NoteTableTextBox = New System.Windows.Forms.TextBox()
        Me.NoteTableLabel = New System.Windows.Forms.Label()
        Me.LabelTextBox = New System.Windows.Forms.TextBox()
        Me.LabelLabel = New System.Windows.Forms.Label()
        Me.OutputData_GroupBox = New System.Windows.Forms.GroupBox()
        Me.SaveAsButton = New System.Windows.Forms.Button()
        Me.CopyAllButton = New System.Windows.Forms.Button()
        Me.OutputText = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.Load_Button = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Config_GroupBox.SuspendLayout()
        Me.OutputData_GroupBox.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Song Name:"
        '
        'Name_TextBox
        '
        Me.Name_TextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Name_TextBox.ForeColor = System.Drawing.Color.Black
        Me.Name_TextBox.Location = New System.Drawing.Point(105, 28)
        Me.Name_TextBox.MaxLength = 32
        Me.Name_TextBox.Name = "Name_TextBox"
        Me.Name_TextBox.ReadOnly = True
        Me.Name_TextBox.Size = New System.Drawing.Size(310, 22)
        Me.Name_TextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Name_TextBox, "up to 32 characters")
        '
        'Author_TextBox
        '
        Me.Author_TextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Author_TextBox.ForeColor = System.Drawing.Color.Black
        Me.Author_TextBox.Location = New System.Drawing.Point(105, 56)
        Me.Author_TextBox.MaxLength = 32
        Me.Author_TextBox.Name = "Author_TextBox"
        Me.Author_TextBox.ReadOnly = True
        Me.Author_TextBox.Size = New System.Drawing.Size(310, 22)
        Me.Author_TextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Author_TextBox, "up to 32 characters")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Author:"
        '
        'HeaderCheckBox
        '
        Me.HeaderCheckBox.AutoSize = True
        Me.HeaderCheckBox.Checked = True
        Me.HeaderCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HeaderCheckBox.Location = New System.Drawing.Point(228, 86)
        Me.HeaderCheckBox.Name = "HeaderCheckBox"
        Me.HeaderCheckBox.Size = New System.Drawing.Size(187, 18)
        Me.HeaderCheckBox.TabIndex = 4
        Me.HeaderCheckBox.Text = "Extract 100 Bytes Header"
        Me.HeaderCheckBox.UseVisualStyleBackColor = True
        '
        'SongInfo_CheckBox
        '
        Me.SongInfo_CheckBox.AutoSize = True
        Me.SongInfo_CheckBox.Location = New System.Drawing.Point(228, 113)
        Me.SongInfo_CheckBox.Name = "SongInfo_CheckBox"
        Me.SongInfo_CheckBox.Size = New System.Drawing.Size(211, 18)
        Me.SongInfo_CheckBox.TabIndex = 5
        Me.SongInfo_CheckBox.Text = "Add Name and Author strings"
        Me.SongInfo_CheckBox.UseVisualStyleBackColor = True
        '
        'Config_GroupBox
        '
        Me.Config_GroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Config_GroupBox.Controls.Add(Me.NoteTableTextBox)
        Me.Config_GroupBox.Controls.Add(Me.NoteTableLabel)
        Me.Config_GroupBox.Controls.Add(Me.LabelTextBox)
        Me.Config_GroupBox.Controls.Add(Me.LabelLabel)
        Me.Config_GroupBox.Controls.Add(Me.Label1)
        Me.Config_GroupBox.Controls.Add(Me.SongInfo_CheckBox)
        Me.Config_GroupBox.Controls.Add(Me.Author_TextBox)
        Me.Config_GroupBox.Controls.Add(Me.Name_TextBox)
        Me.Config_GroupBox.Controls.Add(Me.Label2)
        Me.Config_GroupBox.Controls.Add(Me.HeaderCheckBox)
        Me.Config_GroupBox.Location = New System.Drawing.Point(176, 11)
        Me.Config_GroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Config_GroupBox.Name = "Config_GroupBox"
        Me.Config_GroupBox.Size = New System.Drawing.Size(490, 164)
        Me.Config_GroupBox.TabIndex = 8
        Me.Config_GroupBox.TabStop = False
        Me.Config_GroupBox.Text = "Output config"
        '
        'NoteTableTextBox
        '
        Me.NoteTableTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NoteTableTextBox.ForeColor = System.Drawing.Color.Black
        Me.NoteTableTextBox.Location = New System.Drawing.Point(105, 84)
        Me.NoteTableTextBox.MaxLength = 16
        Me.NoteTableTextBox.Name = "NoteTableTextBox"
        Me.NoteTableTextBox.ReadOnly = True
        Me.NoteTableTextBox.Size = New System.Drawing.Size(97, 22)
        Me.NoteTableTextBox.TabIndex = 69
        Me.NoteTableTextBox.Text = "0"
        Me.NoteTableTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.NoteTableTextBox, "up to 16 characters")
        '
        'NoteTableLabel
        '
        Me.NoteTableLabel.Location = New System.Drawing.Point(14, 85)
        Me.NoteTableLabel.Name = "NoteTableLabel"
        Me.NoteTableLabel.Size = New System.Drawing.Size(80, 18)
        Me.NoteTableLabel.TabIndex = 70
        Me.NoteTableLabel.Text = "Note Table:"
        Me.NoteTableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelTextBox
        '
        Me.LabelTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelTextBox.ForeColor = System.Drawing.Color.Black
        Me.LabelTextBox.Location = New System.Drawing.Point(105, 112)
        Me.LabelTextBox.MaxLength = 16
        Me.LabelTextBox.Name = "LabelTextBox"
        Me.LabelTextBox.Size = New System.Drawing.Size(97, 22)
        Me.LabelTextBox.TabIndex = 3
        Me.LabelTextBox.Text = "SONG00"
        Me.ToolTip1.SetToolTip(Me.LabelTextBox, "up to 16 characters")
        '
        'LabelLabel
        '
        Me.LabelLabel.Location = New System.Drawing.Point(14, 113)
        Me.LabelLabel.Name = "LabelLabel"
        Me.LabelLabel.Size = New System.Drawing.Size(80, 18)
        Me.LabelLabel.TabIndex = 68
        Me.LabelLabel.Text = "Field name:"
        Me.LabelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OutputData_GroupBox
        '
        Me.OutputData_GroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputData_GroupBox.Controls.Add(Me.SaveAsButton)
        Me.OutputData_GroupBox.Controls.Add(Me.CopyAllButton)
        Me.OutputData_GroupBox.Controls.Add(Me.OutputText)
        Me.OutputData_GroupBox.Location = New System.Drawing.Point(12, 182)
        Me.OutputData_GroupBox.Name = "OutputData_GroupBox"
        Me.OutputData_GroupBox.Size = New System.Drawing.Size(700, 300)
        Me.OutputData_GroupBox.TabIndex = 9
        Me.OutputData_GroupBox.TabStop = False
        Me.OutputData_GroupBox.Text = "Output Data"
        '
        'SaveAsButton
        '
        Me.SaveAsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveAsButton.BackColor = System.Drawing.Color.Silver
        Me.SaveAsButton.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveAsButton.Image = Global.mSXdevtools.PT3toCdata.My.Resources.Resources.save3_x24
        Me.SaveAsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveAsButton.Location = New System.Drawing.Point(458, 263)
        Me.SaveAsButton.Name = "SaveAsButton"
        Me.SaveAsButton.Padding = New System.Windows.Forms.Padding(2, 5, 3, 3)
        Me.SaveAsButton.Size = New System.Drawing.Size(123, 32)
        Me.SaveAsButton.TabIndex = 7
        Me.SaveAsButton.Text = "Save PT3.h"
        Me.SaveAsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SaveAsButton.UseVisualStyleBackColor = False
        '
        'CopyAllButton
        '
        Me.CopyAllButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CopyAllButton.BackColor = System.Drawing.Color.Silver
        Me.CopyAllButton.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyAllButton.Location = New System.Drawing.Point(587, 263)
        Me.CopyAllButton.Name = "CopyAllButton"
        Me.CopyAllButton.Size = New System.Drawing.Size(107, 32)
        Me.CopyAllButton.TabIndex = 8
        Me.CopyAllButton.Text = "Copy All"
        Me.CopyAllButton.UseVisualStyleBackColor = False
        '
        'OutputText
        '
        Me.OutputText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputText.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputText.Location = New System.Drawing.Point(18, 21)
        Me.OutputText.Multiline = True
        Me.OutputText.Name = "OutputText"
        Me.OutputText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.OutputText.Size = New System.Drawing.Size(676, 236)
        Me.OutputText.TabIndex = 6
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
        'AboutButton
        '
        Me.AboutButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AboutButton.Image = Global.mSXdevtools.PT3toCdata.My.Resources.Resources.about_24
        Me.AboutButton.Location = New System.Drawing.Point(680, 17)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(32, 32)
        Me.AboutButton.TabIndex = 71
        Me.ToolTip1.SetToolTip(Me.AboutButton, "About this App")
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'Load_Button
        '
        Me.Load_Button.Image = Global.mSXdevtools.PT3toCdata.My.Resources.Resources.Load_64
        Me.Load_Button.Location = New System.Drawing.Point(29, 32)
        Me.Load_Button.Name = "Load_Button"
        Me.Load_Button.Size = New System.Drawing.Size(126, 126)
        Me.Load_Button.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Load_Button, "File dialog for loading PT3 files." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can also drag and drop on the window.")
        Me.Load_Button.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 489)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(724, 22)
        Me.StatusStrip1.TabIndex = 70
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(71, 17)
        Me.ToolStripStatusLabel1.Text = "mSXdevtool"
        '
        'PT3toCdataWin
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(724, 511)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Load_Button)
        Me.Controls.Add(Me.OutputData_GroupBox)
        Me.Controls.Add(Me.Config_GroupBox)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MinimumSize = New System.Drawing.Size(740, 500)
        Me.Name = "PT3toCdataWin"
        Me.Text = "PT3toCdata"
        Me.Config_GroupBox.ResumeLayout(False)
        Me.Config_GroupBox.PerformLayout()
        Me.OutputData_GroupBox.ResumeLayout(False)
        Me.OutputData_GroupBox.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Name_TextBox As TextBox
    Friend WithEvents Author_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents HeaderCheckBox As CheckBox
    Friend WithEvents SongInfo_CheckBox As CheckBox
    Friend WithEvents Config_GroupBox As GroupBox
    Friend WithEvents OutputData_GroupBox As GroupBox
    Friend WithEvents SaveAsButton As Button
    Friend WithEvents CopyAllButton As Button
    Friend WithEvents OutputText As TextBox
    Friend WithEvents Load_Button As Button
    Friend WithEvents LabelTextBox As TextBox
    Friend WithEvents LabelLabel As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents AboutButton As Button
    Friend WithEvents NoteTableTextBox As TextBox
    Friend WithEvents NoteTableLabel As Label
End Class
