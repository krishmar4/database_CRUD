<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCRUD
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
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgNames = New System.Windows.Forms.DataGrid()
        Me.TestDataSet = New WindowsApplication1.testDataSet()
        Me.Names1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Names1TableAdapter = New WindowsApplication1.testDataSetTableAdapters.names1TableAdapter()
        CType(Me.dgNames, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Names1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(12, 25)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(12, 81)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(75, 23)
        Me.btnRead.TabIndex = 1
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(12, 137)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(12, 196)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(246, 27)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(121, 20)
        Me.txtName.TabIndex = 4
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(246, 65)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtNumber.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(186, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Number:"
        '
        'dgNames
        '
        Me.dgNames.DataMember = ""
        Me.dgNames.DataSource = Me.Names1BindingSource
        Me.dgNames.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgNames.Location = New System.Drawing.Point(138, 125)
        Me.dgNames.Name = "dgNames"
        Me.dgNames.Size = New System.Drawing.Size(480, 277)
        Me.dgNames.TabIndex = 8
        '
        'TestDataSet
        '
        Me.TestDataSet.DataSetName = "testDataSet"
        Me.TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Names1BindingSource
        '
        Me.Names1BindingSource.DataMember = "names1"
        Me.Names1BindingSource.DataSource = Me.TestDataSet
        '
        'Names1TableAdapter
        '
        Me.Names1TableAdapter.ClearBeforeFill = True
        '
        'frmCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 428)
        Me.Controls.Add(Me.dgNames)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnCreate)
        Me.Name = "frmCRUD"
        Me.Text = "CRUD"
        CType(Me.dgNames, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Names1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents btnRead As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgNames As System.Windows.Forms.DataGrid
    Friend WithEvents TestDataSet As WindowsApplication1.testDataSet
    Friend WithEvents Names1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Names1TableAdapter As WindowsApplication1.testDataSetTableAdapters.names1TableAdapter

End Class
