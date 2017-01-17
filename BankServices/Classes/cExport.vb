Public Class cExport

    Public Sub ExportToExcel(dGV As DataGridView)

        If MessageBox.Show("Вы действительно хотите вывести на печать?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim ExcelApp As New Microsoft.Office.Interop.Excel.Application()
            Dim ExcelWorkBook As Microsoft.Office.Interop.Excel.Workbook
            ExcelWorkBook = ExcelApp.Workbooks.Add(Reflection.Missing.Value)

            Dim k As Integer = 0
            While k < dGV.ColumnCount
                ExcelApp.Cells(1, k + 1) = dGV.Columns(k).HeaderText
                System.Math.Max(System.Threading.Interlocked.Increment(k), k - 1)
            End While
            Dim i As Integer = 1
            While i < dGV.Rows.Count + 1
                Dim j As Integer = 0
                While j < dGV.ColumnCount
                    ExcelApp.Cells(i + 1, j + 1) = dGV.Rows(i - 1).Cells(j).Value
                    System.Math.Max(System.Threading.Interlocked.Increment(j), j - 1)
                End While
                System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
            End While


            ExcelApp.Visible = True
            ExcelApp.UserControl = True
        Else
            MessageBox.Show("Отмена печати!", "Отмена!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

End Class