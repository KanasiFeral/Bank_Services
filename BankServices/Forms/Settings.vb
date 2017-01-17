Imports System.IO

Public Class Settings

    'Переменная хранящая адрес на объект класса
    Dim connSQL As cSQLConnection

    'Процедура передача адреса объекта класса работы с БД
    Sub SetConnection(connSQLGlobal As cSQLConnection)

        'Присваиваем ссылку на класс работы с БД
        connSQL = connSQLGlobal

    End Sub

    'Создать соединение
    Private Sub bAddConnection_Click(sender As Object, e As EventArgs) Handles bAddConnection.Click

        'Проверка на пустоту полей ввода
        If (tbPath.Text.Equals("")) Then

            MsgBox("Вы не ввели все данные!", "Сообщение!", vbOK + vbExclamation)

        Else

            Dim sConnectionString As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=" + tbPath.Text + ";Integrated Security=true;MultipleActiveResultSets=True"
            Dim writter As StreamWriter = New StreamWriter("Data\ConnectSettings.cfg")
            writter.WriteLine(sConnectionString)
            writter.Close()
            writter.Dispose()
            MsgBox("Данные были сохранены!", 0, "Сообщение")
            Dim fLogIn As LogIn = New LogIn
            fLogIn.connSQL = connSQL
            fLogIn.Show()
            Close()

        End If


    End Sub

    'Отмена
    Private Sub bCancel_Click(sender As Object, e As EventArgs) Handles bCancel.Click

        'Вызов формы авторизации
        Dim fLogIn As LogIn = New LogIn
        fLogIn.Show()
        Close()

    End Sub

    'Возврат в главное меню
    Private Sub bReturnToMain_Click(sender As Object, e As EventArgs) Handles bReturnToMain.Click

        'Открытие главной формы
        Dim fMain As New Main
        fMain.SetConnection(connSQL)
        fMain.Show()
        Close()

    End Sub

    'Указываем путь к файлу
    Private Sub bOpenFile_Click(sender As Object, e As EventArgs) Handles bOpenFile.Click

        Dim openFileDialog As New OpenFileDialog()

        Try

            If (openFileDialog.ShowDialog() = DialogResult.OK) Then

                tbPath.Text = openFileDialog.FileName

            Else

                MsgBox("Отмена добавления", 0 + vbInformation, "Сообщение!")

            End If

        Catch exc As Exception

            MsgBox(exc.Message, 0 + vbExclamation, "Ошибка!")

        End Try

    End Sub
End Class