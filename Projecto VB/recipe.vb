Public Class Recipe
    Public Property Namer As String
    Public Property Ingredients As List(Of Ingredient)
    Public ReadOnly Property Calories As Integer

    Public Sub New()
        Ingredients = New List(Of Ingredient)()
    End Sub

    Public Sub New(namer As String, ingredients As List(Of Ingredient))
        Me.Namer = namer
        Me.Ingredients = ingredients
        CalcularCalories()
    End Sub

    Public Sub New(ingredients As List(Of Ingredient))
        Me.Ingredients = ingredients
        CalcularCalories()
    End Sub

    Public Sub CalcularCalories()
        Dim totalCalories As Integer = 0
        For Each ingredient In Ingredients
            totalCalories += ingredient.Calories
        Next
        SetCalories(totalCalories)
    End Sub


    Private Sub SetCalories(value As Integer)
        Me.CaloriesField = value
    End Sub


    Private CaloriesField As Integer


    Public Class Ingredient

        Public Property Namei As String
        Public Property Quantity As Integer

        Public ReadOnly Property Calories As Integer

        Public Sub New(namei As String, quantity As Integer, calories As Integer)
            Me.Namei = namei
            Me.Quantity = quantity
            Me.Calories = calories
        End Sub

        Public Sub ShowInformation()
            Console.WriteLine($"Ingredient: {Namei}, Quantity: {Quantity}, Calories: {Calories}")
        End Sub
    End Class


End Class
