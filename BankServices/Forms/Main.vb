Imports System.IO

Public Class Main

    'Переменная хранящая адрес на объект класса
    Dim connSQL As cSQLConnection
    'Переменная определяющая, закрыть программу или нет
    Public bCloseApp As Boolean = True
    'Переменная хранящая статус администратора
    Public bAdminStatus As Boolean = True
    'Переменная хранящая статус добавления/редактирования строки
    Public bAdd As Boolean = True
    'Переменная хранящая адрес объекта печати
    Dim printExport As New cExport
    'Переменная хранящая адрес объекта процедур
    Dim proc As New cProcedures

    'Процедура передача адреса объекта класса работы с БД
    Sub SetConnection(connSQLGlobal As cSQLConnection)

        'Присваиваем ссылку на класс работы с БД
        connSQL = connSQLGlobal

    End Sub

    'Процедуры главного меню
    'Выйти на форму авторизации
    Private Sub АвторизацияToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles АвторизацияToolStripMenuItem.Click

        bCloseApp = False
        Dim sLogin As New LogIn
        sLogin.Show()
        Close()

    End Sub

    'Закрыть приложение
    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыходToolStripMenuItem.Click

        bCloseApp = False
        connSQL.bCloseConnection()
        Application.Exit()

    End Sub

    'Настроить подключение к БД
    Private Sub НастройкиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles НастройкиToolStripMenuItem.Click

        Dim fSettings As New Settings
        fSettings.SetConnection(connSQL)
        fSettings.Show()
        'Возврат в главное меню
        fSettings.bReturnToMain.Enabled = True
        'Отмена
        fSettings.bCancel.Enabled = False
        Hide()

    End Sub

    'Информация о проекте
    Private Sub ОПрограммеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОПрограммеToolStripMenuItem.Click

        MsgBox("Проект выполнил:" + vbCrLf + "Влад Утенберг" + vbCrLf + "Колледж бизнеса и права" + vbCrLf + "©2016", 0, "Сообщение!")

    End Sub

    'Вызов справки
    Private Sub СправкаF1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СправкаF1ToolStripMenuItem.Click

        Help.ShowHelp(Me, HelpProviderBankServices.HelpNamespace)

    End Sub

    'Загрузка формы
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        HelpProviderBankServices.HelpNamespace = "Data\Help\BankServices.chm"
        HelpProviderBankServices.SetHelpNavigator(Me, HelpNavigator.Topic)
        HelpProviderBankServices.SetShowHelp(Me, True)

        'Прогрузка таблицы
        connSQL.LoadTable("TYPE_SERVICE", "SELECT iIdTypeService AS 'ID записи', vName AS 'Название услуги', vDescription AS 'Описание услуги' FROM TYPE_SERVICE", connSQL.binSourceTypeService, DataGridViewTypeService, bNavigatorBankServices)

        'Проверка на статус админа
        If (bAdminStatus = False) Then

            'Скрываем от пользователя вкладку с таблицами
            TabPageService.Parent = Nothing
            TabPageOperation.Parent = Nothing
            TabPageUsers.Parent = Nothing

            'Скрываем кнопки работы с бд
            bOpenPanel.Enabled = False
            bEdit.Enabled = False
            bCloseDelete.Enabled = False

        Else

            TabPageServiceOperation.Parent = Nothing

        End If

    End Sub

    'Обработка закрытия формы (после закрытия)
    Private Sub Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        If (bCloseApp = True) Then

            connSQL.bCloseConnection()
            Application.Exit()

        End If

        Exit Sub

    End Sub

    'Происходит при смене вкладки
    Private Sub TabControlTables_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControlTables.Selecting

        'TYPE_SERVICE
        If (TabControlTables.SelectedIndex = 0) Then

            'Прогрузка таблицы
            connSQL.LoadTable("TYPE_SERVICE", "SELECT iIdTypeService AS 'ID записи', vName AS 'Название услуги', vDescription AS 'Описание услуги' FROM TYPE_SERVICE", connSQL.binSourceTypeService, DataGridViewTypeService, bNavigatorBankServices)

            'DEPARTMENT
        ElseIf (TabControlTables.SelectedIndex = 1) Then

            'Прогрузка таблицы
            connSQL.LoadTable("DEPARTMENT", "SELECT iIdDepartment AS 'ID записи', vName AS 'Название отдела', iApartment AS 'Месторасположение' FROM DEPARTMENT", connSQL.binSourceDepartment, DataGridViewDepartment, bNavigatorBankServices)

            'DOCUMENTS
        ElseIf (TabControlTables.SelectedIndex = 2) Then

            'Прогрузка таблицы
            connSQL.LoadTable("DOCUMENTS", "SELECT iIdDocuments AS 'ID записи', vName AS 'Название документа' FROM DOCUMENTS", connSQL.binSourceDocuments, DataGridViewDocuments, bNavigatorBankServices)

            'WORKER
        ElseIf (TabControlTables.SelectedIndex = 3) Then

            'Прогрузка таблицы
            connSQL.LoadTable("WORKER", "SELECT W.iIdWorker AS 'ID записи', W.vSecondName AS 'Фамилия', W.vFirstName AS 'Имя', W.vThirdName AS 'Отчество', W.iRank AS 'Разряд', W.fExperience AS 'Стаж', D.vName AS 'Отдел (FK)' FROM WORKER AS W, DEPARTMENT AS D WHERE W.fk_iIdDep = D.iIdDepartment", connSQL.binSourceWorker, DataGridViewWorker, bNavigatorBankServices)

            'Прогрузка данных в комбобокс
            Try

                connSQL.sQueryToComboBox("SELECT vName FROM DEPARTMENT", cbWorkerFKDepName, "vName")

            Catch exc As Exception

                MsgBox(exc.Message, vbOK + vbExclamation, "Сообщение!")

            End Try

            'SERVICE
        ElseIf (TabControlTables.SelectedIndex = 4) Then

            If (bAdminStatus = False) Then

                'Прогрузка таблицы
                connSQL.LoadTable("CLIENT", "SELECT iIdClient AS 'ID записи', vStatus AS 'Статус', vAdress AS 'Адрес', vNameOrg AS 'Название организации', vSecondName AS 'Фамилия', vFirstName AS 'Имя', vThirdName AS 'Отчество', vDateOfIssue AS 'Дата выдачи', vDateBirth AS 'Дата рождения', vIssuedBy AS 'Кем выдан', vBatch AS 'Серия', iNumber AS 'Личный номер', vDetails AS 'Подробности', vBankDetails AS 'Банковские подробности', vPhoneNumber AS 'Номер телефона' FROM CLIENT", connSQL.binSourceClient, DataGridViewClient, bNavigatorBankServices)

            Else

                'Прогрузка таблицы
                connSQL.LoadTable("SERVICE", "SELECT SER.iIdService AS 'ID записи', TSER.vName AS 'Сервис (FK)', DOC.vName AS 'Документ (FK)', WOR.vSecondName + ' ' + WOR.vFirstName + ' ' + WOR.vThirdName AS 'Работник', SER.iPrice AS 'Стоимость услуги', SER.vName AS 'Название' FROM SERVICE AS SER, TYPE_SERVICE AS TSER, DOCUMENTS AS DOC, WORKER AS WOR WHERE SER.fk_iIdTypeService = TSER.iIdTypeService AND SER.fk_iIdDoc = DOC.iIdDocuments AND SER.fk_iIdWorker = WOR.iIdWorker", connSQL.binSourceService, DataGridViewService, bNavigatorBankServices)

                'Прогрузка данных в комбобокс
                Try

                    connSQL.sQueryToComboBox("SELECT vName FROM TYPE_SERVICE", cbServiceFKTypeService, "vName")
                    connSQL.sQueryToComboBox("SELECT vName FROM DOCUMENTS", cbServiceFKDocName, "vName")
                    connSQL.sQueryToComboBox("SELECT vSecondName + ' ' + vFirstName + ' ' + vThirdName AS FIO FROM WORKER", cbServiceFKFIOWorker, "FIO")

                Catch exc As Exception

                    MsgBox(exc.Message, vbOK + vbExclamation, "Сообщение!")

                End Try

            End If


            'CLIENT
        ElseIf (TabControlTables.SelectedIndex = 5) Then


            If (bAdminStatus = False) Then

                'Прогрузка таблицы
                connSQL.LoadTable("CLIENT", "SELECT O.vDate AS 'Дата', C.vNameOrg AS 'Название организации', C.vSecondName + ' ' + C.vFirstName + ' ' + C.vThirdName AS 'Клиент' , TS.vName AS 'Тип услуги', W.vSecondName + ' ' + W.vFirstName + ' ' + W.vThirdName AS 'Рабочий' FROM SERVICE AS S, OPERATION AS O, TYPE_SERVICE AS TS, CLIENT AS C, WORKER AS W WHERE O.fk_iIdClient = C.iIdClient AND O.fk_iIdService = S.iIdService AND S.fk_iIdTypeService = TS.iIdTypeService AND S.fk_iIdWorker = W.iIdWorker", connSQL.binSourceServiceOperation, DataGridViewServiceOpeartion, bNavigatorBankServices)

            Else

                'Прогрузка таблицы
                connSQL.LoadTable("CLIENT", "SELECT iIdClient AS 'ID записи', vStatus AS 'Статус', vAdress AS 'Адрес', vNameOrg AS 'Название организации', vSecondName AS 'Фамилия', vFirstName AS 'Имя', vThirdName AS 'Отчество', vDateOfIssue AS 'Дата выдачи', vDateBirth AS 'Дата рождения', vIssuedBy AS 'Кем выдан', vBatch AS 'Серия', iNumber AS 'Личный номер', vDetails AS 'Подробности', vBankDetails AS 'Банковские подробности', vPhoneNumber AS 'Номер телефона' FROM CLIENT", connSQL.binSourceClient, DataGridViewClient, bNavigatorBankServices)

            End If


            'OPERATION
        ElseIf (TabControlTables.SelectedIndex = 6) Then

            'Прогрузка таблицы
            connSQL.LoadTable("OPERATION", "SELECT OP.iIdOperation AS 'ID записи', CL.vSecondName + ' ' + CL.vFirstName + ' ' + CL.vThirdName AS 'Клиент', Cl.vNameOrg AS 'Название организации', SER.vName AS 'Сервис', OP.vDate AS 'Дата' FROM OPERATION AS OP, CLIENT AS CL, SERVICE AS SER WHERE OP.fk_iIdClient = CL.iIdClient AND OP.fk_iIdService = SER.iIdService", connSQL.binSourceOperation, DataGridViewOperation, bNavigatorBankServices)

            cbOperationTypeUser.SelectedIndex = 0

            'Прогрузка данных в комбобокс
            Try

                connSQL.sQueryToComboBox("SELECT vName FROM SERVICE", cbOperationFKServiceName, "vName")

            Catch exc As Exception

                MsgBox(exc.Message, vbOK + vbExclamation, "Сообщение!")

            End Try

            'LOGON
        ElseIf (TabControlTables.SelectedIndex = 7) Then

            'Прогрузка таблицы
            connSQL.LoadTable("LOGON", "SELECT iIdLogon AS 'ID записи', vLogin AS 'Логин', vPassword AS 'Пароль', iType AS 'Тип пользователя (1-Адм, 2- Пол)' FROM LOGON", connSQL.binSourceLogon, DataGridViewLogon, bNavigatorBankServices)

            'Доп вкладка Услуги-операции
        ElseIf (TabControlTables.SelectedIndex = 8) Then

            'Прогрузка таблицы
            connSQL.LoadTable("CLIENT", "SELECT O.vDate AS 'Дата', C.vNameOrg AS 'Название организации', C.vSecondName + ' ' + C.vFirstName + ' ' + C.vThirdName AS 'Клиент' , TS.vName AS 'Тип услуги', W.vSecondName + ' ' + W.vFirstName + ' ' + W.vThirdName AS 'Рабочий' FROM SERVICE AS S, OPERATION AS O, TYPE_SERVICE AS TS, CLIENT AS C, WORKER AS W WHERE O.fk_iIdClient = C.iIdClient AND O.fk_iIdService = S.iIdService AND S.fk_iIdTypeService = TS.iIdTypeService AND S.fk_iIdWorker = W.iIdWorker", connSQL.binSourceServiceOperation, DataGridViewServiceOpeartion, bNavigatorBankServices)

        End If

    End Sub

    'Печать таблицы в Excel
    Private Sub bPrint_Click(sender As Object, e As EventArgs) Handles bPrint.Click

        'TYPE_SERVICE
        If (TabControlTables.SelectedIndex = 0) Then

            printExport.ExportToExcel(DataGridViewTypeService)

            'DEPARTMENT
        ElseIf (TabControlTables.SelectedIndex = 1) Then

            printExport.ExportToExcel(DataGridViewDepartment)

            'DOCUMENTS
        ElseIf (TabControlTables.SelectedIndex = 2) Then

            printExport.ExportToExcel(DataGridViewDocuments)

            'WORKER
        ElseIf (TabControlTables.SelectedIndex = 3) Then

            printExport.ExportToExcel(DataGridViewWorker)

            'SERVICE
        ElseIf (TabControlTables.SelectedIndex = 4) Then

            printExport.ExportToExcel(DataGridViewService)

            'CLIENT
        ElseIf (TabControlTables.SelectedIndex = 5) Then

            printExport.ExportToExcel(DataGridViewClient)

            'OPERATION
        ElseIf (TabControlTables.SelectedIndex = 6) Then

            printExport.ExportToExcel(DataGridViewOperation)

            'LOGON
        ElseIf (TabControlTables.SelectedIndex = 7) Then

            printExport.ExportToExcel(DataGridViewLogon)

        End If

    End Sub

    'Открывает панель
    Private Sub bOpenPanel_Click(sender As Object, e As EventArgs) Handles bOpenPanel.Click

        'Ставим флаг в True, значит добавляем запись
        bAdd = True

        'TYPE_SERVICE
        If (TabControlTables.SelectedIndex = 0) Then

            'Очистка полей ввода
            tbTypeServiceName.Clear()
            tbTypeServiceDesc.Clear()

            PanelTypeService.Visible = True
            LabelTypeService.Text = "Добавляем запись"

            'DEPARTMENT
        ElseIf (TabControlTables.SelectedIndex = 1) Then

            'Очистка полей ввода
            tbDepartmentName.Clear()
            NumericUDApartment.Value = 0

            PanelDepartment.Visible = True
            LabelDepartment.Text = "Добавляем запись"

            'DOCUMENTS
        ElseIf (TabControlTables.SelectedIndex = 2) Then

            'Очистка полей ввода
            tbDocumentsName.Clear()

            PanelDocuments.Visible = True
            LabelDocuments.Text = "Добавляем запись"

            'WORKER
        ElseIf (TabControlTables.SelectedIndex = 3) Then

            'Очистка полей ввода
            tbWorkerSecondName.Clear()
            tbWorkerFirstName.Clear()
            tbWorkerThirdName.Clear()
            NumericUDWorkerRank.Value = 0
            NumericUDWorkerExp.Value = 0
            Try
                cbWorkerFKDepName.SelectedIndex = 0
            Catch exc As Exception
            End Try

            PanelWorker.Visible = True
            LabelWorker.Text = "Добавляем запись"

            'SERVICE
        ElseIf (TabControlTables.SelectedIndex = 4) Then

            'Очистка полей ввода
            Try
                cbServiceFKTypeService.SelectedIndex = 0
                cbServiceFKDocName.SelectedIndex = 0
                cbServiceFKFIOWorker.SelectedIndex = 0
            Catch exc As Exception
            End Try
            NumericUDServicePrice.Value = 0
            tbServiceName.Clear()

            PanelService.Visible = True
            LabelService.Text = "Добавляем запись"

            'CLIENT
        ElseIf (TabControlTables.SelectedIndex = 5) Then

            'Очистка полей ввода
            cbClientStatus.SelectedIndex = 0
            tbClientAddress.Clear()
            tbClientNameOrg.Clear()
            tbClientSecondName.Clear()
            tbClientFirstName.Clear()
            tbClientThirdName.Clear()
            DateTPClientDateOfIssue.Value = DateTime.Now
            DateTPClientDateBirth.Value = DateTime.Now
            tbClientIssuedBy.Clear()
            tbClientBatch.Clear()
            NumericUDClientNumber.Value = 0
            tbClientDetails.Clear()
            tbClientBankDetails.Clear()
            tbClientPhoneNumber.Clear()

            PanelClient.Visible = True
            LabelClient.Text = "Добавляем запись"

            'OPERATION
        ElseIf (TabControlTables.SelectedIndex = 6) Then

            'Очистка полей ввода
            Try
                cbOperationFKClientName.SelectedIndex = 0
                cbOperationFKServiceName.SelectedIndex = 0
            Catch exc As Exception
            End Try
            DateTPOperationDate.Value = DateTime.Now

            PanelOperation.Visible = True
            LabelOperation.Text = "Добавляем запись"

            'LOGON
        ElseIf (TabControlTables.SelectedIndex = 7) Then

            'Очистка полей ввода
            tbLogonLogin.Clear()
            tbLogonPassword.Clear()
            cbLogonType.SelectedIndex = 0

            PanelLogon.Visible = True
            LabelLogon.Text = "Добавляем запись"

        End If

    End Sub

    'Изменить запись
    Private Sub bEdit_Click(sender As Object, e As EventArgs) Handles bEdit.Click

        'Ставим флаг добавления в False, редактируем запись
        bAdd = False

        Dim x As Integer

        'TYPE_SERVICE
        If (TabControlTables.SelectedIndex = 0) Then

            Try

                'Определяем индекс выбранной строки
                x = DataGridViewTypeService.CurrentRow.Index

            Catch exc As Exception

                MsgBox("Редактировать нечего!", vbOK + vbExclamation, "Сообщение")

                Exit Sub

            End Try

            'Переносим данные на форму
            tbTypeServiceName.Text = Convert.ToString(DataGridViewTypeService(1, x).Value)
            tbTypeServiceDesc.Text = Convert.ToString(DataGridViewTypeService(2, x).Value)


            'Открываем панель
            PanelTypeService.Visible = True
            LabelTypeService.Text = "Изменяем запись"

            'DEPARTMENT
        ElseIf (TabControlTables.SelectedIndex = 1) Then

            Try

                'Определяем индекс выбранной строки
                x = DataGridViewDepartment.CurrentRow.Index

            Catch exc As Exception

                MsgBox("Редактировать нечего!", vbOK + vbExclamation, "Сообщение")

                Exit Sub

            End Try

            'Переносим данные на форму
            tbDepartmentName.Text = Convert.ToString(DataGridViewDepartment(1, x).Value)
            NumericUDApartment.Value = Convert.ToInt32(DataGridViewDepartment(2, x).Value)


            'Открываем панель
            PanelDepartment.Visible = True
            LabelDepartment.Text = "Изменяем запись"

            'DOCUMENTS
        ElseIf (TabControlTables.SelectedIndex = 2) Then

            Try

                'Определяем индекс выбранной строки
                x = DataGridViewDocuments.CurrentRow.Index

            Catch exc As Exception

                MsgBox("Редактировать нечего!", vbOK + vbExclamation, "Сообщение")

                Exit Sub

            End Try

            'Переносим данные на форму
            tbDocumentsName.Text = Convert.ToString(DataGridViewDocuments(1, x).Value)


            'Открываем панель
            PanelDocuments.Visible = True
            LabelDocuments.Text = "Изменяем запись"

            'WORKER
        ElseIf (TabControlTables.SelectedIndex = 3) Then

            Try

                'Определяем индекс выбранной строки
                x = DataGridViewWorker.CurrentRow.Index

            Catch exc As Exception

                MsgBox("Редактировать нечего!", vbOK + vbExclamation, "Сообщение")

                Exit Sub

            End Try

            'Переносим данные на форму
            tbWorkerSecondName.Text = Convert.ToString(DataGridViewWorker(1, x).Value)
            tbWorkerFirstName.Text = Convert.ToString(DataGridViewWorker(2, x).Value)
            tbWorkerThirdName.Text = Convert.ToString(DataGridViewWorker(3, x).Value)
            NumericUDWorkerRank.Value = Convert.ToInt32(DataGridViewWorker(4, x).Value)
            NumericUDWorkerExp.Value = Convert.ToInt32(DataGridViewWorker(5, x).Value)

            'Открываем панель
            PanelWorker.Visible = True
            LabelWorker.Text = "Изменяем запись"

            'SERVICE
        ElseIf (TabControlTables.SelectedIndex = 4) Then

            Try

                'Определяем индекс выбранной строки
                x = DataGridViewService.CurrentRow.Index

            Catch exc As Exception

                MsgBox("Редактировать нечего!", vbOK + vbExclamation, "Сообщение")

                Exit Sub

            End Try

            'Переносим данные на форму
            cbServiceFKTypeService.Text = Convert.ToString(DataGridViewService(1, x).Value)
            cbServiceFKDocName.Text = Convert.ToString(DataGridViewService(2, x).Value)
            cbServiceFKFIOWorker.Text = Convert.ToString(DataGridViewService(3, x).Value)
            NumericUDServicePrice.Value = Convert.ToInt32(DataGridViewService(4, x).Value)
            tbServiceName.Text = Convert.ToString(DataGridViewService(5, x).Value)

            'Открываем панель
            PanelService.Visible = True
            LabelService.Text = "Изменяем запись"

            'CLIENT
        ElseIf (TabControlTables.SelectedIndex = 5) Then

            Try

                'Определяем индекс выбранной строки
                x = DataGridViewClient.CurrentRow.Index

            Catch exc As Exception

                MsgBox("Редактировать нечего!", vbOK + vbExclamation, "Сообщение")

                Exit Sub

            End Try

            'Переносим данные на форму
            cbClientStatus.Text = Convert.ToString(DataGridViewClient(1, x).Value)
            tbClientAddress.Text = Convert.ToString(DataGridViewClient(2, x).Value)
            tbClientNameOrg.Text = Convert.ToString(DataGridViewClient(3, x).Value)
            tbClientSecondName.Text = Convert.ToString(DataGridViewClient(4, x).Value)
            tbClientFirstName.Text = Convert.ToString(DataGridViewClient(5, x).Value)
            tbClientThirdName.Text = Convert.ToString(DataGridViewClient(6, x).Value)
            DateTPClientDateOfIssue.Text = Convert.ToString(DataGridViewClient(7, x).Value)
            DateTPClientDateBirth.Text = Convert.ToString(DataGridViewClient(8, x).Value)
            tbClientIssuedBy.Text = Convert.ToString(DataGridViewClient(9, x).Value)
            tbClientBatch.Text = Convert.ToString(DataGridViewClient(10, x).Value)
            NumericUDClientNumber.Value = Convert.ToInt32(DataGridViewClient(11, x).Value)
            tbClientDetails.Text = Convert.ToString(DataGridViewClient(12, x).Value)
            tbClientBankDetails.Text = Convert.ToString(DataGridViewClient(13, x).Value)
            tbClientPhoneNumber.Text = Convert.ToString(DataGridViewClient(14, x).Value)

            'Открываем панель
            PanelClient.Visible = True
            LabelClient.Text = "Изменяем запись"

            'OPERATION
        ElseIf (TabControlTables.SelectedIndex = 6) Then

            Try

                'Определяем индекс выбранной строки
                x = DataGridViewOperation.CurrentRow.Index

            Catch exc As Exception

                MsgBox("Редактировать нечего!", vbOK + vbExclamation, "Сообщение")

                Exit Sub

            End Try

            'Переносим данные на форму

            Dim sCheck As String = Convert.ToString(DataGridViewOperation(1, x).Value)
            sCheck = Replace(sCheck, " ", "")

            If (sCheck.Equals("")) Then

                cbOperationTypeUser.SelectedIndex = 1
                cbOperationFKClientName.Text = Convert.ToString(DataGridViewOperation(2, x).Value)

            Else

                cbOperationTypeUser.SelectedIndex = 0
                cbOperationFKClientName.Text = Convert.ToString(DataGridViewOperation(1, x).Value)

            End If

            'cbOperationFKClientName.Text = Convert.ToString(DataGridViewOperation(1, x).Value)
            cbOperationFKServiceName.Text = Convert.ToString(DataGridViewOperation(3, x).Value)
            DateTPOperationDate.Text = Convert.ToString(DataGridViewOperation(4, x).Value)

            'Открываем панель
            PanelOperation.Visible = True
            LabelOperation.Text = "Изменяем запись"

                'LOGON
            ElseIf (TabControlTables.SelectedIndex = 7) Then

                Try

                'Определяем индекс выбранной строки
                x = DataGridViewLogon.CurrentRow.Index

            Catch exc As Exception

                MsgBox("Редактировать нечего!", vbOK + vbExclamation, "Сообщение")

                Exit Sub

            End Try

            'Переносим данные на форму
            tbLogonLogin.Text = Convert.ToString(DataGridViewLogon(1, x).Value)
            tbLogonPassword.Text = Convert.ToString(DataGridViewLogon(2, x).Value)
            cbLogonType.Text = Convert.ToString(DataGridViewLogon(3, x).Value)

            'Открываем панель
            PanelLogon.Visible = True
            LabelLogon.Text = "Изменяем запись"

        End If

    End Sub

    'Закрыть или удалить запись
    Private Sub bCloseDelete_Click(sender As Object, e As EventArgs) Handles bCloseDelete.Click

        'Передача адреса объекта клааса работы с бд
        proc.conSQLServer = connSQL

        'TYPE_SERVICE
        If (TabControlTables.SelectedIndex = 0) Then

            'Проверка на видимость панели
            If (PanelTypeService.Visible = False) Then

                'Вызов процедуры удаления записи
                proc.vDeleteRecord("SELECT * FROM TYPE_SERVICE", "TYPE_SERVICE", "iIdTypeService", connSQL.binSourceTypeService, DataGridViewTypeService, bNavigatorBankServices)

            Else

                'Закрываем панель
                PanelTypeService.Visible = False

            End If

            'Прогрузка таблицы
            connSQL.LoadTable("TYPE_SERVICE", "SELECT iIdTypeService AS 'ID записи', vName AS 'Название услуги', vDescription AS 'Описание услуги' FROM TYPE_SERVICE", connSQL.binSourceTypeService, DataGridViewTypeService, bNavigatorBankServices)

            'DEPARTMENT
        ElseIf (TabControlTables.SelectedIndex = 1) Then

            'Проверка на видимость панели
            If (PanelDepartment.Visible = False) Then

                'Вызов процедуры удаления записи
                proc.vDeleteRecord("SELECT * FROM DEPARTMENT", "DEPARTMENT", "iIdDepartment", connSQL.binSourceDepartment, DataGridViewDepartment, bNavigatorBankServices)

            Else

                'Закрываем панель
                PanelDepartment.Visible = False

            End If

            'Прогрузка таблицы
            connSQL.LoadTable("DEPARTMENT", "SELECT iIdDepartment AS 'ID записи', vName AS 'Название отдела', iApartment AS 'Месторасположение' FROM DEPARTMENT", connSQL.binSourceDepartment, DataGridViewDepartment, bNavigatorBankServices)


            'DOCUMENTS
        ElseIf (TabControlTables.SelectedIndex = 2) Then

            'Проверка на видимость панели
            If (PanelDocuments.Visible = False) Then

                'Вызов процедуры удаления записи
                proc.vDeleteRecord("SELECT * FROM DOCUMENTS", "DOCUMENTS", "iIdDocuments", connSQL.binSourceDocuments, DataGridViewDocuments, bNavigatorBankServices)

            Else

                'Закрываем панель
                PanelDocuments.Visible = False

            End If

            'Прогрузка таблицы
            connSQL.LoadTable("DOCUMENTS", "SELECT iIdDocuments AS 'ID записи', vName AS 'Название документа' FROM DOCUMENTS", connSQL.binSourceDocuments, DataGridViewDocuments, bNavigatorBankServices)


            'WORKER
        ElseIf (TabControlTables.SelectedIndex = 3) Then

            'Проверка на видимость панели
            If (PanelWorker.Visible = False) Then

                'Вызов процедуры удаления записи
                proc.vDeleteRecord("SELECT * FROM WORKER", "WORKER", "iIdWorker", connSQL.binSourceWorker, DataGridViewWorker, bNavigatorBankServices)

            Else

                'Закрываем панель
                PanelWorker.Visible = False

            End If

            'Прогрузка таблицы
            connSQL.LoadTable("WORKER", "SELECT W.iIdWorker AS 'ID записи', W.vSecondName AS 'Фамилия', W.vFirstName AS 'Имя', W.vThirdName AS 'Отчество', W.iRank AS 'Разряд', W.fExperience AS 'Стаж', D.vName AS 'Отдел (FK)' FROM WORKER AS W, DEPARTMENT AS D WHERE W.fk_iIdDep = D.iIdDepartment", connSQL.binSourceWorker, DataGridViewWorker, bNavigatorBankServices)

            'SERVICE
        ElseIf (TabControlTables.SelectedIndex = 4) Then

            'Проверка на видимость панели
            If (PanelService.Visible = False) Then

                'Вызов процедуры удаления записи
                proc.vDeleteRecord("SELECT * FROM SERVICE", "SERVICE", "iIdService", connSQL.binSourceService, DataGridViewService, bNavigatorBankServices)

            Else

                'Закрываем панель
                PanelService.Visible = False

            End If

            'Прогрузка таблицы
            connSQL.LoadTable("SERVICE", "SELECT SER.iIdService AS 'ID записи', TSER.vName AS 'Сервис (FK)', DOC.vName AS 'Документ (FK)', WOR.vSecondName + ' ' + WOR.vFirstName + ' ' + WOR.vThirdName AS 'Работник', SER.iPrice AS 'Стоимость услуги', SER.vName AS 'Название' FROM SERVICE AS SER, TYPE_SERVICE AS TSER, DOCUMENTS AS DOC, WORKER AS WOR WHERE SER.fk_iIdTypeService = TSER.iIdTypeService AND SER.fk_iIdDoc = DOC.iIdDocuments AND SER.fk_iIdWorker = WOR.iIdWorker", connSQL.binSourceService, DataGridViewService, bNavigatorBankServices)

            'CLIENT
        ElseIf (TabControlTables.SelectedIndex = 5) Then

            'Проверка на видимость панели
            If (PanelClient.Visible = False) Then

                'Вызов процедуры удаления записи
                proc.vDeleteRecord("SELECT * FROM CLIENT", "CLIENT", "iIdClient", connSQL.binSourceClient, DataGridViewClient, bNavigatorBankServices)

            Else

                'Закрываем панель
                PanelClient.Visible = False

            End If

            'Прогрузка таблицы
            connSQL.LoadTable("CLIENT", "SELECT iIdClient AS 'ID записи', vStatus AS 'Статус', vAdress AS 'Адрес', vNameOrg AS 'Название организации', vSecondName AS 'Фамилия', vFirstName AS 'Имя', vThirdName AS 'Отчество', vDateOfIssue AS 'Дата выдачи', vDateBirth AS 'Дата рождения', vIssuedBy AS 'Кем выдан', vBatch AS 'Серия', iNumber AS 'Личный номер', vDetails AS 'Подробности', vBankDetails AS 'Банковские подробности', vPhoneNumber AS 'Номер телефона' FROM CLIENT", connSQL.binSourceClient, DataGridViewClient, bNavigatorBankServices)

            'OPERATION
        ElseIf (TabControlTables.SelectedIndex = 6) Then

            'Проверка на видимость панели
            If (PanelOperation.Visible = False) Then

                'Вызов процедуры удаления записи
                proc.vDeleteRecord("SELECT * FROM OPERATION", "OPERATION", "iIdOperation", connSQL.binSourceOperation, DataGridViewOperation, bNavigatorBankServices)

            Else

                'Закрываем панель
                PanelOperation.Visible = False

            End If

            'Прогрузка таблицы
            connSQL.LoadTable("OPERATION", "SELECT OP.iIdOperation AS 'ID записи', CL.vSecondName + ' ' + CL.vFirstName + ' ' + CL.vThirdName AS 'Клиент', Cl.vNameOrg AS 'Название организации', SER.vName AS 'Сервис', OP.vDate AS 'Дата' FROM OPERATION AS OP, CLIENT AS CL, SERVICE AS SER WHERE OP.fk_iIdClient = CL.iIdClient AND OP.fk_iIdService = SER.iIdService", connSQL.binSourceOperation, DataGridViewOperation, bNavigatorBankServices)

            'LOGON
        ElseIf (TabControlTables.SelectedIndex = 7) Then

            'Проверка на видимость панели
            If (PanelLogon.Visible = False) Then

                'Вызов процедуры удаления записи
                proc.vDeleteRecord("SELECT * FROM LOGON", "LOGON", "iIdLogon", connSQL.binSourceLogon, DataGridViewLogon, bNavigatorBankServices)

            Else

                'Закрываем панель
                PanelLogon.Visible = False

            End If

            'Прогрузка таблицы
            connSQL.LoadTable("LOGON", "SELECT iIdLogon AS 'ID записи', vLogin AS 'Логин', vPassword AS 'Пароль', iType AS 'Тип пользователя (1-Адм, 2- Пол)' FROM LOGON", connSQL.binSourceLogon, DataGridViewLogon, bNavigatorBankServices)

        End If

    End Sub

    'Вкладка типы услуг

    'Добавить/изменить запись
    Private Sub bAddTypeService_Click(sender As Object, e As EventArgs) Handles bAddTypeService.Click

        'Проверка на заполненность полей
        If (tbTypeServiceName.Text.Equals("") Or tbTypeServiceDesc.Text.Equals("")) Then

            MsgBox("Не все поля заполнены!", 0 + vbInformation, "Сообщение")

        Else

            'Проверка добавляем ли, True - Добавляем
            If (bAdd = True) Then

                'Добавляем новую запись
                connSQL.bQueryToBoolean("INSERT INTO TYPE_SERVICE (vName, vDescription) VALUES ('" + tbTypeServiceName.Text + "','" + tbTypeServiceDesc.Text + "')")

            Else
                Dim i As Integer = DataGridViewTypeService.CurrentRow.Index
                Dim iIdNow As Integer = Convert.ToInt32(DataGridViewTypeService(0, i).Value)

                'Добавляем новую запись
                connSQL.bQueryToBoolean("UPDATE TYPE_SERVICE SET vName = '" + tbTypeServiceName.Text + "', vDescription = '" + tbTypeServiceDesc.Text + "' WHERE iIdTypeService = " & iIdNow)

                PanelTypeService.Visible = False
                'Очистка полей ввода
                tbTypeServiceName.Clear()
                tbTypeServiceDesc.Clear()

            End If

            'Прогрузка таблицы
            connSQL.LoadTable("TYPE_SERVICE", "SELECT iIdTypeService AS 'ID записи', vName AS 'Название услуги', vDescription AS 'Описание услуги' FROM TYPE_SERVICE", connSQL.binSourceTypeService, DataGridViewTypeService, bNavigatorBankServices)

        End If

    End Sub

    'Очистить поля ввода
    Private Sub bClearTypeService_Click(sender As Object, e As EventArgs) Handles bClearTypeService.Click

        'Очистка полей ввода
        tbTypeServiceName.Clear()
        tbTypeServiceDesc.Clear()

    End Sub

    'Вкладка отдел

    'Добавить/изменить запись
    Private Sub bAddDepartment_Click(sender As Object, e As EventArgs) Handles bAddDepartment.Click

        'Проверка на заполненность полей
        If (tbDepartmentName.Text.Equals("") Or NumericUDApartment.Text.Equals("")) Then

            MsgBox("Не все поля заполнены!", 0 + vbInformation, "Сообщение")

        Else

            'Проверка добавляем ли, True - Добавляем
            If (bAdd = True) Then

                'Добавляем новую запись
                connSQL.bQueryToBoolean("INSERT INTO DEPARTMENT (vName, iApartment) VALUES ('" + tbDepartmentName.Text + "','" + NumericUDApartment.Text + "')")

            Else
                Dim i As Integer = DataGridViewDepartment.CurrentRow.Index
                Dim iIdNow As Integer = Convert.ToInt32(DataGridViewDepartment(0, i).Value)

                'Добавляем новую запись
                connSQL.bQueryToBoolean("UPDATE DEPARTMENT SET vName = '" + tbDepartmentName.Text + "', iApartment = '" + NumericUDApartment.Text + "' WHERE iIdDepartment = " & iIdNow)

                PanelDepartment.Visible = False
                'Очистка полей ввода
                tbDepartmentName.Clear()
                NumericUDApartment.Value = 0

            End If

            'Прогрузка таблицы
            connSQL.LoadTable("DEPARTMENT", "SELECT iIdDepartment AS 'ID записи', vName AS 'Название отдела', iApartment AS 'Месторасположение' FROM DEPARTMENT", connSQL.binSourceDepartment, DataGridViewDepartment, bNavigatorBankServices)

        End If

    End Sub

    'Очистить поля ввода
    Private Sub bClearDepartment_Click(sender As Object, e As EventArgs) Handles bClearDepartment.Click

        'Очистка полей ввода
        tbDepartmentName.Clear()
        NumericUDApartment.Value = 0

    End Sub

    'Вкладка документы

    'Добавить/изменить запись
    Private Sub bAddDocuments_Click(sender As Object, e As EventArgs) Handles bAddDocuments.Click

        'Проверка на заполненность полей
        If (tbDocumentsName.Text.Equals("")) Then

            MsgBox("Не все поля заполнены!", 0 + vbInformation, "Сообщение")

        Else

            'Проверка добавляем ли, True - Добавляем
            If (bAdd = True) Then

                'Добавляем новую запись
                connSQL.bQueryToBoolean("INSERT INTO DOCUMENTS (vName) VALUES ('" + tbDocumentsName.Text + "')")

            Else
                Dim i As Integer = DataGridViewDocuments.CurrentRow.Index
                Dim iIdNow As Integer = Convert.ToInt32(DataGridViewDocuments(0, i).Value)

                'Добавляем новую запись
                connSQL.bQueryToBoolean("UPDATE DOCUMENTS SET vName = '" + tbDocumentsName.Text + "' WHERE iIdDocuments = " & iIdNow)

                PanelDocuments.Visible = False
                'Очистка полей ввода
                tbDocumentsName.Clear()

            End If

            'Прогрузка таблицы
            connSQL.LoadTable("DOCUMENTS", "SELECT iIdDocuments AS 'ID записи', vName AS 'Название документа' FROM DOCUMENTS", connSQL.binSourceDocuments, DataGridViewDocuments, bNavigatorBankServices)

        End If

    End Sub

    'Очистить поля ввода
    Private Sub bClearDocuments_Click(sender As Object, e As EventArgs) Handles bClearDocuments.Click

        'Очистка полей ввода
        tbDocumentsName.Clear()

    End Sub

    'Вкладка работник

    'Добавить/изменить запись
    Private Sub bAddWorker_Click(sender As Object, e As EventArgs) Handles bAddWorker.Click

        'Проверка на заполненность полей
        If (tbWorkerSecondName.Text.Equals("") Or tbWorkerFirstName.Text.Equals("") Or tbWorkerThirdName.Text.Equals("") Or NumericUDWorkerRank.Text.Equals("") Or NumericUDWorkerExp.Text.Equals("") Or cbWorkerFKDepName.Text.Equals("")) Then

            MsgBox("Не все поля заполнены!", 0 + vbInformation, "Сообщение")

        Else

            Dim sIdDep As String = ""

            'Получения ID отдела
            Try

                sIdDep = connSQL.sGetData("SELECT iIdDepartment FROM DEPARTMENT WHERE vName = '" + cbWorkerFKDepName.Text + "'")

            Catch exc As Exception
            End Try

            'Проверка добавляем ли, True - Добавляем
            If (bAdd = True) Then

                'Добавляем новую запись
                connSQL.bQueryToBoolean("INSERT INTO WORKER (vSecondName, vFirstName, vThirdName, iRank, fExperience, fk_iIdDep) VALUES ('" + tbWorkerSecondName.Text + "','" + tbWorkerFirstName.Text + "','" + tbWorkerThirdName.Text + "','" + NumericUDWorkerRank.Text + "','" + NumericUDWorkerExp.Text + "','" + sIdDep + "')")

            Else
                Dim i As Integer = DataGridViewWorker.CurrentRow.Index
                Dim iIdNow As Integer = Convert.ToInt32(DataGridViewWorker(0, i).Value)

                'Добавляем новую запись
                connSQL.bQueryToBoolean("UPDATE WORKER SET vSecondName = '" + tbWorkerSecondName.Text + "', vFirstName = '" + tbWorkerFirstName.Text + "', vThirdName = '" + tbWorkerThirdName.Text + "', iRank = '" + NumericUDWorkerRank.Text + "', fExperience = '" + NumericUDWorkerExp.Text + "', fk_iIdDep = '" + sIdDep + "' WHERE iIdWorker = " & iIdNow)

                PanelWorker.Visible = False
                'Очистка полей ввода
                tbWorkerSecondName.Clear()
                tbWorkerFirstName.Clear()
                tbWorkerThirdName.Clear()
                NumericUDWorkerRank.Value = 0
                NumericUDWorkerExp.Value = 0
                Try
                    cbWorkerFKDepName.SelectedIndex = 0
                Catch exc As Exception
                End Try

            End If

            'Прогрузка таблицы
            connSQL.LoadTable("WORKER", "SELECT W.iIdWorker AS 'ID записи', W.vSecondName AS 'Фамилия', W.vFirstName AS 'Имя', W.vThirdName AS 'Отчество', W.iRank AS 'Разряд', W.fExperience AS 'Стаж', D.vName AS 'Отдел (FK)' FROM WORKER AS W, DEPARTMENT AS D WHERE W.fk_iIdDep = D.iIdDepartment", connSQL.binSourceWorker, DataGridViewWorker, bNavigatorBankServices)

        End If

    End Sub

    'Очистить поля ввода
    Private Sub bClearWorker_Click(sender As Object, e As EventArgs) Handles bClearWorker.Click

        'Очистка полей ввода
        tbWorkerSecondName.Clear()
        tbWorkerFirstName.Clear()
        tbWorkerThirdName.Clear()
        NumericUDWorkerRank.Value = 0
        NumericUDWorkerExp.Value = 0
        Try
            cbWorkerFKDepName.SelectedIndex = 0
        Catch exc As Exception
        End Try

    End Sub

    'Вкладка услуга

    'Добавить/изменить запись
    Private Sub bAddService_Click(sender As Object, e As EventArgs) Handles bAddService.Click

        'Проверка на заполненность полей
        If (cbServiceFKTypeService.Text.Equals("") Or cbServiceFKDocName.Text.Equals("") Or cbServiceFKFIOWorker.Text.Equals("") Or NumericUDServicePrice.Text.Equals("") Or tbServiceName.Text.Equals("")) Then

            MsgBox("Не все поля заполнены!", 0 + vbInformation, "Сообщение")

        Else

            Dim sIdTypeService As String = "", sIdDoc As String = "", sIdWorker As String = ""

            'Получения ID отдела
            Try

                sIdTypeService = connSQL.sGetData("SELECT iIdTypeService FROM TYPE_SERVICE WHERE vName = '" + cbServiceFKTypeService.Text + "'")
                sIdDoc = connSQL.sGetData("SELECT iIdDocuments FROM DOCUMENTS WHERE vName = '" + cbServiceFKDocName.Text + "'")
                sIdWorker = connSQL.sGetData("SELECT iIdWorker FROM WORKER WHERE vSecondName + ' ' + vFirstName + ' ' + vThirdName = '" + cbServiceFKFIOWorker.Text + "'")


            Catch exc As Exception
            End Try

            'Проверка добавляем ли, True - Добавляем
            If (bAdd = True) Then

                'Добавляем новую запись
                connSQL.bQueryToBoolean("INSERT INTO SERVICE (fk_iIdTypeService, fk_iIdDoc, fk_iIdWorker, iPrice, vName) VALUES ('" + sIdTypeService + "','" + sIdDoc + "','" + sIdWorker + "','" + NumericUDServicePrice.Text + "','" + tbServiceName.Text + "')")

            Else
                Dim i As Integer = DataGridViewService.CurrentRow.Index
                Dim iIdNow As Integer = Convert.ToInt32(DataGridViewService(0, i).Value)

                'Добавляем новую запись
                connSQL.bQueryToBoolean("UPDATE SERVICE SET fk_iIdTypeService = '" + sIdTypeService + "', fk_iIdDoc = '" + sIdDoc + "', fk_iIdWorker = '" + sIdWorker + "', iPrice = '" + NumericUDServicePrice.Text + "', vName = '" + tbServiceName.Text + "' WHERE iIdService = " & iIdNow)

                PanelService.Visible = False
                'Очистка полей ввода
                Try
                    cbServiceFKTypeService.SelectedIndex = 0
                    cbServiceFKDocName.SelectedIndex = 0
                    cbServiceFKFIOWorker.SelectedIndex = 0
                Catch exc As Exception
                End Try
                NumericUDServicePrice.Value = 0
                tbServiceName.Clear()

            End If

            'Прогрузка таблицы
            connSQL.LoadTable("SERVICE", "SELECT SER.iIdService AS 'ID записи', TSER.vName AS 'Сервис (FK)', DOC.vName AS 'Документ (FK)', WOR.vSecondName + ' ' + WOR.vFirstName + ' ' + WOR.vThirdName AS 'Работник', SER.iPrice AS 'Стоимость услуги', SER.vName AS 'Название' FROM SERVICE AS SER, TYPE_SERVICE AS TSER, DOCUMENTS AS DOC, WORKER AS WOR WHERE SER.fk_iIdTypeService = TSER.iIdTypeService AND SER.fk_iIdDoc = DOC.iIdDocuments AND SER.fk_iIdWorker = WOR.iIdWorker", connSQL.binSourceService, DataGridViewService, bNavigatorBankServices)

        End If

    End Sub

    'Очистить поля ввода
    Private Sub bClearService_Click(sender As Object, e As EventArgs) Handles bClearService.Click

        'Очистка полей ввода
        Try
            cbServiceFKTypeService.SelectedIndex = 0
            cbServiceFKDocName.SelectedIndex = 0
            cbServiceFKFIOWorker.SelectedIndex = 0
        Catch exc As Exception
        End Try
        NumericUDServicePrice.Value = 0
        tbServiceName.Clear()

    End Sub

    'Вкладка клиент

    'Добавить/изменить запись
    Private Sub bAddClient_Click(sender As Object, e As EventArgs) Handles bAddClient.Click

        'Проверка на заполненность полей
        If (cbClientStatus.Text.Equals("") Or tbClientAddress.Text.Equals("") Or tbClientDetails.Text.Equals("") Or tbClientBankDetails.Text.Equals("") Or tbClientPhoneNumber.Text.Equals("")) Then

            'Если выбрано физ лицо
            If (cbClientStatus.SelectedIndex = 1) Then

                If (tbClientSecondName.Text.Equals("") Or tbClientFirstName.Text.Equals("") Or tbClientThirdName.Text.Equals("") Or DateTPClientDateOfIssue.Text.Equals("") Or DateTPClientDateBirth.Text.Equals("") Or tbClientIssuedBy.Text.Equals("") Or tbClientBatch.Text.Equals("") Or NumericUDClientNumber.Text.Equals("")) Then

                    MsgBox("Не все поля заполнены!", 0 + vbInformation, "Сообщение")

                    Exit Sub

                End If

                'Если выбрано юр лицо
            Else

                If (tbClientNameOrg.Text.Equals("")) Then

                    MsgBox("Не все поля заполнены!", 0 + vbInformation, "Сообщение")

                    Exit Sub

                End If

            End If

            MsgBox("Не все поля заполнены!", 0 + vbInformation, "Сообщение")

            Exit Sub

        Else

            'Проверка добавляем ли, True - Добавляем
            If (bAdd = True) Then

                'Добавляем новую запись
                connSQL.bQueryToBoolean("INSERT INTO CLIENT (vStatus, vAdress, vNameOrg, vSecondName, vFirstName, vThirdName, vDateOfIssue, vDateBirth, vIssuedBy, vBatch, iNumber, vDetails, vBankDetails, vPhoneNumber) VALUES ('" + cbClientStatus.Text + "','" + tbClientAddress.Text + "','" + tbClientNameOrg.Text + "','" + tbClientSecondName.Text + "','" + tbClientFirstName.Text + "','" + tbClientThirdName.Text + "','" + DateTPClientDateOfIssue.Text + "','" + DateTPClientDateBirth.Text + "','" + tbClientIssuedBy.Text + "','" + tbClientBatch.Text + "','" + NumericUDClientNumber.Text + "','" + tbClientDetails.Text + "','" + tbClientBankDetails.Text + "','" + tbClientPhoneNumber.Text + "')")

            Else

                Dim i As Integer = DataGridViewClient.CurrentRow.Index
                Dim iIdNow As Integer = Convert.ToInt32(DataGridViewClient(0, i).Value)

                'Добавляем новую запись
                connSQL.bQueryToBoolean("UPDATE CLIENT SET vStatus = '" + cbClientStatus.Text + "', vAdress = '" + tbClientAddress.Text + "', vNameOrg = '" + tbClientNameOrg.Text + "', vSecondName = '" + tbClientSecondName.Text + "', vFirstName = '" + tbClientFirstName.Text + "', vThirdName = '" + tbClientThirdName.Text + "', vDateOfIssue = '" + DateTPClientDateOfIssue.Text + "', vDateBirth = '" + DateTPClientDateBirth.Text + "', vIssuedBy = '" + tbClientIssuedBy.Text + "', vBatch = '" + tbClientBatch.Text + "', iNumber = '" + NumericUDClientNumber.Text + "', vDetails = '" + tbClientDetails.Text + "', vBankDetails = '" + tbClientBankDetails.Text + "', vPhoneNumber = '" + tbClientPhoneNumber.Text + "' WHERE iIdClient = " & iIdNow)

                PanelClient.Visible = False
                'Очистка полей ввода

                cbClientStatus.SelectedIndex = 0
                tbClientAddress.Clear()
                tbClientNameOrg.Clear()
                tbClientSecondName.Clear()
                tbClientFirstName.Clear()
                tbClientThirdName.Clear()
                DateTPClientDateOfIssue.Value = DateTime.Now
                DateTPClientDateBirth.Value = DateTime.Now
                tbClientIssuedBy.Clear()
                tbClientBatch.Clear()
                NumericUDClientNumber.Value = 0
                tbClientDetails.Clear()
                tbClientBankDetails.Clear()
                tbClientPhoneNumber.Clear()


            End If

            'Прогрузка таблицы
            connSQL.LoadTable("CLIENT", "SELECT iIdClient AS 'ID записи', vStatus AS 'Статус', vAdress AS 'Адрес', vNameOrg AS 'Название организации', vSecondName AS 'Фамилия', vFirstName AS 'Имя', vThirdName AS 'Отчество', vDateOfIssue AS 'Дата выдачи', vDateBirth AS 'Дата рождения', vIssuedBy AS 'Кем выдан', vBatch AS 'Серия', iNumber AS 'Личный номер', vDetails AS 'Подробности', vBankDetails AS 'Банковские подробности', vPhoneNumber AS 'Номер телефона' FROM CLIENT", connSQL.binSourceClient, DataGridViewClient, bNavigatorBankServices)

        End If

    End Sub

    'Очистить поля ввода
    Private Sub bClearClient_Click(sender As Object, e As EventArgs) Handles bClearClient.Click

        'Очистка полей ввода
        cbClientStatus.SelectedIndex = 0
        tbClientAddress.Clear()
        tbClientNameOrg.Clear()
        tbClientSecondName.Clear()
        tbClientFirstName.Clear()
        tbClientThirdName.Clear()
        DateTPClientDateOfIssue.Value = DateTime.Now
        DateTPClientDateBirth.Value = DateTime.Now
        tbClientIssuedBy.Clear()
        tbClientBatch.Clear()
        NumericUDClientNumber.Value = 0
        tbClientDetails.Clear()
        tbClientBankDetails.Clear()
        tbClientPhoneNumber.Clear()

    End Sub

    'Вкладка операции

    'Добавить/изменить запись
    Private Sub bAddOperation_Click(sender As Object, e As EventArgs) Handles bAddOperation.Click

        'Проверка на заполненность полей
        If (cbOperationFKClientName.Text.Equals("") Or cbOperationFKServiceName.Text.Equals("") Or DateTPOperationDate.Text.Equals("")) Then

            MsgBox("Не все поля заполнены!", 0 + vbInformation, "Сообщение")

        Else

            Dim sIdClient As String = "", sIdService As String = ""

            'Получения ID отдела
            Try

                If (cbOperationTypeUser.SelectedIndex = 0) Then

                    sIdClient = connSQL.sGetData("SELECT iIdClient FROM CLIENT WHERE vSecondName + ' ' + vFirstName + ' ' + vThirdName = '" + cbOperationFKClientName.Text + "'")

                Else

                    sIdClient = connSQL.sGetData("SELECT iIdClient FROM CLIENT WHERE vNameOrg = '" + cbOperationFKClientName.Text + "'")

                End If

                sIdService = connSQL.sGetData("SELECT iIdService FROM SERVICE WHERE vName = '" + cbOperationFKServiceName.Text + "'")

            Catch exc As Exception
            End Try

            'Проверка добавляем ли, True - Добавляем
            If (bAdd = True) Then

                'Добавляем новую запись
                connSQL.bQueryToBoolean("INSERT INTO OPERATION (fk_iIdClient, fk_iIdService, vDate) VALUES ('" + sIdClient + "','" + sIdService + "','" + DateTPOperationDate.Text + "')")

            Else
                Dim i As Integer = DataGridViewOperation.CurrentRow.Index
                Dim iIdNow As Integer = Convert.ToInt32(DataGridViewOperation(0, i).Value)

                'Добавляем новую запись
                connSQL.bQueryToBoolean("UPDATE OPERATION SET fk_iIdClient = '" + sIdClient + "', fk_iIdService = '" + sIdService + "', vDate = '" + DateTPOperationDate.Text + "' WHERE iIdOperation = " & iIdNow)

                PanelOperation.Visible = False
                'Очистка полей ввода
                Try
                    cbOperationFKClientName.SelectedIndex = 0
                    cbOperationFKServiceName.SelectedIndex = 0
                Catch exc As Exception
                End Try
                DateTPOperationDate.Value = DateTime.Now

            End If

            'Прогрузка таблицы
            connSQL.LoadTable("OPERATION", "SELECT OP.iIdOperation AS 'ID записи', CL.vSecondName + ' ' + CL.vFirstName + ' ' + CL.vThirdName AS 'Клиент', Cl.vNameOrg AS 'Название организации', SER.vName AS 'Сервис', OP.vDate AS 'Дата' FROM OPERATION AS OP, CLIENT AS CL, SERVICE AS SER WHERE OP.fk_iIdClient = CL.iIdClient AND OP.fk_iIdService = SER.iIdService", connSQL.binSourceOperation, DataGridViewOperation, bNavigatorBankServices)

        End If

    End Sub

    'Очистить поля ввода
    Private Sub bClearOperation_Click(sender As Object, e As EventArgs) Handles bClearOperation.Click

        'Очистка полей ввода
        Try
            cbOperationFKClientName.SelectedIndex = 0
            cbOperationFKServiceName.SelectedIndex = 0
        Catch exc As Exception
        End Try
        DateTPOperationDate.Value = DateTime.Now

    End Sub

    'Вкладка пользователи

    'Добавить/изменить запись
    Private Sub bAddLogon_Click(sender As Object, e As EventArgs) Handles bAddLogon.Click

        'Проверка на заполненность полей
        If (tbLogonLogin.Text.Equals("") Or tbLogonPassword.Text.Equals("") Or cbLogonType.Text.Equals("")) Then

            MsgBox("Не все поля заполнены!", 0 + vbInformation, "Сообщение")

        Else

            'Проверка добавляем ли, True - Добавляем
            If (bAdd = True) Then

                'Добавляем новую запись
                connSQL.bQueryToBoolean("INSERT INTO LOGON (vLogin, vPassword, iType) VALUES ('" + tbLogonLogin.Text + "','" + tbLogonPassword.Text + "','" + Convert.ToString(cbLogonType.SelectedIndex) + "')")

            Else
                Dim i As Integer = DataGridViewLogon.CurrentRow.Index
                Dim iIdNow As Integer = Convert.ToInt32(DataGridViewLogon(0, i).Value)

                'Добавляем новую запись
                connSQL.bQueryToBoolean("UPDATE LOGON SET vLogin = '" + tbLogonLogin.Text + "', vPassword = '" + tbLogonPassword.Text + "', iType = '" + Convert.ToString(cbLogonType.SelectedIndex) + "' WHERE iIdLogon = " & iIdNow)

                PanelLogon.Visible = False
                'Очистка полей ввода
                tbLogonLogin.Clear()
                tbLogonPassword.Clear()
                cbLogonType.SelectedIndex = 0

            End If

            'Прогрузка таблицы
            connSQL.LoadTable("LOGON", "SELECT iIdLogon AS 'ID записи', vLogin AS 'Логин', vPassword AS 'Пароль', iType AS 'Тип пользователя (1-Адм, 2- Пол)' FROM LOGON", connSQL.binSourceLogon, DataGridViewLogon, bNavigatorBankServices)

        End If

    End Sub

    'Очистить поля ввода
    Private Sub bClearLogon_Click(sender As Object, e As EventArgs) Handles bClearLogon.Click

        'Очистка полей ввода
        tbLogonLogin.Clear()
        tbLogonPassword.Clear()
        cbLogonType.SelectedIndex = 0

    End Sub

    'Вкладка услуги

    'Расчет суммы кредита и ежемесячного платежа
    Private Sub bCalculation_Click(sender As Object, e As EventArgs) Handles bCalculation.Click

        If (NumericUDCreditsSumm.Value <= 0 Or NumericUDCreditsMonth.Value <= 0 Or cbCreditsCurrency.Text.Equals("") Or NumericUDCreditsPercent.Value <= 0) Then

            MsgBox("Не все данные введены!", 0 + vbInformation, "Сообщение!")

        Else

            'Объявление переменных
            Dim dAllPrice As Double = 0, dMonthPrice = 0, dYear = 0
            Dim iCreditSum As Integer = NumericUDCreditsSumm.Value
            Dim iMonth As Integer = NumericUDCreditsMonth.Value
            Dim dPercent As Double = NumericUDCreditsPercent.Value

            'Расчет количества лет
            dYear = iMonth / 12

            'Расчет процента
            dPercent = dPercent / 100

            'Сумма ежемесячнего платежа
            dMonthPrice = (iCreditSum * (dPercent / iMonth)) / (1 - (1 / ((1 + dPercent / iMonth) ^ dYear * iMonth)))

            'Расчет всей суммы оплаты
            dAllPrice = (dMonthPrice * iMonth) + iCreditSum

            'Отображение лейблов на форме
            LabelAllPrice.Visible = True
            LabelMonthPrice.Visible = True
            LabelResultInf.Visible = True

            'Вывод информации, Доллар США
            If (cbCreditsCurrency.SelectedIndex = 0) Then

                LabelAllPrice.Text = dAllPrice & " долар $ (USD)"
                LabelMonthPrice.Text = dMonthPrice & " долар $"
                LabelResultInf.Text = "Для " & iCreditSum & " долар $ (USD) на " & iMonth & " мес. при " & NumericUDCreditsPercent.Value & "% годовых"

                'Евро
            ElseIf (cbCreditsCurrency.SelectedIndex = 1) Then

                LabelAllPrice.Text = dAllPrice & " евро (EUR)"
                LabelMonthPrice.Text = dMonthPrice & " евро"
                LabelResultInf.Text = "Для " & iCreditSum & "евро (EUR) (BYN) на " & iMonth & " мес. при " & NumericUDCreditsPercent.Value & "% годовых"

                'Белорусский рубль
            ElseIf (cbCreditsCurrency.SelectedIndex = 2) Then

                LabelAllPrice.Text = dAllPrice & " бел. руб (BYN)"
                LabelMonthPrice.Text = dMonthPrice & " бел. руб"
                LabelResultInf.Text = "Для " & iCreditSum & " бел.руб (BYN) на " & iMonth & " мес. при " & NumericUDCreditsPercent.Value & "% годовых"

                'Российский рубль
            Else

                LabelAllPrice.Text = dAllPrice & " рус. руб (RUB)"
                LabelMonthPrice.Text = dMonthPrice & " рус. руб"
                LabelResultInf.Text = "Для " & iCreditSum & " рос.руб (RUB) на " & iMonth & " мес. при " & NumericUDCreditsPercent.Value & "% годовых"

            End If

        End If

    End Sub

    'Происходит при смене вкладки
    Private Sub TabControlUserFunctional_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControlUserFunctional.Selecting

        'Кредиты и вклады
        If (TabControlUserFunctional.SelectedIndex = 1) Then

            cbPapersTypeClient.SelectedIndex = 0
            cbPapersType.SelectedIndex = 0
            cbPapersTypeCurrency.SelectedIndex = 0

            'Поиск информации
        Else

            'Прогрузка данных в комбобокс
            Try

                'Добавляем названия столбцов
                Dim massRuTables() As String = {"Тип услуги", "Отдел", "Документы", "Рабочий", "Услуга", "Клиент", "Операции"}
                cbSearchTables.Items.Clear()
                cbSearchTables.Items.AddRange(massRuTables)
                cbSearchTables.SelectedIndex = 0

            Catch exc As Exception
            End Try


        End If

    End Sub

    'Оформление и вывод на печать кредита или вклада
    Private Sub bRegistr_Click(sender As Object, e As EventArgs) Handles bRegistr.Click

        Dim saveOpenDialog As New SaveFileDialog()
        saveOpenDialog.Filter = "Файл документа Word|*.doc|Текстовый файл|*.txt"
        saveOpenDialog.Title = "Сохранение документа"
        saveOpenDialog.ShowDialog()
        'Если название файла не пустое
        If saveOpenDialog.FileName <> "" Then

            Dim fs As System.IO.FileStream = CType(saveOpenDialog.OpenFile(), System.IO.FileStream)

            'Очистить поток и закрыть
            fs.Dispose()
            fs.Close()

            'Поток на запись
            Dim swWritter As New StreamWriter(saveOpenDialog.FileName)
            'Запись данных в файл
            swWritter.WriteLine("ФИО клиента: " & cbPapersClientFIO.Text)
            swWritter.WriteLine("Тип оформляемого документа: " & cbPapersType.Text)
            swWritter.WriteLine("Срок оформления: " & NumericUDPapersTime.Text & " мес.")
            swWritter.WriteLine("Сумма: " & NumericUDPapersSumm.Text & " " & cbPapersTypeCurrency.Text)
            swWritter.WriteLine(rtbPapersClient.Lines(0))
            swWritter.WriteLine(rtbPapersClient.Lines(1))
            swWritter.WriteLine(rtbPapersClient.Lines(2))
            swWritter.WriteLine(rtbPapersClient.Lines(3))
            swWritter.WriteLine(rtbPapersClient.Lines(4))
            swWritter.WriteLine(rtbPapersClient.Lines(5))
            swWritter.WriteLine(rtbPapersClient.Lines(6))
            swWritter.WriteLine(rtbPapersClient.Lines(7))
            swWritter.WriteLine(rtbPapersClient.Lines(8))
            swWritter.WriteLine(rtbPapersClient.Lines(9))
            swWritter.WriteLine(rtbPapersClient.Lines(10))
            swWritter.WriteLine(rtbPapersClient.Lines(11))

            'Очистить поток и закрыть
            swWritter.Dispose()
            swWritter.Close()

            MsgBox("Файл был успешно сохранен!", 0 + vbInformation, "Сообщение")

        Else

            MsgBox("Отмена сохранения!", 0 + vbInformation, "Сообщение")

        End If

    End Sub

    'Происходит при выборе элемента из выпадающего списка
    Private Sub cbPapersClientFIO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPapersClientFIO.SelectedIndexChanged

        Try

            rtbPapersClient.Clear()

            'Проверка какой тип клиента сейчас выбран
            'Физ лицо
            If (cbPapersTypeClient.SelectedIndex = 0) Then

                'Прогрузка данных
                rtbPapersClient.AppendText("Информация о клиенте: " + vbCrLf)
                rtbPapersClient.AppendText("Статус: " & connSQL.sGetData("SELECT vStatus FROM CLIENT WHERE vSecondName + ' ' + vFirstName + ' ' + vThirdName ='" & cbPapersClientFIO.Text & "'") + vbCrLf)
                rtbPapersClient.AppendText("Адрес: " & connSQL.sGetData("SELECT vAdress FROM CLIENT WHERE vSecondName + ' ' + vFirstName + ' ' + vThirdName ='" & cbPapersClientFIO.Text & "'") + vbCrLf)
                rtbPapersClient.AppendText("Название организации: " & connSQL.sGetData("SELECT vNameOrg FROM CLIENT WHERE vSecondName + ' ' + vFirstName + ' ' + vThirdName ='" & cbPapersClientFIO.Text & "'") + vbCrLf)
                rtbPapersClient.AppendText("Дата выдачи: " & connSQL.sGetData("SELECT vDateOfIssue FROM CLIENT WHERE vSecondName + ' ' + vFirstName + ' ' + vThirdName ='" & cbPapersClientFIO.Text & "'") + vbCrLf)
                rtbPapersClient.AppendText("Дата рождения: " & connSQL.sGetData("SELECT vDateBirth FROM CLIENT WHERE vSecondName + ' ' + vFirstName + ' ' + vThirdName ='" & cbPapersClientFIO.Text & "'") + vbCrLf)
                rtbPapersClient.AppendText("Выдан: " & connSQL.sGetData("SELECT vIssuedBy FROM CLIENT WHERE vSecondName + ' ' + vFirstName + ' ' + vThirdName ='" & cbPapersClientFIO.Text & "'") + vbCrLf)
                rtbPapersClient.AppendText("Тип: " & connSQL.sGetData("SELECT vBatch FROM CLIENT WHERE vSecondName + ' ' + vFirstName + ' ' + vThirdName ='" & cbPapersClientFIO.Text & "'") + vbCrLf)
                rtbPapersClient.AppendText("Номер: " & connSQL.sGetData("SELECT iNumber FROM CLIENT WHERE vSecondName + ' ' + vFirstName + ' ' + vThirdName ='" & cbPapersClientFIO.Text & "'") + vbCrLf)
                rtbPapersClient.AppendText("Подробности: " & connSQL.sGetData("SELECT vDetails FROM CLIENT WHERE vSecondName + ' ' + vFirstName + ' ' + vThirdName ='" & cbPapersClientFIO.Text & "'") + vbCrLf)
                rtbPapersClient.AppendText("Банковские подробности: " & connSQL.sGetData("SELECT vBankDetails FROM CLIENT WHERE vSecondName + ' ' + vFirstName + ' ' + vThirdName ='" & cbPapersClientFIO.Text & "'") + vbCrLf)
                rtbPapersClient.AppendText("Номер телефона: " & connSQL.sGetData("SELECT vPhoneNumber FROM CLIENT WHERE vSecondName + ' ' + vFirstName + ' ' + vThirdName ='" & cbPapersClientFIO.Text & "'") + vbCrLf)

            Else

                'Прогрузка данных
                rtbPapersClient.AppendText("Информация о клиенте: " + vbCrLf)
                rtbPapersClient.AppendText("Статус: " & connSQL.sGetData("SELECT vStatus FROM CLIENT WHERE vNameOrg ='" & cbPapersClientFIO.Text & "'") + vbCrLf)
                rtbPapersClient.AppendText("Название организации: " & connSQL.sGetData("SELECT vNameOrg FROM CLIENT WHERE vNameOrg ='" & cbPapersClientFIO.Text & "'") + vbCrLf)

            End If

        Catch exc As Exception
        End Try

    End Sub

    'Происходит при выборе элемента из выпадающего списка
    Private Sub cbSearchTables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSearchTables.SelectedIndexChanged

        If (cbSearchTables.SelectedIndex = 0) Then

            'Добавляем названия столбцов
            Dim massRuColumnsTypeService() As String = {"Название", "Описание"}
            cbSearchColumn.Items.Clear()
            cbSearchColumn.Items.AddRange(massRuColumnsTypeService)
            cbSearchColumn.SelectedIndex = 0

        ElseIf (cbSearchTables.SelectedIndex = 1) Then

            'Добавляем названия столбцов
            Dim massRuColumnsTypeService() As String = {"Название", "Месторасположение"}
            cbSearchColumn.Items.Clear()
            cbSearchColumn.Items.AddRange(massRuColumnsTypeService)
            cbSearchColumn.SelectedIndex = 0

        ElseIf (cbSearchTables.SelectedIndex = 2) Then

            'Добавляем названия столбцов
            Dim massRuColumnsDocuments() As String = {"Название"}
            cbSearchColumn.Items.Clear()
            cbSearchColumn.Items.AddRange(massRuColumnsDocuments)
            cbSearchColumn.SelectedIndex = 0

        ElseIf (cbSearchTables.SelectedIndex = 3) Then

            'Добавляем названия столбцов
            Dim massRuColumnsWorker() As String = {"Фамилия", "Имя", "Отчество", "Стаж", "Опыт"}
            cbSearchColumn.Items.Clear()
            cbSearchColumn.Items.AddRange(massRuColumnsWorker)
            cbSearchColumn.SelectedIndex = 0

        ElseIf (cbSearchTables.SelectedIndex = 4) Then

            'Добавляем названия столбцов
            Dim massRuColumnsService() As String = {"Стоимость", "Название"}
            cbSearchColumn.Items.Clear()
            cbSearchColumn.Items.AddRange(massRuColumnsService)
            cbSearchColumn.SelectedIndex = 0

        ElseIf (cbSearchTables.SelectedIndex = 5) Then

            'Добавляем названия столбцов
            Dim massRuColumnsClient() As String = {"Статус", "Адрес", "Название организации", "Фамилия", "Имя", "Отчество", "Дата получения", "Дата рождения", "Выдан", "Серия", "Номер", "Подробности", "Банковские подробности", "Телефон"}
            cbSearchColumn.Items.Clear()
            cbSearchColumn.Items.AddRange(massRuColumnsClient)
            cbSearchColumn.SelectedIndex = 0

        ElseIf (cbSearchTables.SelectedIndex = 6) Then

            'Добавляем названия столбцов
            Dim massRuColumnsOperation() As String = {"Дата"}
            cbSearchColumn.Items.Clear()
            cbSearchColumn.Items.AddRange(massRuColumnsOperation)
            cbSearchColumn.SelectedIndex = 0

        End If

    End Sub

    'Загружаем таблицу
    Private Sub bSearchLoadTable_Click(sender As Object, e As EventArgs) Handles bSearchLoadTable.Click

        connSQL.binSourceTables.Filter = ""

        If (cbSearchTables.SelectedIndex = 0) Then

            connSQL.LoadTable("TYPE_SERVICE", "SELECT * FROM TYPE_SERVICE", connSQL.binSourceTables, DataGridViewSearch, bNavigatorSearch)

        ElseIf (cbSearchTables.SelectedIndex = 1) Then

            connSQL.LoadTable("DEPARTMENT", "SELECT * FROM DEPARTMENT", connSQL.binSourceTables, DataGridViewSearch, bNavigatorSearch)

        ElseIf (cbSearchTables.SelectedIndex = 2) Then

            connSQL.LoadTable("DOCUMENTS", "SELECT * FROM DOCUMENTS", connSQL.binSourceTables, DataGridViewSearch, bNavigatorSearch)

        ElseIf (cbSearchTables.SelectedIndex = 3) Then

            connSQL.LoadTable("WORKER", "SELECT * FROM WORKER", connSQL.binSourceTables, DataGridViewSearch, bNavigatorSearch)

        ElseIf (cbSearchTables.SelectedIndex = 4) Then

            connSQL.LoadTable("SERVICE", "SELECT * FROM SERVICE", connSQL.binSourceTables, DataGridViewSearch, bNavigatorSearch)

        ElseIf (cbSearchTables.SelectedIndex = 5) Then

            connSQL.LoadTable("CLIENT", "SELECT * FROM CLIENT", connSQL.binSourceTables, DataGridViewSearch, bNavigatorSearch)

        ElseIf (cbSearchTables.SelectedIndex = 6) Then

            connSQL.LoadTable("OPERATION", "SELECT * FROM OPERATION", connSQL.binSourceTables, DataGridViewSearch, bNavigatorSearch)

        End If

        DataGridViewSearch.Columns(0).Visible = False

    End Sub

    'Фильтрация информации
    Private Sub bSearch_Click(sender As Object, e As EventArgs) Handles bSearch.Click

        connSQL.binSourceTables.Filter = ""

        Dim massEngTables() As String = {"TYPE_SERVICE", "DEPARTMENT", "DOCUMENTS", "WORKER", "SERVICE", "CLIENT", "OPERATION"}
        Dim massEngColumnsTypeService() As String = {"vName", "vDescription"}
        Dim massEngColumnsDepartment() As String = {"vName", "iApartment"}
        Dim massEngColumnsDocuments() As String = {"vName"}
        Dim massEngColumnsWorker() As String = {"vSecondName", "vFirstName", "vThirdName", "iRank", "fExperience"}
        Dim massEngColumnsService() As String = {"iPrice", "vName"}
        Dim massEngColumnsClient() As String = {"vStatus", "vAdress", "vNameOrg", "vSecondName", "vFirstName", "vThirdName", "vDateOfIssue", "vDateBirth", "vIssuedBy", "vBatch", "iNumber", "vDetails", "vBankDetails", "vPhoneNumber"}
        Dim massEngColumnsOperation() As String = {"vDate"}

        'TYPE_SERVICE
        If (cbSearchTables.SelectedIndex = 0) Then

            If (cbSearchColumn.SelectedIndex = 0) Then

                connSQL.binSourceTables.Filter = massEngColumnsTypeService(0) & " LIKE '%" & tbSearch.Text & "%'"

            Else

                connSQL.binSourceTables.Filter = massEngColumnsTypeService(1) & " LIKE '%" & tbSearch.Text & "%'"

            End If

            'DEPARTMENT
        ElseIf (cbSearchTables.SelectedIndex = 1) Then

            If (cbSearchColumn.SelectedIndex = 0) Then

                connSQL.binSourceTables.Filter = massEngColumnsDepartment(0) & " LIKE '%" & tbSearch.Text & "%'"

            Else

                Try
                    connSQL.binSourceTables.Filter = massEngColumnsDepartment(1) & " = '" & tbSearch.Text & "'"
                Catch ex As Exception
                End Try

            End If

            'DOCUMENTS
        ElseIf (cbSearchTables.SelectedIndex = 2) Then

            If (cbSearchColumn.SelectedIndex = 0) Then

                connSQL.binSourceTables.Filter = massEngColumnsDocuments(0) & " LIKE '%" & tbSearch.Text & "%'"

            End If

            'WORKER
        ElseIf (cbSearchTables.SelectedIndex = 3) Then

            If (cbSearchColumn.SelectedIndex = 0) Then

                connSQL.binSourceTables.Filter = massEngColumnsWorker(0) & " LIKE '%" & tbSearch.Text & "%'"

            ElseIf (cbSearchColumn.SelectedIndex = 1) Then

                connSQL.binSourceTables.Filter = massEngColumnsWorker(1) & " LIKE '%" & tbSearch.Text & "%'"

            ElseIf (cbSearchColumn.SelectedIndex = 2) Then

                connSQL.binSourceTables.Filter = massEngColumnsWorker(2) & " LIKE '%" & tbSearch.Text & "%'"

            ElseIf (cbSearchColumn.SelectedIndex = 3) Then

                Try
                    connSQL.binSourceTables.Filter = massEngColumnsWorker(3) & " = '" & tbSearch.Text & "'"
                Catch ex As Exception
                End Try

            ElseIf (cbSearchColumn.SelectedIndex = 4) Then

                Try
                    connSQL.binSourceTables.Filter = massEngColumnsWorker(4) & " = '" & tbSearch.Text & "'"
                Catch ex As Exception
                End Try

            End If

            'SERVICE
        ElseIf (cbSearchTables.SelectedIndex = 4) Then

            If (cbSearchColumn.SelectedIndex = 0) Then

                Try
                    connSQL.binSourceTables.Filter = massEngColumnsService(0) & " = '" & tbSearch.Text & "'"
                Catch ex As Exception
                End Try

            Else

                connSQL.binSourceTables.Filter = massEngColumnsService(1) & " LIKE '%" & tbSearch.Text & "%'"

            End If

            'CLIENT
        ElseIf (cbSearchTables.SelectedIndex = 5) Then

            If (cbSearchColumn.SelectedIndex = 0) Then

                connSQL.binSourceTables.Filter = massEngColumnsClient(0) & " LIKE '%" & tbSearch.Text & "%'"

            ElseIf (cbSearchColumn.SelectedIndex = 1) Then

                connSQL.binSourceTables.Filter = massEngColumnsClient(1) & " LIKE '%" & tbSearch.Text & "%'"

            ElseIf (cbSearchColumn.SelectedIndex = 2) Then

                connSQL.binSourceTables.Filter = massEngColumnsClient(2) & " LIKE '%" & tbSearch.Text & "%'"

            ElseIf (cbSearchColumn.SelectedIndex = 3) Then

                connSQL.binSourceTables.Filter = massEngColumnsClient(3) & " LIKE '%" & tbSearch.Text & "%'"

            ElseIf (cbSearchColumn.SelectedIndex = 4) Then

                connSQL.binSourceTables.Filter = massEngColumnsClient(4) & " LIKE '%" & tbSearch.Text & "%'"

            ElseIf (cbSearchColumn.SelectedIndex = 5) Then

                connSQL.binSourceTables.Filter = massEngColumnsClient(5) & " LIKE '%" & tbSearch.Text & "%'"

            ElseIf (cbSearchColumn.SelectedIndex = 6) Then

                connSQL.binSourceTables.Filter = massEngColumnsClient(6) & " LIKE '%" & tbSearch.Text & "%'"

            ElseIf (cbSearchColumn.SelectedIndex = 7) Then

                connSQL.binSourceTables.Filter = massEngColumnsClient(7) & " LIKE '%" & tbSearch.Text & "%'"

            ElseIf (cbSearchColumn.SelectedIndex = 8) Then

                connSQL.binSourceTables.Filter = massEngColumnsClient(8) & " LIKE '%" & tbSearch.Text & "%'"

            ElseIf (cbSearchColumn.SelectedIndex = 9) Then

                connSQL.binSourceTables.Filter = massEngColumnsClient(9) & " LIKE '%" & tbSearch.Text & "%'"

            ElseIf (cbSearchColumn.SelectedIndex = 10) Then

                Try
                    connSQL.binSourceTables.Filter = massEngColumnsClient(10) & " = '" & tbSearch.Text & "'"
                Catch ex As Exception
                End Try

            ElseIf (cbSearchColumn.SelectedIndex = 11) Then

                connSQL.binSourceTables.Filter = massEngColumnsClient(11) & " LIKE '%" & tbSearch.Text & "%'"

            ElseIf (cbSearchColumn.SelectedIndex = 12) Then

                connSQL.binSourceTables.Filter = massEngColumnsClient(12) & " LIKE '%" & tbSearch.Text & "%'"

            ElseIf (cbSearchColumn.SelectedIndex = 13) Then

                connSQL.binSourceTables.Filter = massEngColumnsClient(13) & " LIKE '%" & tbSearch.Text & "%'"

            End If

            'OPERATION
        ElseIf (cbSearchTables.SelectedIndex = 6) Then

            If (cbSearchColumn.SelectedIndex = 0) Then

                connSQL.binSourceTables.Filter = massEngColumnsOperation(0) & " LIKE '%" & tbSearch.Text & "%'"

            End If

        End If

    End Sub

    'Печать найденной информации
    Private Sub bSearchPrint_Click(sender As Object, e As EventArgs) Handles bSearchPrint.Click

        printExport.ExportToExcel(DataGridViewSearch)

    End Sub

    'Происходит при выборе элемента из выпадающего списка
    Private Sub cbPapersTypeClient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPapersTypeClient.SelectedIndexChanged

        If (cbPapersTypeClient.SelectedIndex = 0) Then

            'Прогрузка данных в комбобокс
            Try

                connSQL.sQueryToComboBox("SELECT vSecondName + ' ' + vFirstName + ' ' + vThirdName AS FIO FROM CLIENT WHERE vStatus = 'Физ лицо'", cbPapersClientFIO, "FIO")

            Catch exc As Exception
            End Try

        Else

            'Прогрузка данных в комбобокс
            Try

                connSQL.sQueryToComboBox("SELECT vNameOrg FROM CLIENT WHERE vStatus = 'Юр лицо'", cbPapersClientFIO, "vNameOrg")

            Catch exc As Exception
            End Try

        End If

    End Sub

    'Происходит при выборе элемента из выпадающего списка
    Private Sub cbOperationTypeUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOperationTypeUser.SelectedIndexChanged

        If (cbOperationTypeUser.SelectedIndex = 0) Then

            connSQL.sQueryToComboBox("SELECT vSecondName + ' ' + vFirstName + ' ' + vThirdName AS FIO FROM CLIENT WHERE vStatus = 'Физ лицо'", cbOperationFKClientName, "FIO")

        Else

            connSQL.sQueryToComboBox("SELECT vNameOrg FROM CLIENT WHERE vStatus = 'Юр лицо'", cbOperationFKClientName, "vNameOrg")

        End If

    End Sub

    Private Sub cbSearchColumn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSearchColumn.SelectedIndexChanged

    End Sub
End Class