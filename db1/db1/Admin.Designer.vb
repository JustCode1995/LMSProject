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
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.StudentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LMSDataSet = New db1.LMSDataSet()
        Me.StudentTableAdapter = New db1.LMSDataSetTableAdapters.StudentTableAdapter()
        Me.TableAdapterManager = New db1.LMSDataSetTableAdapters.TableAdapterManager()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.StudentDataGridView)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.txtSearch)
        Me.TabPage2.Location = New System.Drawing.Point(10, 47)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1357, 776)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Search"
        Me.TabPage2.UseVisualStyleBackColor = True
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
        Me.TabPage1.Size = New System.Drawing.Size(1357, 776)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "AddStudent"
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
        Me.TabControl1.Location = New System.Drawing.Point(142, 68)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1377, 833)
        Me.TabControl1.TabIndex = 11
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(216, 102)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(297, 35)
        Me.txtSearch.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(607, 102)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 63)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'StudentDataGridView
        '
        Me.StudentDataGridView.AutoGenerateColumns = False
        Me.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.StudentDataGridView.DataSource = Me.StudentBindingSource
        Me.StudentDataGridView.Location = New System.Drawing.Point(52, 228)
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
        'LMSDataSet
        '
        Me.LMSDataSet.DataSetName = "LMSDataSet"
        Me.LMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1749, 1119)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Admin"
        Me.Text = "Form1"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents StudentDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
