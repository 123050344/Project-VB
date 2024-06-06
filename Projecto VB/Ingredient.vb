Public Class Ingredient
    Inherits Recipe
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
