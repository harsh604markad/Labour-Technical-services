<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel
        Me.Text1EmpID = New Guna.UI.WinForms.GunaTextBox
        Me.Text2Empname = New Guna.UI.WinForms.GunaTextBox
        Me.Text3Address = New Guna.UI.WinForms.GunaTextBox
        Me.Text4DOB = New Guna.UI.WinForms.GunaTextBox
        Me.Text5Qualification = New Guna.UI.WinForms.GunaTextBox
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton
        Me.GunaAdvenceButton2 = New Guna.UI.WinForms.GunaAdvenceButton
        Me.GunaAdvenceButton3 = New Guna.UI.WinForms.GunaAdvenceButton
        Me.GunaAdvenceButton4 = New Guna.UI.WinForms.GunaAdvenceButton
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel
        Me.Text6Gender = New Guna.UI.WinForms.GunaTextBox
        Me.GunaAdvenceButton5 = New Guna.UI.WinForms.GunaAdvenceButton
        Me.GunaAdvenceButton6 = New Guna.UI.WinForms.GunaAdvenceButton
        Me.GunaTextBox1 = New Guna.UI.WinForms.GunaTextBox
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(501, 9)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(246, 41)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Employee Details"
        Me.GunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(460, 168)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(0, 20)
        Me.GunaLabel3.TabIndex = 2
        Me.GunaLabel3.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(448, 79)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(80, 30)
        Me.GunaLabel2.TabIndex = 3
        Me.GunaLabel2.Text = "Emp id"
        Me.GunaLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(448, 142)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(116, 30)
        Me.GunaLabel4.TabIndex = 4
        Me.GunaLabel4.Text = "Emp name"
        Me.GunaLabel4.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(448, 206)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(91, 30)
        Me.GunaLabel5.TabIndex = 5
        Me.GunaLabel5.Text = "Address"
        Me.GunaLabel5.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(448, 275)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(58, 30)
        Me.GunaLabel6.TabIndex = 6
        Me.GunaLabel6.Text = "DOB"
        Me.GunaLabel6.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.Location = New System.Drawing.Point(446, 342)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(133, 30)
        Me.GunaLabel7.TabIndex = 7
        Me.GunaLabel7.Text = "Qualification"
        Me.GunaLabel7.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'Text1EmpID
        '
        Me.Text1EmpID.BaseColor = System.Drawing.Color.White
        Me.Text1EmpID.BorderColor = System.Drawing.Color.Silver
        Me.Text1EmpID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1EmpID.FocusedBaseColor = System.Drawing.Color.White
        Me.Text1EmpID.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Text1EmpID.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Text1EmpID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Text1EmpID.Location = New System.Drawing.Point(585, 71)
        Me.Text1EmpID.Name = "Text1EmpID"
        Me.Text1EmpID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Text1EmpID.Size = New System.Drawing.Size(220, 34)
        Me.Text1EmpID.TabIndex = 8
        Me.Text1EmpID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Text2Empname
        '
        Me.Text2Empname.BaseColor = System.Drawing.Color.White
        Me.Text2Empname.BorderColor = System.Drawing.Color.Silver
        Me.Text2Empname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text2Empname.FocusedBaseColor = System.Drawing.Color.White
        Me.Text2Empname.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Text2Empname.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Text2Empname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Text2Empname.Location = New System.Drawing.Point(585, 134)
        Me.Text2Empname.Name = "Text2Empname"
        Me.Text2Empname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Text2Empname.Size = New System.Drawing.Size(220, 34)
        Me.Text2Empname.TabIndex = 9
        Me.Text2Empname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Text3Address
        '
        Me.Text3Address.BaseColor = System.Drawing.Color.White
        Me.Text3Address.BorderColor = System.Drawing.Color.Silver
        Me.Text3Address.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text3Address.FocusedBaseColor = System.Drawing.Color.White
        Me.Text3Address.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Text3Address.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Text3Address.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Text3Address.Location = New System.Drawing.Point(585, 198)
        Me.Text3Address.Name = "Text3Address"
        Me.Text3Address.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Text3Address.Size = New System.Drawing.Size(220, 34)
        Me.Text3Address.TabIndex = 10
        Me.Text3Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Text4DOB
        '
        Me.Text4DOB.BaseColor = System.Drawing.Color.White
        Me.Text4DOB.BorderColor = System.Drawing.Color.Silver
        Me.Text4DOB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text4DOB.FocusedBaseColor = System.Drawing.Color.White
        Me.Text4DOB.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Text4DOB.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Text4DOB.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Text4DOB.Location = New System.Drawing.Point(585, 268)
        Me.Text4DOB.Name = "Text4DOB"
        Me.Text4DOB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Text4DOB.Size = New System.Drawing.Size(220, 33)
        Me.Text4DOB.TabIndex = 11
        Me.Text4DOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Text5Qualification
        '
        Me.Text5Qualification.BaseColor = System.Drawing.Color.White
        Me.Text5Qualification.BorderColor = System.Drawing.Color.Silver
        Me.Text5Qualification.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text5Qualification.FocusedBaseColor = System.Drawing.Color.White
        Me.Text5Qualification.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Text5Qualification.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Text5Qualification.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Text5Qualification.Location = New System.Drawing.Point(585, 342)
        Me.Text5Qualification.Name = "Text5Qualification"
        Me.Text5Qualification.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Text5Qualification.Size = New System.Drawing.Size(220, 30)
        Me.Text5Qualification.TabIndex = 12
        Me.Text5Qualification.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.ButtonType = Guna.UI.WinForms.AdvenceButtonType.DefaultButton
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Image = CType(resources.GetObject("GunaAdvenceButton1.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(93, 91)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(220, 43)
        Me.GunaAdvenceButton1.TabIndex = 13
        Me.GunaAdvenceButton1.Text = "add"
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.GunaAdvenceButton1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'GunaAdvenceButton2
        '
        Me.GunaAdvenceButton2.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton2.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.ButtonType = Guna.UI.WinForms.AdvenceButtonType.DefaultButton
        Me.GunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.CheckedImage = CType(resources.GetObject("GunaAdvenceButton2.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton2.ForeColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.Image = CType(resources.GetObject("GunaAdvenceButton2.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.GunaAdvenceButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.Location = New System.Drawing.Point(93, 193)
        Me.GunaAdvenceButton2.Name = "GunaAdvenceButton2"
        Me.GunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.OnHoverImage = Nothing
        Me.GunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.Size = New System.Drawing.Size(220, 43)
        Me.GunaAdvenceButton2.TabIndex = 14
        Me.GunaAdvenceButton2.Text = "save"
        Me.GunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.GunaAdvenceButton2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'GunaAdvenceButton3
        '
        Me.GunaAdvenceButton3.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton3.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.ButtonType = Guna.UI.WinForms.AdvenceButtonType.DefaultButton
        Me.GunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.CheckedImage = CType(resources.GetObject("GunaAdvenceButton3.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton3.ForeColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.Image = CType(resources.GetObject("GunaAdvenceButton3.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.GunaAdvenceButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.Location = New System.Drawing.Point(93, 307)
        Me.GunaAdvenceButton3.Name = "GunaAdvenceButton3"
        Me.GunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.OnHoverImage = Nothing
        Me.GunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.Size = New System.Drawing.Size(220, 43)
        Me.GunaAdvenceButton3.TabIndex = 15
        Me.GunaAdvenceButton3.Text = "next"
        Me.GunaAdvenceButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.GunaAdvenceButton3.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'GunaAdvenceButton4
        '
        Me.GunaAdvenceButton4.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton4.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.ButtonType = Guna.UI.WinForms.AdvenceButtonType.DefaultButton
        Me.GunaAdvenceButton4.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton4.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.CheckedImage = CType(resources.GetObject("GunaAdvenceButton4.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton4.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton4.ForeColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.Image = CType(resources.GetObject("GunaAdvenceButton4.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.GunaAdvenceButton4.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton4.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton4.Location = New System.Drawing.Point(962, 91)
        Me.GunaAdvenceButton4.Name = "GunaAdvenceButton4"
        Me.GunaAdvenceButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.OnHoverImage = Nothing
        Me.GunaAdvenceButton4.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.Size = New System.Drawing.Size(220, 43)
        Me.GunaAdvenceButton4.TabIndex = 16
        Me.GunaAdvenceButton4.Text = "Exit"
        Me.GunaAdvenceButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.GunaAdvenceButton4.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.Location = New System.Drawing.Point(448, 421)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(85, 30)
        Me.GunaLabel8.TabIndex = 18
        Me.GunaLabel8.Text = "Gender"
        Me.GunaLabel8.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'Text6Gender
        '
        Me.Text6Gender.BaseColor = System.Drawing.Color.White
        Me.Text6Gender.BorderColor = System.Drawing.Color.Silver
        Me.Text6Gender.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text6Gender.FocusedBaseColor = System.Drawing.Color.White
        Me.Text6Gender.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Text6Gender.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Text6Gender.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Text6Gender.Location = New System.Drawing.Point(585, 421)
        Me.Text6Gender.Name = "Text6Gender"
        Me.Text6Gender.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Text6Gender.Size = New System.Drawing.Size(216, 30)
        Me.Text6Gender.TabIndex = 19
        Me.Text6Gender.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GunaAdvenceButton5
        '
        Me.GunaAdvenceButton5.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton5.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton5.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton5.ButtonType = Guna.UI.WinForms.AdvenceButtonType.DefaultButton
        Me.GunaAdvenceButton5.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton5.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton5.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton5.CheckedImage = CType(resources.GetObject("GunaAdvenceButton5.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton5.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton5.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton5.ForeColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton5.Image = CType(resources.GetObject("GunaAdvenceButton5.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.GunaAdvenceButton5.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton5.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton5.Location = New System.Drawing.Point(950, 307)
        Me.GunaAdvenceButton5.Name = "GunaAdvenceButton5"
        Me.GunaAdvenceButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton5.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton5.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton5.OnHoverImage = Nothing
        Me.GunaAdvenceButton5.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton5.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton5.Size = New System.Drawing.Size(245, 40)
        Me.GunaAdvenceButton5.TabIndex = 21
        Me.GunaAdvenceButton5.Text = "Update"
        Me.GunaAdvenceButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.GunaAdvenceButton5.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'GunaAdvenceButton6
        '
        Me.GunaAdvenceButton6.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton6.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton6.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton6.ButtonType = Guna.UI.WinForms.AdvenceButtonType.DefaultButton
        Me.GunaAdvenceButton6.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton6.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton6.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton6.CheckedImage = CType(resources.GetObject("GunaAdvenceButton6.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton6.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton6.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton6.ForeColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton6.Image = CType(resources.GetObject("GunaAdvenceButton6.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.GunaAdvenceButton6.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton6.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton6.Location = New System.Drawing.Point(962, 193)
        Me.GunaAdvenceButton6.Name = "GunaAdvenceButton6"
        Me.GunaAdvenceButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton6.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton6.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton6.OnHoverImage = Nothing
        Me.GunaAdvenceButton6.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton6.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton6.Size = New System.Drawing.Size(220, 43)
        Me.GunaAdvenceButton6.TabIndex = 22
        Me.GunaAdvenceButton6.Text = "bill"
        Me.GunaAdvenceButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.GunaAdvenceButton6.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'GunaTextBox1
        '
        Me.GunaTextBox1.BaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox1.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaTextBox1.Location = New System.Drawing.Point(585, 509)
        Me.GunaTextBox1.Name = "GunaTextBox1"
        Me.GunaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox1.Size = New System.Drawing.Size(216, 30)
        Me.GunaTextBox1.TabIndex = 23
        Me.GunaTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.Location = New System.Drawing.Point(445, 504)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(81, 35)
        Me.GunaLabel9.TabIndex = 24
        Me.GunaLabel9.Text = "Salary"
        Me.GunaLabel9.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1261, 669)
        Me.Controls.Add(Me.GunaLabel9)
        Me.Controls.Add(Me.GunaTextBox1)
        Me.Controls.Add(Me.GunaAdvenceButton6)
        Me.Controls.Add(Me.GunaAdvenceButton5)
        Me.Controls.Add(Me.Text6Gender)
        Me.Controls.Add(Me.GunaLabel8)
        Me.Controls.Add(Me.GunaAdvenceButton4)
        Me.Controls.Add(Me.GunaAdvenceButton3)
        Me.Controls.Add(Me.GunaAdvenceButton2)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.Text5Qualification)
        Me.Controls.Add(Me.Text4DOB)
        Me.Controls.Add(Me.Text3Address)
        Me.Controls.Add(Me.Text2Empname)
        Me.Controls.Add(Me.Text1EmpID)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Name = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Text1EmpID As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Text2Empname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Text3Address As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Text4DOB As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Text5Qualification As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton2 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton3 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton4 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Text6Gender As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaAdvenceButton5 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton6 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaTextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
End Class
