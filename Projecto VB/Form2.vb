
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

    Public Event RecipeCreated As EventHandler

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Interface IMostrable
        Sub ShowInformation()
    End Interface

    Private Sub btnaddrecipe_Click(sender As Object, e As EventArgs) Handles btnaddrecipe.Click
        Try
            Dim recipeName As String = txtnamerecipe.Text
            If String.IsNullOrWhiteSpace(recipeName) Then
                Windows.MessageBox.Show("The name of the recipe cannot be empty")
                Return
            End If

            Dim ingredients As New List(Of Ingredient)()
            For Each row As DataGridViewRow In dgvingredients.Rows
                If row.IsNewRow Then Continue For

                Dim ingredientCell = row.Cells("Ingredient")
                Dim quantityCell = row.Cells("Quantity")
                Dim caloriesCell = row.Cells("Calories")

                If ingredientCell.Value IsNot Nothing AndAlso quantityCell.Value IsNot Nothing AndAlso caloriesCell.Value IsNot Nothing Then
                    Dim iname As String = ingredientCell.Value.ToString()
                    Dim iQuantity As Integer
                    Dim icalories As Integer
                    If Integer.TryParse(quantityCell.Value.ToString(), iQuantity) AndAlso Integer.TryParse(caloriesCell.Value.ToString(), icalories) Then
                        ingredients.Add(New Ingredient(iname, iQuantity, icalories))
                    Else
                        Windows.MessageBox.Show("Amount or Calories are not valid numbers. Please check the values")
                        Return
                    End If
                End If
            Next


            Dim recipe1 As New Recipe(recipeName, ingredients)
            RaiseEvent RecipeCreated(Me, EventArgs.Empty)

            lstrecipes.Items.Add(recipe1.Namer)


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

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Dim form1 As New Form1()
        form1.Show()
        Me.Close()
    End Sub

    Private Sub cbkindoffood_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbkindoffood.SelectedIndexChanged
        cbkindoffood.Items.Add("Sweet")
        cbkindoffood.Items.Add("Salty")
        cbkindoffood.Items.Add("Drink")
    End Sub

    Private Sub btncalculatecalories_Click(sender As Object, e As EventArgs) Handles btncalculatecalories.Click
        Dim totalCalories As Integer = 0

        For Each row As DataGridViewRow In dgvingredients.Rows
            If row.Cells("Calories").Value IsNot Nothing AndAlso Integer.TryParse(row.Cells("Calories").Value.ToString(), totalCalories) Then

                totalCalories += totalCalories
            End If
        Next

        txttotalcalories.Text = totalCalories.ToString() & " cal"
    End Sub

    Private Sub btncreaterecipe_Click(sender As Object, e As EventArgs) Handles btncreaterecipe.Click
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

    Private Sub lstrecipes_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lstrecipes.SelectedIndexChanged

    End Sub

    Private Sub dgvrecipe_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvingredients.CellContentClick

    End Sub

    Private Sub lstrecipes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstrecipes.SelectedIndexChanged

    End Sub
End Class
