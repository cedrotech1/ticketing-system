<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class routes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(routes))
        Me.update = New System.Windows.Forms.Button()
        Me.DeleteDataButton = New System.Windows.Forms.Button()
        Me.insertDataButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBoxD = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxB = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TT = New System.Windows.Forms.TextBox()
        Me.seach = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tid = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ref = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Buttonv = New System.Windows.Forms.Button()
        Me.addB = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.DataGridView9 = New System.Windows.Forms.DataGridView()
        Me.WELCAME = New System.Windows.Forms.Label()
        Me.DataGridView8 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'update
        '
        Me.update.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.update.Location = New System.Drawing.Point(463, 214)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(56, 23)
        Me.update.TabIndex = 100
        Me.update.Text = "update"
        Me.update.UseVisualStyleBackColor = False
        '
        'DeleteDataButton
        '
        Me.DeleteDataButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DeleteDataButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteDataButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DeleteDataButton.Location = New System.Drawing.Point(392, 214)
        Me.DeleteDataButton.Name = "DeleteDataButton"
        Me.DeleteDataButton.Size = New System.Drawing.Size(65, 23)
        Me.DeleteDataButton.TabIndex = 99
        Me.DeleteDataButton.Text = "delete"
        Me.DeleteDataButton.UseVisualStyleBackColor = False
        '
        'insertDataButton
        '
        Me.insertDataButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.insertDataButton.Location = New System.Drawing.Point(327, 214)
        Me.insertDataButton.Name = "insertDataButton"
        Me.insertDataButton.Size = New System.Drawing.Size(50, 23)
        Me.insertDataButton.TabIndex = 96
        Me.insertDataButton.Text = "Save"
        Me.insertDataButton.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label5.Location = New System.Drawing.Point(207, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 21)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "direction"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label3.Location = New System.Drawing.Point(-240, 273)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "hello"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(436, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 91
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.Location = New System.Drawing.Point(196, 300)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(538, 138)
        Me.DataGridView1.TabIndex = 106
        '
        'ComboBoxD
        '
        Me.ComboBoxD.FormattingEnabled = True
        Me.ComboBoxD.Location = New System.Drawing.Point(289, 159)
        Me.ComboBoxD.Name = "ComboBoxD"
        Me.ComboBoxD.Size = New System.Drawing.Size(122, 21)
        Me.ComboBoxD.TabIndex = 107
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(207, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 21)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "bus for route"
        '
        'ComboBoxB
        '
        Me.ComboBoxB.FormattingEnabled = True
        Me.ComboBoxB.Location = New System.Drawing.Point(320, 187)
        Me.ComboBoxB.Name = "ComboBoxB"
        Me.ComboBoxB.Size = New System.Drawing.Size(91, 21)
        Me.ComboBoxB.TabIndex = 109
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(465, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 21)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "time to go"
        '
        'TT
        '
        Me.TT.Location = New System.Drawing.Point(557, 128)
        Me.TT.Name = "TT"
        Me.TT.Size = New System.Drawing.Size(136, 20)
        Me.TT.TabIndex = 111
        '
        'seach
        '
        Me.seach.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.seach.Location = New System.Drawing.Point(344, 248)
        Me.seach.Name = "seach"
        Me.seach.Size = New System.Drawing.Size(131, 31)
        Me.seach.TabIndex = 105
        Me.seach.Text = "seach routes fo dates"
        Me.seach.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(465, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 21)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(207, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 21)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "route Id"
        '
        'Tid
        '
        Me.Tid.Location = New System.Drawing.Point(289, 130)
        Me.Tid.Name = "Tid"
        Me.Tid.Size = New System.Drawing.Size(121, 20)
        Me.Tid.TabIndex = 116
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(465, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 21)
        Me.Label8.TabIndex = 117
        Me.Label8.Text = "status"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(514, 153)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(179, 20)
        Me.TextBox1.TabIndex = 119
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"activate", "disactivate"})
        Me.ComboBox1.Location = New System.Drawing.Point(536, 183)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(157, 21)
        Me.ComboBox1.TabIndex = 121
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.DarkGray
        Me.TextBox2.Location = New System.Drawing.Point(196, 250)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(142, 20)
        Me.TextBox2.TabIndex = 122
        '
        'ref
        '
        Me.ref.BackColor = System.Drawing.Color.Black
        Me.ref.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ref.ForeColor = System.Drawing.Color.Lime
        Me.ref.Location = New System.Drawing.Point(481, 248)
        Me.ref.Name = "ref"
        Me.ref.Size = New System.Drawing.Size(88, 31)
        Me.ref.TabIndex = 123
        Me.ref.Text = "Refresh"
        Me.ref.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label9.Location = New System.Drawing.Point(193, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 17)
        Me.Label9.TabIndex = 124
        Me.Label9.Text = "LISTE OF ALL ROUTES"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button5.Location = New System.Drawing.Point(30, 330)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(124, 37)
        Me.Button5.TabIndex = 130
        Me.Button5.Text = "Logout"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button4.Location = New System.Drawing.Point(30, 289)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(124, 37)
        Me.Button4.TabIndex = 129
        Me.Button4.Text = "Users"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button3.Location = New System.Drawing.Point(30, 248)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 37)
        Me.Button3.TabIndex = 128
        Me.Button3.Text = "Reports"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button2.Location = New System.Drawing.Point(30, 207)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 37)
        Me.Button2.TabIndex = 127
        Me.Button2.Text = "Set Route"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Buttonv
        '
        Me.Buttonv.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Buttonv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonv.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Buttonv.Location = New System.Drawing.Point(30, 165)
        Me.Buttonv.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Buttonv.Name = "Buttonv"
        Me.Buttonv.Size = New System.Drawing.Size(124, 37)
        Me.Buttonv.TabIndex = 126
        Me.Buttonv.Text = "Add Directions"
        Me.Buttonv.UseVisualStyleBackColor = False
        '
        'addB
        '
        Me.addB.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.addB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addB.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.addB.Location = New System.Drawing.Point(30, 122)
        Me.addB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.addB.Name = "addB"
        Me.addB.Size = New System.Drawing.Size(124, 37)
        Me.addB.TabIndex = 125
        Me.addB.Text = "Add Buss"
        Me.addB.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Chartreuse
        Me.Button1.Location = New System.Drawing.Point(356, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 26)
        Me.Button1.TabIndex = 131
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label10.Location = New System.Drawing.Point(208, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 24)
        Me.Label10.TabIndex = 132
        Me.Label10.Text = "Make Sure you"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button6.Location = New System.Drawing.Point(30, 81)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(124, 37)
        Me.Button6.TabIndex = 203
        Me.Button6.Text = "Home"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Courier New", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label12.Location = New System.Drawing.Point(363, 53)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(307, 22)
        Me.Label12.TabIndex = 213
        Me.Label12.Text = "welcame admin control panel"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(64, 7)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(154, 58)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 211
        Me.PictureBox6.TabStop = False
        '
        'DataGridView9
        '
        Me.DataGridView9.AllowUserToAddRows = False
        Me.DataGridView9.AllowUserToDeleteRows = False
        Me.DataGridView9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView9.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView9.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView9.Location = New System.Drawing.Point(36, 3)
        Me.DataGridView9.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView9.Name = "DataGridView9"
        Me.DataGridView9.ReadOnly = True
        Me.DataGridView9.Size = New System.Drawing.Size(214, 62)
        Me.DataGridView9.TabIndex = 210
        '
        'WELCAME
        '
        Me.WELCAME.AutoSize = True
        Me.WELCAME.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.WELCAME.Font = New System.Drawing.Font("Jokerman", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WELCAME.ForeColor = System.Drawing.SystemColors.Desktop
        Me.WELCAME.Location = New System.Drawing.Point(359, 9)
        Me.WELCAME.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WELCAME.Name = "WELCAME"
        Me.WELCAME.Size = New System.Drawing.Size(289, 47)
        Me.WELCAME.TabIndex = 209
        Me.WELCAME.Text = "TICKET SYSTEM"
        '
        'DataGridView8
        '
        Me.DataGridView8.AllowUserToAddRows = False
        Me.DataGridView8.AllowUserToDeleteRows = False
        Me.DataGridView8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView8.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView8.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView8.Location = New System.Drawing.Point(292, 3)
        Me.DataGridView8.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView8.Name = "DataGridView8"
        Me.DataGridView8.ReadOnly = True
        Me.DataGridView8.Size = New System.Drawing.Size(448, 62)
        Me.DataGridView8.TabIndex = 212
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView2.Location = New System.Drawing.Point(196, 88)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(544, 154)
        Me.DataGridView2.TabIndex = 214
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(575, 248)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(159, 31)
        Me.Button7.TabIndex = 215
        Me.Button7.Text = "view act/dis activate"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'routes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 450)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.DataGridView9)
        Me.Controls.Add(Me.WELCAME)
        Me.Controls.Add(Me.DataGridView8)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Buttonv)
        Me.Controls.Add(Me.addB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ref)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Tid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBoxB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxD)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.seach)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.DeleteDataButton)
        Me.Controls.Add(Me.insertDataButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Name = "routes"
        Me.Text = "Routes_Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents update As Button
    Friend WithEvents DeleteDataButton As Button
    Friend WithEvents insertDataButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBoxD As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxB As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TT As TextBox
    Friend WithEvents seach As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Tid As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ref As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Buttonv As Button
    Friend WithEvents addB As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents DataGridView9 As DataGridView
    Friend WithEvents WELCAME As Label
    Friend WithEvents DataGridView8 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button7 As Button
End Class
