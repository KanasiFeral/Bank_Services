Public Class cProcedures

    'Объект класса cSQLConnection
    Public conSQLServer As cSQLConnection

    'Процедура удаления записи
    Public Sub vDeleteRecord(sQuery As String, sNameOfTable As String, sIdRecord As String,
                             binSource As BindingSource, dataGrid As DataGridView,
                             binNavigator As BindingNavigator)

        If MsgBox("Вы действительно хотите удалить запись?",
                  vbYesNo + vbQuestion, "Сообщение!") = vbYes Then

            If (conSQLServer.bQueryToBoolean(sQuery) = False) Then

                MsgBox("Все строки были удалены из базы!", 0, "Ошибка!")

            Else

                Dim iIdNow = 0
                Dim i = dataGrid.CurrentRow.Index
                iIdNow = Convert.ToInt32(dataGrid(0, i).Value)
                Dim sDelete As String = "DELETE FROM " + sNameOfTable + " WHERE " + sIdRecord + " = " + Convert.ToString(iIdNow)
                conSQLServer.bQueryToBoolean(sDelete)
                binSource.RemoveAt(i)
                conSQLServer.LoadTable(sNameOfTable, sQuery, binSource, dataGrid, binNavigator)

            End If

        End If


    End Sub

End Class