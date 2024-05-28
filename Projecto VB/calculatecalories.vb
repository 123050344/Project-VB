Imports Projecto_VB.Recipe

Friend Class CalculateCalories
    Public Shared Function AddCalories(ingredients As List(Of Ingredient)) As Integer
        Dim totalCalories As Integer = 0
        For Each ingredient In ingredients
            totalCalories += ingredient.Calories
        Next
        Return totalCalories
    End Function

End Class
