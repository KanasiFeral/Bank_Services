Imports System.IO
Public Class LogIn

    'Создаем экземпляр класса cSQLConnection
    Public connSQL As New cSQLConnection()

    'Вход в программу
    Private Sub bEnter_Click(sender As Object, e As EventArgs) Handles bEnter.Click

        Dim sQueryIsEmpry As String

        If (comboBoxType.SelectedIndex = 0) Then

            sQueryIsEmpry = "SELECT * FROM LOGON WHERE iType = 0"
            'Проверка на существование в базе кого-нибудь из администрации
            If (connSQL.bQueryToBoolean(sQueryIsEmpry) = True) Then

                'Проверка на ввод данных
                If (tBNameUser.Text.Equals("") Or tBPassword.Text.Equals("")) Then

                    MsgBox("Вы не ввели все данные!", 0 + vbInformation, "Сообщение!")

                Else

                    'Строка проверки
                    sQueryIsEmpry = "SELECT * FROM LOGON WHERE vLogin = '" + tBNameUser.Text + "' AND vPassword = '" + tBPassword.Text + "' AND iType = 0;"
                    'Проверка на существование аккаунта
                    If (connSQL.bQueryToBoolean(sQueryIsEmpry) = True) Then

                        Dim fMain As New Main()
                        fMain.SetConnection(connSQL)
                        fMain.bAdminStatus = True
                        fMain.Text = "Технобанк: Администратор (" + tBNameUser.Text + ")"
                        fMain.Show()
                        Hide()

                    Else

                        MsgBox("Данные не верны, повторите попытку!", 0 + vbInformation, "Сообщение!")

                    End If

                End If

            Else

                'Предложение создать администратора с паролем по умолчанию
                If MsgBox("Аккаунта администратора не существует!" + vbCrLf + "Создать по умолчанию?" + vbCrLf + "Имя: admin" + vbCrLf + "Пароль:admin",
                  vbYesNo + vbQuestion, "Сообщение!") = vbYes Then

                    sQueryIsEmpry = "INSERT INTO LOGON (vLogin, vPassword, iType) VALUES ('admin', 'admin', 0)"
                    'Создание записи
                    connSQL.bQueryToBoolean(sQueryIsEmpry)

                Else

                    'Закрыть программу
                    Application.Exit()

                End If


            End If

        Else 'Главный if

            If (tBNameUser.Text.Equals("") Or tBPassword.Text.Equals("")) Then

                MsgBox("Вы не ввели все данные!", "Сообщение!")

            Else

                'Строка проверки
                sQueryIsEmpry = "SELECT * FROM LOGON WHERE vLogin = '" + tBNameUser.Text + "' AND vPassword = '" + tBPassword.Text + "' AND iType = 1"

                'Проверка на существование аккаунта
                If (connSQL.bQueryToBoolean(sQueryIsEmpry) = True) Then

                    Dim fMain As New Main()
                    fMain.SetConnection(connSQL)
                    fMain.bAdminStatus = False
                    fMain.Text = "Технобанк: Пользователь (" + tBNameUser.Text + ")"
                    fMain.Show()
                    Hide()

                Else

                    MsgBox("Данные не верны, повторите попытку!", 0 + vbInformation, "Сообщение!")

                End If

            End If

        End If

    End Sub

    'Закрыть программу
    Private Sub bClose_Click(sender As Object, e As EventArgs) Handles bClose.Click

        'Закрыть соединение
        connSQL.bCloseConnection()
        'Закрыть программу
        Application.Exit()

    End Sub

    'Действия таймера
    Private Sub TimerBankServices_Tick(sender As Object, e As EventArgs) Handles TimerBankServices.Tick


        'Если существует файл настроек подключения
        If (File.Exists("Data\ConnectSettings.cfg")) Then

            Dim srReader As StreamReader = New StreamReader("Data\ConnectSettings.cfg")
            'Обьявление и присвоение значения переменной коннекта
            Dim sConnectionString As String
            sConnectionString = srReader.ReadLine()
            'Читаем и очищаем поток данных
            srReader.Close()
            srReader.Dispose()
            'Если вернет true
            If (connSQL.bOpenConnection(sConnectionString) = True) Then

                'Останавливаем таймер
                TimerBankServices.Stop()
                'Разблокируем форму, если соединение было открыто
                Enabled = True
                'Меняем текст лейбла
                ConnectionLabel.Text = "Настройки приняты!"

            Else

                ConnectionLabel.Text = "Ошибка подключения..."
                TimerBankServices.Stop()
                If MsgBox("Не удалось подключиться к базе данных, сервер выключен или неправильно указаны данные соединения. Настроить подключение?",
                  vbYesNo + vbQuestion, "Сообщение!") = vbYes Then

                    Dim fSettings As New Settings
                    fSettings.Show()
                    'Передача адреса conn
                    fSettings.SetConnection(connSQL)
                    'Возрат на главную форму
                    fSettings.bReturnToMain.Enabled = False
                    'Отмена
                    fSettings.bCancel.Enabled = True
                    'Скрываем
                    Hide()

                    Exit Sub

                Else

                    'Закрываем соединение и приложение
                    connSQL.bCloseConnection()
                    Application.Exit()

                End If

            End If
            'Главный if
        Else

            Dim swReader As StreamWriter = New StreamWriter("Data\ConnectSettings.cfg")
            swReader.Close()

        End If

    End Sub

    'Загрузка формы
    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Выбор по умолчанию администратора
        comboBoxType.SelectedIndex = 0
        'Блочим форму, пока идет проверка настроек
        Enabled = False
        'Устанавливаем текст для лейбла
        ConnectionLabel.Text = "Проверяем настройки..."
        'Интервал в 1 секунду
        TimerBankServices.Interval = 1000
        'Запуск таймера
        TimerBankServices.Start()

    End Sub

End Class