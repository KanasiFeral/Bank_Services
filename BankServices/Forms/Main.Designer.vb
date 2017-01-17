<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStripBankServices = New System.Windows.Forms.MenuStrip()
        Me.МенюToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.АвторизацияToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ВыходToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.НастройкиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ИнформацияToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОПрограммеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.СправкаF1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControlMain = New System.Windows.Forms.TabControl()
        Me.TabPageTables = New System.Windows.Forms.TabPage()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.bCloseDelete = New System.Windows.Forms.Button()
        Me.bEdit = New System.Windows.Forms.Button()
        Me.bOpenPanel = New System.Windows.Forms.Button()
        Me.TabControlTables = New System.Windows.Forms.TabControl()
        Me.TabPageTypeService = New System.Windows.Forms.TabPage()
        Me.PanelTypeService = New System.Windows.Forms.Panel()
        Me.tbTypeServiceDesc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbTypeServiceName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBoxTypeService = New System.Windows.Forms.PictureBox()
        Me.LabelTypeService = New System.Windows.Forms.Label()
        Me.bClearTypeService = New System.Windows.Forms.Button()
        Me.bAddTypeService = New System.Windows.Forms.Button()
        Me.DataGridViewTypeService = New System.Windows.Forms.DataGridView()
        Me.TabPageDepartment = New System.Windows.Forms.TabPage()
        Me.PanelDepartment = New System.Windows.Forms.Panel()
        Me.NumericUDApartment = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbDepartmentName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBoxDepartment = New System.Windows.Forms.PictureBox()
        Me.LabelDepartment = New System.Windows.Forms.Label()
        Me.bClearDepartment = New System.Windows.Forms.Button()
        Me.bAddDepartment = New System.Windows.Forms.Button()
        Me.DataGridViewDepartment = New System.Windows.Forms.DataGridView()
        Me.TabPageDocuments = New System.Windows.Forms.TabPage()
        Me.PanelDocuments = New System.Windows.Forms.Panel()
        Me.tbDocumentsName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBoxDocuments = New System.Windows.Forms.PictureBox()
        Me.LabelDocuments = New System.Windows.Forms.Label()
        Me.bClearDocuments = New System.Windows.Forms.Button()
        Me.bAddDocuments = New System.Windows.Forms.Button()
        Me.DataGridViewDocuments = New System.Windows.Forms.DataGridView()
        Me.TabPageWorker = New System.Windows.Forms.TabPage()
        Me.PanelWorker = New System.Windows.Forms.Panel()
        Me.cbWorkerFKDepName = New System.Windows.Forms.ComboBox()
        Me.NumericUDWorkerExp = New System.Windows.Forms.NumericUpDown()
        Me.NumericUDWorkerRank = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbWorkerThirdName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbWorkerFirstName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbWorkerSecondName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBoxWorker = New System.Windows.Forms.PictureBox()
        Me.LabelWorker = New System.Windows.Forms.Label()
        Me.bClearWorker = New System.Windows.Forms.Button()
        Me.bAddWorker = New System.Windows.Forms.Button()
        Me.DataGridViewWorker = New System.Windows.Forms.DataGridView()
        Me.TabPageService = New System.Windows.Forms.TabPage()
        Me.PanelService = New System.Windows.Forms.Panel()
        Me.tbServiceName = New System.Windows.Forms.TextBox()
        Me.cbServiceFKFIOWorker = New System.Windows.Forms.ComboBox()
        Me.cbServiceFKDocName = New System.Windows.Forms.ComboBox()
        Me.cbServiceFKTypeService = New System.Windows.Forms.ComboBox()
        Me.NumericUDServicePrice = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBoxService = New System.Windows.Forms.PictureBox()
        Me.LabelService = New System.Windows.Forms.Label()
        Me.bClearService = New System.Windows.Forms.Button()
        Me.bAddService = New System.Windows.Forms.Button()
        Me.DataGridViewService = New System.Windows.Forms.DataGridView()
        Me.TabPageClient = New System.Windows.Forms.TabPage()
        Me.PanelClient = New System.Windows.Forms.Panel()
        Me.NumericUDClientNumber = New System.Windows.Forms.NumericUpDown()
        Me.DateTPClientDateBirth = New System.Windows.Forms.DateTimePicker()
        Me.DateTPClientDateOfIssue = New System.Windows.Forms.DateTimePicker()
        Me.cbClientStatus = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.tbClientPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.tbClientSecondName = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.tbClientNameOrg = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbClientBankDetails = New System.Windows.Forms.TextBox()
        Me.tbClientBatch = New System.Windows.Forms.TextBox()
        Me.tbClientThirdName = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tbClientAddress = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbClientDetails = New System.Windows.Forms.TextBox()
        Me.tbClientIssuedBy = New System.Windows.Forms.TextBox()
        Me.tbClientFirstName = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.PictureBoxClient = New System.Windows.Forms.PictureBox()
        Me.LabelClient = New System.Windows.Forms.Label()
        Me.bClearClient = New System.Windows.Forms.Button()
        Me.bAddClient = New System.Windows.Forms.Button()
        Me.DataGridViewClient = New System.Windows.Forms.DataGridView()
        Me.TabPageOperation = New System.Windows.Forms.TabPage()
        Me.PanelOperation = New System.Windows.Forms.Panel()
        Me.cbOperationTypeUser = New System.Windows.Forms.ComboBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.DateTPOperationDate = New System.Windows.Forms.DateTimePicker()
        Me.cbOperationFKServiceName = New System.Windows.Forms.ComboBox()
        Me.cbOperationFKClientName = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.PictureBoxOperation = New System.Windows.Forms.PictureBox()
        Me.LabelOperation = New System.Windows.Forms.Label()
        Me.bClearOperation = New System.Windows.Forms.Button()
        Me.bAddOperation = New System.Windows.Forms.Button()
        Me.DataGridViewOperation = New System.Windows.Forms.DataGridView()
        Me.TabPageUsers = New System.Windows.Forms.TabPage()
        Me.PanelLogon = New System.Windows.Forms.Panel()
        Me.cbLogonType = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.tbLogonPassword = New System.Windows.Forms.TextBox()
        Me.tbLogonLogin = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.PictureBoxUsers = New System.Windows.Forms.PictureBox()
        Me.LabelLogon = New System.Windows.Forms.Label()
        Me.bClearLogon = New System.Windows.Forms.Button()
        Me.bAddLogon = New System.Windows.Forms.Button()
        Me.DataGridViewLogon = New System.Windows.Forms.DataGridView()
        Me.TabPageServiceOperation = New System.Windows.Forms.TabPage()
        Me.DataGridViewServiceOpeartion = New System.Windows.Forms.DataGridView()
        Me.TabPageServices = New System.Windows.Forms.TabPage()
        Me.TabControlUserFunctional = New System.Windows.Forms.TabControl()
        Me.TabPageCredits = New System.Windows.Forms.TabPage()
        Me.LabelResultInf = New System.Windows.Forms.Label()
        Me.LabelMonthPrice = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.LabelAllPrice = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.bCalculation = New System.Windows.Forms.Button()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.NumericUDCreditsPercent = New System.Windows.Forms.NumericUpDown()
        Me.NumericUDCreditsMonth = New System.Windows.Forms.NumericUpDown()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.cbCreditsCurrency = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.NumericUDCreditsSumm = New System.Windows.Forms.NumericUpDown()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.PictureBoxCredits = New System.Windows.Forms.PictureBox()
        Me.TabPagePapers = New System.Windows.Forms.TabPage()
        Me.cbPapersTypeClient = New System.Windows.Forms.ComboBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.cbPapersTypeCurrency = New System.Windows.Forms.ComboBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.cbPapersClientFIO = New System.Windows.Forms.ComboBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.DateTPPapersDataReg = New System.Windows.Forms.DateTimePicker()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.NumericUDPapersTime = New System.Windows.Forms.NumericUpDown()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.NumericUDPapersSumm = New System.Windows.Forms.NumericUpDown()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.cbPapersType = New System.Windows.Forms.ComboBox()
        Me.bRegistr = New System.Windows.Forms.Button()
        Me.rtbPapersClient = New System.Windows.Forms.RichTextBox()
        Me.PictureBoxPapers = New System.Windows.Forms.PictureBox()
        Me.TabPageSearch = New System.Windows.Forms.TabPage()
        Me.bSearchLoadTable = New System.Windows.Forms.Button()
        Me.bNavigatorSearch = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.bSearchPrint = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewSearch = New System.Windows.Forms.DataGridView()
        Me.bSearch = New System.Windows.Forms.Button()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.cbSearchColumn = New System.Windows.Forms.ComboBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.cbSearchTables = New System.Windows.Forms.ComboBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.PictureBoxSearch = New System.Windows.Forms.PictureBox()
        Me.bNavigatorBankServices = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpProviderBankServices = New System.Windows.Forms.HelpProvider()
        Me.MenuStripBankServices.SuspendLayout()
        Me.TabControlMain.SuspendLayout()
        Me.TabPageTables.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlTables.SuspendLayout()
        Me.TabPageTypeService.SuspendLayout()
        Me.PanelTypeService.SuspendLayout()
        CType(Me.PictureBoxTypeService, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewTypeService, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageDepartment.SuspendLayout()
        Me.PanelDepartment.SuspendLayout()
        CType(Me.NumericUDApartment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxDepartment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewDepartment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageDocuments.SuspendLayout()
        Me.PanelDocuments.SuspendLayout()
        CType(Me.PictureBoxDocuments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewDocuments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageWorker.SuspendLayout()
        Me.PanelWorker.SuspendLayout()
        CType(Me.NumericUDWorkerExp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUDWorkerRank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxWorker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewWorker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageService.SuspendLayout()
        Me.PanelService.SuspendLayout()
        CType(Me.NumericUDServicePrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxService, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewService, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageClient.SuspendLayout()
        Me.PanelClient.SuspendLayout()
        CType(Me.NumericUDClientNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxClient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageOperation.SuspendLayout()
        Me.PanelOperation.SuspendLayout()
        CType(Me.PictureBoxOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageUsers.SuspendLayout()
        Me.PanelLogon.SuspendLayout()
        CType(Me.PictureBoxUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewLogon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageServiceOperation.SuspendLayout()
        CType(Me.DataGridViewServiceOpeartion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageServices.SuspendLayout()
        Me.TabControlUserFunctional.SuspendLayout()
        Me.TabPageCredits.SuspendLayout()
        CType(Me.NumericUDCreditsPercent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUDCreditsMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUDCreditsSumm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCredits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePapers.SuspendLayout()
        CType(Me.NumericUDPapersTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUDPapersSumm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPapers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageSearch.SuspendLayout()
        CType(Me.bNavigatorSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bNavigatorSearch.SuspendLayout()
        CType(Me.DataGridViewSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bNavigatorBankServices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bNavigatorBankServices.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripBankServices
        '
        Me.MenuStripBankServices.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.MenuStripBankServices.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.МенюToolStripMenuItem, Me.НастройкиToolStripMenuItem, Me.ИнформацияToolStripMenuItem})
        Me.MenuStripBankServices.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripBankServices.Name = "MenuStripBankServices"
        Me.MenuStripBankServices.Size = New System.Drawing.Size(947, 25)
        Me.MenuStripBankServices.TabIndex = 0
        Me.MenuStripBankServices.Text = "MenuStrip1"
        '
        'МенюToolStripMenuItem
        '
        Me.МенюToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.АвторизацияToolStripMenuItem, Me.ToolStripMenuItem2, Me.ВыходToolStripMenuItem})
        Me.МенюToolStripMenuItem.Image = CType(resources.GetObject("МенюToolStripMenuItem.Image"), System.Drawing.Image)
        Me.МенюToolStripMenuItem.Name = "МенюToolStripMenuItem"
        Me.МенюToolStripMenuItem.Size = New System.Drawing.Size(74, 21)
        Me.МенюToolStripMenuItem.Text = "Меню"
        '
        'АвторизацияToolStripMenuItem
        '
        Me.АвторизацияToolStripMenuItem.Image = CType(resources.GetObject("АвторизацияToolStripMenuItem.Image"), System.Drawing.Image)
        Me.АвторизацияToolStripMenuItem.Name = "АвторизацияToolStripMenuItem"
        Me.АвторизацияToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.АвторизацияToolStripMenuItem.Text = "Авторизация"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(156, 6)
        '
        'ВыходToolStripMenuItem
        '
        Me.ВыходToolStripMenuItem.Image = CType(resources.GetObject("ВыходToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ВыходToolStripMenuItem.Name = "ВыходToolStripMenuItem"
        Me.ВыходToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ВыходToolStripMenuItem.Text = "Выход"
        '
        'НастройкиToolStripMenuItem
        '
        Me.НастройкиToolStripMenuItem.Image = CType(resources.GetObject("НастройкиToolStripMenuItem.Image"), System.Drawing.Image)
        Me.НастройкиToolStripMenuItem.Name = "НастройкиToolStripMenuItem"
        Me.НастройкиToolStripMenuItem.Size = New System.Drawing.Size(108, 21)
        Me.НастройкиToolStripMenuItem.Text = "Настройки"
        '
        'ИнформацияToolStripMenuItem
        '
        Me.ИнформацияToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОПрограммеToolStripMenuItem, Me.ToolStripMenuItem1, Me.СправкаF1ToolStripMenuItem})
        Me.ИнформацияToolStripMenuItem.Image = CType(resources.GetObject("ИнформацияToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ИнформацияToolStripMenuItem.Name = "ИнформацияToolStripMenuItem"
        Me.ИнформацияToolStripMenuItem.Size = New System.Drawing.Size(128, 21)
        Me.ИнформацияToolStripMenuItem.Text = "Информация"
        '
        'ОПрограммеToolStripMenuItem
        '
        Me.ОПрограммеToolStripMenuItem.Image = CType(resources.GetObject("ОПрограммеToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ОПрограммеToolStripMenuItem.Name = "ОПрограммеToolStripMenuItem"
        Me.ОПрограммеToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ОПрограммеToolStripMenuItem.Text = "О программе"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(167, 6)
        '
        'СправкаF1ToolStripMenuItem
        '
        Me.СправкаF1ToolStripMenuItem.Image = CType(resources.GetObject("СправкаF1ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.СправкаF1ToolStripMenuItem.Name = "СправкаF1ToolStripMenuItem"
        Me.СправкаF1ToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.СправкаF1ToolStripMenuItem.Text = "Справка (F1)"
        '
        'TabControlMain
        '
        Me.TabControlMain.Controls.Add(Me.TabPageTables)
        Me.TabControlMain.Controls.Add(Me.TabPageServices)
        Me.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlMain.Location = New System.Drawing.Point(0, 50)
        Me.TabControlMain.Name = "TabControlMain"
        Me.TabControlMain.SelectedIndex = 0
        Me.TabControlMain.Size = New System.Drawing.Size(947, 426)
        Me.TabControlMain.TabIndex = 1
        '
        'TabPageTables
        '
        Me.TabPageTables.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TabPageTables.Controls.Add(Me.PictureBoxLogo)
        Me.TabPageTables.Controls.Add(Me.bCloseDelete)
        Me.TabPageTables.Controls.Add(Me.bEdit)
        Me.TabPageTables.Controls.Add(Me.bOpenPanel)
        Me.TabPageTables.Controls.Add(Me.TabControlTables)
        Me.TabPageTables.Location = New System.Drawing.Point(4, 30)
        Me.TabPageTables.Name = "TabPageTables"
        Me.TabPageTables.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageTables.Size = New System.Drawing.Size(939, 392)
        Me.TabPageTables.TabIndex = 0
        Me.TabPageTables.Text = "Таблицы"
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxLogo.BackgroundImage = CType(resources.GetObject("PictureBoxLogo.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxLogo.Location = New System.Drawing.Point(8, 239)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(67, 67)
        Me.PictureBoxLogo.TabIndex = 4
        Me.PictureBoxLogo.TabStop = False
        '
        'bCloseDelete
        '
        Me.bCloseDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bCloseDelete.BackgroundImage = CType(resources.GetObject("bCloseDelete.BackgroundImage"), System.Drawing.Image)
        Me.bCloseDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bCloseDelete.Location = New System.Drawing.Point(8, 312)
        Me.bCloseDelete.Name = "bCloseDelete"
        Me.bCloseDelete.Size = New System.Drawing.Size(67, 67)
        Me.bCloseDelete.TabIndex = 3
        Me.bCloseDelete.UseVisualStyleBackColor = True
        '
        'bEdit
        '
        Me.bEdit.BackgroundImage = CType(resources.GetObject("bEdit.BackgroundImage"), System.Drawing.Image)
        Me.bEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bEdit.Location = New System.Drawing.Point(8, 106)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Size = New System.Drawing.Size(67, 67)
        Me.bEdit.TabIndex = 2
        Me.bEdit.UseVisualStyleBackColor = True
        '
        'bOpenPanel
        '
        Me.bOpenPanel.BackgroundImage = CType(resources.GetObject("bOpenPanel.BackgroundImage"), System.Drawing.Image)
        Me.bOpenPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bOpenPanel.Location = New System.Drawing.Point(8, 33)
        Me.bOpenPanel.Name = "bOpenPanel"
        Me.bOpenPanel.Size = New System.Drawing.Size(67, 67)
        Me.bOpenPanel.TabIndex = 1
        Me.bOpenPanel.UseVisualStyleBackColor = True
        '
        'TabControlTables
        '
        Me.TabControlTables.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlTables.Controls.Add(Me.TabPageTypeService)
        Me.TabControlTables.Controls.Add(Me.TabPageDepartment)
        Me.TabControlTables.Controls.Add(Me.TabPageDocuments)
        Me.TabControlTables.Controls.Add(Me.TabPageWorker)
        Me.TabControlTables.Controls.Add(Me.TabPageService)
        Me.TabControlTables.Controls.Add(Me.TabPageClient)
        Me.TabControlTables.Controls.Add(Me.TabPageOperation)
        Me.TabControlTables.Controls.Add(Me.TabPageUsers)
        Me.TabControlTables.Controls.Add(Me.TabPageServiceOperation)
        Me.TabControlTables.Location = New System.Drawing.Point(81, 3)
        Me.TabControlTables.Name = "TabControlTables"
        Me.TabControlTables.SelectedIndex = 0
        Me.TabControlTables.Size = New System.Drawing.Size(855, 386)
        Me.TabControlTables.TabIndex = 0
        '
        'TabPageTypeService
        '
        Me.TabPageTypeService.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TabPageTypeService.Controls.Add(Me.PanelTypeService)
        Me.TabPageTypeService.Controls.Add(Me.DataGridViewTypeService)
        Me.TabPageTypeService.Location = New System.Drawing.Point(4, 30)
        Me.TabPageTypeService.Name = "TabPageTypeService"
        Me.TabPageTypeService.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageTypeService.Size = New System.Drawing.Size(847, 352)
        Me.TabPageTypeService.TabIndex = 0
        Me.TabPageTypeService.Text = "Тип услуги"
        '
        'PanelTypeService
        '
        Me.PanelTypeService.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTypeService.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelTypeService.Controls.Add(Me.tbTypeServiceDesc)
        Me.PanelTypeService.Controls.Add(Me.Label2)
        Me.PanelTypeService.Controls.Add(Me.tbTypeServiceName)
        Me.PanelTypeService.Controls.Add(Me.Label1)
        Me.PanelTypeService.Controls.Add(Me.PictureBoxTypeService)
        Me.PanelTypeService.Controls.Add(Me.LabelTypeService)
        Me.PanelTypeService.Controls.Add(Me.bClearTypeService)
        Me.PanelTypeService.Controls.Add(Me.bAddTypeService)
        Me.PanelTypeService.Location = New System.Drawing.Point(6, 6)
        Me.PanelTypeService.Name = "PanelTypeService"
        Me.PanelTypeService.Size = New System.Drawing.Size(835, 343)
        Me.PanelTypeService.TabIndex = 4
        Me.PanelTypeService.Visible = False
        '
        'tbTypeServiceDesc
        '
        Me.tbTypeServiceDesc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTypeServiceDesc.Location = New System.Drawing.Point(59, 145)
        Me.tbTypeServiceDesc.MaxLength = 255
        Me.tbTypeServiceDesc.Multiline = True
        Me.tbTypeServiceDesc.Name = "tbTypeServiceDesc"
        Me.tbTypeServiceDesc.Size = New System.Drawing.Size(725, 123)
        Me.tbTypeServiceDesc.TabIndex = 1002
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(55, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 22)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Описание услуги:"
        '
        'tbTypeServiceName
        '
        Me.tbTypeServiceName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTypeServiceName.Location = New System.Drawing.Point(59, 90)
        Me.tbTypeServiceName.MaxLength = 255
        Me.tbTypeServiceName.Name = "tbTypeServiceName"
        Me.tbTypeServiceName.Size = New System.Drawing.Size(725, 27)
        Me.tbTypeServiceName.TabIndex = 1001
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(55, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Тип услуги:"
        '
        'PictureBoxTypeService
        '
        Me.PictureBoxTypeService.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxTypeService.BackgroundImage = CType(resources.GetObject("PictureBoxTypeService.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxTypeService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxTypeService.Location = New System.Drawing.Point(543, 286)
        Me.PictureBoxTypeService.Name = "PictureBoxTypeService"
        Me.PictureBoxTypeService.Size = New System.Drawing.Size(285, 50)
        Me.PictureBoxTypeService.TabIndex = 5
        Me.PictureBoxTypeService.TabStop = False
        '
        'LabelTypeService
        '
        Me.LabelTypeService.AutoSize = True
        Me.LabelTypeService.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelTypeService.ForeColor = System.Drawing.Color.White
        Me.LabelTypeService.Location = New System.Drawing.Point(7, 4)
        Me.LabelTypeService.Name = "LabelTypeService"
        Me.LabelTypeService.Size = New System.Drawing.Size(270, 33)
        Me.LabelTypeService.TabIndex = 4
        Me.LabelTypeService.Text = "Добавляем запись"
        '
        'bClearTypeService
        '
        Me.bClearTypeService.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bClearTypeService.BackgroundImage = CType(resources.GetObject("bClearTypeService.BackgroundImage"), System.Drawing.Image)
        Me.bClearTypeService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bClearTypeService.Location = New System.Drawing.Point(59, 286)
        Me.bClearTypeService.Name = "bClearTypeService"
        Me.bClearTypeService.Size = New System.Drawing.Size(50, 50)
        Me.bClearTypeService.TabIndex = 1003
        Me.bClearTypeService.UseVisualStyleBackColor = True
        '
        'bAddTypeService
        '
        Me.bAddTypeService.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bAddTypeService.BackgroundImage = CType(resources.GetObject("bAddTypeService.BackgroundImage"), System.Drawing.Image)
        Me.bAddTypeService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bAddTypeService.Location = New System.Drawing.Point(3, 286)
        Me.bAddTypeService.Name = "bAddTypeService"
        Me.bAddTypeService.Size = New System.Drawing.Size(50, 50)
        Me.bAddTypeService.TabIndex = 1004
        Me.bAddTypeService.UseVisualStyleBackColor = True
        '
        'DataGridViewTypeService
        '
        Me.DataGridViewTypeService.AllowUserToAddRows = False
        Me.DataGridViewTypeService.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewTypeService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewTypeService.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewTypeService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTypeService.Location = New System.Drawing.Point(6, 6)
        Me.DataGridViewTypeService.MultiSelect = False
        Me.DataGridViewTypeService.Name = "DataGridViewTypeService"
        Me.DataGridViewTypeService.ReadOnly = True
        Me.DataGridViewTypeService.Size = New System.Drawing.Size(835, 343)
        Me.DataGridViewTypeService.TabIndex = 0
        '
        'TabPageDepartment
        '
        Me.TabPageDepartment.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TabPageDepartment.Controls.Add(Me.PanelDepartment)
        Me.TabPageDepartment.Controls.Add(Me.DataGridViewDepartment)
        Me.TabPageDepartment.Location = New System.Drawing.Point(4, 30)
        Me.TabPageDepartment.Name = "TabPageDepartment"
        Me.TabPageDepartment.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDepartment.Size = New System.Drawing.Size(847, 352)
        Me.TabPageDepartment.TabIndex = 3
        Me.TabPageDepartment.Text = "Отдел"
        '
        'PanelDepartment
        '
        Me.PanelDepartment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDepartment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelDepartment.Controls.Add(Me.NumericUDApartment)
        Me.PanelDepartment.Controls.Add(Me.Label3)
        Me.PanelDepartment.Controls.Add(Me.tbDepartmentName)
        Me.PanelDepartment.Controls.Add(Me.Label4)
        Me.PanelDepartment.Controls.Add(Me.PictureBoxDepartment)
        Me.PanelDepartment.Controls.Add(Me.LabelDepartment)
        Me.PanelDepartment.Controls.Add(Me.bClearDepartment)
        Me.PanelDepartment.Controls.Add(Me.bAddDepartment)
        Me.PanelDepartment.Location = New System.Drawing.Point(6, 6)
        Me.PanelDepartment.Name = "PanelDepartment"
        Me.PanelDepartment.Size = New System.Drawing.Size(835, 343)
        Me.PanelDepartment.TabIndex = 4
        Me.PanelDepartment.Visible = False
        '
        'NumericUDApartment
        '
        Me.NumericUDApartment.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUDApartment.Location = New System.Drawing.Point(59, 149)
        Me.NumericUDApartment.Name = "NumericUDApartment"
        Me.NumericUDApartment.Size = New System.Drawing.Size(725, 27)
        Me.NumericUDApartment.TabIndex = 2002
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(55, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 22)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Месторасположение:"
        '
        'tbDepartmentName
        '
        Me.tbDepartmentName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDepartmentName.Location = New System.Drawing.Point(59, 94)
        Me.tbDepartmentName.MaxLength = 100
        Me.tbDepartmentName.Name = "tbDepartmentName"
        Me.tbDepartmentName.Size = New System.Drawing.Size(725, 27)
        Me.tbDepartmentName.TabIndex = 2001
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(55, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 22)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Название отдела:"
        '
        'PictureBoxDepartment
        '
        Me.PictureBoxDepartment.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxDepartment.BackgroundImage = CType(resources.GetObject("PictureBoxDepartment.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxDepartment.Location = New System.Drawing.Point(543, 286)
        Me.PictureBoxDepartment.Name = "PictureBoxDepartment"
        Me.PictureBoxDepartment.Size = New System.Drawing.Size(285, 50)
        Me.PictureBoxDepartment.TabIndex = 6
        Me.PictureBoxDepartment.TabStop = False
        '
        'LabelDepartment
        '
        Me.LabelDepartment.AutoSize = True
        Me.LabelDepartment.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelDepartment.ForeColor = System.Drawing.Color.White
        Me.LabelDepartment.Location = New System.Drawing.Point(7, 4)
        Me.LabelDepartment.Name = "LabelDepartment"
        Me.LabelDepartment.Size = New System.Drawing.Size(270, 33)
        Me.LabelDepartment.TabIndex = 4
        Me.LabelDepartment.Text = "Добавляем запись"
        '
        'bClearDepartment
        '
        Me.bClearDepartment.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bClearDepartment.BackgroundImage = CType(resources.GetObject("bClearDepartment.BackgroundImage"), System.Drawing.Image)
        Me.bClearDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bClearDepartment.Location = New System.Drawing.Point(59, 286)
        Me.bClearDepartment.Name = "bClearDepartment"
        Me.bClearDepartment.Size = New System.Drawing.Size(50, 50)
        Me.bClearDepartment.TabIndex = 2003
        Me.bClearDepartment.UseVisualStyleBackColor = True
        '
        'bAddDepartment
        '
        Me.bAddDepartment.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bAddDepartment.BackgroundImage = CType(resources.GetObject("bAddDepartment.BackgroundImage"), System.Drawing.Image)
        Me.bAddDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bAddDepartment.Location = New System.Drawing.Point(3, 286)
        Me.bAddDepartment.Name = "bAddDepartment"
        Me.bAddDepartment.Size = New System.Drawing.Size(50, 50)
        Me.bAddDepartment.TabIndex = 2004
        Me.bAddDepartment.UseVisualStyleBackColor = True
        '
        'DataGridViewDepartment
        '
        Me.DataGridViewDepartment.AllowUserToAddRows = False
        Me.DataGridViewDepartment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewDepartment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDepartment.Location = New System.Drawing.Point(6, 6)
        Me.DataGridViewDepartment.MultiSelect = False
        Me.DataGridViewDepartment.Name = "DataGridViewDepartment"
        Me.DataGridViewDepartment.ReadOnly = True
        Me.DataGridViewDepartment.Size = New System.Drawing.Size(835, 343)
        Me.DataGridViewDepartment.TabIndex = 1
        '
        'TabPageDocuments
        '
        Me.TabPageDocuments.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TabPageDocuments.Controls.Add(Me.PanelDocuments)
        Me.TabPageDocuments.Controls.Add(Me.DataGridViewDocuments)
        Me.TabPageDocuments.Location = New System.Drawing.Point(4, 30)
        Me.TabPageDocuments.Name = "TabPageDocuments"
        Me.TabPageDocuments.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDocuments.Size = New System.Drawing.Size(847, 352)
        Me.TabPageDocuments.TabIndex = 4
        Me.TabPageDocuments.Text = "Документы"
        '
        'PanelDocuments
        '
        Me.PanelDocuments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDocuments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelDocuments.Controls.Add(Me.tbDocumentsName)
        Me.PanelDocuments.Controls.Add(Me.Label6)
        Me.PanelDocuments.Controls.Add(Me.PictureBoxDocuments)
        Me.PanelDocuments.Controls.Add(Me.LabelDocuments)
        Me.PanelDocuments.Controls.Add(Me.bClearDocuments)
        Me.PanelDocuments.Controls.Add(Me.bAddDocuments)
        Me.PanelDocuments.Location = New System.Drawing.Point(6, 6)
        Me.PanelDocuments.Name = "PanelDocuments"
        Me.PanelDocuments.Size = New System.Drawing.Size(835, 343)
        Me.PanelDocuments.TabIndex = 4
        Me.PanelDocuments.Visible = False
        '
        'tbDocumentsName
        '
        Me.tbDocumentsName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDocumentsName.Location = New System.Drawing.Point(59, 90)
        Me.tbDocumentsName.MaxLength = 100
        Me.tbDocumentsName.Multiline = True
        Me.tbDocumentsName.Name = "tbDocumentsName"
        Me.tbDocumentsName.Size = New System.Drawing.Size(725, 178)
        Me.tbDocumentsName.TabIndex = 3001
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(55, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(216, 22)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Название документа:"
        '
        'PictureBoxDocuments
        '
        Me.PictureBoxDocuments.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxDocuments.BackgroundImage = CType(resources.GetObject("PictureBoxDocuments.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxDocuments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxDocuments.Location = New System.Drawing.Point(543, 286)
        Me.PictureBoxDocuments.Name = "PictureBoxDocuments"
        Me.PictureBoxDocuments.Size = New System.Drawing.Size(285, 50)
        Me.PictureBoxDocuments.TabIndex = 6
        Me.PictureBoxDocuments.TabStop = False
        '
        'LabelDocuments
        '
        Me.LabelDocuments.AutoSize = True
        Me.LabelDocuments.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelDocuments.ForeColor = System.Drawing.Color.White
        Me.LabelDocuments.Location = New System.Drawing.Point(7, 4)
        Me.LabelDocuments.Name = "LabelDocuments"
        Me.LabelDocuments.Size = New System.Drawing.Size(270, 33)
        Me.LabelDocuments.TabIndex = 4
        Me.LabelDocuments.Text = "Добавляем запись"
        '
        'bClearDocuments
        '
        Me.bClearDocuments.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bClearDocuments.BackgroundImage = CType(resources.GetObject("bClearDocuments.BackgroundImage"), System.Drawing.Image)
        Me.bClearDocuments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bClearDocuments.Location = New System.Drawing.Point(59, 286)
        Me.bClearDocuments.Name = "bClearDocuments"
        Me.bClearDocuments.Size = New System.Drawing.Size(50, 50)
        Me.bClearDocuments.TabIndex = 3002
        Me.bClearDocuments.UseVisualStyleBackColor = True
        '
        'bAddDocuments
        '
        Me.bAddDocuments.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bAddDocuments.BackgroundImage = CType(resources.GetObject("bAddDocuments.BackgroundImage"), System.Drawing.Image)
        Me.bAddDocuments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bAddDocuments.Location = New System.Drawing.Point(3, 286)
        Me.bAddDocuments.Name = "bAddDocuments"
        Me.bAddDocuments.Size = New System.Drawing.Size(50, 50)
        Me.bAddDocuments.TabIndex = 3003
        Me.bAddDocuments.UseVisualStyleBackColor = True
        '
        'DataGridViewDocuments
        '
        Me.DataGridViewDocuments.AllowUserToAddRows = False
        Me.DataGridViewDocuments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewDocuments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewDocuments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDocuments.Location = New System.Drawing.Point(6, 6)
        Me.DataGridViewDocuments.MultiSelect = False
        Me.DataGridViewDocuments.Name = "DataGridViewDocuments"
        Me.DataGridViewDocuments.ReadOnly = True
        Me.DataGridViewDocuments.Size = New System.Drawing.Size(835, 343)
        Me.DataGridViewDocuments.TabIndex = 1
        '
        'TabPageWorker
        '
        Me.TabPageWorker.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TabPageWorker.Controls.Add(Me.PanelWorker)
        Me.TabPageWorker.Controls.Add(Me.DataGridViewWorker)
        Me.TabPageWorker.Location = New System.Drawing.Point(4, 30)
        Me.TabPageWorker.Name = "TabPageWorker"
        Me.TabPageWorker.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageWorker.Size = New System.Drawing.Size(847, 352)
        Me.TabPageWorker.TabIndex = 5
        Me.TabPageWorker.Text = "Работник"
        '
        'PanelWorker
        '
        Me.PanelWorker.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelWorker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelWorker.Controls.Add(Me.cbWorkerFKDepName)
        Me.PanelWorker.Controls.Add(Me.NumericUDWorkerExp)
        Me.PanelWorker.Controls.Add(Me.NumericUDWorkerRank)
        Me.PanelWorker.Controls.Add(Me.Label9)
        Me.PanelWorker.Controls.Add(Me.Label10)
        Me.PanelWorker.Controls.Add(Me.Label11)
        Me.PanelWorker.Controls.Add(Me.tbWorkerThirdName)
        Me.PanelWorker.Controls.Add(Me.Label8)
        Me.PanelWorker.Controls.Add(Me.tbWorkerFirstName)
        Me.PanelWorker.Controls.Add(Me.Label5)
        Me.PanelWorker.Controls.Add(Me.tbWorkerSecondName)
        Me.PanelWorker.Controls.Add(Me.Label7)
        Me.PanelWorker.Controls.Add(Me.PictureBoxWorker)
        Me.PanelWorker.Controls.Add(Me.LabelWorker)
        Me.PanelWorker.Controls.Add(Me.bClearWorker)
        Me.PanelWorker.Controls.Add(Me.bAddWorker)
        Me.PanelWorker.Location = New System.Drawing.Point(6, 6)
        Me.PanelWorker.Name = "PanelWorker"
        Me.PanelWorker.Size = New System.Drawing.Size(835, 343)
        Me.PanelWorker.TabIndex = 5
        Me.PanelWorker.Visible = False
        '
        'cbWorkerFKDepName
        '
        Me.cbWorkerFKDepName.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cbWorkerFKDepName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWorkerFKDepName.FormattingEnabled = True
        Me.cbWorkerFKDepName.Location = New System.Drawing.Point(464, 202)
        Me.cbWorkerFKDepName.Name = "cbWorkerFKDepName"
        Me.cbWorkerFKDepName.Size = New System.Drawing.Size(300, 29)
        Me.cbWorkerFKDepName.TabIndex = 4006
        '
        'NumericUDWorkerExp
        '
        Me.NumericUDWorkerExp.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.NumericUDWorkerExp.Location = New System.Drawing.Point(464, 149)
        Me.NumericUDWorkerExp.Name = "NumericUDWorkerExp"
        Me.NumericUDWorkerExp.Size = New System.Drawing.Size(300, 27)
        Me.NumericUDWorkerExp.TabIndex = 4005
        '
        'NumericUDWorkerRank
        '
        Me.NumericUDWorkerRank.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.NumericUDWorkerRank.Location = New System.Drawing.Point(464, 94)
        Me.NumericUDWorkerRank.Name = "NumericUDWorkerRank"
        Me.NumericUDWorkerRank.Size = New System.Drawing.Size(300, 27)
        Me.NumericUDWorkerRank.TabIndex = 4004
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(460, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 22)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Отдел:"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(460, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 22)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Стаж:"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(460, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(189, 22)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Разряд работника:"
        '
        'tbWorkerThirdName
        '
        Me.tbWorkerThirdName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbWorkerThirdName.Location = New System.Drawing.Point(59, 204)
        Me.tbWorkerThirdName.MaxLength = 100
        Me.tbWorkerThirdName.Name = "tbWorkerThirdName"
        Me.tbWorkerThirdName.Size = New System.Drawing.Size(399, 27)
        Me.tbWorkerThirdName.TabIndex = 4003
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(55, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 22)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Отчество"
        '
        'tbWorkerFirstName
        '
        Me.tbWorkerFirstName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbWorkerFirstName.Location = New System.Drawing.Point(59, 149)
        Me.tbWorkerFirstName.MaxLength = 100
        Me.tbWorkerFirstName.Name = "tbWorkerFirstName"
        Me.tbWorkerFirstName.Size = New System.Drawing.Size(399, 27)
        Me.tbWorkerFirstName.TabIndex = 4002
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(55, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 22)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Имя:"
        '
        'tbWorkerSecondName
        '
        Me.tbWorkerSecondName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbWorkerSecondName.Location = New System.Drawing.Point(59, 94)
        Me.tbWorkerSecondName.MaxLength = 100
        Me.tbWorkerSecondName.Name = "tbWorkerSecondName"
        Me.tbWorkerSecondName.Size = New System.Drawing.Size(399, 27)
        Me.tbWorkerSecondName.TabIndex = 4001
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(55, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(222, 22)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Фамилия сотрудника:"
        '
        'PictureBoxWorker
        '
        Me.PictureBoxWorker.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxWorker.BackgroundImage = CType(resources.GetObject("PictureBoxWorker.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxWorker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxWorker.Location = New System.Drawing.Point(543, 286)
        Me.PictureBoxWorker.Name = "PictureBoxWorker"
        Me.PictureBoxWorker.Size = New System.Drawing.Size(285, 50)
        Me.PictureBoxWorker.TabIndex = 6
        Me.PictureBoxWorker.TabStop = False
        '
        'LabelWorker
        '
        Me.LabelWorker.AutoSize = True
        Me.LabelWorker.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelWorker.ForeColor = System.Drawing.Color.White
        Me.LabelWorker.Location = New System.Drawing.Point(7, 4)
        Me.LabelWorker.Name = "LabelWorker"
        Me.LabelWorker.Size = New System.Drawing.Size(270, 33)
        Me.LabelWorker.TabIndex = 4
        Me.LabelWorker.Text = "Добавляем запись"
        '
        'bClearWorker
        '
        Me.bClearWorker.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bClearWorker.BackgroundImage = CType(resources.GetObject("bClearWorker.BackgroundImage"), System.Drawing.Image)
        Me.bClearWorker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bClearWorker.Location = New System.Drawing.Point(59, 286)
        Me.bClearWorker.Name = "bClearWorker"
        Me.bClearWorker.Size = New System.Drawing.Size(50, 50)
        Me.bClearWorker.TabIndex = 4007
        Me.bClearWorker.UseVisualStyleBackColor = True
        '
        'bAddWorker
        '
        Me.bAddWorker.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bAddWorker.BackgroundImage = CType(resources.GetObject("bAddWorker.BackgroundImage"), System.Drawing.Image)
        Me.bAddWorker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bAddWorker.Location = New System.Drawing.Point(3, 286)
        Me.bAddWorker.Name = "bAddWorker"
        Me.bAddWorker.Size = New System.Drawing.Size(50, 50)
        Me.bAddWorker.TabIndex = 4008
        Me.bAddWorker.UseVisualStyleBackColor = True
        '
        'DataGridViewWorker
        '
        Me.DataGridViewWorker.AllowUserToAddRows = False
        Me.DataGridViewWorker.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewWorker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewWorker.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewWorker.Location = New System.Drawing.Point(6, 6)
        Me.DataGridViewWorker.MultiSelect = False
        Me.DataGridViewWorker.Name = "DataGridViewWorker"
        Me.DataGridViewWorker.ReadOnly = True
        Me.DataGridViewWorker.Size = New System.Drawing.Size(835, 343)
        Me.DataGridViewWorker.TabIndex = 2
        '
        'TabPageService
        '
        Me.TabPageService.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TabPageService.Controls.Add(Me.PanelService)
        Me.TabPageService.Controls.Add(Me.DataGridViewService)
        Me.TabPageService.Location = New System.Drawing.Point(4, 30)
        Me.TabPageService.Name = "TabPageService"
        Me.TabPageService.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageService.Size = New System.Drawing.Size(847, 352)
        Me.TabPageService.TabIndex = 6
        Me.TabPageService.Text = "Услуга"
        '
        'PanelService
        '
        Me.PanelService.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelService.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelService.Controls.Add(Me.tbServiceName)
        Me.PanelService.Controls.Add(Me.cbServiceFKFIOWorker)
        Me.PanelService.Controls.Add(Me.cbServiceFKDocName)
        Me.PanelService.Controls.Add(Me.cbServiceFKTypeService)
        Me.PanelService.Controls.Add(Me.NumericUDServicePrice)
        Me.PanelService.Controls.Add(Me.Label12)
        Me.PanelService.Controls.Add(Me.Label13)
        Me.PanelService.Controls.Add(Me.Label14)
        Me.PanelService.Controls.Add(Me.Label16)
        Me.PanelService.Controls.Add(Me.Label17)
        Me.PanelService.Controls.Add(Me.PictureBoxService)
        Me.PanelService.Controls.Add(Me.LabelService)
        Me.PanelService.Controls.Add(Me.bClearService)
        Me.PanelService.Controls.Add(Me.bAddService)
        Me.PanelService.Location = New System.Drawing.Point(6, 6)
        Me.PanelService.Name = "PanelService"
        Me.PanelService.Size = New System.Drawing.Size(835, 343)
        Me.PanelService.TabIndex = 5
        Me.PanelService.Visible = False
        '
        'tbServiceName
        '
        Me.tbServiceName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbServiceName.Location = New System.Drawing.Point(59, 206)
        Me.tbServiceName.MaxLength = 255
        Me.tbServiceName.Name = "tbServiceName"
        Me.tbServiceName.Size = New System.Drawing.Size(705, 27)
        Me.tbServiceName.TabIndex = 5005
        '
        'cbServiceFKFIOWorker
        '
        Me.cbServiceFKFIOWorker.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cbServiceFKFIOWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbServiceFKFIOWorker.FormattingEnabled = True
        Me.cbServiceFKFIOWorker.Location = New System.Drawing.Point(464, 92)
        Me.cbServiceFKFIOWorker.Name = "cbServiceFKFIOWorker"
        Me.cbServiceFKFIOWorker.Size = New System.Drawing.Size(300, 29)
        Me.cbServiceFKFIOWorker.TabIndex = 5003
        '
        'cbServiceFKDocName
        '
        Me.cbServiceFKDocName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbServiceFKDocName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbServiceFKDocName.FormattingEnabled = True
        Me.cbServiceFKDocName.Location = New System.Drawing.Point(59, 149)
        Me.cbServiceFKDocName.Name = "cbServiceFKDocName"
        Me.cbServiceFKDocName.Size = New System.Drawing.Size(399, 29)
        Me.cbServiceFKDocName.TabIndex = 5002
        '
        'cbServiceFKTypeService
        '
        Me.cbServiceFKTypeService.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbServiceFKTypeService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbServiceFKTypeService.FormattingEnabled = True
        Me.cbServiceFKTypeService.Location = New System.Drawing.Point(59, 92)
        Me.cbServiceFKTypeService.Name = "cbServiceFKTypeService"
        Me.cbServiceFKTypeService.Size = New System.Drawing.Size(399, 29)
        Me.cbServiceFKTypeService.TabIndex = 5001
        '
        'NumericUDServicePrice
        '
        Me.NumericUDServicePrice.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.NumericUDServicePrice.Location = New System.Drawing.Point(464, 149)
        Me.NumericUDServicePrice.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumericUDServicePrice.Name = "NumericUDServicePrice"
        Me.NumericUDServicePrice.Size = New System.Drawing.Size(300, 27)
        Me.NumericUDServicePrice.TabIndex = 5004
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(55, 181)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 22)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Название:"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(460, 124)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 22)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Стоимость:"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(460, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 22)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Работник:"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(55, 124)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(109, 22)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Документ:"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(55, 69)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(114, 22)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Тип услуги:"
        '
        'PictureBoxService
        '
        Me.PictureBoxService.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxService.BackgroundImage = CType(resources.GetObject("PictureBoxService.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxService.Location = New System.Drawing.Point(543, 286)
        Me.PictureBoxService.Name = "PictureBoxService"
        Me.PictureBoxService.Size = New System.Drawing.Size(285, 50)
        Me.PictureBoxService.TabIndex = 6
        Me.PictureBoxService.TabStop = False
        '
        'LabelService
        '
        Me.LabelService.AutoSize = True
        Me.LabelService.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelService.ForeColor = System.Drawing.Color.White
        Me.LabelService.Location = New System.Drawing.Point(7, 4)
        Me.LabelService.Name = "LabelService"
        Me.LabelService.Size = New System.Drawing.Size(270, 33)
        Me.LabelService.TabIndex = 4
        Me.LabelService.Text = "Добавляем запись"
        '
        'bClearService
        '
        Me.bClearService.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bClearService.BackgroundImage = CType(resources.GetObject("bClearService.BackgroundImage"), System.Drawing.Image)
        Me.bClearService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bClearService.Location = New System.Drawing.Point(59, 286)
        Me.bClearService.Name = "bClearService"
        Me.bClearService.Size = New System.Drawing.Size(50, 50)
        Me.bClearService.TabIndex = 5006
        Me.bClearService.UseVisualStyleBackColor = True
        '
        'bAddService
        '
        Me.bAddService.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bAddService.BackgroundImage = CType(resources.GetObject("bAddService.BackgroundImage"), System.Drawing.Image)
        Me.bAddService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bAddService.Location = New System.Drawing.Point(3, 286)
        Me.bAddService.Name = "bAddService"
        Me.bAddService.Size = New System.Drawing.Size(50, 50)
        Me.bAddService.TabIndex = 5007
        Me.bAddService.UseVisualStyleBackColor = True
        '
        'DataGridViewService
        '
        Me.DataGridViewService.AllowUserToAddRows = False
        Me.DataGridViewService.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewService.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewService.Location = New System.Drawing.Point(6, 6)
        Me.DataGridViewService.MultiSelect = False
        Me.DataGridViewService.Name = "DataGridViewService"
        Me.DataGridViewService.ReadOnly = True
        Me.DataGridViewService.Size = New System.Drawing.Size(835, 343)
        Me.DataGridViewService.TabIndex = 2
        '
        'TabPageClient
        '
        Me.TabPageClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TabPageClient.Controls.Add(Me.PanelClient)
        Me.TabPageClient.Controls.Add(Me.DataGridViewClient)
        Me.TabPageClient.Location = New System.Drawing.Point(4, 30)
        Me.TabPageClient.Name = "TabPageClient"
        Me.TabPageClient.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageClient.Size = New System.Drawing.Size(847, 352)
        Me.TabPageClient.TabIndex = 7
        Me.TabPageClient.Text = "Клиент"
        '
        'PanelClient
        '
        Me.PanelClient.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelClient.Controls.Add(Me.NumericUDClientNumber)
        Me.PanelClient.Controls.Add(Me.DateTPClientDateBirth)
        Me.PanelClient.Controls.Add(Me.DateTPClientDateOfIssue)
        Me.PanelClient.Controls.Add(Me.cbClientStatus)
        Me.PanelClient.Controls.Add(Me.Label30)
        Me.PanelClient.Controls.Add(Me.Label31)
        Me.PanelClient.Controls.Add(Me.tbClientPhoneNumber)
        Me.PanelClient.Controls.Add(Me.Label32)
        Me.PanelClient.Controls.Add(Me.tbClientSecondName)
        Me.PanelClient.Controls.Add(Me.Label26)
        Me.PanelClient.Controls.Add(Me.Label27)
        Me.PanelClient.Controls.Add(Me.Label28)
        Me.PanelClient.Controls.Add(Me.tbClientNameOrg)
        Me.PanelClient.Controls.Add(Me.Label15)
        Me.PanelClient.Controls.Add(Me.Label18)
        Me.PanelClient.Controls.Add(Me.Label20)
        Me.PanelClient.Controls.Add(Me.tbClientBankDetails)
        Me.PanelClient.Controls.Add(Me.tbClientBatch)
        Me.PanelClient.Controls.Add(Me.tbClientThirdName)
        Me.PanelClient.Controls.Add(Me.Label24)
        Me.PanelClient.Controls.Add(Me.tbClientAddress)
        Me.PanelClient.Controls.Add(Me.Label23)
        Me.PanelClient.Controls.Add(Me.Label22)
        Me.PanelClient.Controls.Add(Me.Label19)
        Me.PanelClient.Controls.Add(Me.tbClientDetails)
        Me.PanelClient.Controls.Add(Me.tbClientIssuedBy)
        Me.PanelClient.Controls.Add(Me.tbClientFirstName)
        Me.PanelClient.Controls.Add(Me.Label21)
        Me.PanelClient.Controls.Add(Me.PictureBoxClient)
        Me.PanelClient.Controls.Add(Me.LabelClient)
        Me.PanelClient.Controls.Add(Me.bClearClient)
        Me.PanelClient.Controls.Add(Me.bAddClient)
        Me.PanelClient.Location = New System.Drawing.Point(6, 6)
        Me.PanelClient.Name = "PanelClient"
        Me.PanelClient.Size = New System.Drawing.Size(835, 343)
        Me.PanelClient.TabIndex = 5
        Me.PanelClient.Visible = False
        '
        'NumericUDClientNumber
        '
        Me.NumericUDClientNumber.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.NumericUDClientNumber.Location = New System.Drawing.Point(470, 185)
        Me.NumericUDClientNumber.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.NumericUDClientNumber.Name = "NumericUDClientNumber"
        Me.NumericUDClientNumber.Size = New System.Drawing.Size(173, 27)
        Me.NumericUDClientNumber.TabIndex = 6010
        '
        'DateTPClientDateBirth
        '
        Me.DateTPClientDateBirth.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.DateTPClientDateBirth.Location = New System.Drawing.Point(291, 185)
        Me.DateTPClientDateBirth.Name = "DateTPClientDateBirth"
        Me.DateTPClientDateBirth.Size = New System.Drawing.Size(173, 27)
        Me.DateTPClientDateBirth.TabIndex = 6007
        '
        'DateTPClientDateOfIssue
        '
        Me.DateTPClientDateOfIssue.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.DateTPClientDateOfIssue.Location = New System.Drawing.Point(470, 75)
        Me.DateTPClientDateOfIssue.Name = "DateTPClientDateOfIssue"
        Me.DateTPClientDateOfIssue.Size = New System.Drawing.Size(173, 27)
        Me.DateTPClientDateOfIssue.TabIndex = 6008
        '
        'cbClientStatus
        '
        Me.cbClientStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbClientStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClientStatus.FormattingEnabled = True
        Me.cbClientStatus.Items.AddRange(New Object() {"Физ лицо", "Юр лицо"})
        Me.cbClientStatus.Location = New System.Drawing.Point(13, 75)
        Me.cbClientStatus.Name = "cbClientStatus"
        Me.cbClientStatus.Size = New System.Drawing.Size(272, 29)
        Me.cbClientStatus.TabIndex = 6001
        '
        'Label30
        '
        Me.Label30.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(645, 160)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(101, 22)
        Me.Label30.TabIndex = 83
        Me.Label30.Text = "Телефон:"
        '
        'Label31
        '
        Me.Label31.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(287, 160)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(162, 22)
        Me.Label31.TabIndex = 82
        Me.Label31.Text = "Дата рождения:"
        '
        'tbClientPhoneNumber
        '
        Me.tbClientPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.tbClientPhoneNumber.Location = New System.Drawing.Point(649, 185)
        Me.tbClientPhoneNumber.MaxLength = 10
        Me.tbClientPhoneNumber.Name = "tbClientPhoneNumber"
        Me.tbClientPhoneNumber.Size = New System.Drawing.Size(173, 27)
        Me.tbClientPhoneNumber.TabIndex = 6013
        '
        'Label32
        '
        Me.Label32.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(9, 215)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(104, 22)
        Me.Label32.TabIndex = 78
        Me.Label32.Text = "Фамилия:"
        '
        'tbClientSecondName
        '
        Me.tbClientSecondName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbClientSecondName.Location = New System.Drawing.Point(13, 240)
        Me.tbClientSecondName.MaxLength = 100
        Me.tbClientSecondName.Name = "tbClientSecondName"
        Me.tbClientSecondName.Size = New System.Drawing.Size(272, 27)
        Me.tbClientSecondName.TabIndex = 6004
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(466, 160)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(155, 22)
        Me.Label26.TabIndex = 75
        Me.Label26.Text = "Личный номер:"
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(466, 50)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(135, 22)
        Me.Label27.TabIndex = 74
        Me.Label27.Text = "Дата выдачи:"
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(9, 160)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(141, 22)
        Me.Label28.TabIndex = 70
        Me.Label28.Text = "Организация:"
        '
        'tbClientNameOrg
        '
        Me.tbClientNameOrg.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbClientNameOrg.Location = New System.Drawing.Point(13, 185)
        Me.tbClientNameOrg.MaxLength = 255
        Me.tbClientNameOrg.Name = "tbClientNameOrg"
        Me.tbClientNameOrg.Size = New System.Drawing.Size(272, 27)
        Me.tbClientNameOrg.TabIndex = 6003
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(287, 215)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(259, 22)
        Me.Label15.TabIndex = 68
        Me.Label15.Text = "Банковские подробности:"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(466, 105)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 22)
        Me.Label18.TabIndex = 67
        Me.Label18.Text = "Серия:"
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(287, 105)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 22)
        Me.Label20.TabIndex = 66
        Me.Label20.Text = "Отчество:"
        '
        'tbClientBankDetails
        '
        Me.tbClientBankDetails.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.tbClientBankDetails.Location = New System.Drawing.Point(291, 240)
        Me.tbClientBankDetails.MaxLength = 255
        Me.tbClientBankDetails.Name = "tbClientBankDetails"
        Me.tbClientBankDetails.Size = New System.Drawing.Size(531, 27)
        Me.tbClientBankDetails.TabIndex = 6014
        '
        'tbClientBatch
        '
        Me.tbClientBatch.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.tbClientBatch.Location = New System.Drawing.Point(470, 130)
        Me.tbClientBatch.MaxLength = 2
        Me.tbClientBatch.Name = "tbClientBatch"
        Me.tbClientBatch.Size = New System.Drawing.Size(173, 27)
        Me.tbClientBatch.TabIndex = 6009
        '
        'tbClientThirdName
        '
        Me.tbClientThirdName.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.tbClientThirdName.Location = New System.Drawing.Point(291, 130)
        Me.tbClientThirdName.MaxLength = 100
        Me.tbClientThirdName.Name = "tbClientThirdName"
        Me.tbClientThirdName.Size = New System.Drawing.Size(173, 27)
        Me.tbClientThirdName.TabIndex = 6006
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(9, 105)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(79, 22)
        Me.Label24.TabIndex = 62
        Me.Label24.Text = "Адрес:"
        '
        'tbClientAddress
        '
        Me.tbClientAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbClientAddress.Location = New System.Drawing.Point(13, 130)
        Me.tbClientAddress.MaxLength = 255
        Me.tbClientAddress.Name = "tbClientAddress"
        Me.tbClientAddress.Size = New System.Drawing.Size(272, 27)
        Me.tbClientAddress.TabIndex = 6002
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(645, 105)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(144, 22)
        Me.Label23.TabIndex = 60
        Me.Label23.Text = "Подробности:"
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(645, 50)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(75, 22)
        Me.Label22.TabIndex = 59
        Me.Label22.Text = "Выдан:"
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(287, 50)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(54, 22)
        Me.Label19.TabIndex = 58
        Me.Label19.Text = "Имя:"
        '
        'tbClientDetails
        '
        Me.tbClientDetails.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.tbClientDetails.Location = New System.Drawing.Point(649, 130)
        Me.tbClientDetails.MaxLength = 255
        Me.tbClientDetails.Name = "tbClientDetails"
        Me.tbClientDetails.Size = New System.Drawing.Size(173, 27)
        Me.tbClientDetails.TabIndex = 6012
        '
        'tbClientIssuedBy
        '
        Me.tbClientIssuedBy.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.tbClientIssuedBy.Location = New System.Drawing.Point(649, 75)
        Me.tbClientIssuedBy.MaxLength = 100
        Me.tbClientIssuedBy.Name = "tbClientIssuedBy"
        Me.tbClientIssuedBy.Size = New System.Drawing.Size(173, 27)
        Me.tbClientIssuedBy.TabIndex = 6011
        '
        'tbClientFirstName
        '
        Me.tbClientFirstName.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.tbClientFirstName.Location = New System.Drawing.Point(291, 75)
        Me.tbClientFirstName.MaxLength = 100
        Me.tbClientFirstName.Name = "tbClientFirstName"
        Me.tbClientFirstName.Size = New System.Drawing.Size(173, 27)
        Me.tbClientFirstName.TabIndex = 6005
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(9, 50)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 22)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "Статус:"
        '
        'PictureBoxClient
        '
        Me.PictureBoxClient.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxClient.BackgroundImage = CType(resources.GetObject("PictureBoxClient.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxClient.Location = New System.Drawing.Point(543, 286)
        Me.PictureBoxClient.Name = "PictureBoxClient"
        Me.PictureBoxClient.Size = New System.Drawing.Size(285, 50)
        Me.PictureBoxClient.TabIndex = 7
        Me.PictureBoxClient.TabStop = False
        '
        'LabelClient
        '
        Me.LabelClient.AutoSize = True
        Me.LabelClient.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelClient.ForeColor = System.Drawing.Color.White
        Me.LabelClient.Location = New System.Drawing.Point(7, 4)
        Me.LabelClient.Name = "LabelClient"
        Me.LabelClient.Size = New System.Drawing.Size(270, 33)
        Me.LabelClient.TabIndex = 4
        Me.LabelClient.Text = "Добавляем запись"
        '
        'bClearClient
        '
        Me.bClearClient.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bClearClient.BackgroundImage = CType(resources.GetObject("bClearClient.BackgroundImage"), System.Drawing.Image)
        Me.bClearClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bClearClient.Location = New System.Drawing.Point(59, 286)
        Me.bClearClient.Name = "bClearClient"
        Me.bClearClient.Size = New System.Drawing.Size(50, 50)
        Me.bClearClient.TabIndex = 6015
        Me.bClearClient.UseVisualStyleBackColor = True
        '
        'bAddClient
        '
        Me.bAddClient.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bAddClient.BackgroundImage = CType(resources.GetObject("bAddClient.BackgroundImage"), System.Drawing.Image)
        Me.bAddClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bAddClient.Location = New System.Drawing.Point(3, 286)
        Me.bAddClient.Name = "bAddClient"
        Me.bAddClient.Size = New System.Drawing.Size(50, 50)
        Me.bAddClient.TabIndex = 6016
        Me.bAddClient.UseVisualStyleBackColor = True
        '
        'DataGridViewClient
        '
        Me.DataGridViewClient.AllowUserToAddRows = False
        Me.DataGridViewClient.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewClient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewClient.Location = New System.Drawing.Point(6, 6)
        Me.DataGridViewClient.MultiSelect = False
        Me.DataGridViewClient.Name = "DataGridViewClient"
        Me.DataGridViewClient.ReadOnly = True
        Me.DataGridViewClient.Size = New System.Drawing.Size(835, 343)
        Me.DataGridViewClient.TabIndex = 2
        '
        'TabPageOperation
        '
        Me.TabPageOperation.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TabPageOperation.Controls.Add(Me.PanelOperation)
        Me.TabPageOperation.Controls.Add(Me.DataGridViewOperation)
        Me.TabPageOperation.Location = New System.Drawing.Point(4, 30)
        Me.TabPageOperation.Name = "TabPageOperation"
        Me.TabPageOperation.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageOperation.Size = New System.Drawing.Size(847, 352)
        Me.TabPageOperation.TabIndex = 8
        Me.TabPageOperation.Text = "Операции"
        '
        'PanelOperation
        '
        Me.PanelOperation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelOperation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelOperation.Controls.Add(Me.cbOperationTypeUser)
        Me.PanelOperation.Controls.Add(Me.Label56)
        Me.PanelOperation.Controls.Add(Me.DateTPOperationDate)
        Me.PanelOperation.Controls.Add(Me.cbOperationFKServiceName)
        Me.PanelOperation.Controls.Add(Me.cbOperationFKClientName)
        Me.PanelOperation.Controls.Add(Me.Label33)
        Me.PanelOperation.Controls.Add(Me.Label25)
        Me.PanelOperation.Controls.Add(Me.Label29)
        Me.PanelOperation.Controls.Add(Me.PictureBoxOperation)
        Me.PanelOperation.Controls.Add(Me.LabelOperation)
        Me.PanelOperation.Controls.Add(Me.bClearOperation)
        Me.PanelOperation.Controls.Add(Me.bAddOperation)
        Me.PanelOperation.Location = New System.Drawing.Point(6, 6)
        Me.PanelOperation.Name = "PanelOperation"
        Me.PanelOperation.Size = New System.Drawing.Size(835, 348)
        Me.PanelOperation.TabIndex = 5
        Me.PanelOperation.Visible = False
        '
        'cbOperationTypeUser
        '
        Me.cbOperationTypeUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOperationTypeUser.FormattingEnabled = True
        Me.cbOperationTypeUser.Items.AddRange(New Object() {"Физ", "Юр"})
        Me.cbOperationTypeUser.Location = New System.Drawing.Point(59, 93)
        Me.cbOperationTypeUser.Name = "cbOperationTypeUser"
        Me.cbOperationTypeUser.Size = New System.Drawing.Size(84, 29)
        Me.cbOperationTypeUser.TabIndex = 7000
        '
        'Label56
        '
        Me.Label56.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.White
        Me.Label56.Location = New System.Drawing.Point(55, 68)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(46, 22)
        Me.Label56.TabIndex = 7006
        Me.Label56.Text = "Тип:"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTPOperationDate
        '
        Me.DateTPOperationDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTPOperationDate.Location = New System.Drawing.Point(59, 207)
        Me.DateTPOperationDate.Name = "DateTPOperationDate"
        Me.DateTPOperationDate.Size = New System.Drawing.Size(725, 27)
        Me.DateTPOperationDate.TabIndex = 7003
        '
        'cbOperationFKServiceName
        '
        Me.cbOperationFKServiceName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbOperationFKServiceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOperationFKServiceName.FormattingEnabled = True
        Me.cbOperationFKServiceName.Location = New System.Drawing.Point(59, 150)
        Me.cbOperationFKServiceName.Name = "cbOperationFKServiceName"
        Me.cbOperationFKServiceName.Size = New System.Drawing.Size(725, 29)
        Me.cbOperationFKServiceName.TabIndex = 7002
        '
        'cbOperationFKClientName
        '
        Me.cbOperationFKClientName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbOperationFKClientName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOperationFKClientName.FormattingEnabled = True
        Me.cbOperationFKClientName.Location = New System.Drawing.Point(149, 97)
        Me.cbOperationFKClientName.Name = "cbOperationFKClientName"
        Me.cbOperationFKClientName.Size = New System.Drawing.Size(635, 29)
        Me.cbOperationFKClientName.TabIndex = 7001
        '
        'Label33
        '
        Me.Label33.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(55, 182)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(62, 22)
        Me.Label33.TabIndex = 14
        Me.Label33.Text = "Дата:"
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(55, 127)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 22)
        Me.Label25.TabIndex = 12
        Me.Label25.Text = "Услуга:"
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(145, 72)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(78, 22)
        Me.Label29.TabIndex = 10
        Me.Label29.Text = "Клиент:"
        '
        'PictureBoxOperation
        '
        Me.PictureBoxOperation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxOperation.BackgroundImage = CType(resources.GetObject("PictureBoxOperation.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxOperation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxOperation.Location = New System.Drawing.Point(543, 291)
        Me.PictureBoxOperation.Name = "PictureBoxOperation"
        Me.PictureBoxOperation.Size = New System.Drawing.Size(285, 50)
        Me.PictureBoxOperation.TabIndex = 7
        Me.PictureBoxOperation.TabStop = False
        '
        'LabelOperation
        '
        Me.LabelOperation.AutoSize = True
        Me.LabelOperation.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelOperation.ForeColor = System.Drawing.Color.White
        Me.LabelOperation.Location = New System.Drawing.Point(7, 4)
        Me.LabelOperation.Name = "LabelOperation"
        Me.LabelOperation.Size = New System.Drawing.Size(270, 33)
        Me.LabelOperation.TabIndex = 4
        Me.LabelOperation.Text = "Добавляем запись"
        '
        'bClearOperation
        '
        Me.bClearOperation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bClearOperation.BackgroundImage = CType(resources.GetObject("bClearOperation.BackgroundImage"), System.Drawing.Image)
        Me.bClearOperation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bClearOperation.Location = New System.Drawing.Point(59, 291)
        Me.bClearOperation.Name = "bClearOperation"
        Me.bClearOperation.Size = New System.Drawing.Size(50, 50)
        Me.bClearOperation.TabIndex = 7004
        Me.bClearOperation.UseVisualStyleBackColor = True
        '
        'bAddOperation
        '
        Me.bAddOperation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bAddOperation.BackgroundImage = CType(resources.GetObject("bAddOperation.BackgroundImage"), System.Drawing.Image)
        Me.bAddOperation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bAddOperation.Location = New System.Drawing.Point(3, 291)
        Me.bAddOperation.Name = "bAddOperation"
        Me.bAddOperation.Size = New System.Drawing.Size(50, 50)
        Me.bAddOperation.TabIndex = 7005
        Me.bAddOperation.UseVisualStyleBackColor = True
        '
        'DataGridViewOperation
        '
        Me.DataGridViewOperation.AllowUserToAddRows = False
        Me.DataGridViewOperation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewOperation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewOperation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOperation.Location = New System.Drawing.Point(6, 6)
        Me.DataGridViewOperation.MultiSelect = False
        Me.DataGridViewOperation.Name = "DataGridViewOperation"
        Me.DataGridViewOperation.ReadOnly = True
        Me.DataGridViewOperation.Size = New System.Drawing.Size(835, 348)
        Me.DataGridViewOperation.TabIndex = 2
        '
        'TabPageUsers
        '
        Me.TabPageUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TabPageUsers.Controls.Add(Me.PanelLogon)
        Me.TabPageUsers.Controls.Add(Me.DataGridViewLogon)
        Me.TabPageUsers.Location = New System.Drawing.Point(4, 30)
        Me.TabPageUsers.Name = "TabPageUsers"
        Me.TabPageUsers.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageUsers.Size = New System.Drawing.Size(847, 352)
        Me.TabPageUsers.TabIndex = 9
        Me.TabPageUsers.Text = "Пользователи"
        '
        'PanelLogon
        '
        Me.PanelLogon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelLogon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelLogon.Controls.Add(Me.cbLogonType)
        Me.PanelLogon.Controls.Add(Me.Label34)
        Me.PanelLogon.Controls.Add(Me.tbLogonPassword)
        Me.PanelLogon.Controls.Add(Me.tbLogonLogin)
        Me.PanelLogon.Controls.Add(Me.Label35)
        Me.PanelLogon.Controls.Add(Me.Label36)
        Me.PanelLogon.Controls.Add(Me.PictureBoxUsers)
        Me.PanelLogon.Controls.Add(Me.LabelLogon)
        Me.PanelLogon.Controls.Add(Me.bClearLogon)
        Me.PanelLogon.Controls.Add(Me.bAddLogon)
        Me.PanelLogon.Location = New System.Drawing.Point(6, 6)
        Me.PanelLogon.Name = "PanelLogon"
        Me.PanelLogon.Size = New System.Drawing.Size(835, 348)
        Me.PanelLogon.TabIndex = 3
        Me.PanelLogon.Visible = False
        '
        'cbLogonType
        '
        Me.cbLogonType.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbLogonType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLogonType.FormattingEnabled = True
        Me.cbLogonType.Items.AddRange(New Object() {"Администратор", "Пользователь"})
        Me.cbLogonType.Location = New System.Drawing.Point(59, 207)
        Me.cbLogonType.Name = "cbLogonType"
        Me.cbLogonType.Size = New System.Drawing.Size(725, 29)
        Me.cbLogonType.TabIndex = 8003
        '
        'Label34
        '
        Me.Label34.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(55, 182)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(172, 22)
        Me.Label34.TabIndex = 26
        Me.Label34.Text = "Тип пользователя:"
        '
        'tbLogonPassword
        '
        Me.tbLogonPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbLogonPassword.Location = New System.Drawing.Point(59, 152)
        Me.tbLogonPassword.MaxLength = 100
        Me.tbLogonPassword.Name = "tbLogonPassword"
        Me.tbLogonPassword.Size = New System.Drawing.Size(725, 27)
        Me.tbLogonPassword.TabIndex = 8002
        '
        'tbLogonLogin
        '
        Me.tbLogonLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbLogonLogin.Location = New System.Drawing.Point(59, 97)
        Me.tbLogonLogin.MaxLength = 100
        Me.tbLogonLogin.Name = "tbLogonLogin"
        Me.tbLogonLogin.Size = New System.Drawing.Size(725, 27)
        Me.tbLogonLogin.TabIndex = 8001
        '
        'Label35
        '
        Me.Label35.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(55, 127)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(85, 22)
        Me.Label35.TabIndex = 20
        Me.Label35.Text = "Пароль:"
        '
        'Label36
        '
        Me.Label36.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(55, 72)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(54, 22)
        Me.Label36.TabIndex = 19
        Me.Label36.Text = "Имя:"
        '
        'PictureBoxUsers
        '
        Me.PictureBoxUsers.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxUsers.BackgroundImage = CType(resources.GetObject("PictureBoxUsers.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxUsers.Location = New System.Drawing.Point(543, 291)
        Me.PictureBoxUsers.Name = "PictureBoxUsers"
        Me.PictureBoxUsers.Size = New System.Drawing.Size(285, 50)
        Me.PictureBoxUsers.TabIndex = 7
        Me.PictureBoxUsers.TabStop = False
        '
        'LabelLogon
        '
        Me.LabelLogon.AutoSize = True
        Me.LabelLogon.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelLogon.ForeColor = System.Drawing.Color.White
        Me.LabelLogon.Location = New System.Drawing.Point(7, 4)
        Me.LabelLogon.Name = "LabelLogon"
        Me.LabelLogon.Size = New System.Drawing.Size(270, 33)
        Me.LabelLogon.TabIndex = 4
        Me.LabelLogon.Text = "Добавляем запись"
        '
        'bClearLogon
        '
        Me.bClearLogon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bClearLogon.BackgroundImage = CType(resources.GetObject("bClearLogon.BackgroundImage"), System.Drawing.Image)
        Me.bClearLogon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bClearLogon.Location = New System.Drawing.Point(59, 291)
        Me.bClearLogon.Name = "bClearLogon"
        Me.bClearLogon.Size = New System.Drawing.Size(50, 50)
        Me.bClearLogon.TabIndex = 8004
        Me.bClearLogon.UseVisualStyleBackColor = True
        '
        'bAddLogon
        '
        Me.bAddLogon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bAddLogon.BackgroundImage = CType(resources.GetObject("bAddLogon.BackgroundImage"), System.Drawing.Image)
        Me.bAddLogon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bAddLogon.Location = New System.Drawing.Point(3, 291)
        Me.bAddLogon.Name = "bAddLogon"
        Me.bAddLogon.Size = New System.Drawing.Size(50, 50)
        Me.bAddLogon.TabIndex = 8005
        Me.bAddLogon.UseVisualStyleBackColor = True
        '
        'DataGridViewLogon
        '
        Me.DataGridViewLogon.AllowUserToAddRows = False
        Me.DataGridViewLogon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewLogon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewLogon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewLogon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewLogon.Location = New System.Drawing.Point(6, 6)
        Me.DataGridViewLogon.MultiSelect = False
        Me.DataGridViewLogon.Name = "DataGridViewLogon"
        Me.DataGridViewLogon.ReadOnly = True
        Me.DataGridViewLogon.Size = New System.Drawing.Size(835, 348)
        Me.DataGridViewLogon.TabIndex = 2
        '
        'TabPageServiceOperation
        '
        Me.TabPageServiceOperation.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TabPageServiceOperation.Controls.Add(Me.DataGridViewServiceOpeartion)
        Me.TabPageServiceOperation.Location = New System.Drawing.Point(4, 30)
        Me.TabPageServiceOperation.Name = "TabPageServiceOperation"
        Me.TabPageServiceOperation.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageServiceOperation.Size = New System.Drawing.Size(847, 352)
        Me.TabPageServiceOperation.TabIndex = 10
        Me.TabPageServiceOperation.Text = "Услуги-операции"
        '
        'DataGridViewServiceOpeartion
        '
        Me.DataGridViewServiceOpeartion.AllowUserToAddRows = False
        Me.DataGridViewServiceOpeartion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewServiceOpeartion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewServiceOpeartion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewServiceOpeartion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewServiceOpeartion.Location = New System.Drawing.Point(6, 6)
        Me.DataGridViewServiceOpeartion.MultiSelect = False
        Me.DataGridViewServiceOpeartion.Name = "DataGridViewServiceOpeartion"
        Me.DataGridViewServiceOpeartion.ReadOnly = True
        Me.DataGridViewServiceOpeartion.Size = New System.Drawing.Size(835, 348)
        Me.DataGridViewServiceOpeartion.TabIndex = 3
        '
        'TabPageServices
        '
        Me.TabPageServices.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TabPageServices.Controls.Add(Me.TabControlUserFunctional)
        Me.TabPageServices.Location = New System.Drawing.Point(4, 30)
        Me.TabPageServices.Name = "TabPageServices"
        Me.TabPageServices.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageServices.Size = New System.Drawing.Size(939, 392)
        Me.TabPageServices.TabIndex = 1
        Me.TabPageServices.Text = "Услуги"
        '
        'TabControlUserFunctional
        '
        Me.TabControlUserFunctional.Controls.Add(Me.TabPageCredits)
        Me.TabControlUserFunctional.Controls.Add(Me.TabPagePapers)
        Me.TabControlUserFunctional.Controls.Add(Me.TabPageSearch)
        Me.TabControlUserFunctional.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlUserFunctional.Location = New System.Drawing.Point(3, 3)
        Me.TabControlUserFunctional.Name = "TabControlUserFunctional"
        Me.TabControlUserFunctional.SelectedIndex = 0
        Me.TabControlUserFunctional.Size = New System.Drawing.Size(933, 386)
        Me.TabControlUserFunctional.TabIndex = 0
        '
        'TabPageCredits
        '
        Me.TabPageCredits.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TabPageCredits.Controls.Add(Me.LabelResultInf)
        Me.TabPageCredits.Controls.Add(Me.LabelMonthPrice)
        Me.TabPageCredits.Controls.Add(Me.Label45)
        Me.TabPageCredits.Controls.Add(Me.LabelAllPrice)
        Me.TabPageCredits.Controls.Add(Me.Label43)
        Me.TabPageCredits.Controls.Add(Me.bCalculation)
        Me.TabPageCredits.Controls.Add(Me.Label42)
        Me.TabPageCredits.Controls.Add(Me.NumericUDCreditsPercent)
        Me.TabPageCredits.Controls.Add(Me.NumericUDCreditsMonth)
        Me.TabPageCredits.Controls.Add(Me.Label41)
        Me.TabPageCredits.Controls.Add(Me.Label39)
        Me.TabPageCredits.Controls.Add(Me.cbCreditsCurrency)
        Me.TabPageCredits.Controls.Add(Me.Label38)
        Me.TabPageCredits.Controls.Add(Me.NumericUDCreditsSumm)
        Me.TabPageCredits.Controls.Add(Me.Label37)
        Me.TabPageCredits.Controls.Add(Me.Label40)
        Me.TabPageCredits.Controls.Add(Me.PictureBoxCredits)
        Me.TabPageCredits.Location = New System.Drawing.Point(4, 30)
        Me.TabPageCredits.Name = "TabPageCredits"
        Me.TabPageCredits.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCredits.Size = New System.Drawing.Size(925, 352)
        Me.TabPageCredits.TabIndex = 1
        Me.TabPageCredits.Text = "Расчет суммы платежа и кредита"
        '
        'LabelResultInf
        '
        Me.LabelResultInf.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelResultInf.AutoSize = True
        Me.LabelResultInf.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelResultInf.ForeColor = System.Drawing.Color.White
        Me.LabelResultInf.Location = New System.Drawing.Point(66, 262)
        Me.LabelResultInf.Name = "LabelResultInf"
        Me.LabelResultInf.Size = New System.Drawing.Size(575, 30)
        Me.LabelResultInf.TabIndex = 46
        Me.LabelResultInf.Text = "Для 0 бел. руб (BYN) на 0 мес. при 0% годовых"
        Me.LabelResultInf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabelResultInf.Visible = False
        '
        'LabelMonthPrice
        '
        Me.LabelMonthPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelMonthPrice.AutoSize = True
        Me.LabelMonthPrice.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelMonthPrice.ForeColor = System.Drawing.Color.White
        Me.LabelMonthPrice.Location = New System.Drawing.Point(569, 217)
        Me.LabelMonthPrice.Name = "LabelMonthPrice"
        Me.LabelMonthPrice.Size = New System.Drawing.Size(163, 30)
        Me.LabelMonthPrice.TabIndex = 45
        Me.LabelMonthPrice.Text = "206 бел. руб"
        Me.LabelMonthPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabelMonthPrice.Visible = False
        '
        'Label45
        '
        Me.Label45.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.White
        Me.Label45.Location = New System.Drawing.Point(566, 187)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(280, 30)
        Me.Label45.TabIndex = 44
        Me.Label45.Text = "Ежемесячный платеж:"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelAllPrice
        '
        Me.LabelAllPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelAllPrice.AutoSize = True
        Me.LabelAllPrice.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelAllPrice.ForeColor = System.Drawing.Color.White
        Me.LabelAllPrice.Location = New System.Drawing.Point(66, 217)
        Me.LabelAllPrice.Name = "LabelAllPrice"
        Me.LabelAllPrice.Size = New System.Drawing.Size(248, 30)
        Me.LabelAllPrice.TabIndex = 43
        Me.LabelAllPrice.Text = "2 471 бел. руб(BYN)"
        Me.LabelAllPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabelAllPrice.Visible = False
        '
        'Label43
        '
        Me.Label43.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.White
        Me.Label43.Location = New System.Drawing.Point(66, 187)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(228, 30)
        Me.Label43.TabIndex = 42
        Me.Label43.Text = "Итоговая выплата:"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bCalculation
        '
        Me.bCalculation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCalculation.Location = New System.Drawing.Point(22, 305)
        Me.bCalculation.Name = "bCalculation"
        Me.bCalculation.Size = New System.Drawing.Size(606, 49)
        Me.bCalculation.TabIndex = 41
        Me.bCalculation.Text = "Расчет суммы кредита по представленным данным"
        Me.bCalculation.UseVisualStyleBackColor = True
        '
        'Label42
        '
        Me.Label42.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.White
        Me.Label42.Location = New System.Drawing.Point(750, 107)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(71, 22)
        Me.Label42.TabIndex = 40
        Me.Label42.Text = "%, год:"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericUDCreditsPercent
        '
        Me.NumericUDCreditsPercent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumericUDCreditsPercent.DecimalPlaces = 1
        Me.NumericUDCreditsPercent.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUDCreditsPercent.Location = New System.Drawing.Point(754, 132)
        Me.NumericUDCreditsPercent.Name = "NumericUDCreditsPercent"
        Me.HelpProviderBankServices.SetShowHelp(Me.NumericUDCreditsPercent, False)
        Me.NumericUDCreditsPercent.Size = New System.Drawing.Size(115, 27)
        Me.NumericUDCreditsPercent.TabIndex = 39
        Me.NumericUDCreditsPercent.ThousandsSeparator = True
        '
        'NumericUDCreditsMonth
        '
        Me.NumericUDCreditsMonth.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumericUDCreditsMonth.Location = New System.Drawing.Point(571, 132)
        Me.NumericUDCreditsMonth.Maximum = New Decimal(New Integer() {240, 0, 0, 0})
        Me.NumericUDCreditsMonth.Name = "NumericUDCreditsMonth"
        Me.NumericUDCreditsMonth.Size = New System.Drawing.Size(115, 27)
        Me.NumericUDCreditsMonth.TabIndex = 38
        '
        'Label41
        '
        Me.Label41.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.White
        Me.Label41.Location = New System.Drawing.Point(567, 107)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(65, 22)
        Me.Label41.TabIndex = 37
        Me.Label41.Text = "Срок:"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label39
        '
        Me.Label39.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(692, 139)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(56, 22)
        Me.Label39.TabIndex = 36
        Me.Label39.Text = "мес."
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbCreditsCurrency
        '
        Me.cbCreditsCurrency.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbCreditsCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCreditsCurrency.FormattingEnabled = True
        Me.cbCreditsCurrency.Items.AddRange(New Object() {"Доллар США", "Евро", "Белорусский рубль", "Российский рубль"})
        Me.cbCreditsCurrency.Location = New System.Drawing.Point(321, 132)
        Me.cbCreditsCurrency.Name = "cbCreditsCurrency"
        Me.cbCreditsCurrency.Size = New System.Drawing.Size(244, 29)
        Me.cbCreditsCurrency.TabIndex = 33
        '
        'Label38
        '
        Me.Label38.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.White
        Me.Label38.Location = New System.Drawing.Point(317, 108)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(85, 22)
        Me.Label38.TabIndex = 32
        Me.Label38.Text = "Валюта:"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericUDCreditsSumm
        '
        Me.NumericUDCreditsSumm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumericUDCreditsSumm.Location = New System.Drawing.Point(71, 133)
        Me.NumericUDCreditsSumm.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUDCreditsSumm.Name = "NumericUDCreditsSumm"
        Me.NumericUDCreditsSumm.Size = New System.Drawing.Size(244, 27)
        Me.NumericUDCreditsSumm.TabIndex = 31
        '
        'Label37
        '
        Me.Label37.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(67, 108)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(88, 22)
        Me.Label37.TabIndex = 30
        Me.Label37.Text = "Сумма:"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.White
        Me.Label40.Location = New System.Drawing.Point(17, 3)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(468, 30)
        Me.Label40.TabIndex = 29
        Me.Label40.Text = "Универсальный калькулятор кредитов"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBoxCredits
        '
        Me.PictureBoxCredits.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxCredits.BackgroundImage = CType(resources.GetObject("PictureBoxCredits.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxCredits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxCredits.Location = New System.Drawing.Point(634, 304)
        Me.PictureBoxCredits.Name = "PictureBoxCredits"
        Me.PictureBoxCredits.Size = New System.Drawing.Size(285, 50)
        Me.PictureBoxCredits.TabIndex = 6
        Me.PictureBoxCredits.TabStop = False
        '
        'TabPagePapers
        '
        Me.TabPagePapers.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TabPagePapers.Controls.Add(Me.cbPapersTypeClient)
        Me.TabPagePapers.Controls.Add(Me.Label55)
        Me.TabPagePapers.Controls.Add(Me.cbPapersTypeCurrency)
        Me.TabPagePapers.Controls.Add(Me.Label51)
        Me.TabPagePapers.Controls.Add(Me.Label50)
        Me.TabPagePapers.Controls.Add(Me.cbPapersClientFIO)
        Me.TabPagePapers.Controls.Add(Me.Label44)
        Me.TabPagePapers.Controls.Add(Me.DateTPPapersDataReg)
        Me.TabPagePapers.Controls.Add(Me.Label49)
        Me.TabPagePapers.Controls.Add(Me.NumericUDPapersTime)
        Me.TabPagePapers.Controls.Add(Me.Label48)
        Me.TabPagePapers.Controls.Add(Me.NumericUDPapersSumm)
        Me.TabPagePapers.Controls.Add(Me.Label47)
        Me.TabPagePapers.Controls.Add(Me.Label46)
        Me.TabPagePapers.Controls.Add(Me.cbPapersType)
        Me.TabPagePapers.Controls.Add(Me.bRegistr)
        Me.TabPagePapers.Controls.Add(Me.rtbPapersClient)
        Me.TabPagePapers.Controls.Add(Me.PictureBoxPapers)
        Me.TabPagePapers.Location = New System.Drawing.Point(4, 30)
        Me.TabPagePapers.Name = "TabPagePapers"
        Me.TabPagePapers.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePapers.Size = New System.Drawing.Size(925, 352)
        Me.TabPagePapers.TabIndex = 2
        Me.TabPagePapers.Text = "Оформление кредита и вклада"
        '
        'cbPapersTypeClient
        '
        Me.cbPapersTypeClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPapersTypeClient.FormattingEnabled = True
        Me.cbPapersTypeClient.Items.AddRange(New Object() {"Физ", "Юр"})
        Me.cbPapersTypeClient.Location = New System.Drawing.Point(25, 34)
        Me.cbPapersTypeClient.Name = "cbPapersTypeClient"
        Me.cbPapersTypeClient.Size = New System.Drawing.Size(84, 29)
        Me.cbPapersTypeClient.TabIndex = 2010
        '
        'Label55
        '
        Me.Label55.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.White
        Me.Label55.Location = New System.Drawing.Point(21, 9)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(46, 22)
        Me.Label55.TabIndex = 2009
        Me.Label55.Text = "Тип:"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbPapersTypeCurrency
        '
        Me.cbPapersTypeCurrency.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbPapersTypeCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPapersTypeCurrency.FormattingEnabled = True
        Me.cbPapersTypeCurrency.Items.AddRange(New Object() {"Доллар США", "Евро", "Белорусский рубль", "Российский рубль"})
        Me.cbPapersTypeCurrency.Location = New System.Drawing.Point(634, 146)
        Me.cbPapersTypeCurrency.Name = "cbPapersTypeCurrency"
        Me.cbPapersTypeCurrency.Size = New System.Drawing.Size(285, 29)
        Me.cbPapersTypeCurrency.TabIndex = 2005
        '
        'Label51
        '
        Me.Label51.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.White
        Me.Label51.Location = New System.Drawing.Point(21, 66)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(244, 22)
        Me.Label51.TabIndex = 55
        Me.Label51.Text = "Информация о клиенте:"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label50
        '
        Me.Label50.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.White
        Me.Label50.Location = New System.Drawing.Point(634, 121)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(216, 22)
        Me.Label50.TabIndex = 54
        Me.Label50.Text = "Выберите тип валюты:"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbPapersClientFIO
        '
        Me.cbPapersClientFIO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbPapersClientFIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPapersClientFIO.FormattingEnabled = True
        Me.cbPapersClientFIO.Items.AddRange(New Object() {"Кредит", "Вклад"})
        Me.cbPapersClientFIO.Location = New System.Drawing.Point(115, 34)
        Me.cbPapersClientFIO.Name = "cbPapersClientFIO"
        Me.cbPapersClientFIO.Size = New System.Drawing.Size(513, 29)
        Me.cbPapersClientFIO.TabIndex = 2001
        '
        'Label44
        '
        Me.Label44.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.White
        Me.Label44.Location = New System.Drawing.Point(111, 9)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(188, 22)
        Me.Label44.TabIndex = 51
        Me.Label44.Text = "Выберите клиента:"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTPPapersDataReg
        '
        Me.DateTPPapersDataReg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTPPapersDataReg.Location = New System.Drawing.Point(634, 258)
        Me.DateTPPapersDataReg.Name = "DateTPPapersDataReg"
        Me.DateTPPapersDataReg.Size = New System.Drawing.Size(285, 27)
        Me.DateTPPapersDataReg.TabIndex = 2007
        '
        'Label49
        '
        Me.Label49.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.White
        Me.Label49.Location = New System.Drawing.Point(630, 233)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(195, 22)
        Me.Label49.TabIndex = 49
        Me.Label49.Text = "Дата оформления:"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericUDPapersTime
        '
        Me.NumericUDPapersTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUDPapersTime.Location = New System.Drawing.Point(634, 203)
        Me.NumericUDPapersTime.Maximum = New Decimal(New Integer() {240, 0, 0, 0})
        Me.NumericUDPapersTime.Name = "NumericUDPapersTime"
        Me.NumericUDPapersTime.Size = New System.Drawing.Size(285, 27)
        Me.NumericUDPapersTime.TabIndex = 2006
        '
        'Label48
        '
        Me.Label48.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(634, 178)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(125, 22)
        Me.Label48.TabIndex = 47
        Me.Label48.Text = "Срок(мес.):"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericUDPapersSumm
        '
        Me.NumericUDPapersSumm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUDPapersSumm.DecimalPlaces = 1
        Me.NumericUDPapersSumm.Location = New System.Drawing.Point(634, 91)
        Me.NumericUDPapersSumm.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUDPapersSumm.Name = "NumericUDPapersSumm"
        Me.NumericUDPapersSumm.Size = New System.Drawing.Size(285, 27)
        Me.NumericUDPapersSumm.TabIndex = 2004
        '
        'Label47
        '
        Me.Label47.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.White
        Me.Label47.Location = New System.Drawing.Point(634, 66)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(88, 22)
        Me.Label47.TabIndex = 45
        Me.Label47.Text = "Сумма:"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label46
        '
        Me.Label46.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.White
        Me.Label46.Location = New System.Drawing.Point(630, 9)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(143, 22)
        Me.Label46.TabIndex = 44
        Me.Label46.Text = "Выберите тип:"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbPapersType
        '
        Me.cbPapersType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbPapersType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPapersType.FormattingEnabled = True
        Me.cbPapersType.Items.AddRange(New Object() {"Кредит", "Вклад"})
        Me.cbPapersType.Location = New System.Drawing.Point(634, 34)
        Me.cbPapersType.Name = "cbPapersType"
        Me.cbPapersType.Size = New System.Drawing.Size(285, 29)
        Me.cbPapersType.TabIndex = 2003
        '
        'bRegistr
        '
        Me.bRegistr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bRegistr.Location = New System.Drawing.Point(25, 305)
        Me.bRegistr.Name = "bRegistr"
        Me.bRegistr.Size = New System.Drawing.Size(603, 49)
        Me.bRegistr.TabIndex = 2008
        Me.bRegistr.Text = "Оформить и вывести на печать"
        Me.bRegistr.UseVisualStyleBackColor = True
        '
        'rtbPapersClient
        '
        Me.rtbPapersClient.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbPapersClient.Location = New System.Drawing.Point(25, 91)
        Me.rtbPapersClient.Name = "rtbPapersClient"
        Me.rtbPapersClient.ReadOnly = True
        Me.rtbPapersClient.Size = New System.Drawing.Size(603, 202)
        Me.rtbPapersClient.TabIndex = 2002
        Me.rtbPapersClient.Text = ""
        '
        'PictureBoxPapers
        '
        Me.PictureBoxPapers.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxPapers.BackgroundImage = CType(resources.GetObject("PictureBoxPapers.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxPapers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxPapers.Location = New System.Drawing.Point(634, 304)
        Me.PictureBoxPapers.Name = "PictureBoxPapers"
        Me.PictureBoxPapers.Size = New System.Drawing.Size(285, 50)
        Me.PictureBoxPapers.TabIndex = 6
        Me.PictureBoxPapers.TabStop = False
        '
        'TabPageSearch
        '
        Me.TabPageSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TabPageSearch.Controls.Add(Me.bSearchLoadTable)
        Me.TabPageSearch.Controls.Add(Me.bNavigatorSearch)
        Me.TabPageSearch.Controls.Add(Me.DataGridViewSearch)
        Me.TabPageSearch.Controls.Add(Me.bSearch)
        Me.TabPageSearch.Controls.Add(Me.tbSearch)
        Me.TabPageSearch.Controls.Add(Me.Label54)
        Me.TabPageSearch.Controls.Add(Me.cbSearchColumn)
        Me.TabPageSearch.Controls.Add(Me.Label53)
        Me.TabPageSearch.Controls.Add(Me.cbSearchTables)
        Me.TabPageSearch.Controls.Add(Me.Label52)
        Me.TabPageSearch.Controls.Add(Me.PictureBoxSearch)
        Me.TabPageSearch.Location = New System.Drawing.Point(4, 30)
        Me.TabPageSearch.Name = "TabPageSearch"
        Me.TabPageSearch.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSearch.Size = New System.Drawing.Size(925, 352)
        Me.TabPageSearch.TabIndex = 3
        Me.TabPageSearch.Text = "Поиск"
        '
        'bSearchLoadTable
        '
        Me.bSearchLoadTable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSearchLoadTable.Location = New System.Drawing.Point(634, 148)
        Me.bSearchLoadTable.Name = "bSearchLoadTable"
        Me.bSearchLoadTable.Size = New System.Drawing.Size(285, 36)
        Me.bSearchLoadTable.TabIndex = 2015
        Me.bSearchLoadTable.Text = "Загрузить"
        Me.bSearchLoadTable.UseVisualStyleBackColor = True
        '
        'bNavigatorSearch
        '
        Me.bNavigatorSearch.AddNewItem = Nothing
        Me.bNavigatorSearch.CountItem = Me.BindingNavigatorCountItem1
        Me.bNavigatorSearch.DeleteItem = Nothing
        Me.bNavigatorSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.bNavigatorSearch.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator2, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator4, Me.bSearchPrint})
        Me.bNavigatorSearch.Location = New System.Drawing.Point(3, 3)
        Me.bNavigatorSearch.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.bNavigatorSearch.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.bNavigatorSearch.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.bNavigatorSearch.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.bNavigatorSearch.Name = "bNavigatorSearch"
        Me.bNavigatorSearch.PositionItem = Me.BindingNavigatorPositionItem1
        Me.bNavigatorSearch.Size = New System.Drawing.Size(919, 25)
        Me.bNavigatorSearch.TabIndex = 2014
        Me.bNavigatorSearch.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(49, 22)
        Me.BindingNavigatorCountItem1.Text = "для {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'bSearchPrint
        '
        Me.bSearchPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bSearchPrint.Image = CType(resources.GetObject("bSearchPrint.Image"), System.Drawing.Image)
        Me.bSearchPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bSearchPrint.Name = "bSearchPrint"
        Me.bSearchPrint.Size = New System.Drawing.Size(23, 22)
        Me.bSearchPrint.Text = "Печать"
        '
        'DataGridViewSearch
        '
        Me.DataGridViewSearch.AllowUserToAddRows = False
        Me.DataGridViewSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSearch.Location = New System.Drawing.Point(6, 31)
        Me.DataGridViewSearch.MultiSelect = False
        Me.DataGridViewSearch.Name = "DataGridViewSearch"
        Me.DataGridViewSearch.ReadOnly = True
        Me.DataGridViewSearch.Size = New System.Drawing.Size(622, 323)
        Me.DataGridViewSearch.TabIndex = 2013
        '
        'bSearch
        '
        Me.bSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSearch.Location = New System.Drawing.Point(634, 249)
        Me.bSearch.Name = "bSearch"
        Me.bSearch.Size = New System.Drawing.Size(285, 36)
        Me.bSearch.TabIndex = 2009
        Me.bSearch.Text = "Поиск"
        Me.bSearch.UseVisualStyleBackColor = True
        '
        'tbSearch
        '
        Me.tbSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSearch.Location = New System.Drawing.Point(634, 216)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(285, 27)
        Me.tbSearch.TabIndex = 2008
        '
        'Label54
        '
        Me.Label54.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.White
        Me.Label54.Location = New System.Drawing.Point(630, 191)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(151, 22)
        Me.Label54.TabIndex = 2007
        Me.Label54.Text = "Искомый текс:"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbSearchColumn
        '
        Me.cbSearchColumn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSearchColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSearchColumn.FormattingEnabled = True
        Me.cbSearchColumn.Items.AddRange(New Object() {"Кредит", "Вклад"})
        Me.cbSearchColumn.Location = New System.Drawing.Point(634, 113)
        Me.cbSearchColumn.Name = "cbSearchColumn"
        Me.cbSearchColumn.Size = New System.Drawing.Size(285, 29)
        Me.cbSearchColumn.TabIndex = 2006
        '
        'Label53
        '
        Me.Label53.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.White
        Me.Label53.Location = New System.Drawing.Point(630, 88)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(191, 22)
        Me.Label53.TabIndex = 2005
        Me.Label53.Text = "Выберите столбец:"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbSearchTables
        '
        Me.cbSearchTables.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSearchTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSearchTables.FormattingEnabled = True
        Me.cbSearchTables.Items.AddRange(New Object() {"Кредит", "Вклад"})
        Me.cbSearchTables.Location = New System.Drawing.Point(634, 56)
        Me.cbSearchTables.Name = "cbSearchTables"
        Me.cbSearchTables.Size = New System.Drawing.Size(285, 29)
        Me.cbSearchTables.TabIndex = 2004
        '
        'Label52
        '
        Me.Label52.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.White
        Me.Label52.Location = New System.Drawing.Point(634, 31)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(191, 22)
        Me.Label52.TabIndex = 52
        Me.Label52.Text = "Выберите таблицу:"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBoxSearch
        '
        Me.PictureBoxSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxSearch.BackgroundImage = CType(resources.GetObject("PictureBoxSearch.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxSearch.Location = New System.Drawing.Point(634, 304)
        Me.PictureBoxSearch.Name = "PictureBoxSearch"
        Me.PictureBoxSearch.Size = New System.Drawing.Size(285, 50)
        Me.PictureBoxSearch.TabIndex = 7
        Me.PictureBoxSearch.TabStop = False
        '
        'bNavigatorBankServices
        '
        Me.bNavigatorBankServices.AddNewItem = Nothing
        Me.bNavigatorBankServices.CountItem = Me.BindingNavigatorCountItem
        Me.bNavigatorBankServices.DeleteItem = Nothing
        Me.bNavigatorBankServices.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.bNavigatorBankServices.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.ToolStripSeparator1, Me.bPrint, Me.ToolStripSeparator2})
        Me.bNavigatorBankServices.Location = New System.Drawing.Point(0, 25)
        Me.bNavigatorBankServices.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bNavigatorBankServices.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bNavigatorBankServices.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bNavigatorBankServices.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bNavigatorBankServices.Name = "bNavigatorBankServices"
        Me.bNavigatorBankServices.PositionItem = Me.BindingNavigatorPositionItem
        Me.bNavigatorBankServices.Size = New System.Drawing.Size(947, 25)
        Me.bNavigatorBankServices.TabIndex = 2
        Me.bNavigatorBankServices.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(49, 22)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Переместить в конец"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'bPrint
        '
        Me.bPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bPrint.Image = CType(resources.GetObject("bPrint.Image"), System.Drawing.Image)
        Me.bPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bPrint.Name = "bPrint"
        Me.bPrint.Size = New System.Drawing.Size(23, 22)
        Me.bPrint.Text = "Печать"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(947, 476)
        Me.Controls.Add(Me.TabControlMain)
        Me.Controls.Add(Me.bNavigatorBankServices)
        Me.Controls.Add(Me.MenuStripBankServices)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStripBankServices
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Технобанк"
        Me.MenuStripBankServices.ResumeLayout(False)
        Me.MenuStripBankServices.PerformLayout()
        Me.TabControlMain.ResumeLayout(False)
        Me.TabPageTables.ResumeLayout(False)
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlTables.ResumeLayout(False)
        Me.TabPageTypeService.ResumeLayout(False)
        Me.PanelTypeService.ResumeLayout(False)
        Me.PanelTypeService.PerformLayout()
        CType(Me.PictureBoxTypeService, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewTypeService, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageDepartment.ResumeLayout(False)
        Me.PanelDepartment.ResumeLayout(False)
        Me.PanelDepartment.PerformLayout()
        CType(Me.NumericUDApartment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxDepartment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewDepartment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageDocuments.ResumeLayout(False)
        Me.PanelDocuments.ResumeLayout(False)
        Me.PanelDocuments.PerformLayout()
        CType(Me.PictureBoxDocuments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewDocuments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageWorker.ResumeLayout(False)
        Me.PanelWorker.ResumeLayout(False)
        Me.PanelWorker.PerformLayout()
        CType(Me.NumericUDWorkerExp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUDWorkerRank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxWorker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewWorker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageService.ResumeLayout(False)
        Me.PanelService.ResumeLayout(False)
        Me.PanelService.PerformLayout()
        CType(Me.NumericUDServicePrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxService, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewService, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageClient.ResumeLayout(False)
        Me.PanelClient.ResumeLayout(False)
        Me.PanelClient.PerformLayout()
        CType(Me.NumericUDClientNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxClient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageOperation.ResumeLayout(False)
        Me.PanelOperation.ResumeLayout(False)
        Me.PanelOperation.PerformLayout()
        CType(Me.PictureBoxOperation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewOperation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageUsers.ResumeLayout(False)
        Me.PanelLogon.ResumeLayout(False)
        Me.PanelLogon.PerformLayout()
        CType(Me.PictureBoxUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewLogon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageServiceOperation.ResumeLayout(False)
        CType(Me.DataGridViewServiceOpeartion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageServices.ResumeLayout(False)
        Me.TabControlUserFunctional.ResumeLayout(False)
        Me.TabPageCredits.ResumeLayout(False)
        Me.TabPageCredits.PerformLayout()
        CType(Me.NumericUDCreditsPercent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUDCreditsMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUDCreditsSumm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCredits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePapers.ResumeLayout(False)
        Me.TabPagePapers.PerformLayout()
        CType(Me.NumericUDPapersTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUDPapersSumm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPapers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageSearch.ResumeLayout(False)
        Me.TabPageSearch.PerformLayout()
        CType(Me.bNavigatorSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bNavigatorSearch.ResumeLayout(False)
        Me.bNavigatorSearch.PerformLayout()
        CType(Me.DataGridViewSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bNavigatorBankServices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bNavigatorBankServices.ResumeLayout(False)
        Me.bNavigatorBankServices.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStripBankServices As MenuStrip
    Friend WithEvents МенюToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents НастройкиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ИнформацияToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОПрограммеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents СправкаF1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents АвторизацияToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ВыходToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControlMain As TabControl
    Friend WithEvents TabPageTables As TabPage
    Friend WithEvents TabPageServices As TabPage
    Friend WithEvents bNavigatorBankServices As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents TabControlTables As TabControl
    Friend WithEvents TabPageTypeService As TabPage
    Friend WithEvents TabPageDepartment As TabPage
    Friend WithEvents TabPageDocuments As TabPage
    Friend WithEvents TabPageWorker As TabPage
    Friend WithEvents TabPageService As TabPage
    Friend WithEvents TabPageClient As TabPage
    Friend WithEvents TabPageOperation As TabPage
    Friend WithEvents TabPageUsers As TabPage
    Friend WithEvents DataGridViewTypeService As DataGridView
    Friend WithEvents DataGridViewDepartment As DataGridView
    Friend WithEvents DataGridViewDocuments As DataGridView
    Friend WithEvents DataGridViewWorker As DataGridView
    Friend WithEvents DataGridViewService As DataGridView
    Friend WithEvents DataGridViewClient As DataGridView
    Friend WithEvents DataGridViewOperation As DataGridView
    Friend WithEvents DataGridViewLogon As DataGridView
    Friend WithEvents bCloseDelete As Button
    Friend WithEvents bEdit As Button
    Friend WithEvents bOpenPanel As Button
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents PanelLogon As Panel
    Friend WithEvents bAddLogon As Button
    Friend WithEvents bClearLogon As Button
    Friend WithEvents LabelLogon As Label
    Friend WithEvents PanelTypeService As Panel
    Friend WithEvents LabelTypeService As Label
    Friend WithEvents bClearTypeService As Button
    Friend WithEvents bAddTypeService As Button
    Friend WithEvents PanelDepartment As Panel
    Friend WithEvents LabelDepartment As Label
    Friend WithEvents bClearDepartment As Button
    Friend WithEvents bAddDepartment As Button
    Friend WithEvents PanelDocuments As Panel
    Friend WithEvents LabelDocuments As Label
    Friend WithEvents bClearDocuments As Button
    Friend WithEvents bAddDocuments As Button
    Friend WithEvents PanelWorker As Panel
    Friend WithEvents LabelWorker As Label
    Friend WithEvents bClearWorker As Button
    Friend WithEvents bAddWorker As Button
    Friend WithEvents PanelService As Panel
    Friend WithEvents LabelService As Label
    Friend WithEvents bClearService As Button
    Friend WithEvents bAddService As Button
    Friend WithEvents PanelClient As Panel
    Friend WithEvents LabelClient As Label
    Friend WithEvents bClearClient As Button
    Friend WithEvents bAddClient As Button
    Friend WithEvents PanelOperation As Panel
    Friend WithEvents LabelOperation As Label
    Friend WithEvents bClearOperation As Button
    Friend WithEvents bAddOperation As Button
    Friend WithEvents PictureBoxTypeService As PictureBox
    Friend WithEvents PictureBoxDepartment As PictureBox
    Friend WithEvents PictureBoxDocuments As PictureBox
    Friend WithEvents PictureBoxWorker As PictureBox
    Friend WithEvents PictureBoxService As PictureBox
    Friend WithEvents PictureBoxClient As PictureBox
    Friend WithEvents PictureBoxOperation As PictureBox
    Friend WithEvents PictureBoxUsers As PictureBox
    Friend WithEvents tbTypeServiceName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbTypeServiceDesc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbDepartmentName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbDocumentsName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbWorkerFirstName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbWorkerSecondName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbWorkerThirdName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents NumericUDWorkerRank As NumericUpDown
    Friend WithEvents NumericUDWorkerExp As NumericUpDown
    Friend WithEvents cbWorkerFKDepName As ComboBox
    Friend WithEvents NumericUDServicePrice As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cbServiceFKTypeService As ComboBox
    Friend WithEvents cbServiceFKDocName As ComboBox
    Friend WithEvents cbServiceFKFIOWorker As ComboBox
    Friend WithEvents tbServiceName As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents tbClientPhoneNumber As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents tbClientSecondName As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents tbClientNameOrg As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents tbClientBankDetails As TextBox
    Friend WithEvents tbClientBatch As TextBox
    Friend WithEvents tbClientThirdName As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents tbClientAddress As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents tbClientDetails As TextBox
    Friend WithEvents tbClientIssuedBy As TextBox
    Friend WithEvents tbClientFirstName As TextBox
    Friend WithEvents cbClientStatus As ComboBox
    Friend WithEvents DateTPClientDateOfIssue As DateTimePicker
    Friend WithEvents DateTPClientDateBirth As DateTimePicker
    Friend WithEvents Label33 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents cbOperationFKClientName As ComboBox
    Friend WithEvents cbOperationFKServiceName As ComboBox
    Friend WithEvents DateTPOperationDate As DateTimePicker
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents tbLogonPassword As TextBox
    Friend WithEvents tbLogonLogin As TextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents bPrint As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents cbLogonType As ComboBox
    Friend WithEvents Label34 As Label
    Friend WithEvents HelpProviderBankServices As HelpProvider
    Friend WithEvents NumericUDApartment As NumericUpDown
    Friend WithEvents NumericUDClientNumber As NumericUpDown
    Friend WithEvents TabControlUserFunctional As TabControl
    Friend WithEvents TabPageCredits As TabPage
    Friend WithEvents Label40 As Label
    Friend WithEvents PictureBoxCredits As PictureBox
    Friend WithEvents TabPagePapers As TabPage
    Friend WithEvents PictureBoxPapers As PictureBox
    Friend WithEvents TabPageSearch As TabPage
    Friend WithEvents PictureBoxSearch As PictureBox
    Friend WithEvents cbCreditsCurrency As ComboBox
    Friend WithEvents Label38 As Label
    Friend WithEvents NumericUDCreditsSumm As NumericUpDown
    Friend WithEvents Label37 As Label
    Friend WithEvents NumericUDCreditsPercent As NumericUpDown
    Friend WithEvents NumericUDCreditsMonth As NumericUpDown
    Friend WithEvents Label41 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents bCalculation As Button
    Friend WithEvents LabelMonthPrice As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents LabelAllPrice As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents LabelResultInf As Label
    Friend WithEvents rtbPapersClient As RichTextBox
    Friend WithEvents bRegistr As Button
    Friend WithEvents Label46 As Label
    Friend WithEvents cbPapersType As ComboBox
    Friend WithEvents NumericUDPapersTime As NumericUpDown
    Friend WithEvents Label48 As Label
    Friend WithEvents NumericUDPapersSumm As NumericUpDown
    Friend WithEvents Label47 As Label
    Friend WithEvents DateTPPapersDataReg As DateTimePicker
    Friend WithEvents Label49 As Label
    Friend WithEvents cbPapersClientFIO As ComboBox
    Friend WithEvents Label44 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents cbPapersTypeCurrency As ComboBox
    Friend WithEvents Label52 As Label
    Friend WithEvents bSearch As Button
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents Label54 As Label
    Friend WithEvents cbSearchColumn As ComboBox
    Friend WithEvents Label53 As Label
    Friend WithEvents cbSearchTables As ComboBox
    Friend WithEvents DataGridViewSearch As DataGridView
    Friend WithEvents bNavigatorSearch As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem1 As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents bSearchLoadTable As Button
    Friend WithEvents bSearchPrint As ToolStripButton
    Friend WithEvents cbPapersTypeClient As ComboBox
    Friend WithEvents Label55 As Label
    Friend WithEvents TabPageServiceOperation As TabPage
    Friend WithEvents DataGridViewServiceOpeartion As DataGridView
    Friend WithEvents cbOperationTypeUser As ComboBox
    Friend WithEvents Label56 As Label
End Class
