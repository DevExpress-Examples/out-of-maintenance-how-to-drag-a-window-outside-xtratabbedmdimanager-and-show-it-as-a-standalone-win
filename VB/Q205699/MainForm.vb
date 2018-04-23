Imports Microsoft.VisualBasic
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

Namespace Q205699
	Partial Public Class MainForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
			InitializeModules()
		End Sub
		Private Sub InitializeModules()
			ShowModule(New UCCategories(), True)
			ShowModule(New UCProducts(), True)
		End Sub
		Private Sub ShowModule(ByVal [module] As UserControl, ByVal mdi As Boolean)
			Dim m As IDXSampleModule = TryCast([module], IDXSampleModule)
			Dim form As New FormForDXSample()
			[module].Dock = DockStyle.Fill
			form.Controls.Add([module])
			If m Is Nothing Then
				form.Text = "DXSample"
			Else
				form.Text = m.ModuleName
			End If
			If mdi Then
				form.MdiParent = Me
				form.Show()
			Else
				AddHandler form.HDoubleClick, AddressOf OnFormHDoubleClick
				form.Show(Me)
			End If
		End Sub
		Private Function DetachModule(ByVal form As Form) As UserControl
			Dim result As UserControl = Nothing
			Dim i As Integer = 0
			Do While i < form.Controls.Count
				Dim c As Control = form.Controls(i)
				If TypeOf c Is UserControl Then
					form.Controls.Remove(c)
					result = CType(c, UserControl)
					Exit Do
				End If
				i += 1
			Loop
			form.Close()
			Return result
		End Function
		Private clicks As Integer = 0
		Private Sub IncrementClicks()
			If clicks = 0 Then
				clicksTimer.Start()
			End If
			clicks += 1
		End Sub
		Private Sub OnXtraTabbedMdiManagerMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles xtraTabbedMdiManager1.MouseDown
			IncrementClicks()
			If clicks <> 2 Then
				Return
			End If
			Dim hitInfo As BaseTabHitInfo = (CType(sender, XtraTabbedMdiManager)).CalcHitInfo(e.Location)
			If hitInfo.HitTest = XtraTabHitTest.PageHeader Then
				ChangeWindowState((CType(hitInfo.Page, XtraMdiTabPage)).MdiChild, False)
			End If
		End Sub
		Private Sub ChangeWindowState(ByVal form As Form, ByVal mdi As Boolean)
			Dim [module] As UserControl = DetachModule(form)
			If [module] IsNot Nothing Then
				ShowModule([module], mdi)
			End If
		End Sub
		Private Sub OnClicksTimerTick(ByVal sender As Object, ByVal e As EventArgs) Handles clicksTimer.Tick
			CType(sender, Timer).Stop()
			clicks = 0
		End Sub
		Private Sub OnFormHDoubleClick(ByVal sender As Object, ByVal e As EventArgs)
			ChangeWindowState(CType(sender, Form), True)
		End Sub
	End Class
	#Region "Utils"
	Public Interface IDXSampleModule
		ReadOnly Property ModuleName() As String
	End Interface
	''' <summary>
	''' This form allows you to handle the DoubleClick in Form's header
	''' NOTE! This is a FAKE implementation, use your own instead
	''' </summary>
	Public Class FormForDXSample
		Inherits Form
		Public Sub New()
			MyBase.New()
			MinimizeBox = False
			MaximizeBox = False
		End Sub
		Protected Overrides Sub WndProc(ByRef m As Message)
			If m.Msg = &Ha3 Then
				RaiseHDoubleClick()
			End If
			MyBase.WndProc(m)
		End Sub
        Private fHDoubleClick As Object = New Object()
		Public Custom Event HDoubleClick As EventHandler
			AddHandler(ByVal value As EventHandler)
                Events.AddHandler(fHDoubleClick, value)
			End AddHandler
			RemoveHandler(ByVal value As EventHandler)
                Events.RemoveHandler(fHDoubleClick, value)
			End RemoveHandler
			RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
			End RaiseEvent
		End Event
		Private Sub RaiseHDoubleClick()
            Dim handler As EventHandler = CType(Events(fHDoubleClick), EventHandler)
			If handler IsNot Nothing Then
				handler(Me, EventArgs.Empty)
			End If
		End Sub
	End Class
	#End Region
End Namespace