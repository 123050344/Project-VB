<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        txtnotes = New TextBox()
        btncreaterecipe = New Button()
        dgvingredients = New DataGridView()
        Ingredient = New DataGridViewTextBoxColumn()
        Quantity = New DataGridViewTextBoxColumn()
        Calories = New DataGridViewTextBoxColumn()
        btncalculatecalories = New Button()
        txttotalcalories = New TextBox()
        lstrecipes = New ListView()
        cbkindoffood = New ComboBox()
        label3 = New Label()
        txtnamerecipe = New TextBox()
        label1 = New Label()
        label5 = New Label()
        btnback = New FontAwesome.Sharp.IconButton()
        btnaddrecipe = New FontAwesome.Sharp.IconButton()
        CType(dgvingredients, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtnotes
        ' 
        txtnotes.BackColor = Color.SandyBrown
        txtnotes.Location = New Point(385, 275)
        txtnotes.Multiline = True
        txtnotes.Name = "txtnotes"
        txtnotes.Size = New Size(390, 194)
        txtnotes.TabIndex = 0
        ' 
        ' btncreaterecipe
        ' 
        btncreaterecipe.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btncreaterecipe.Font = New Font("Script MT Bold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        btncreaterecipe.ForeColor = Color.Maroon
        btncreaterecipe.ImageAlign = ContentAlignment.MiddleRight
        btncreaterecipe.Location = New Point(781, 275)
        btncreaterecipe.Name = "btncreaterecipe"
        btncreaterecipe.Size = New Size(116, 194)
        btncreaterecipe.TabIndex = 34
        btncreaterecipe.Text = "Create"
        btncreaterecipe.UseVisualStyleBackColor = False
        ' 
        ' dgvingredients
        ' 
        dgvingredients.BackgroundColor = Color.Peru
        dgvingredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvingredients.Columns.AddRange(New DataGridViewColumn() {Ingredient, Quantity, Calories})
        dgvingredients.GridColor = Color.PeachPuff
        dgvingredients.Location = New Point(385, 12)
        dgvingredients.Name = "dgvingredients"
        dgvingredients.RowTemplate.Height = 25
        dgvingredients.Size = New Size(512, 257)
        dgvingredients.TabIndex = 35
        ' 
        ' Ingredient
        ' 
        Ingredient.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Ingredient.HeaderText = "Ingredient"
        Ingredient.Name = "Ingredient"
        ' 
        ' Quantity
        ' 
        Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Quantity.HeaderText = "Quantity"
        Quantity.Name = "Quantity"
        Quantity.Width = 78
        ' 
        ' Calories
        ' 
        Calories.HeaderText = "Calories"
        Calories.Name = "Calories"
        ' 
        ' btncalculatecalories
        ' 
        btncalculatecalories.BackColor = Color.SaddleBrown
        btncalculatecalories.FlatStyle = FlatStyle.Popup
        btncalculatecalories.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btncalculatecalories.ForeColor = Color.PeachPuff
        btncalculatecalories.Location = New Point(12, 428)
        btncalculatecalories.Name = "btncalculatecalories"
        btncalculatecalories.Size = New Size(164, 37)
        btncalculatecalories.TabIndex = 36
        btncalculatecalories.Text = "Calculate calories"
        btncalculatecalories.UseVisualStyleBackColor = False
        ' 
        ' txttotalcalories
        ' 
        txttotalcalories.BackColor = Color.PeachPuff
        txttotalcalories.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txttotalcalories.ForeColor = Color.Black
        txttotalcalories.Location = New Point(182, 428)
        txttotalcalories.Name = "txttotalcalories"
        txttotalcalories.Size = New Size(197, 29)
        txttotalcalories.TabIndex = 37
        ' 
        ' lstrecipes
        ' 
        lstrecipes.BackColor = Color.SaddleBrown
        lstrecipes.BackgroundImage = CType(resources.GetObject("lstrecipes.BackgroundImage"), Image)
        lstrecipes.Location = New Point(12, 169)
        lstrecipes.Name = "lstrecipes"
        lstrecipes.Size = New Size(183, 237)
        lstrecipes.TabIndex = 38
        lstrecipes.UseCompatibleStateImageBehavior = False
        lstrecipes.View = View.List
        ' 
        ' cbkindoffood
        ' 
        cbkindoffood.BackColor = Color.PeachPuff
        cbkindoffood.FormattingEnabled = True
        cbkindoffood.Items.AddRange(New Object() {"Sweet", "Salty", "Drink"})
        cbkindoffood.Location = New Point(12, 128)
        cbkindoffood.Name = "cbkindoffood"
        cbkindoffood.Size = New Size(193, 23)
        cbkindoffood.TabIndex = 39
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.BackColor = Color.Transparent
        label3.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        label3.ForeColor = Color.Peru
        label3.Location = New Point(12, 105)
        label3.Name = "label3"
        label3.Size = New Size(102, 20)
        label3.TabIndex = 40
        label3.Text = "Kind of food:"
        ' 
        ' txtnamerecipe
        ' 
        txtnamerecipe.BackColor = Color.PeachPuff
        txtnamerecipe.Location = New Point(12, 79)
        txtnamerecipe.Name = "txtnamerecipe"
        txtnamerecipe.Size = New Size(238, 23)
        txtnamerecipe.TabIndex = 41
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.BackColor = Color.Transparent
        label1.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        label1.ForeColor = Color.Peru
        label1.Location = New Point(12, 56)
        label1.Name = "label1"
        label1.Size = New Size(57, 20)
        label1.TabIndex = 42
        label1.Text = "Name:"
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.BackColor = Color.Transparent
        label5.Font = New Font("Perpetua Titling MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        label5.ForeColor = Color.PeachPuff
        label5.Location = New Point(76, 9)
        label5.Name = "label5"
        label5.Size = New Size(259, 26)
        label5.TabIndex = 43
        label5.Text = "Create your recipe"
        ' 
        ' btnback
        ' 
        btnback.BackColor = Color.Transparent
        btnback.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft
        btnback.IconColor = Color.Black
        btnback.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnback.IconSize = 32
        btnback.Location = New Point(12, 7)
        btnback.Name = "btnback"
        btnback.Size = New Size(51, 36)
        btnback.TabIndex = 44
        btnback.Text = "                            Back"
        btnback.UseVisualStyleBackColor = False
        ' 
        ' btnaddrecipe
        ' 
        btnaddrecipe.BackColor = Color.Transparent
        btnaddrecipe.FlatStyle = FlatStyle.Popup
        btnaddrecipe.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        btnaddrecipe.IconColor = Color.DarkOrange
        btnaddrecipe.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnaddrecipe.IconSize = 40
        btnaddrecipe.Location = New Point(271, 68)
        btnaddrecipe.Name = "btnaddrecipe"
        btnaddrecipe.Size = New Size(64, 42)
        btnaddrecipe.TabIndex = 45
        btnaddrecipe.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(909, 477)
        Controls.Add(btnaddrecipe)
        Controls.Add(btnback)
        Controls.Add(label5)
        Controls.Add(label1)
        Controls.Add(txtnamerecipe)
        Controls.Add(label3)
        Controls.Add(cbkindoffood)
        Controls.Add(lstrecipes)
        Controls.Add(txttotalcalories)
        Controls.Add(btncalculatecalories)
        Controls.Add(dgvingredients)
        Controls.Add(btncreaterecipe)
        Controls.Add(txtnotes)
        Name = "Form2"
        Text = "Form2"
        CType(dgvingredients, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtnotes As TextBox
    Private WithEvents btncreaterecipe As Button
    Private WithEvents dgvingredients As DataGridView
    Private WithEvents Ingredient As DataGridViewTextBoxColumn
    Private WithEvents Quantity As DataGridViewTextBoxColumn
    Private WithEvents Calories As DataGridViewTextBoxColumn
    Private WithEvents btncalculatecalories As Button
    Private WithEvents txttotalcalories As TextBox
    Private WithEvents lstrecipes As ListView
    Private WithEvents cbkindoffood As ComboBox
    Private WithEvents label3 As Label
    Private WithEvents txtnamerecipe As TextBox
    Private WithEvents label1 As Label
    Private WithEvents label5 As Label
    Private WithEvents btnback As FontAwesome.Sharp.IconButton
    Private WithEvents btnaddrecipe As FontAwesome.Sharp.IconButton
End Class
