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
        Me.BonfireTabControl1 = New Pokémon_Essentials_Form_Generator.BonfireTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.generation_cmb = New Pokémon_Essentials_Form_Generator.BonfireCombo()
        Me.BonfireLabel1 = New Pokémon_Essentials_Form_Generator.BonfireLabel()
        Me.spellingNotice_wrnbox = New Pokémon_Essentials_Form_Generator.ProMessage()
        Me.baseStats_grp = New Pokémon_Essentials_Form_Generator.BonfireGroupBox()
        Me.baseStatsHeader_lbl = New Pokémon_Essentials_Form_Generator.BonfireLabelHeader()
        Me.baseStatSPDEF_lbl = New Pokémon_Essentials_Form_Generator.BonfireLabel()
        Me.baseStatSPATK_lbl = New Pokémon_Essentials_Form_Generator.BonfireLabel()
        Me.baseStatSPD_lbl = New Pokémon_Essentials_Form_Generator.BonfireLabel()
        Me.baseStatDEF_lbl = New Pokémon_Essentials_Form_Generator.BonfireLabel()
        Me.baseStatATK_lbl = New Pokémon_Essentials_Form_Generator.BonfireLabel()
        Me.baseStatHP_lbl = New Pokémon_Essentials_Form_Generator.BonfireLabel()
        Me.baseStatDEF_txt = New System.Windows.Forms.TextBox()
        Me.baseStatSPDEF_txt = New System.Windows.Forms.TextBox()
        Me.baseStatSPATK_txt = New System.Windows.Forms.TextBox()
        Me.baseStatSPD_txt = New System.Windows.Forms.TextBox()
        Me.baseStatATK_txt = New System.Windows.Forms.TextBox()
        Me.baseStatHP_txt = New System.Windows.Forms.TextBox()
        Me.BonfireCheckbox1 = New Pokémon_Essentials_Form_Generator.BonfireCheckbox()
        Me.typeTwo_txt = New System.Windows.Forms.TextBox()
        Me.typeTwo_chk = New Pokémon_Essentials_Form_Generator.BonfireCheckbox()
        Me.typeOne_txt = New System.Windows.Forms.TextBox()
        Me.typeOne_lbl = New Pokémon_Essentials_Form_Generator.BonfireLabel()
        Me.formName_txt = New System.Windows.Forms.TextBox()
        Me.formName_lbl = New Pokémon_Essentials_Form_Generator.BonfireLabel()
        Me.BonfireTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.baseStats_grp.SuspendLayout()
        Me.SuspendLayout()
        '
        'BonfireTabControl1
        '
        Me.BonfireTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BonfireTabControl1.Controls.Add(Me.TabPage1)
        Me.BonfireTabControl1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BonfireTabControl1.ItemSize = New System.Drawing.Size(0, 30)
        Me.BonfireTabControl1.Location = New System.Drawing.Point(12, 12)
        Me.BonfireTabControl1.Name = "BonfireTabControl1"
        Me.BonfireTabControl1.SelectedIndex = 0
        Me.BonfireTabControl1.Size = New System.Drawing.Size(760, 537)
        Me.BonfireTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.generation_cmb)
        Me.TabPage1.Controls.Add(Me.BonfireLabel1)
        Me.TabPage1.Controls.Add(Me.spellingNotice_wrnbox)
        Me.TabPage1.Controls.Add(Me.baseStats_grp)
        Me.TabPage1.Controls.Add(Me.typeTwo_txt)
        Me.TabPage1.Controls.Add(Me.typeTwo_chk)
        Me.TabPage1.Controls.Add(Me.typeOne_txt)
        Me.TabPage1.Controls.Add(Me.typeOne_lbl)
        Me.TabPage1.Controls.Add(Me.formName_txt)
        Me.TabPage1.Controls.Add(Me.formName_lbl)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(752, 499)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Form Details"
        '
        'generation_cmb
        '
        Me.generation_cmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.generation_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.generation_cmb.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.generation_cmb.FormattingEnabled = True
        Me.generation_cmb.ItemHeight = 20
        Me.generation_cmb.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.generation_cmb.Location = New System.Drawing.Point(85, 56)
        Me.generation_cmb.Name = "generation_cmb"
        Me.generation_cmb.Size = New System.Drawing.Size(121, 26)
        Me.generation_cmb.TabIndex = 9
        '
        'BonfireLabel1
        '
        Me.BonfireLabel1.AutoSize = True
        Me.BonfireLabel1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BonfireLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.BonfireLabel1.Location = New System.Drawing.Point(6, 62)
        Me.BonfireLabel1.Name = "BonfireLabel1"
        Me.BonfireLabel1.Size = New System.Drawing.Size(70, 13)
        Me.BonfireLabel1.TabIndex = 8
        Me.BonfireLabel1.Text = "Generation"
        '
        'spellingNotice_wrnbox
        '
        Me.spellingNotice_wrnbox.BackColor = System.Drawing.Color.LemonChiffon
        Me.spellingNotice_wrnbox.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.spellingNotice_wrnbox.Header = "NOTICE"
        Me.spellingNotice_wrnbox.HeaderFont = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.spellingNotice_wrnbox.Location = New System.Drawing.Point(6, 436)
        Me.spellingNotice_wrnbox.Name = "spellingNotice_wrnbox"
        Me.spellingNotice_wrnbox.Size = New System.Drawing.Size(740, 57)
        Me.spellingNotice_wrnbox.SizeByText = False
        Me.spellingNotice_wrnbox.TabIndex = 7
        Me.spellingNotice_wrnbox.Text = "Some elements, such as Type 1 and 2 and the Pokémon Species, require proper spell" &
    "ing."
        '
        'baseStats_grp
        '
        Me.baseStats_grp.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.baseStats_grp.Controls.Add(Me.baseStatsHeader_lbl)
        Me.baseStats_grp.Controls.Add(Me.baseStatSPDEF_lbl)
        Me.baseStats_grp.Controls.Add(Me.baseStatSPATK_lbl)
        Me.baseStats_grp.Controls.Add(Me.baseStatSPD_lbl)
        Me.baseStats_grp.Controls.Add(Me.baseStatDEF_lbl)
        Me.baseStats_grp.Controls.Add(Me.baseStatATK_lbl)
        Me.baseStats_grp.Controls.Add(Me.baseStatHP_lbl)
        Me.baseStats_grp.Controls.Add(Me.baseStatDEF_txt)
        Me.baseStats_grp.Controls.Add(Me.baseStatSPDEF_txt)
        Me.baseStats_grp.Controls.Add(Me.baseStatSPATK_txt)
        Me.baseStats_grp.Controls.Add(Me.baseStatSPD_txt)
        Me.baseStats_grp.Controls.Add(Me.baseStatATK_txt)
        Me.baseStats_grp.Controls.Add(Me.baseStatHP_txt)
        Me.baseStats_grp.Controls.Add(Me.BonfireCheckbox1)
        Me.baseStats_grp.Location = New System.Drawing.Point(348, 6)
        Me.baseStats_grp.Name = "baseStats_grp"
        Me.baseStats_grp.Size = New System.Drawing.Size(300, 92)
        Me.baseStats_grp.TabIndex = 6
        Me.baseStats_grp.Text = "Base Stats"
        '
        'baseStatsHeader_lbl
        '
        Me.baseStatsHeader_lbl.AutoSize = True
        Me.baseStatsHeader_lbl.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.baseStatsHeader_lbl.Location = New System.Drawing.Point(3, 3)
        Me.baseStatsHeader_lbl.Name = "baseStatsHeader_lbl"
        Me.baseStatsHeader_lbl.Size = New System.Drawing.Size(89, 17)
        Me.baseStatsHeader_lbl.TabIndex = 26
        Me.baseStatsHeader_lbl.Text = "Base Stats"
        '
        'baseStatSPDEF_lbl
        '
        Me.baseStatSPDEF_lbl.AutoSize = True
        Me.baseStatSPDEF_lbl.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.baseStatSPDEF_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.baseStatSPDEF_lbl.Location = New System.Drawing.Point(253, 53)
        Me.baseStatSPDEF_lbl.Name = "baseStatSPDEF_lbl"
        Me.baseStatSPDEF_lbl.Size = New System.Drawing.Size(44, 13)
        Me.baseStatSPDEF_lbl.TabIndex = 25
        Me.baseStatSPDEF_lbl.Text = "SPDEF"
        '
        'baseStatSPATK_lbl
        '
        Me.baseStatSPATK_lbl.AutoSize = True
        Me.baseStatSPATK_lbl.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.baseStatSPATK_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.baseStatSPATK_lbl.Location = New System.Drawing.Point(203, 53)
        Me.baseStatSPATK_lbl.Name = "baseStatSPATK_lbl"
        Me.baseStatSPATK_lbl.Size = New System.Drawing.Size(44, 13)
        Me.baseStatSPATK_lbl.TabIndex = 24
        Me.baseStatSPATK_lbl.Text = "SPATK"
        '
        'baseStatSPD_lbl
        '
        Me.baseStatSPD_lbl.AutoSize = True
        Me.baseStatSPD_lbl.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.baseStatSPD_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.baseStatSPD_lbl.Location = New System.Drawing.Point(160, 53)
        Me.baseStatSPD_lbl.Name = "baseStatSPD_lbl"
        Me.baseStatSPD_lbl.Size = New System.Drawing.Size(31, 13)
        Me.baseStatSPD_lbl.TabIndex = 23
        Me.baseStatSPD_lbl.Text = "SPD"
        '
        'baseStatDEF_lbl
        '
        Me.baseStatDEF_lbl.AutoSize = True
        Me.baseStatDEF_lbl.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.baseStatDEF_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.baseStatDEF_lbl.Location = New System.Drawing.Point(110, 53)
        Me.baseStatDEF_lbl.Name = "baseStatDEF_lbl"
        Me.baseStatDEF_lbl.Size = New System.Drawing.Size(29, 13)
        Me.baseStatDEF_lbl.TabIndex = 22
        Me.baseStatDEF_lbl.Text = "DEF"
        '
        'baseStatATK_lbl
        '
        Me.baseStatATK_lbl.AutoSize = True
        Me.baseStatATK_lbl.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.baseStatATK_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.baseStatATK_lbl.Location = New System.Drawing.Point(61, 53)
        Me.baseStatATK_lbl.Name = "baseStatATK_lbl"
        Me.baseStatATK_lbl.Size = New System.Drawing.Size(29, 13)
        Me.baseStatATK_lbl.TabIndex = 21
        Me.baseStatATK_lbl.Text = "ATK"
        '
        'baseStatHP_lbl
        '
        Me.baseStatHP_lbl.AutoSize = True
        Me.baseStatHP_lbl.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.baseStatHP_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.baseStatHP_lbl.Location = New System.Drawing.Point(14, 53)
        Me.baseStatHP_lbl.Name = "baseStatHP_lbl"
        Me.baseStatHP_lbl.Size = New System.Drawing.Size(22, 13)
        Me.baseStatHP_lbl.TabIndex = 20
        Me.baseStatHP_lbl.Text = "HP"
        '
        'baseStatDEF_txt
        '
        Me.baseStatDEF_txt.Location = New System.Drawing.Point(103, 67)
        Me.baseStatDEF_txt.MaxLength = 3
        Me.baseStatDEF_txt.Name = "baseStatDEF_txt"
        Me.baseStatDEF_txt.Size = New System.Drawing.Size(44, 20)
        Me.baseStatDEF_txt.TabIndex = 19
        Me.baseStatDEF_txt.Text = "0"
        '
        'baseStatSPDEF_txt
        '
        Me.baseStatSPDEF_txt.Location = New System.Drawing.Point(253, 67)
        Me.baseStatSPDEF_txt.MaxLength = 3
        Me.baseStatSPDEF_txt.Name = "baseStatSPDEF_txt"
        Me.baseStatSPDEF_txt.Size = New System.Drawing.Size(44, 20)
        Me.baseStatSPDEF_txt.TabIndex = 18
        Me.baseStatSPDEF_txt.Text = "0"
        '
        'baseStatSPATK_txt
        '
        Me.baseStatSPATK_txt.Location = New System.Drawing.Point(203, 67)
        Me.baseStatSPATK_txt.MaxLength = 3
        Me.baseStatSPATK_txt.Name = "baseStatSPATK_txt"
        Me.baseStatSPATK_txt.Size = New System.Drawing.Size(44, 20)
        Me.baseStatSPATK_txt.TabIndex = 17
        Me.baseStatSPATK_txt.Text = "0"
        '
        'baseStatSPD_txt
        '
        Me.baseStatSPD_txt.Location = New System.Drawing.Point(153, 67)
        Me.baseStatSPD_txt.MaxLength = 3
        Me.baseStatSPD_txt.Name = "baseStatSPD_txt"
        Me.baseStatSPD_txt.Size = New System.Drawing.Size(44, 20)
        Me.baseStatSPD_txt.TabIndex = 16
        Me.baseStatSPD_txt.Text = "0"
        '
        'baseStatATK_txt
        '
        Me.baseStatATK_txt.Location = New System.Drawing.Point(53, 67)
        Me.baseStatATK_txt.MaxLength = 3
        Me.baseStatATK_txt.Name = "baseStatATK_txt"
        Me.baseStatATK_txt.Size = New System.Drawing.Size(44, 20)
        Me.baseStatATK_txt.TabIndex = 15
        Me.baseStatATK_txt.Text = "0"
        '
        'baseStatHP_txt
        '
        Me.baseStatHP_txt.Location = New System.Drawing.Point(3, 67)
        Me.baseStatHP_txt.MaxLength = 3
        Me.baseStatHP_txt.Name = "baseStatHP_txt"
        Me.baseStatHP_txt.Size = New System.Drawing.Size(44, 20)
        Me.baseStatHP_txt.TabIndex = 14
        Me.baseStatHP_txt.Text = "0"
        '
        'BonfireCheckbox1
        '
        Me.BonfireCheckbox1.Checked = False
        Me.BonfireCheckbox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BonfireCheckbox1.Location = New System.Drawing.Point(3, 23)
        Me.BonfireCheckbox1.Name = "BonfireCheckbox1"
        Me.BonfireCheckbox1.Size = New System.Drawing.Size(226, 20)
        Me.BonfireCheckbox1.TabIndex = 0
        Me.BonfireCheckbox1.Text = "This form has different base stats"
        '
        'typeTwo_txt
        '
        Me.typeTwo_txt.Location = New System.Drawing.Point(242, 32)
        Me.typeTwo_txt.Name = "typeTwo_txt"
        Me.typeTwo_txt.Size = New System.Drawing.Size(100, 20)
        Me.typeTwo_txt.TabIndex = 5
        '
        'typeTwo_chk
        '
        Me.typeTwo_chk.Checked = False
        Me.typeTwo_chk.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.typeTwo_chk.Location = New System.Drawing.Point(163, 32)
        Me.typeTwo_chk.Name = "typeTwo_chk"
        Me.typeTwo_chk.Size = New System.Drawing.Size(140, 20)
        Me.typeTwo_chk.TabIndex = 4
        Me.typeTwo_chk.Text = "Type 2"
        '
        'typeOne_txt
        '
        Me.typeOne_txt.Location = New System.Drawing.Point(57, 32)
        Me.typeOne_txt.Name = "typeOne_txt"
        Me.typeOne_txt.Size = New System.Drawing.Size(100, 20)
        Me.typeOne_txt.TabIndex = 3
        '
        'typeOne_lbl
        '
        Me.typeOne_lbl.AutoSize = True
        Me.typeOne_lbl.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.typeOne_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.typeOne_lbl.Location = New System.Drawing.Point(6, 35)
        Me.typeOne_lbl.Name = "typeOne_lbl"
        Me.typeOne_lbl.Size = New System.Drawing.Size(45, 13)
        Me.typeOne_lbl.TabIndex = 2
        Me.typeOne_lbl.Text = "Type 1"
        '
        'formName_txt
        '
        Me.formName_txt.Location = New System.Drawing.Point(85, 6)
        Me.formName_txt.MaxLength = 255
        Me.formName_txt.Name = "formName_txt"
        Me.formName_txt.Size = New System.Drawing.Size(257, 20)
        Me.formName_txt.TabIndex = 1
        '
        'formName_lbl
        '
        Me.formName_lbl.AutoSize = True
        Me.formName_lbl.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.formName_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.formName_lbl.Location = New System.Drawing.Point(6, 9)
        Me.formName_lbl.Name = "formName_lbl"
        Me.formName_lbl.Size = New System.Drawing.Size(73, 13)
        Me.formName_lbl.TabIndex = 0
        Me.formName_lbl.Text = "Form Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.BonfireTabControl1)
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Generator"
        Me.BonfireTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.baseStats_grp.ResumeLayout(False)
        Me.baseStats_grp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BonfireTabControl1 As BonfireTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents formName_txt As TextBox
    Friend WithEvents formName_lbl As BonfireLabel
    Friend WithEvents typeTwo_txt As TextBox
    Friend WithEvents typeTwo_chk As BonfireCheckbox
    Friend WithEvents typeOne_txt As TextBox
    Friend WithEvents typeOne_lbl As BonfireLabel
    Friend WithEvents spellingNotice_wrnbox As ProMessage
    Friend WithEvents baseStats_grp As BonfireGroupBox
    Friend WithEvents baseStatsHeader_lbl As BonfireLabelHeader
    Friend WithEvents baseStatSPDEF_lbl As BonfireLabel
    Friend WithEvents baseStatSPATK_lbl As BonfireLabel
    Friend WithEvents baseStatSPD_lbl As BonfireLabel
    Friend WithEvents baseStatDEF_lbl As BonfireLabel
    Friend WithEvents baseStatATK_lbl As BonfireLabel
    Friend WithEvents baseStatHP_lbl As BonfireLabel
    Friend WithEvents baseStatDEF_txt As TextBox
    Friend WithEvents baseStatSPDEF_txt As TextBox
    Friend WithEvents baseStatSPATK_txt As TextBox
    Friend WithEvents baseStatSPD_txt As TextBox
    Friend WithEvents baseStatATK_txt As TextBox
    Friend WithEvents baseStatHP_txt As TextBox
    Friend WithEvents BonfireCheckbox1 As BonfireCheckbox
    Friend WithEvents generation_cmb As BonfireCombo
    Friend WithEvents BonfireLabel1 As BonfireLabel
End Class
