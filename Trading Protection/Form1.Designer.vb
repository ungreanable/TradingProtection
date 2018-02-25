<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.impactCb = New System.Windows.Forms.ComboBox()
        Me.impactLb = New System.Windows.Forms.Label()
        Me.protectionBtn = New System.Windows.Forms.Button()
        Me.returnAfterLb = New System.Windows.Forms.Label()
        Me.returnAfterCb = New System.Windows.Forms.ComboBox()
        Me.protectBeforeLb = New System.Windows.Forms.Label()
        Me.protectBeforeCb = New System.Windows.Forms.ComboBox()
        Me.SEAsiaTimeLb = New System.Windows.Forms.Label()
        Me.localTimeLb = New System.Windows.Forms.Label()
        Me.newsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Currency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimeNews = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Impact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stopProtectionTimer = New System.Windows.Forms.Timer(Me.components)
        Me.startProtectionTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.newsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.impactCb)
        Me.GroupBox1.Controls.Add(Me.impactLb)
        Me.GroupBox1.Controls.Add(Me.protectionBtn)
        Me.GroupBox1.Controls.Add(Me.returnAfterLb)
        Me.GroupBox1.Controls.Add(Me.returnAfterCb)
        Me.GroupBox1.Controls.Add(Me.protectBeforeLb)
        Me.GroupBox1.Controls.Add(Me.protectBeforeCb)
        Me.GroupBox1.Controls.Add(Me.SEAsiaTimeLb)
        Me.GroupBox1.Controls.Add(Me.localTimeLb)
        Me.GroupBox1.Controls.Add(Me.newsDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(785, 359)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Trading Protection by Siwarak UnGreanable"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Refresh News"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(107, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(480, 23)
        Me.TextBox1.TabIndex = 34
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'impactCb
        '
        Me.impactCb.FormattingEnabled = True
        Me.impactCb.Items.AddRange(New Object() {"Low", "Medium", "High"})
        Me.impactCb.Location = New System.Drawing.Point(430, 313)
        Me.impactCb.Name = "impactCb"
        Me.impactCb.Size = New System.Drawing.Size(80, 21)
        Me.impactCb.TabIndex = 33
        '
        'impactLb
        '
        Me.impactLb.AutoSize = True
        Me.impactLb.Location = New System.Drawing.Point(382, 316)
        Me.impactLb.Name = "impactLb"
        Me.impactLb.Size = New System.Drawing.Size(42, 13)
        Me.impactLb.TabIndex = 32
        Me.impactLb.Text = "Impact:"
        '
        'protectionBtn
        '
        Me.protectionBtn.BackColor = System.Drawing.Color.PaleGreen
        Me.protectionBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.protectionBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.protectionBtn.Location = New System.Drawing.Point(516, 305)
        Me.protectionBtn.Name = "protectionBtn"
        Me.protectionBtn.Size = New System.Drawing.Size(269, 35)
        Me.protectionBtn.TabIndex = 31
        Me.protectionBtn.Text = "Start Protection"
        Me.protectionBtn.UseVisualStyleBackColor = False
        '
        'returnAfterLb
        '
        Me.returnAfterLb.AutoSize = True
        Me.returnAfterLb.Location = New System.Drawing.Point(183, 316)
        Me.returnAfterLb.Name = "returnAfterLb"
        Me.returnAfterLb.Size = New System.Drawing.Size(66, 13)
        Me.returnAfterLb.TabIndex = 30
        Me.returnAfterLb.Text = "Return after:"
        '
        'returnAfterCb
        '
        Me.returnAfterCb.FormattingEnabled = True
        Me.returnAfterCb.Items.AddRange(New Object() {"30 Minutes", "1 Hour"})
        Me.returnAfterCb.Location = New System.Drawing.Point(255, 313)
        Me.returnAfterCb.Name = "returnAfterCb"
        Me.returnAfterCb.Size = New System.Drawing.Size(121, 21)
        Me.returnAfterCb.TabIndex = 29
        '
        'protectBeforeLb
        '
        Me.protectBeforeLb.AutoSize = True
        Me.protectBeforeLb.Location = New System.Drawing.Point(1, 316)
        Me.protectBeforeLb.Name = "protectBeforeLb"
        Me.protectBeforeLb.Size = New System.Drawing.Size(77, 13)
        Me.protectBeforeLb.TabIndex = 28
        Me.protectBeforeLb.Text = "Protect before:"
        '
        'protectBeforeCb
        '
        Me.protectBeforeCb.FormattingEnabled = True
        Me.protectBeforeCb.Items.AddRange(New Object() {"30 Minutes", "1 Hour"})
        Me.protectBeforeCb.Location = New System.Drawing.Point(84, 313)
        Me.protectBeforeCb.Name = "protectBeforeCb"
        Me.protectBeforeCb.Size = New System.Drawing.Size(93, 21)
        Me.protectBeforeCb.TabIndex = 27
        '
        'SEAsiaTimeLb
        '
        Me.SEAsiaTimeLb.AutoSize = True
        Me.SEAsiaTimeLb.Location = New System.Drawing.Point(593, 37)
        Me.SEAsiaTimeLb.Name = "SEAsiaTimeLb"
        Me.SEAsiaTimeLb.Size = New System.Drawing.Size(72, 13)
        Me.SEAsiaTimeLb.TabIndex = 26
        Me.SEAsiaTimeLb.Text = "GMT+7 Time:"
        '
        'localTimeLb
        '
        Me.localTimeLb.AutoSize = True
        Me.localTimeLb.Location = New System.Drawing.Point(603, 18)
        Me.localTimeLb.Name = "localTimeLb"
        Me.localTimeLb.Size = New System.Drawing.Size(62, 13)
        Me.localTimeLb.TabIndex = 25
        Me.localTimeLb.Text = "Local Time:"
        '
        'newsDataGridView
        '
        Me.newsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.newsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.newsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.newsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Title, Me.Currency, Me.DateTimeNews, Me.Impact})
        Me.newsDataGridView.Location = New System.Drawing.Point(0, 53)
        Me.newsDataGridView.MultiSelect = False
        Me.newsDataGridView.Name = "newsDataGridView"
        Me.newsDataGridView.ReadOnly = True
        Me.newsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.newsDataGridView.ShowEditingIcon = False
        Me.newsDataGridView.Size = New System.Drawing.Size(785, 246)
        Me.newsDataGridView.TabIndex = 24
        '
        'Title
        '
        Me.Title.HeaderText = "Title"
        Me.Title.Name = "Title"
        Me.Title.ReadOnly = True
        '
        'Currency
        '
        Me.Currency.HeaderText = "Currency"
        Me.Currency.Name = "Currency"
        Me.Currency.ReadOnly = True
        '
        'DateTimeNews
        '
        Me.DateTimeNews.HeaderText = "DateTime"
        Me.DateTimeNews.Name = "DateTimeNews"
        Me.DateTimeNews.ReadOnly = True
        '
        'Impact
        '
        Me.Impact.HeaderText = "Impact"
        Me.Impact.Name = "Impact"
        Me.Impact.ReadOnly = True
        '
        'stopProtectionTimer
        '
        '
        'startProtectionTimer
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 343)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "***News from Weekly ForexFactory.com"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 383)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Trading Protection (Only EURUSD)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.newsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents newsDataGridView As DataGridView
    Friend WithEvents Title As DataGridViewTextBoxColumn
    Friend WithEvents Currency As DataGridViewTextBoxColumn
    Friend WithEvents DateTimeNews As DataGridViewTextBoxColumn
    Friend WithEvents Impact As DataGridViewTextBoxColumn
    Friend WithEvents SEAsiaTimeLb As Label
    Friend WithEvents localTimeLb As Label
    Friend WithEvents protectBeforeCb As ComboBox
    Friend WithEvents protectBeforeLb As Label
    Friend WithEvents returnAfterLb As Label
    Friend WithEvents returnAfterCb As ComboBox
    Friend WithEvents protectionBtn As Button
    Friend WithEvents impactLb As Label
    Friend WithEvents impactCb As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents startProtectionTimer As Timer
    Friend WithEvents stopProtectionTimer As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
