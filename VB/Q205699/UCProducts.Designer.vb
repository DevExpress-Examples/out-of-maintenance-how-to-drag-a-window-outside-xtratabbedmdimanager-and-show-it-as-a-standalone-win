Imports Microsoft.VisualBasic
Imports System
Namespace Q205699
	Partial Public Class UCProducts
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
			Me.productsTableAdapter = New Q205699.nwindDataSetTableAdapters.ProductsTableAdapter()
			Me.dataGridView1 = New System.Windows.Forms.DataGridView()
			Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.productIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.productNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.quantityPerUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.unitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.unitsInStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.unitsOnOrderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.reorderLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.discontinuedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
			Me.eAN13DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' dataGridView1
			' 
			Me.dataGridView1.AutoGenerateColumns = False
			Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() { Me.productIDDataGridViewTextBoxColumn, Me.productNameDataGridViewTextBoxColumn, Me.quantityPerUnitDataGridViewTextBoxColumn, Me.unitPriceDataGridViewTextBoxColumn, Me.unitsInStockDataGridViewTextBoxColumn, Me.unitsOnOrderDataGridViewTextBoxColumn, Me.reorderLevelDataGridViewTextBoxColumn, Me.discontinuedDataGridViewCheckBoxColumn, Me.eAN13DataGridViewTextBoxColumn})
			Me.dataGridView1.DataSource = Me.productsBindingSource
			Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dataGridView1.Location = New System.Drawing.Point(0, 0)
			Me.dataGridView1.Name = "dataGridView1"
			Me.dataGridView1.Size = New System.Drawing.Size(944, 153)
			Me.dataGridView1.TabIndex = 0
			' 
			' productsBindingSource
			' 
			Me.productsBindingSource.DataMember = "Products"
			Me.productsBindingSource.DataSource = Me.nwindDataSet
			' 
			' productIDDataGridViewTextBoxColumn
			' 
			Me.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
			Me.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID"
			Me.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn"
			' 
			' productNameDataGridViewTextBoxColumn
			' 
			Me.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
			Me.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName"
			Me.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn"
			' 
			' quantityPerUnitDataGridViewTextBoxColumn
			' 
			Me.quantityPerUnitDataGridViewTextBoxColumn.DataPropertyName = "QuantityPerUnit"
			Me.quantityPerUnitDataGridViewTextBoxColumn.HeaderText = "QuantityPerUnit"
			Me.quantityPerUnitDataGridViewTextBoxColumn.Name = "quantityPerUnitDataGridViewTextBoxColumn"
			' 
			' unitPriceDataGridViewTextBoxColumn
			' 
			Me.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice"
			Me.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice"
			Me.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn"
			' 
			' unitsInStockDataGridViewTextBoxColumn
			' 
			Me.unitsInStockDataGridViewTextBoxColumn.DataPropertyName = "UnitsInStock"
			Me.unitsInStockDataGridViewTextBoxColumn.HeaderText = "UnitsInStock"
			Me.unitsInStockDataGridViewTextBoxColumn.Name = "unitsInStockDataGridViewTextBoxColumn"
			' 
			' unitsOnOrderDataGridViewTextBoxColumn
			' 
			Me.unitsOnOrderDataGridViewTextBoxColumn.DataPropertyName = "UnitsOnOrder"
			Me.unitsOnOrderDataGridViewTextBoxColumn.HeaderText = "UnitsOnOrder"
			Me.unitsOnOrderDataGridViewTextBoxColumn.Name = "unitsOnOrderDataGridViewTextBoxColumn"
			' 
			' reorderLevelDataGridViewTextBoxColumn
			' 
			Me.reorderLevelDataGridViewTextBoxColumn.DataPropertyName = "ReorderLevel"
			Me.reorderLevelDataGridViewTextBoxColumn.HeaderText = "ReorderLevel"
			Me.reorderLevelDataGridViewTextBoxColumn.Name = "reorderLevelDataGridViewTextBoxColumn"
			' 
			' discontinuedDataGridViewCheckBoxColumn
			' 
			Me.discontinuedDataGridViewCheckBoxColumn.DataPropertyName = "Discontinued"
			Me.discontinuedDataGridViewCheckBoxColumn.HeaderText = "Discontinued"
			Me.discontinuedDataGridViewCheckBoxColumn.Name = "discontinuedDataGridViewCheckBoxColumn"
			' 
			' eAN13DataGridViewTextBoxColumn
			' 
			Me.eAN13DataGridViewTextBoxColumn.DataPropertyName = "EAN13"
			Me.eAN13DataGridViewTextBoxColumn.HeaderText = "EAN13"
			Me.eAN13DataGridViewTextBoxColumn.Name = "eAN13DataGridViewTextBoxColumn"
			' 
			' UCProducts
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.dataGridView1)
			Me.Name = "UCProducts"
			Me.Size = New System.Drawing.Size(944, 153)
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private nwindDataSet As nwindDataSet
		Private productsTableAdapter As Q205699.nwindDataSetTableAdapters.ProductsTableAdapter
		Private dataGridView1 As System.Windows.Forms.DataGridView
		Private productIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private productNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private quantityPerUnitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private unitPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private unitsInStockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private unitsOnOrderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private reorderLevelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private discontinuedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
		Private eAN13DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private productsBindingSource As System.Windows.Forms.BindingSource
	End Class
End Namespace
