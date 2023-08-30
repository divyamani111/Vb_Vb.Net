Imports Excel = Microsoft.Office.Interop.Excel
Public Class Generate_Excel
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Excel_btn.Click
        Dim appXL As Excel.Application
        Dim wbXl As Excel.Workbook
        Dim shXL As Excel.Worksheet
        Dim raXL As Excel.Range

        appXL = CreateObject("Excel.Application")
        appXL.Visible = True

        wbXl = appXL.Workbooks.Add
        shXL = wbXl.ActiveSheet

        shXL.Cells(1, 1).Value = "FirstName"
        shXL.Cells(1, 2).Value = "LastName"
        shXL.Cells(1, 3).Value = "FullName"
        shXL.Cells(1, 4).Value = "Specialization"

        With shXL.Range("A1", "D1")
            .Font.Bold = True
            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        End With

        Dim Students(5, 2) As String
        Students(0, 0) = "Vijet"
        Students(0, 1) = "Girish"
        Students(1, 0) = "Atharva"
        Students(1, 1) = "Niharika"
        Students(2, 0) = "Johny"
        Students(2, 1) = "Joshna"
        Students(3, 0) = "Ram"
        Students(3, 1) = "Mythili"
        Students(4, 0) = "Umme"
        Students(4, 1) = "Ayman"

        shXL.Range("A2", "B6").Value = Students

        raXL = shXL.Range("C2", "C6")
        raXL.Formula = "=A2 & "" "" & B2"

        With shXL
            .Cells(2, 4).Value = "Kannada"
            .Cells(3, 4).Value = "Mathematics"
            .Cells(4, 4).Value = "Computer Science"
            .Cells(5, 4).Value = "Mathematics"
            .Cells(6, 4).Value = "Biology"
        End With

        raXL = shXL.Range("A1", "D1")
        raXL.EntireColumn.AutoFit()

        appXL.Visible = "True"
        appXL.UserControl = "True"

        raXL = Nothing
        shXL = Nothing
        wbXl = Nothing
        appXL.Quit()
        appXL = Nothing
        Exit Sub

Err_Handler:
        MsgBox(Err.Description, vbCritical, "Error: " & Err.Number)



    End Sub
End Class
