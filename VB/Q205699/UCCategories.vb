Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms

Namespace Q205699
	Partial Public Class UCCategories
		Inherits UserControl
		Implements IDXSampleModule
		Public Sub New()
			InitializeComponent()
			InitializeData()
		End Sub
		Private Sub InitializeData()
			categoriesTableAdapter.Fill(nwindDataSet.Categories)
		End Sub

		#Region "IDXSampleModule Members"

		Public ReadOnly Property ModuleName() As String Implements IDXSampleModule.ModuleName
			Get
				Return "Categories"
			End Get
		End Property

		#End Region
	End Class
End Namespace
