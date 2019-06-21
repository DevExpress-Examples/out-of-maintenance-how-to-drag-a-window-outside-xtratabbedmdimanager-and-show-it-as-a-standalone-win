Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTabbedMdi
Imports DevExpress.XtraTab.ViewInfo
Imports System.Diagnostics
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors

Namespace Q205699
	Partial Public Class MainForm
		Inherits Form

		Public Sub New()
			InitializeComponent()

			xtraTabbedMdiManager1.FloatPageDragMode = FloatPageDragMode.FullWindow
			xtraTabbedMdiManager1.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.True
			xtraTabbedMdiManager1.FloatOnDrag = DevExpress.Utils.DefaultBoolean.True
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			For i As Integer = 0 To 2
				AddChild()
			Next i
		End Sub
		Private childCount As Integer = 1
		Private Sub AddChild()
			Dim childForm As New Form()
			childForm.Text = "Form" & childCount

			Dim label As New LabelControl()
			label.AutoSizeMode = LabelAutoSizeMode.None
'INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
'ORIGINAL LINE: label.Text = "Form" + childCount++;
			label.Text = "Form" & childCount
			childCount += 1
			childForm.Controls.Add(label)
			label.Dock = DockStyle.Fill
			label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

			childForm.MdiParent = Me
			childForm.Show()
		End Sub
	End Class
End Namespace