<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIn))
        Me.bClose = New System.Windows.Forms.Button()
        Me.tBPassword = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.tBNameUser = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.comboBoxType = New System.Windows.Forms.ComboBox()
        Me.bEnter = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.ConnectionLabel = New System.Windows.Forms.Label()
        Me.TimerBankServices = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBoxTypeService = New System.Windows.Forms.PictureBox()
        Me.panel1.SuspendLayout()
        CType(Me.PictureBoxTypeService, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bClose
        '
        Me.bClose.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.bClose.Location = New System.Drawing.Point(12, 291)
        Me.bClose.Name = "bClose"
        Me.bClose.Size = New System.Drawing.Size(350, 31)
        Me.bClose.TabIndex = 27
        Me.bClose.Text = "Закрыть программу"
        Me.bClose.UseVisualStyleBackColor = True
        '
        'tBPassword
        '
        Me.tBPassword.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.tBPassword.Location = New System.Drawing.Point(12, 217)
        Me.tBPassword.Name = "tBPassword"
        Me.tBPassword.Size = New System.Drawing.Size(349, 31)
        Me.tBPassword.TabIndex = 26
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(8, 192)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(163, 22)
        Me.label3.TabIndex = 25
        Me.label3.Text = "Введите пароль:"
        '
        'tBNameUser
        '
        Me.tBNameUser.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.tBNameUser.Location = New System.Drawing.Point(12, 158)
        Me.tBNameUser.Name = "tBNameUser"
        Me.tBNameUser.Size = New System.Drawing.Size(349, 31)
        Me.tBNameUser.TabIndex = 24
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(8, 133)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(132, 22)
        Me.label2.TabIndex = 23
        Me.label2.Text = "Введите имя:"
        '
        'comboBoxType
        '
        Me.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxType.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.comboBoxType.ForeColor = System.Drawing.Color.Black
        Me.comboBoxType.FormattingEnabled = True
        Me.comboBoxType.Items.AddRange(New Object() {"Администратор", "Пользователь"})
        Me.comboBoxType.Location = New System.Drawing.Point(12, 100)
        Me.comboBoxType.Name = "comboBoxType"
        Me.comboBoxType.Size = New System.Drawing.Size(349, 30)
        Me.comboBoxType.TabIndex = 22
        '
        'bEnter
        '
        Me.bEnter.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.bEnter.Location = New System.Drawing.Point(12, 254)
        Me.bEnter.Name = "bEnter"
        Me.bEnter.Size = New System.Drawing.Size(350, 31)
        Me.bEnter.TabIndex = 21
        Me.bEnter.Text = "Войти в программу"
        Me.bEnter.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(12, 75)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(269, 22)
        Me.label1.TabIndex = 20
        Me.label1.Text = "Выберите тип пользователя:"
        '
        'panel1
        '
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel1.Controls.Add(Me.ConnectionLabel)
        Me.panel1.Location = New System.Drawing.Point(12, 12)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(349, 60)
        Me.panel1.TabIndex = 19
        '
        'ConnectionLabel
        '
        Me.ConnectionLabel.AutoSize = True
        Me.ConnectionLabel.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ConnectionLabel.ForeColor = System.Drawing.Color.White
        Me.ConnectionLabel.Location = New System.Drawing.Point(3, 9)
        Me.ConnectionLabel.Name = "ConnectionLabel"
        Me.ConnectionLabel.Size = New System.Drawing.Size(303, 33)
        Me.ConnectionLabel.TabIndex = 0
        Me.ConnectionLabel.Text = "Настройки приняты!!!"
        '
        'TimerBankServices
        '
        '
        'PictureBoxTypeService
        '
        Me.PictureBoxTypeService.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxTypeService.BackgroundImage = CType(resources.GetObject("PictureBoxTypeService.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxTypeService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxTypeService.Location = New System.Drawing.Point(12, 333)
        Me.PictureBoxTypeService.Name = "PictureBoxTypeService"
        Me.PictureBoxTypeService.Size = New System.Drawing.Size(349, 56)
        Me.PictureBoxTypeService.TabIndex = 28
        Me.PictureBoxTypeService.TabStop = False
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(373, 401)
        Me.Controls.Add(Me.PictureBoxTypeService)
        Me.Controls.Add(Me.bClose)
        Me.Controls.Add(Me.tBPassword)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.tBNameUser)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.comboBoxType)
        Me.Controls.Add(Me.bEnter)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "LogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Авторизация"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.PictureBoxTypeService, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents bClose As Button
    Private WithEvents tBPassword As TextBox
    Private WithEvents label3 As Label
    Private WithEvents tBNameUser As TextBox
    Private WithEvents label2 As Label
    Private WithEvents comboBoxType As ComboBox
    Private WithEvents bEnter As Button
    Private WithEvents label1 As Label
    Private WithEvents panel1 As Panel
    Friend WithEvents TimerBankServices As Timer
    Friend WithEvents PictureBoxTypeService As PictureBox
    Friend WithEvents ConnectionLabel As Label
End Class
