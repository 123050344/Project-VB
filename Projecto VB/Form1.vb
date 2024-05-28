
Partial Public Class Form1
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub AddToListView(item As String)
        lstnrecipes.Items.Add(New ListViewItem(item))
    End Sub

    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        Dim create As New Form2()
        create.Show()
    End Sub

    Private Sub btnopen_Click(sender As Object, e As EventArgs) Handles btnopen.Click
        Dim open As New Form3()
        open.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub label1_Click(sender As Object, e As EventArgs) Handles label1.Click

    End Sub

    Private Sub label2_Click(sender As Object, e As EventArgs) Handles label2.Click

    End Sub
End Class



