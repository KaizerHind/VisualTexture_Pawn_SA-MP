<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VSprites
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VSprites))
        Me.label4 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnimationsViewerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextureViewerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAMPScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PawnColorPickerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PawnWikiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseBtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.SystemColors.Control
        Me.label4.Location = New System.Drawing.Point(500, 268)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(101, 15)
        Me.label4.TabIndex = 21
        Me.label4.Text = "1000 SPRITES"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.ForeColor = System.Drawing.SystemColors.Control
        Me.label2.Location = New System.Drawing.Point(501, 313)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(100, 13)
        Me.label2.TabIndex = 18
        Me.label2.Text = "Created by Lorenc_"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.Control
        Me.label1.Location = New System.Drawing.Point(504, 36)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(85, 16)
        Me.label1.TabIndex = 17
        Me.label1.Text = "Image Size"
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.YellowGreen
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.button3.Location = New System.Drawing.Point(501, 86)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(91, 28)
        Me.button3.TabIndex = 16
        Me.button3.Text = "Centered"
        Me.button3.UseVisualStyleBackColor = False
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.YellowGreen
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.button2.Location = New System.Drawing.Point(501, 117)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(91, 28)
        Me.button2.TabIndex = 15
        Me.button2.Text = "Stretched"
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.YellowGreen
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.button1.Location = New System.Drawing.Point(501, 55)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(91, 28)
        Me.button1.TabIndex = 14
        Me.button1.Text = "Normal"
        Me.button1.UseVisualStyleBackColor = False
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(184, 305)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ReadOnly = True
        Me.textBox1.Size = New System.Drawing.Size(297, 20)
        Me.textBox1.TabIndex = 13
        Me.textBox1.Text = "NO IMAGE SELECTED!"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(184, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(296, 266)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.Location = New System.Drawing.Point(9, 36)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(167, 290)
        Me.listBox1.TabIndex = 11
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuItem, Me.SupportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(613, 24)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnimationsViewerToolStripMenuItem, Me.TextureViewerToolStripMenuItem, Me.SAMPScriptToolStripMenuItem, Me.PawnColorPickerToolStripMenuItem, Me.PawnWikiToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'AnimationsViewerToolStripMenuItem
        '
        Me.AnimationsViewerToolStripMenuItem.Name = "AnimationsViewerToolStripMenuItem"
        Me.AnimationsViewerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AnimationsViewerToolStripMenuItem.Text = "Animations viewer"
        '
        'TextureViewerToolStripMenuItem
        '
        Me.TextureViewerToolStripMenuItem.Name = "TextureViewerToolStripMenuItem"
        Me.TextureViewerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TextureViewerToolStripMenuItem.Text = "Texture Viewer"
        '
        'SAMPScriptToolStripMenuItem
        '
        Me.SAMPScriptToolStripMenuItem.Name = "SAMPScriptToolStripMenuItem"
        Me.SAMPScriptToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SAMPScriptToolStripMenuItem.Text = "SA:MP Script"
        '
        'PawnColorPickerToolStripMenuItem
        '
        Me.PawnColorPickerToolStripMenuItem.Name = "PawnColorPickerToolStripMenuItem"
        Me.PawnColorPickerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PawnColorPickerToolStripMenuItem.Text = "Pawn Color Picker"
        '
        'PawnWikiToolStripMenuItem
        '
        Me.PawnWikiToolStripMenuItem.Name = "PawnWikiToolStripMenuItem"
        Me.PawnWikiToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PawnWikiToolStripMenuItem.Text = "PawnWiki"
        '
        'SupportToolStripMenuItem
        '
        Me.SupportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ContactUsToolStripMenuItem, Me.LOGToolStripMenuItem, Me.CreditsToolStripMenuItem})
        Me.SupportToolStripMenuItem.Name = "SupportToolStripMenuItem"
        Me.SupportToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SupportToolStripMenuItem.Text = "Support"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ContactUsToolStripMenuItem
        '
        Me.ContactUsToolStripMenuItem.Name = "ContactUsToolStripMenuItem"
        Me.ContactUsToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ContactUsToolStripMenuItem.Text = "Contact us"
        '
        'LOGToolStripMenuItem
        '
        Me.LOGToolStripMenuItem.Name = "LOGToolStripMenuItem"
        Me.LOGToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.LOGToolStripMenuItem.Text = "LOG"
        '
        'CreditsToolStripMenuItem
        '
        Me.CreditsToolStripMenuItem.Name = "CreditsToolStripMenuItem"
        Me.CreditsToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.CreditsToolStripMenuItem.Text = "Credits"
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.SystemColors.Control
        Me.CloseBtn.FlatAppearance.BorderSize = 0
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.Location = New System.Drawing.Point(573, 0)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(40, 24)
        Me.CloseBtn.TabIndex = 23
        Me.CloseBtn.Text = "X"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'VSprites
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(613, 351)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.listBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VSprites"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VSprites"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label4 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents textBox1 As TextBox
    Private WithEvents PictureBox1 As PictureBox
    Private WithEvents listBox1 As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnimationsViewerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextureViewerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreditsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PawnColorPickerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SAMPScriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PawnWikiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseBtn As Button
End Class
