<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form3))
        btnopenfile = New Button()
        btnsave = New Button()
        label5 = New Label()
        btnback2 = New FontAwesome.Sharp.IconButton()
        dgvinformation = New DataGridView()
        CType(dgvinformation, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnopenfile
        ' 
        btnopenfile.BackColor = Color.BurlyWood
        btnopenfile.FlatStyle = FlatStyle.Popup
        btnopenfile.Font = New Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point)
        btnopenfile.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnopenfile.Location = New Point(72, 116)
        btnopenfile.Name = "btnopenfile"
        btnopenfile.Size = New Size(157, 57)
        btnopenfile.TabIndex = 26
        btnopenfile.Text = "Open file"
        btnopenfile.UseVisualStyleBackColor = False
        ' 
        ' btnsave
        ' 
        btnsave.BackColor = Color.BurlyWood
        btnsave.FlatStyle = FlatStyle.Popup
        btnsave.Font = New Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point)
        btnsave.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnsave.Location = New Point(72, 238)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(157, 57)
        btnsave.TabIndex = 27
        btnsave.Text = "Save "
        btnsave.UseVisualStyleBackColor = False
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.BackColor = Color.Transparent
        label5.Font = New Font("Perpetua Titling MT", 18F, FontStyle.Bold, GraphicsUnit.Point)
        label5.ForeColor = Color.PeachPuff
        label5.Location = New Point(81, 19)
        label5.Name = "label5"
        label5.Size = New Size(206, 29)
        label5.TabIndex = 28
        label5.Text = "Open a recipe"
        ' 
        ' btnback2
        ' 
        btnback2.BackColor = Color.Transparent
        btnback2.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft
        btnback2.IconColor = Color.Black
        btnback2.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnback2.IconSize = 32
        btnback2.Location = New Point(12, 12)
        btnback2.Name = "btnback2"
        btnback2.Size = New Size(51, 36)
        btnback2.TabIndex = 29
        btnback2.Text = "                            Back"
        btnback2.UseVisualStyleBackColor = False
        ' 
        ' dgvinformation
        ' 
        dgvinformation.BackgroundColor = Color.Sienna
        dgvinformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvinformation.Location = New Point(308, 72)
        dgvinformation.Name = "dgvinformation"
        dgvinformation.RowTemplate.Height = 25
        dgvinformation.Size = New Size(462, 354)
        dgvinformation.TabIndex = 30
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(dgvinformation)
        Controls.Add(btnback2)
        Controls.Add(label5)
        Controls.Add(btnsave)
        Controls.Add(btnopenfile)
        Name = "Form3"
        Text = "Form3"
        CType(dgvinformation, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents btnopenfile As Button
    Private WithEvents btnsave As Button
    Private WithEvents label5 As Label
    Private WithEvents btnback2 As FontAwesome.Sharp.IconButton
    Private WithEvents dgvinformation As DataGridView
End Class
