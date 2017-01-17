<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.bReturnToMain = New System.Windows.Forms.Button()
        Me.bCancel = New System.Windows.Forms.Button()
        Me.bAddConnection = New System.Windows.Forms.Button()
        Me.PictureBoxTypeService = New System.Windows.Forms.PictureBox()
        Me.bOpenFile = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbPath = New System.Windows.Forms.TextBox()
        CType(Me.PictureBoxTypeService, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bReturnToMain
        '
        Me.bReturnToMain.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.bReturnToMain.Location = New System.Drawing.Point(16, 163)
        Me.bReturnToMain.Name = "bReturnToMain"
        Me.bReturnToMain.Size = New System.Drawing.Size(256, 40)
        Me.bReturnToMain.TabIndex = 45
        Me.bReturnToMain.Text = "Возврат в главное меню"
        Me.bReturnToMain.UseVisualStyleBackColor = True
        '
        'bCancel
        '
        Me.bCancel.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.bCancel.Location = New System.Drawing.Point(16, 117)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New System.Drawing.Size(256, 40)
        Me.bCancel.TabIndex = 44
        Me.bCancel.Text = "Отмена"
        Me.bCancel.UseVisualStyleBackColor = True
        '
        'bAddConnection
        '
        Me.bAddConnection.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.bAddConnection.Location = New System.Drawing.Point(16, 71)
        Me.bAddConnection.Name = "bAddConnection"
        Me.bAddConnection.Size = New System.Drawing.Size(256, 40)
        Me.bAddConnection.TabIndex = 43
        Me.bAddConnection.Text = "Соеденить"
        Me.bAddConnection.UseVisualStyleBackColor = True
        '
        'PictureBoxTypeService
        '
        Me.PictureBoxTypeService.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxTypeService.BackgroundImage = CType(resources.GetObject("PictureBoxTypeService.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxTypeService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxTypeService.Location = New System.Drawing.Point(16, 214)
        Me.PictureBoxTypeService.Name = "PictureBoxTypeService"
        Me.PictureBoxTypeService.Size = New System.Drawing.Size(256, 40)
        Me.PictureBoxTypeService.TabIndex = 46
        Me.PictureBoxTypeService.TabStop = False
        '
        'bOpenFile
        '
        Me.bOpenFile.BackgroundImage = CType(resources.GetObject("bOpenFile.BackgroundImage"), System.Drawing.Image)
        Me.bOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bOpenFile.Location = New System.Drawing.Point(241, 34)
        Me.bOpenFile.Name = "bOpenFile"
        Me.bOpenFile.Size = New System.Drawing.Size(31, 31)
        Me.bOpenFile.TabIndex = 47
        Me.bOpenFile.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 22)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Path*:"
        '
        'tbPath
        '
        Me.tbPath.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.tbPath.Location = New System.Drawing.Point(16, 34)
        Me.tbPath.Name = "tbPath"
        Me.tbPath.Size = New System.Drawing.Size(219, 31)
        Me.tbPath.TabIndex = 49
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(287, 266)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbPath)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.bOpenFile)
        Me.Controls.Add(Me.PictureBoxTypeService)
        Me.Controls.Add(Me.bReturnToMain)
        Me.Controls.Add(Me.bCancel)
        Me.Controls.Add(Me.bAddConnection)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Настройки"
        CType(Me.PictureBoxTypeService, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents bReturnToMain As Button
    Public WithEvents bCancel As Button
    Public WithEvents bAddConnection As Button
    Friend WithEvents PictureBoxTypeService As PictureBox
    Friend WithEvents bOpenFile As Button
    Private WithEvents Label5 As Label
    Private WithEvents tbPath As TextBox
End Class
