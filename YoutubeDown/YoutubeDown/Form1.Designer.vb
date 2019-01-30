<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MiniaturaPequena = New System.Windows.Forms.PictureBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FlatAlertBox1 = New YoutubeDown.FlatAlertBox()
        Me.ProgressBar1 = New YoutubeDown.AlphaBar()
        Me.FlatButton1 = New YoutubeDown.FlatButton()
        Me.TextBox1 = New YoutubeDown.FlatTextBox()
        Me.TextBox2 = New YoutubeDown.FlatTextBox()
        Me.FlatButton2 = New YoutubeDown.FlatButton()
        Me.Label3 = New YoutubeDown.FlatLabel()
        Me.Label1 = New YoutubeDown.FlatLabel()
        CType(Me.MiniaturaPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(164, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Enter the Video URL"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'MiniaturaPequena
        '
        Me.MiniaturaPequena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniaturaPequena.ImageLocation = ""
        Me.MiniaturaPequena.Location = New System.Drawing.Point(12, 174)
        Me.MiniaturaPequena.Name = "MiniaturaPequena"
        Me.MiniaturaPequena.Size = New System.Drawing.Size(280, 172)
        Me.MiniaturaPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MiniaturaPequena.TabIndex = 12
        Me.MiniaturaPequena.TabStop = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Music File | *.mp3"
        '
        'FlatAlertBox1
        '
        Me.FlatAlertBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatAlertBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatAlertBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlatAlertBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatAlertBox1.kind = YoutubeDown.FlatAlertBox._Kind.Success
        Me.FlatAlertBox1.Location = New System.Drawing.Point(0, 352)
        Me.FlatAlertBox1.Name = "FlatAlertBox1"
        Me.FlatAlertBox1.Size = New System.Drawing.Size(439, 42)
        Me.FlatAlertBox1.TabIndex = 3
        Me.FlatAlertBox1.Tag = ""
        Me.FlatAlertBox1.Text = "Success"
        Me.FlatAlertBox1.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressBar1.Image = Nothing
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 0)
        Me.ProgressBar1.Maximum = 100
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.NoRounding = False
        Me.ProgressBar1.Size = New System.Drawing.Size(439, 5)
        Me.ProgressBar1.TabIndex = 14
        Me.ProgressBar1.Text = "AlphaBar1"
        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Visible = False
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.DodgerBlue
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(66, 47)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(316, 45)
        Me.FlatButton1.TabIndex = 2
        Me.FlatButton1.Text = "Get Link"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Transparent
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.MaxLength = 32767
        Me.TextBox1.Multiline = False
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = False
        Me.TextBox1.Size = New System.Drawing.Size(421, 29)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.UseSystemPasswordChar = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Transparent
        Me.TextBox2.Location = New System.Drawing.Point(8, 398)
        Me.TextBox2.MaxLength = 32767
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = False
        Me.TextBox2.Size = New System.Drawing.Size(419, 54)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBox2.TextColor = System.Drawing.Color.DodgerBlue
        Me.TextBox2.UseSystemPasswordChar = False
        Me.TextBox2.Visible = False
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.DodgerBlue
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(298, 174)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(125, 55)
        Me.FlatButton2.TabIndex = 13
        Me.FlatButton2.Text = "Download MP3"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(12, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 18)
        Me.Label3.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(12, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 18)
        Me.Label1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(439, 394)
        Me.Controls.Add(Me.FlatAlertBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FlatButton1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.FlatButton2)
        Me.Controls.Add(Me.MiniaturaPequena)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Youtube to mp3"
        CType(Me.MiniaturaPequena, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As YoutubeDown.FlatTextBox
    Friend WithEvents FlatButton1 As YoutubeDown.FlatButton
    Friend WithEvents FlatAlertBox1 As YoutubeDown.FlatAlertBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox2 As YoutubeDown.FlatTextBox
    Friend WithEvents Label1 As YoutubeDown.FlatLabel
    Friend WithEvents Label3 As YoutubeDown.FlatLabel
    Friend WithEvents MiniaturaPequena As System.Windows.Forms.PictureBox
    Friend WithEvents FlatButton2 As YoutubeDown.FlatButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ProgressBar1 As YoutubeDown.AlphaBar

End Class
