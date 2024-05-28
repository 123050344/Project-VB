
Imports System.IO
Imports System.Windows.Forms
Imports DocumentFormat.OpenXml
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Wordprocessing
Imports OfficeOpenXml
Imports System.Xml


Partial Public Class Form4
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub SetFinalNoteText(text As String)
            txtfinalnote.Text = text
        End Sub

        Public Sub SetFinalRecipeName(name As String)
            lblnamefinal.Text = name
        End Sub

        Private Sub btnexportword_Click(sender As Object, e As EventArgs) Handles btnexportword.Click
            Try

            Dim labelContent As String = lblnamefinal.Text
                Dim textboxContent As String = txtfinalnote.Text

            Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                Dim filePath As String = Path.Combine(desktopPath, "Recipe.docx")


            Using wordDocument As WordprocessingDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document)

                Dim mainPart As MainDocumentPart = wordDocument.AddMainDocumentPart()
                    mainPart.Document = New Document()
                    Dim body As Body = mainPart.Document.AppendChild(New Body())


                Dim paraLabel As Paragraph = body.AppendChild(New Paragraph())
                    Dim runLabel As Run = paraLabel.AppendChild(New Run())
                    runLabel.AppendChild(New Text("" & labelContent))

                Dim paraListView As Paragraph = body.AppendChild(New Paragraph())
                    Dim runListView As Run = paraListView.AppendChild(New Run())
                    runListView.AppendChild(New Text(""))
                    For Each item As ListViewItem In lstrecipefinal.Items
                        Dim itemPara As Paragraph = body.AppendChild(New Paragraph())
                        Dim itemRun As Run = itemPara.AppendChild(New Run())
                        itemRun.AppendChild(New Text(item.Text))
                    Next


                Dim paraTextBox As Paragraph = body.AppendChild(New Paragraph())
                    Dim runTextBox As Run = paraTextBox.AppendChild(New Run())
                runTextBox.AppendChild(New Text("" & textboxContent))
                mainPart.Document.Save()
                End Using

                MessageBox.Show("Document created successfully at " & filePath)
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Sub

        Private Sub btnexportexcel_Click(sender As Object, e As EventArgs) Handles btnexportexcel.Click
            Try

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial


            Dim labelContent As String = lblnamefinal.Text
            Dim textboxContent As String = txtfinalnote.Text

            Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                Dim filePath As String = Path.Combine(desktopPath, "Recipe.xlsx")

            Using package = New ExcelPackage()

                Dim worksheet = package.Workbook.Worksheets.Add("my recipe")


                worksheet.Cells("A1").Value = "Name"
                    worksheet.Cells("B1").Value = labelContent


                worksheet.Cells("A2").Value = "Ingredients"
                    worksheet.Cells("B2").Value = "Quantity"

                    Dim row As Integer = 3
                    For Each item As ListViewItem In lstrecipefinal.Items
                        If item.SubItems.Count >= 2 Then
                        worksheet.Cells("A" & row).Value = item.SubItems(0).Text
                        worksheet.Cells("B" & row).Value = item.SubItems(1).Text
                        row += 1
                        Else
                            MessageBox.Show("Each ListViewItem should have at least 2 subitems.")
                        End If
                    Next

                worksheet.Cells("A" & row).Value = "Preparation"
                    worksheet.Cells("B" & row).Value = textboxContent

                Dim fileInfo As New FileInfo(filePath)
                    package.SaveAs(fileInfo)
                End Using

                MessageBox.Show("Excel file created successfully at " & filePath)
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Sub

        Private Sub btnexporttxt_Click(sender As Object, e As EventArgs) Handles btnexporttxt.Click
            Try

            Dim labelContent As String = lblnamefinal.Text
                Dim textboxContent As String = txtfinalnote.Text


            Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                Dim filePath As String = Path.Combine(desktopPath, "Recipe.txt")


            Using writer As New StreamWriter(filePath)

                writer.WriteLine("Name:")
                    writer.WriteLine(labelContent)
                    writer.WriteLine()


                writer.WriteLine("Ingredients" & vbTab & "Quantity")
                    For Each item As ListViewItem In lstrecipefinal.Items
                        If item.SubItems.Count >= 2 Then
                            writer.WriteLine($"{item.SubItems(0).Text}{vbTab}{item.SubItems(1).Text}")
                        Else
                            MessageBox.Show("Each ListViewItem should have at least 2 subitems.")
                        End If
                    Next
                    writer.WriteLine()

                writer.WriteLine("Preparation:")
                    writer.WriteLine(textboxContent)
                End Using

                MessageBox.Show("Text file created successfully at " & filePath)
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Sub

        Private Sub btnexportxml_Click(sender As Object, e As EventArgs) Handles btnexportxml.Click
            Try

            Dim labelContent As String = lblnamefinal.Text
                Dim textboxContent As String = txtfinalnote.Text


            Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                Dim filePath As String = Path.Combine(desktopPath, "Recipe.xml")

            Using writer As XmlWriter = XmlWriter.Create(filePath, New XmlWriterSettings() With {.Indent = True})
                    writer.WriteStartDocument()
                    writer.WriteStartElement("Recipe")


                writer.WriteStartElement("Name")
                    writer.WriteString(labelContent)
                    writer.WriteEndElement()


                writer.WriteStartElement("Ingredients")
                    For Each item As ListViewItem In lstrecipefinal.Items
                        If item.SubItems.Count >= 2 Then
                            writer.WriteStartElement("Ingredient")
                            writer.WriteElementString("Name", item.SubItems(0).Text)
                            writer.WriteElementString("Quantity", item.SubItems(1).Text)
                            writer.WriteEndElement()
                        Else
                            MessageBox.Show("Each ListViewItem should have at least 2 subitems.")
                        End If
                    Next
                    writer.WriteEndElement()

                writer.WriteStartElement("Preparation")
                    writer.WriteString(textboxContent)
                    writer.WriteEndElement()

                    writer.WriteEndElement()
                    writer.WriteEndDocument()
                End Using

                MessageBox.Show("XML file created successfully at " & filePath)
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Sub

        Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class
