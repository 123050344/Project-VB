Public Class Recipe
    Public Property Namer As String
    Public Property Ingredients As Ingredient()
    Public ReadOnly Property Calories As Integer
        Get
            Return CalcularCalories()
        End Get
    End Property

    ' Constructor que no recibe parámetros
    Public Sub New()
        Ingredients = New Ingredient(0) {}
    End Sub

    ' Constructor que recibe el número de ingredientes
    Public Sub New(namer As String, numberOfIngredients As Integer)
        Me.Namer = namer
        Ingredients = New Ingredient(numberOfIngredients - 1) {}
    End Sub

    ' Constructor que recibe un arreglo de ingredientes
    Public Sub New(namer As String, ingredients As Ingredient())
        Me.Namer = namer
        Me.Ingredients = ingredients
        CalcularCalories()
    End Sub


    ' Método que no recibe parámetros pero regresa algo
    Public Function CalcularCalories() As Integer
        Dim totalCalories As Integer = 0
        For Each ingredient As Ingredient In Ingredients
            If ingredient IsNot Nothing Then
                totalCalories += ingredient.Calories
            End If
        Next
        Return totalCalories
    End Function
End Class