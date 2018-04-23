Imports Microsoft.VisualBasic
Imports System
Namespace Q205699
	Partial Public Class UCCategories
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.nwindDataSet = New Q205699.nwindDataSet()
			Me.categoriesTableAdapter = New Q205699.nwindDataSetTableAdapters.CategoriesTableAdapter()
			Me.categoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.dataGridView1 = New System.Windows.Forms.DataGridView()
			Me.categoryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.categoryNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.descriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' categoriesBindingSource
			' 
			Me.categoriesBindingSource.DataMember = "Categories"
			Me.categoriesBindingSource.DataSource = Me.nwindDataSet
			' 
			' dataGridView1
			' 
			Me.dataGridView1.AutoGenerateColumns = False
			Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() { Me.categoryIDDataGridViewTextBoxColumn, Me.categoryNameDataGridViewTextBoxColumn, Me.descriptionDataGridViewTextBoxColumn})
			Me.dataGridView1.DataSource = Me.categoriesBindingSource
			Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dataGridView1.Location = New System.Drawing.Point(0, 0)
			Me.dataGridView1.Name = "dataGridView1"
			Me.dataGridView1.Size = New System.Drawing.Size(344, 153)
			Me.dataGridView1.TabIndex = 0
			' 
			' categoryIDDataGridViewTextBoxColumn
			' 
			Me.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID"
			Me.categoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID"
			Me.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn"
			' 
			' categoryNameDataGridViewTextBoxColumn
			' 
			Me.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName"
			Me.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName"
			Me.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn"
			' 
			' descriptionDataGridViewTextBoxColumn
			' 
			Me.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
			Me.descriptionDataGridViewTextBoxColumn.HeaderText = "Description"
			Me.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn"
			' 
			' UCCategories
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.dataGridView1)
			Me.Name = "UCCategories"
			Me.Size = New System.Drawing.Size(344, 153)
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private nwindDataSet As nwindDataSet
		Private categoriesTableAdapter As Q205699.nwindDataSetTableAdapters.CategoriesTableAdapter
		Private categoriesBindingSource As System.Windows.Forms.BindingSource
		Private dataGridView1 As System.Windows.Forms.DataGridView
		Private categoryIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private categoryNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private descriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	End Class
End Namespace
