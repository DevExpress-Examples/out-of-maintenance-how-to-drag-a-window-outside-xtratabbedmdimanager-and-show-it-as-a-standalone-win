Imports Microsoft.VisualBasic
Imports System
Namespace Q205699
	Partial Public Class MainForm
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.xtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
			Me.clicksTimer = New System.Windows.Forms.Timer(Me.components)
			CType(Me.xtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabbedMdiManager1
			' 
			Me.xtraTabbedMdiManager1.MdiParent = Me
'			Me.xtraTabbedMdiManager1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.OnXtraTabbedMdiManagerMouseDown);
			' 
			' clicksTimer
			' 
			Me.clicksTimer.Interval = 500
'			Me.clicksTimer.Tick += New System.EventHandler(Me.OnClicksTimerTick);
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(674, 523)
			Me.IsMdiContainer = True
			Me.Name = "MainForm"
			Me.Text = "Form1"
			CType(Me.xtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents xtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
		Private WithEvents clicksTimer As System.Windows.Forms.Timer
	End Class
End Namespace

