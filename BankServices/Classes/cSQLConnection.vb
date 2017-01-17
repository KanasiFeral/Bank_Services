Imports System.Data.SqlClient

Public Class cSQLConnection

    'Переменная подключения
    Public conn As New SqlConnection
    'Флаг ошибки
    Public bCheckException As Boolean
    'Объекты для работы с таблицами
    Public dataTable As DataTable
    Public dataAdap As SqlDataAdapter
    Public dataSet As DataSet
    Public commBuild As SqlCommandBuilder

    'Бинсорсы для таблиц, хранят строки таблицы (данные)
    Public binSourceTypeService As New BindingSource
    Public binSourceDepartment As New BindingSource
    Public binSourceDocuments As New BindingSource
    Public binSourceWorker As New BindingSource
    Public binSourceService As New BindingSource
    Public binSourceClient As New BindingSource
    Public binSourceOperation As New BindingSource
    Public binSourceLogon As New BindingSource
    Public binSourceTables As New BindingSource
    Public binSourceServiceOperation As New BindingSource

    'Функции
    'Функция подключения к базе данных
    Public Function bOpenConnection(Connection As String) As Boolean

        Try

            conn = New SqlConnection(Connection)
            conn.Open()

        Catch

            Return False

        End Try

        Return True

    End Function

    'Функция закрытия соединения
    Public Function bCloseConnection() As Boolean

        conn.Close()
        Return True

    End Function

    'Вернет True, если есть записи
    Public Function bQueryToBoolean(sQueryString As String) As Boolean

        dataTable = New DataTable()
        Dim comm As SqlCommand
        Dim dataReader As SqlDataReader
        comm = New SqlCommand(sQueryString, conn)
        Try

            dataReader = comm.ExecuteReader()

        Catch exc As Exception

            MsgBox(exc.Message)
            bCheckException = True
            Return False

        End Try

        If (dataReader.HasRows) Then

            dataTable.Load(dataReader)

            dataReader.Close()
            comm.Dispose()
            Return True

        End If

        dataReader.Close()
        comm.Dispose()
        bCheckException = False
        Return False

    End Function

    'Процедура загрузки таблицы
    Public Sub LoadTable(sNameOfTable As String, sQuery As String, binSource As BindingSource, dataGrid As DataGridView, binNavigator As BindingNavigator)

        Try

            dataAdap = New SqlDataAdapter(sQuery, conn)
            dataSet = New DataSet()
            dataAdap.Fill(dataSet, sNameOfTable)
            binSource.DataSource = dataSet.Tables(0)
            binNavigator.BindingSource = binSource
            dataGrid.DataSource = binSource

        Catch exc As Exception

            MsgBox(exc.Message, vbOK + vbCritical, "Ошибка!")

        End Try

    End Sub

    'Функция получения агрегатных данных
    Public Function sGetData(sQuery As String) As String

        Dim iResultQuery As Integer
        Dim sResultQuery As String = ""

        Dim comm As SqlCommand
        Dim dataReader As SqlDataReader
        comm = New SqlCommand(sQuery, conn)
        Try

            dataReader = comm.ExecuteReader()

        Catch exc As Exception

            MsgBox(exc.Message, "Ошибка!", vbOK + vbCritical)
            Return sResultQuery

        End Try

        dataReader.Read()

        Try

            sResultQuery = dataReader.GetString(0)

        Catch exc As Exception

            iResultQuery = dataReader.GetInt32(0)
            sResultQuery = Convert.ToString(iResultQuery)

        End Try

        dataReader.Close()
        comm.Dispose()

        Return sResultQuery

    End Function

    'Функция вывода столбца таблицы в ComboBox
    Public Function sQueryToComboBox(sQuery As String, comboBox As ComboBox, sNameOfColumn As String) As Boolean

        dataTable = New DataTable()
        Dim comm As SqlCommand
        Dim dataReader As SqlDataReader
        comm = New SqlCommand(sQuery, conn)
        Try

            dataReader = comm.ExecuteReader()

        Catch exc As Exception

            MsgBox(exc.Message)
            Return False

        End Try

        If (dataReader.HasRows) Then

            dataTable.Load(dataReader)

            comboBox.DataSource = dataTable
            comboBox.DisplayMember = sNameOfColumn

            dataReader.Close()
            comm.Dispose()
            Return True

        End If

        dataReader.Close()
        comm.Dispose()
        Return False

    End Function

End Class