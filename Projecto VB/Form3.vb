Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.IO


Partial Public Class Form3
        Inherits Form

        Private currentFilePath As String

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btnopenfile_Click(sender As Object, e As EventArgs) Handles btnopenfile.Click
            Dim openFileDialog As New OpenFileDialog()
        End Sub

    Private Sub dataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvinformation.CellContentClick
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
            If currentFilePath IsNot Nothing Then
                Dim dt As DataTable = CType(dgvinformation.DataSource, DataTable)
                Dim lines(dt.Rows.Count - 1) As String

                For i As Integer = 0 To dt.Rows.Count - 1
                    lines(i) = dt.Rows(i)(0).ToString()
                Next

                File.WriteAllLines(currentFilePath, lines)
                MessageBox.Show("File saved successfully!")
            Else
                MessageBox.Show("No file loaded to save.")
            End If
        End Sub

        Private Sub btnopenfile_Click_1(sender As Object, e As EventArgs) Handles btnopenfile.Click
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Text Files (*.txt)|*.txt"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                currentFilePath = openFileDialog.FileName
                Dim fileData() As String = File.ReadAllLines(currentFilePath)

                Dim dt As New DataTable()
                dt.Columns.Add("Recipe")

                For Each line As String In fileData
                    dt.Rows.Add(line)
                Next

                dgvinformation.DataSource = dt
            dgvinformation.ReadOnly = False
        End If
        End Sub

        Private Sub btnback2_Click(sender As Object, e As EventArgs) Handles btnback2.Click
            Dim form1 As New Form1()
            form1.Show()
            Me.Close()
        End Sub
    End Class
 