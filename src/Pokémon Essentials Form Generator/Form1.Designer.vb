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
        Me.formName_lbl = New Pokémon_Essentials_Form_Generator.BonfireLabel()
        Me.formName_txt = New System.Windows.Forms.TextBox()
        Me.BonfireTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
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
        Me.TabPage1.Controls.Add(Me.formName_txt)
        Me.TabPage1.Controls.Add(Me.formName_lbl)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(752, 499)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Form Details"
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
        'formName_txt
        '
        Me.formName_txt.Location = New System.Drawing.Point(85, 6)
        Me.formName_txt.MaxLength = 255
        Me.formName_txt.Name = "formName_txt"
        Me.formName_txt.Size = New System.Drawing.Size(204, 20)
        Me.formName_txt.TabIndex = 1
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BonfireTabControl1 As BonfireTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents formName_txt As TextBox
    Friend WithEvents formName_lbl As BonfireLabel
End Class
