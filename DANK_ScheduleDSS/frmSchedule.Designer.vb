﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchedule
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
        Me.ClassesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Fall2017ClassesDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Fall2017ClassesDataSet = New DANKSolutions_ClassScheduleDSS.Fall2017ClassesDataSet()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtMWF = New System.Windows.Forms.TextBox()
        Me.txtMW = New System.Windows.Forms.TextBox()
        Me.txtTR = New System.Windows.Forms.TextBox()
        Me.txtMorning = New System.Windows.Forms.TextBox()
        Me.txtEvening = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabPage = New System.Windows.Forms.TabPage()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.Selected = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.ClassesTableAdapter = New DANKSolutions_ClassScheduleDSS.Fall2017ClassesDataSetTableAdapters.ClassesTableAdapter()
        Me.CourseAbstractionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CourseAbstractionTableAdapter = New DANKSolutions_ClassScheduleDSS.Fall2017ClassesDataSetTableAdapters.CourseAbstractionTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fall2017ClassesDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fall2017ClassesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.tabPage.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        CType(Me.CourseAbstractionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClassesBindingSource
        '
        Me.ClassesBindingSource.DataMember = "Classes"
        Me.ClassesBindingSource.DataSource = Me.Fall2017ClassesDataSetBindingSource
        '
        'Fall2017ClassesDataSetBindingSource
        '
        Me.Fall2017ClassesDataSetBindingSource.DataSource = Me.Fall2017ClassesDataSet
        Me.Fall2017ClassesDataSetBindingSource.Position = 0
        '
        'Fall2017ClassesDataSet
        '
        Me.Fall2017ClassesDataSet.DataSetName = "Fall2017ClassesDataSet"
        Me.Fall2017ClassesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnCalculate)
        Me.TabPage1.Location = New System.Drawing.Point(8, 39)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(850, 845)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Calculate"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(94, 121)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(523, 185)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtMWF)
        Me.TabPage2.Controls.Add(Me.txtMW)
        Me.TabPage2.Controls.Add(Me.txtTR)
        Me.TabPage2.Controls.Add(Me.txtMorning)
        Me.TabPage2.Controls.Add(Me.txtEvening)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(8, 39)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(850, 845)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Weekly Goals"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtMWF
        '
        Me.txtMWF.Location = New System.Drawing.Point(412, 346)
        Me.txtMWF.Name = "txtMWF"
        Me.txtMWF.Size = New System.Drawing.Size(196, 31)
        Me.txtMWF.TabIndex = 9
        '
        'txtMW
        '
        Me.txtMW.Location = New System.Drawing.Point(412, 273)
        Me.txtMW.Name = "txtMW"
        Me.txtMW.Size = New System.Drawing.Size(196, 31)
        Me.txtMW.TabIndex = 8
        '
        'txtTR
        '
        Me.txtTR.Location = New System.Drawing.Point(412, 196)
        Me.txtTR.Name = "txtTR"
        Me.txtTR.Size = New System.Drawing.Size(196, 31)
        Me.txtTR.TabIndex = 7
        '
        'txtMorning
        '
        Me.txtMorning.Location = New System.Drawing.Point(412, 123)
        Me.txtMorning.Name = "txtMorning"
        Me.txtMorning.Size = New System.Drawing.Size(196, 31)
        Me.txtMorning.TabIndex = 6
        '
        'txtEvening
        '
        Me.txtEvening.Location = New System.Drawing.Point(412, 51)
        Me.txtEvening.Name = "txtEvening"
        Me.txtEvening.Size = New System.Drawing.Size(196, 31)
        Me.txtEvening.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 346)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(326, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Monday/Wednesday/Friday Goal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(260, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Monday/Wednesday Goal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(242, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tuesday/Thursday Goal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(227, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Morning Courses Goal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Evening Courses Goal"
        '
        'tabPage
        '
        Me.tabPage.Controls.Add(Me.DataGridView)
        Me.tabPage.Location = New System.Drawing.Point(8, 39)
        Me.tabPage.Name = "tabPage"
        Me.tabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage.Size = New System.Drawing.Size(850, 845)
        Me.tabPage.TabIndex = 0
        Me.tabPage.Text = "Requested Courses"
        Me.tabPage.UseVisualStyleBackColor = True
        '
        'DataGridView
        '
        Me.DataGridView.AutoGenerateColumns = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Selected, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DataGridView.DataSource = Me.CourseAbstractionBindingSource
        Me.DataGridView.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowTemplate.Height = 33
        Me.DataGridView.Size = New System.Drawing.Size(810, 806)
        Me.DataGridView.TabIndex = 0
        '
        'Selected
        '
        Me.Selected.HeaderText = "Selected"
        Me.Selected.Name = "Selected"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.tabPage)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Location = New System.Drawing.Point(51, 30)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(866, 892)
        Me.TabControl.TabIndex = 0
        '
        'ClassesTableAdapter
        '
        Me.ClassesTableAdapter.ClearBeforeFill = True
        '
        'CourseAbstractionBindingSource
        '
        Me.CourseAbstractionBindingSource.DataMember = "CourseAbstraction"
        Me.CourseAbstractionBindingSource.DataSource = Me.Fall2017ClassesDataSetBindingSource
        '
        'CourseAbstractionTableAdapter
        '
        Me.CourseAbstractionTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Department"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Department"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CourseNumber"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CourseNumber"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'frmSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 991)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "frmSchedule"
        Me.Text = "Set Schedule"
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fall2017ClassesDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fall2017ClassesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.tabPage.ResumeLayout(False)
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        CType(Me.CourseAbstractionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fall2017ClassesDataSetBindingSource As BindingSource
    Friend WithEvents Fall2017ClassesDataSet As Fall2017ClassesDataSet
    Friend WithEvents ClassesBindingSource As BindingSource
    Friend WithEvents ClassesTableAdapter As Fall2017ClassesDataSetTableAdapters.ClassesTableAdapter
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnCalculate As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtMWF As TextBox
    Friend WithEvents txtMW As TextBox
    Friend WithEvents txtTR As TextBox
    Friend WithEvents txtMorning As TextBox
    Friend WithEvents txtEvening As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tabPage As TabPage
    Friend WithEvents TabControl As TabControl
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Selected As DataGridViewCheckBoxColumn
    Friend WithEvents CourseAbstractionBindingSource As BindingSource
    Friend WithEvents CourseAbstractionTableAdapter As Fall2017ClassesDataSetTableAdapters.CourseAbstractionTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
