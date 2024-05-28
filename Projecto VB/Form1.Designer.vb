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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        btncreate = New Button()
        btnopen = New Button()
        pictureBox1 = New PictureBox()
        label2 = New Label()
        label1 = New Label()
        lstnrecipes = New ListView()
        CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btncreate
        ' 
        btncreate.BackColor = Color.Tan
        btncreate.FlatStyle = FlatStyle.Popup
        btncreate.Font = New Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point)
        btncreate.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btncreate.Location = New Point(47, 142)
        btncreate.Name = "btncreate"
        btncreate.Size = New Size(152, 61)
        btncreate.TabIndex = 1
        btncreate.Text = "Create"
        btncreate.UseVisualStyleBackColor = False
        ' 
        ' btnopen
        ' 
        btnopen.BackColor = Color.Tan
        btnopen.FlatStyle = FlatStyle.Popup
        btnopen.Font = New Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point)
        btnopen.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnopen.Location = New Point(47, 265)
        btnopen.Name = "btnopen"
        btnopen.Size = New Size(152, 61)
        btnopen.TabIndex = 2
        btnopen.Text = "Open"
        btnopen.UseVisualStyleBackColor = False
        ' 
        ' pictureBox1
        ' 
        pictureBox1.BackgroundImage = CType(resources.GetObject("pictureBox1.BackgroundImage"), Image)
        pictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        pictureBox1.Location = New Point(442, -2)
        pictureBox1.Name = "pictureBox1"
        pictureBox1.Size = New Size(201, 457)
        pictureBox1.TabIndex = 4
        pictureBox1.TabStop = False
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.BackColor = Color.Transparent
        label2.Font = New Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        label2.ForeColor = Color.SaddleBrown
        label2.Location = New Point(3, 397)
        label2.Name = "label2"
        label2.Size = New Size(433, 34)
        label2.TabIndex = 5
        label2.Text = "Note: if you already have a recipe, click on ""open"" to open and modify it." & vbCrLf & " If you want to create one, click on ""create""."
        label2.TextAlign = ContentAlignment.BottomCenter
        label2.UseMnemonic = False
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.BackColor = Color.Transparent
        label1.Font = New Font("Script MT Bold", 36F, FontStyle.Bold, GraphicsUnit.Point)
        label1.ForeColor = Color.LightSalmon
        label1.Location = New Point(47, 26)
        label1.Name = "label1"
        label1.Size = New Size(348, 58)
        label1.TabIndex = 6
        label1.Text = "Recipe Manager"
        ' 
        ' lstnrecipes
        ' 
        lstnrecipes.BackColor = Color.SaddleBrown
        lstnrecipes.BackgroundImage = CType(resources.GetObject("lstnrecipes.BackgroundImage"), Image)
        lstnrecipes.ForeColor = Color.SandyBrown
        lstnrecipes.Location = New Point(229, 142)
        lstnrecipes.Name = "lstnrecipes"
        lstnrecipes.Size = New Size(193, 231)
        lstnrecipes.TabIndex = 7
        lstnrecipes.UseCompatibleStateImageBehavior = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(637, 450)
        Controls.Add(lstnrecipes)
        Controls.Add(label1)
        Controls.Add(label2)
        Controls.Add(pictureBox1)
        Controls.Add(btnopen)
        Controls.Add(btncreate)
        Name = "Form1"
        Text = "Form1"
        CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btncreate As Button
    Friend WithEvents btnopen As Button
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents lstnrecipes As ListView
End Class
