<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Student1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LMSDataSet = New db1.LMSDataSet()
        Me.SearchbynameBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dateDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.StudentTableAdapter = New db1.LMSDataSetTableAdapters.StudentTableAdapter()
        Me.TableAdapterManager = New db1.LMSDataSetTableAdapters.TableAdapterManager()
        Me.StudentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchbynameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchbynameTableAdapter = New db1.LMSDataSetTableAdapters.SearchbynameTableAdapter()
        Me.SearchbynameBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchbynameBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchbynameBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchbynameBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student1TableAdapter = New db1.LMSDataSetTableAdapters.Student1TableAdapter()
        Me.StudentBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student1BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student1BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TabPage2.SuspendLayout()
        CType(Me.Student1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchbynameBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.StudentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchbynameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchbynameBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchbynameBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchbynameBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchbynameBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student1BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student1BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Location = New System.Drawing.Point(10, 47)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1357, 982)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Search"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Student1BindingSource
        '
        Me.Student1BindingSource.DataMember = "Student1"
        Me.Student1BindingSource.DataSource = Me.LMSDataSet
        '
        'LMSDataSet
        '
        Me.LMSDataSet.DataSetName = "LMSDataSet"
        Me.LMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SearchbynameBindingSource5
        '
        Me.SearchbynameBindingSource5.DataMember = "Searchbyname"
        Me.SearchbynameBindingSource5.DataSource = Me.LMSDataSet
        '
        'StudentDataGridView
        '
        Me.StudentDataGridView.AutoGenerateColumns = False
        Me.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.StudentDataGridView.DataSource = Me.StudentBindingSource
        Me.StudentDataGridView.Location = New System.Drawing.Point(56, 149)
        Me.StudentDataGridView.Name = "StudentDataGridView"
        Me.StudentDataGridView.RowTemplate.Height = 37
        Me.StudentDataGridView.Size = New System.Drawing.Size(1229, 516)
        Me.StudentDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "StudentID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "StudentID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Fname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Lname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Lname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.LMSDataSet
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1029, 34)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(256, 63)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Student Records"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtStudentID)
        Me.TabPage1.Controls.Add(Me.txtFname)
        Me.TabPage1.Controls.Add(Me.txtLname)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.dateDOB)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(10, 47)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1357, 982)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add Student"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(416, 173)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(438, 35)
        Me.txtStudentID.TabIndex = 0
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(416, 214)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(438, 35)
        Me.txtFname.TabIndex = 1
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(416, 255)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(438, 35)
        Me.txtLname.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(126, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 29)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "DOB"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(123, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Last Name"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1109, 402)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(207, 161)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(416, 402)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(438, 57)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dateDOB
        '
        Me.dateDOB.Location = New System.Drawing.Point(416, 296)
        Me.dateDOB.Name = "dateDOB"
        Me.dateDOB.Size = New System.Drawing.Size(438, 35)
        Me.dateDOB.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(123, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "StudentID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "First Name"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(142, 43)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1377, 1039)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.StudentDataGridView)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Location = New System.Drawing.Point(10, 47)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1357, 982)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Records"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StudentTableAdapter = Me.StudentTableAdapter
        Me.TableAdapterManager.UpdateOrder = db1.LMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StudentBindingSource1
        '
        Me.StudentBindingSource1.DataMember = "Student"
        Me.StudentBindingSource1.DataSource = Me.LMSDataSet
        '
        'SearchbynameBindingSource
        '
        Me.SearchbynameBindingSource.DataSource = Me.LMSDataSet
        Me.SearchbynameBindingSource.Position = 0
        '
        'SearchbynameTableAdapter
        '
        Me.SearchbynameTableAdapter.ClearBeforeFill = True
        '
        'SearchbynameBindingSource1
        '
        Me.SearchbynameBindingSource1.DataMember = "Searchbyname"
        Me.SearchbynameBindingSource1.DataSource = Me.LMSDataSet
        '
        'StudentBindingSource2
        '
        Me.StudentBindingSource2.DataMember = "Student"
        Me.StudentBindingSource2.DataSource = Me.LMSDataSet
        '
        'SearchbynameBindingSource2
        '
        Me.SearchbynameBindingSource2.DataMember = "Searchbyname"
        Me.SearchbynameBindingSource2.DataSource = Me.LMSDataSet
        '
        'SearchbynameBindingSource3
        '
        Me.SearchbynameBindingSource3.DataMember = "Searchbyname"
        Me.SearchbynameBindingSource3.DataSource = Me.LMSDataSet
        '
        'SearchbynameBindingSource4
        '
        Me.SearchbynameBindingSource4.DataMember = "Searchbyname"
        Me.SearchbynameBindingSource4.DataSource = Me.LMSDataSet
        '
        'Student1TableAdapter
        '
        Me.Student1TableAdapter.ClearBeforeFill = True
        '
        'StudentBindingSource3
        '
        Me.StudentBindingSource3.DataMember = "Student"
        Me.StudentBindingSource3.DataSource = Me.LMSDataSet
        '
        'Student1BindingSource1
        '
        Me.Student1BindingSource1.DataMember = "Student1"
        Me.Student1BindingSource1.DataSource = Me.LMSDataSet
        '
        'Student1BindingSource2
        '
        Me.Student1BindingSource2.DataMember = "Student1"
        Me.Student1BindingSource2.DataSource = Me.LMSDataSet
        '
        'Student1BindingSource3
        '
        Me.Student1BindingSource3.DataMember = "Student1"
        Me.Student1BindingSource3.DataSource = Me.LMSDataSet
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(43, 78)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(212, 165)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "Search By Name"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2179, 1127)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Admin"
        Me.Text = "Form1"
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Student1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchbynameBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.StudentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchbynameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchbynameBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchbynameBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchbynameBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchbynameBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student1BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student1BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LMSDataSet As LMSDataSet
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As LMSDataSetTableAdapters.StudentTableAdapter
    Friend WithEvents TableAdapterManager As LMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dateDOB As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Button3 As Button
    Friend WithEvents StudentDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents StudentBindingSource1 As BindingSource
    Friend WithEvents SearchbynameBindingSource As BindingSource
    Friend WithEvents SearchbynameTableAdapter As LMSDataSetTableAdapters.SearchbynameTableAdapter
    Friend WithEvents SearchbynameBindingSource1 As BindingSource
    Friend WithEvents SearchbynameBindingSource2 As BindingSource
    Friend WithEvents StudentBindingSource2 As BindingSource
    Friend WithEvents SearchbynameBindingSource3 As BindingSource
    Friend WithEvents SearchbynameBindingSource4 As BindingSource
    Friend WithEvents SearchbynameBindingSource5 As BindingSource
    Friend WithEvents Student1BindingSource As BindingSource
    Friend WithEvents Student1TableAdapter As LMSDataSetTableAdapters.Student1TableAdapter
    Friend WithEvents StudentBindingSource3 As BindingSource
    Friend WithEvents Student1BindingSource1 As BindingSource
    Friend WithEvents Student1BindingSource2 As BindingSource
    Friend WithEvents Student1BindingSource3 As BindingSource
    Friend WithEvents Button4 As Button
End Class
