
Imports System
Imports System.Windows
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.IO
Imports System.Xml.Linq
Imports PROYECT.recipe
Imports System.Windows.Forms.DataFormats
Imports Projecto_VB.Recipe


Partial Public Class Form2
    Inherits Form

    Private currentRecipe As Recipe
    Private ingredientLimit As Integer
    Public Event RecipeCreated As EventHandler

    Public Sub New()
        InitializeComponent()
    End Sub

    ' Interface
    Public Interface IMostrable
        Sub ShowInformation()
    End Interface

    ' Su implementación
    Public Sub ShowInformation()
        If currentRecipe IsNot Nothing Then
            Dim message As String = $"Recipe Name: {currentRecipe.Namer}{Environment.NewLine}"
            message &= $"Number of Ingredients: {currentRecipe.Ingredients.Length}{Environment.NewLine}"
            message &= $"Total Calories: {currentRecipe.Calories}{Environment.NewLine}"

            Windows.MessageBox.Show(message, "Recipe Information")
        Else
            Windows.MessageBox.Show("No recipe available.", "Recipe Information")
        End If
    End Sub

    Private Sub btnAddRecipe_Click(sender As Object, e As EventArgs) Handles btnaddrecipe.Click
        Try
            Dim recipeName As String = txtnamerecipe.Text
            If String.IsNullOrWhiteSpace(recipeName) Then
                Windows.MessageBox.Show("The name of the recipe cannot be empty")
                Return
            End If

            Dim ingredients(ingredientLimit - 1) As Ingredient
            Dim index As Integer = 0
            For Each row As DataGridViewRow In dgvingredients.Rows
                If row.IsNewRow Then Continue For

                Dim ingredientCell = row.Cells("Ingredient")
                Dim quantityCell = row.Cells("Quantity")
                Dim caloriesCell = row.Cells("Calories")

                If ingredientCell.Value IsNot Nothing AndAlso quantityCell.Value IsNot Nothing AndAlso caloriesCell.Value IsNot Nothing Then
                    Dim iname As String = ingredientCell.Value.ToString()
                    Dim iQuantity As Integer
                    Dim iCalories As Integer

                    If Integer.TryParse(quantityCell.Value.ToString(), iQuantity) AndAlso Integer.TryParse(caloriesCell.Value.ToString(), iCalories) Then
                        ingredients(index) = New Ingredient(iname, iQuantity, iCalories)
                        index += 1
                    Else
                        Windows.MessageBox.Show("Amount or Calories are not valid numbers. Please check the values")
                        Return
                    End If
                End If
            Next

            currentRecipe = New Recipe(recipeName, ingredients)
            RaiseEvent RecipeCreated(Me, EventArgs.Empty)

            lstrecipes.Items.Add(currentRecipe.Namer)

            Dim form1 As New Form1()
            form1.AddToListView(recipeName)
            form1.Show()

            txtnamerecipe.Clear()
            dgvingredients.Rows.Clear()
            txttotalcalories.Clear()
            cbkindoffood.Items.Clear()
            txtnotes.Clear()
        Catch ex As Exception
            Windows.MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Dim form1 As New Form1()
        form1.Show()
        Me.Close()
    End Sub

    Private Sub cbKindOfFood_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbkindoffood.SelectedIndexChanged
        cbkindoffood.Items.Add("Sweet")
        cbkindoffood.Items.Add("Salty")
        cbkindoffood.Items.Add("Drink")
    End Sub

    Private Sub btnCalculateCalories_Click(sender As Object, e As EventArgs) Handles btncalculatecalories.Click
        Dim totalCalories As Integer = 0

        For Each row As DataGridViewRow In dgvingredients.Rows
            If row.Cells("Calories").Value IsNot Nothing AndAlso Integer.TryParse(row.Cells("Calories").Value.ToString(), totalCalories) Then
                totalCalories += totalCalories
            End If
        Next

        txttotalcalories.Text = totalCalories.ToString() & " cal"
    End Sub

    Private Sub btnCreateRecipe_Click(sender As Object, e As EventArgs) Handles btncreaterecipe.Click
        Dim form4 As New Form4()

        For Each row As DataGridViewRow In dgvingredients.Rows
            If row IsNot Nothing Then
                Dim ingredient As String = row.Cells("Ingredient").Value?.ToString()
                Dim quantity As String = row.Cells("Quantity").Value?.ToString()

                If ingredient IsNot Nothing AndAlso quantity IsNot Nothing Then
                    Dim item As New ListViewItem(ingredient)
                    item.SubItems.Add(quantity)
                    form4.lstrecipefinal.Items.Add(item)
                End If
            End If
        Next

        Dim recipeName As String = txtnamerecipe.Text
        form4.SetFinalRecipeName(recipeName)
        Dim notes As String = txtnotes.Text
        form4.SetFinalNoteText(notes)
        form4.Show()
    End Sub

    ' Se define el tamaño del arreglo
    Private Sub btnAddNIngredients_Click(sender As Object, e As EventArgs) Handles btnaddningredients.Click
        Dim numberOfIngredients As Integer
        If Integer.TryParse(txtnumberingredients.Text, numberOfIngredients) Then
            currentRecipe = New Recipe("New Recipe", numberOfIngredients)
            GenerateIngredientInputs(numberOfIngredients)
        Else
            Windows.MessageBox.Show("Please enter a valid number of ingredients.")
        End If

        txtnumberingredients.Clear()
    End Sub

    Private Sub GenerateIngredientInputs(numberOfIngredients As Integer)
        dgvingredients.Rows.Clear()

        For i As Integer = 0 To numberOfIngredients - 1
            dgvingredients.Rows.Add()
        Next
    End Sub

    Private Sub txtNumberIngredients_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumberingredients.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            Windows.MessageBox.Show("Please enter only numbers.")
        End If
    End Sub

    Private Sub dgvIngredients_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvingredients.CellEndEdit
        Dim filledRows As Integer = 0

        For Each row As DataGridViewRow In dgvingredients.Rows
            If row.Cells("Ingredient").Value IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(row.Cells("Ingredient").Value.ToString()) Then
                filledRows += 1
            End If
        Next

        If filledRows > ingredientLimit Then
            dgvingredients.Rows(e.RowIndex).Cells("Ingredient").Value = Nothing
            dgvingredients.Rows(e.RowIndex).Cells("Calories").Value = Nothing
            Windows.MessageBox.Show("You have reached the limit of ingredients.")
        End If
    End Sub


End Class
