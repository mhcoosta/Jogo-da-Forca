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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.PBmercado = New System.Windows.Forms.PictureBox
        Me.BTproximo = New System.Windows.Forms.Button
        Me.BTanterior = New System.Windows.Forms.Button
        Me.BTdeleta = New System.Windows.Forms.Button
        Me.BTedita = New System.Windows.Forms.Button
        Me.BTsalva = New System.Windows.Forms.Button
        Me.BTnovo = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PBmercado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(183, 66)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(604, 434)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TextBox3)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.MaskedTextBox2)
        Me.TabPage1.Controls.Add(Me.BTproximo)
        Me.TabPage1.Controls.Add(Me.BTanterior)
        Me.TabPage1.Controls.Add(Me.BTdeleta)
        Me.TabPage1.Controls.Add(Me.BTedita)
        Me.TabPage1.Controls.Add(Me.BTsalva)
        Me.TabPage1.Controls.Add(Me.BTnovo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(596, 408)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Modo Cadastro"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.TextBox4)
        Me.TabPage2.Controls.Add(Me.TextBox5)
        Me.TabPage2.Controls.Add(Me.TextBox6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(596, 408)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Modo Procura"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Enabled = False
        Me.MaskedTextBox2.Location = New System.Drawing.Point(247, 339)
        Me.MaskedTextBox2.Mask = "$ 00,00"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(195, 20)
        Me.MaskedTextBox2.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(247, 304)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(195, 20)
        Me.TextBox1.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(247, 268)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(195, 20)
        Me.TextBox2.TabIndex = 9
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(247, 232)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(195, 20)
        Me.TextBox3.TabIndex = 10
        Me.TextBox3.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(167, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Posição:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(167, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Código:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(167, 307)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Descrição:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(167, 339)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Preço:"
        '
        'PBmercado
        '
        Me.PBmercado.BackColor = System.Drawing.Color.Transparent
        Me.PBmercado.Image = Global.Supermercado.My.Resources.Resources.supermarket_icon
        Me.PBmercado.Location = New System.Drawing.Point(21, 27)
        Me.PBmercado.Name = "PBmercado"
        Me.PBmercado.Size = New System.Drawing.Size(139, 108)
        Me.PBmercado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBmercado.TabIndex = 1
        Me.PBmercado.TabStop = False
        '
        'BTproximo
        '
        Me.BTproximo.BackgroundImage = Global.Supermercado.My.Resources.Resources.Arrows_Forward_icon
        Me.BTproximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTproximo.Location = New System.Drawing.Point(496, 252)
        Me.BTproximo.Name = "BTproximo"
        Me.BTproximo.Size = New System.Drawing.Size(85, 74)
        Me.BTproximo.TabIndex = 5
        Me.BTproximo.UseVisualStyleBackColor = True
        '
        'BTanterior
        '
        Me.BTanterior.BackgroundImage = Global.Supermercado.My.Resources.Resources.Arrows_Back_icon
        Me.BTanterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTanterior.Location = New System.Drawing.Point(15, 252)
        Me.BTanterior.Name = "BTanterior"
        Me.BTanterior.Size = New System.Drawing.Size(85, 74)
        Me.BTanterior.TabIndex = 4
        Me.BTanterior.UseVisualStyleBackColor = True
        '
        'BTdeleta
        '
        Me.BTdeleta.BackgroundImage = Global.Supermercado.My.Resources.Resources.Trash_Empty_icon
        Me.BTdeleta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTdeleta.Location = New System.Drawing.Point(479, 67)
        Me.BTdeleta.Name = "BTdeleta"
        Me.BTdeleta.Size = New System.Drawing.Size(85, 74)
        Me.BTdeleta.TabIndex = 3
        Me.BTdeleta.UseVisualStyleBackColor = True
        '
        'BTedita
        '
        Me.BTedita.BackgroundImage = Global.Supermercado.My.Resources.Resources.edit_icon
        Me.BTedita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTedita.Location = New System.Drawing.Point(335, 67)
        Me.BTedita.Name = "BTedita"
        Me.BTedita.Size = New System.Drawing.Size(85, 74)
        Me.BTedita.TabIndex = 2
        Me.BTedita.UseVisualStyleBackColor = True
        '
        'BTsalva
        '
        Me.BTsalva.BackgroundImage = Global.Supermercado.My.Resources.Resources.Save_icon
        Me.BTsalva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTsalva.Location = New System.Drawing.Point(195, 67)
        Me.BTsalva.Name = "BTsalva"
        Me.BTsalva.Size = New System.Drawing.Size(85, 74)
        Me.BTsalva.TabIndex = 1
        Me.BTsalva.UseVisualStyleBackColor = True
        '
        'BTnovo
        '
        Me.BTnovo.BackgroundImage = Global.Supermercado.My.Resources.Resources.Actions_document_new_icon
        Me.BTnovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTnovo.Location = New System.Drawing.Point(51, 67)
        Me.BTnovo.Name = "BTnovo"
        Me.BTnovo.Size = New System.Drawing.Size(85, 74)
        Me.BTnovo.TabIndex = 0
        Me.BTnovo.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(147, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Descrição:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(147, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Código:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(147, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Posição:"
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(227, 163)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(195, 20)
        Me.TextBox4.TabIndex = 16
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(227, 199)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(195, 20)
        Me.TextBox5.TabIndex = 15
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(227, 235)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(195, 20)
        Me.TextBox6.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 526)
        Me.Controls.Add(Me.PBmercado)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Supermercado"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PBmercado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents BTproximo As System.Windows.Forms.Button
    Friend WithEvents BTanterior As System.Windows.Forms.Button
    Friend WithEvents BTdeleta As System.Windows.Forms.Button
    Friend WithEvents BTedita As System.Windows.Forms.Button
    Friend WithEvents BTsalva As System.Windows.Forms.Button
    Friend WithEvents BTnovo As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PBmercado As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox

End Class
