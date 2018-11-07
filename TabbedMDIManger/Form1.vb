Imports Microsoft.VisualBasic
Imports Syncfusion.Windows.Forms.Tools
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace TabbedMDIManager_TabActivation
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			Me.tabbedMDIManager1.ShowCloseButton = True
			Me.tabbedMDIManager1.ShowCloseButtonForActiveTabOnly = True
			AddItems()
		End Sub


		''' <summary>
		''' Helps to add Forms
		''' </summary>
		Private Sub AddItems()
			For i As Integer = 0 To 2
				Dim form As New Form2()
				form.MdiParent = Me
				form.Text = "Form" & i
				form.Show()
			Next i
		End Sub

		''' <summary>
		''' To cancel Form from closing
		''' </summary>
		Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
			If TypeOf sender Is Form2 AndAlso e.CloseReason = CloseReason.UserClosing Then
				e.Cancel = True
			End If
		End Sub

		''' <summary>
		''' Add new Tab child. 
		''' </summary>
		Private Sub toolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripMenuItem1.Click
			Dim form As New Form2()
			form.MdiParent = Me
			form.Text = "Form"
			form.Show()
			Me.tabbedMDIManager1.ShowCloseButtonForForm(form, True)
		End Sub

		''' <summary>
		''' Update close button visibility
		''' </summary>
		Private Sub updateCloseButtonVisibilityToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles updateCloseButtonVisibilityToolStripMenuItem.Click
			For i As Integer = 0 To Me.tabbedMDIManager1.MdiChildren.Length - 1
				If i = 0 Then
					Me.tabbedMDIManager1.ShowCloseButtonForForm(Me.tabbedMDIManager1.MdiChildren(i), False)
				Else
					Me.tabbedMDIManager1.ShowCloseButtonForForm(Me.tabbedMDIManager1.MdiChildren(i), True)
				End If
			Next i
		End Sub
	End Class
End Namespace
