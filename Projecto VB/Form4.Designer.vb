<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form4))
        lstrecipefinal = New ListView()
        ingredient = New ColumnHeader()
        quantity = New ColumnHeader()
        txtfinalnote = New TextBox()
        lblnamefinal = New Label()
        btnexportword = New FontAwesome.Sharp.IconButton()
        btnexportexcel = New FontAwesome.Sharp.IconButton()
        btnexporttxt = New FontAwesome.Sharp.IconButton()
        btnexportxml = New FontAwesome.Sharp.IconButton()
        SuspendLayout()
        ' 
        ' lstrecipefinal
        ' 
        lstrecipefinal.BackColor = Color.BurlyWood
        lstrecipefinal.BackgroundImage = CType(resources.GetObject("lstrecipefinal.BackgroundImage"), Image)
        lstrecipefinal.Columns.AddRange(New ColumnHeader() {ingredient, quantity})
        lstrecipefinal.Font = New Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point)
        lstrecipefinal.Location = New Point(31, 78)
        lstrecipefinal.Name = "lstrecipefinal"
        lstrecipefinal.Size = New Size(241, 253)
        lstrecipefinal.TabIndex = 3
        lstrecipefinal.UseCompatibleStateImageBehavior = False
        lstrecipefinal.View = View.Details
        ' 
        ' ingredient
        ' 
        ingredient.Text = "Ingredient"
        ' 
        ' quantity
        ' 
        quantity.Text = "Quantity"
        ' 
        ' txtfinalnote
        ' 
        txtfinalnote.BackColor = Color.BurlyWood
        txtfinalnote.Location = New Point(31, 337)
        txtfinalnote.Multiline = True
        txtfinalnote.Name = "txtfinalnote"
        txtfinalnote.Size = New Size(335, 118)
        txtfinalnote.TabIndex = 4
        ' 
        ' lblnamefinal
        ' 
        lblnamefinal.AutoSize = True
        lblnamefinal.BackColor = Color.Transparent
        lblnamefinal.Font = New Font("Script MT Bold", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblnamefinal.ForeColor = Color.LemonChiffon
        lblnamefinal.Location = New Point(31, 33)
        lblnamefinal.Name = "lblnamefinal"
        lblnamefinal.Size = New Size(0, 42)
        lblnamefinal.TabIndex = 18
        ' 
        ' btnexportword
        ' 
        btnexportword.BackColor = Color.Transparent
        btnexportword.BackgroundImageLayout = ImageLayout.Center
        btnexportword.FlatStyle = FlatStyle.Flat
        btnexportword.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnexportword.ForeColor = Color.Transparent
        btnexportword.IconChar = FontAwesome.Sharp.IconChar.FileWord
        btnexportword.IconColor = Color.White
        btnexportword.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnexportword.IconSize = 38
        btnexportword.Location = New Point(419, 62)
        btnexportword.Name = "btnexportword"
        btnexportword.Size = New Size(69, 67)
        btnexportword.TabIndex = 19
        btnexportword.Text = "Word"
        btnexportword.TextAlign = ContentAlignment.BottomCenter
        btnexportword.UseVisualStyleBackColor = False
        ' 
        ' btnexportexcel
        ' 
        btnexportexcel.BackColor = Color.Transparent
        btnexportexcel.FlatStyle = FlatStyle.Flat
        btnexportexcel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnexportexcel.ForeColor = SystemColors.ControlLightLight
        btnexportexcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel
        btnexportexcel.IconColor = Color.White
        btnexportexcel.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnexportexcel.IconSize = 38
        btnexportexcel.Location = New Point(419, 135)
        btnexportexcel.Name = "btnexportexcel"
        btnexportexcel.Size = New Size(69, 67)
        btnexportexcel.TabIndex = 20
        btnexportexcel.Text = "Excel"
        btnexportexcel.TextAlign = ContentAlignment.BottomCenter
        btnexportexcel.UseVisualStyleBackColor = False
        ' 
        ' btnexporttxt
        ' 
        btnexporttxt.BackColor = Color.Transparent
        btnexporttxt.FlatStyle = FlatStyle.Flat
        btnexporttxt.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnexporttxt.ForeColor = SystemColors.ButtonHighlight
        btnexporttxt.IconChar = FontAwesome.Sharp.IconChar.FileText
        btnexporttxt.IconColor = Color.White
        btnexporttxt.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnexporttxt.IconSize = 38
        btnexporttxt.Location = New Point(419, 208)
        btnexporttxt.Name = "btnexporttxt"
        btnexporttxt.Size = New Size(69, 67)
        btnexporttxt.TabIndex = 21
        btnexporttxt.Text = "TXT"
        btnexporttxt.TextAlign = ContentAlignment.BottomCenter
        btnexporttxt.UseVisualStyleBackColor = False
        ' 
        ' btnexportxml
        ' 
        btnexportxml.BackColor = Color.Transparent
        btnexportxml.BackgroundImageLayout = ImageLayout.Center
        btnexportxml.FlatStyle = FlatStyle.Flat
        btnexportxml.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnexportxml.ForeColor = Color.Transparent
        btnexportxml.IconChar = FontAwesome.Sharp.IconChar.File
        btnexportxml.IconColor = Color.White
        btnexportxml.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnexportxml.IconSize = 38
        btnexportxml.Location = New Point(419, 281)
        btnexportxml.Name = "btnexportxml"
        btnexportxml.Size = New Size(69, 67)
        btnexportxml.TabIndex = 22
        btnexportxml.Text = "XML"
        btnexportxml.TextAlign = ContentAlignment.BottomCenter
        btnexportxml.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(504, 467)
        Controls.Add(btnexportxml)
        Controls.Add(btnexporttxt)
        Controls.Add(btnexportexcel)
        Controls.Add(btnexportword)
        Controls.Add(lblnamefinal)
        Controls.Add(txtfinalnote)
        Controls.Add(lstrecipefinal)
        Name = "Form4"
        Text = "Recipe"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Public WithEvents lstrecipefinal As ListView
    Private WithEvents ingredient As ColumnHeader
    Private WithEvents quantity As ColumnHeader
    Private WithEvents txtfinalnote As TextBox
    Private WithEvents lblnamefinal As Label
    Private WithEvents btnexportword As FontAwesome.Sharp.IconButton
    Private WithEvents btnexportexcel As FontAwesome.Sharp.IconButton
    Private WithEvents btnexporttxt As FontAwesome.Sharp.IconButton
    Private WithEvents btnexportxml As FontAwesome.Sharp.IconButton
End Class
