Imports Microsoft.VisualBasic
Imports System
Namespace TabbedMDIManager_TabActivation
	Partial Public Class Form1
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
			Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
			Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
			Me.tabbedMDIManager1 = New Syncfusion.Windows.Forms.Tools.TabbedMDIManager()
			Me.updateCloseButtonVisibilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.menuStrip1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' menuStrip1
			' 
			Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripMenuItem1, Me.toolStripMenuItem2, Me.updateCloseButtonVisibilityToolStripMenuItem})
			Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
			Me.menuStrip1.Name = "menuStrip1"
			Me.menuStrip1.Size = New System.Drawing.Size(956, 24)
			Me.menuStrip1.TabIndex = 1
			Me.menuStrip1.Text = "menuStrip1"
			' 
			' toolStripMenuItem1
			' 
			Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
			Me.toolStripMenuItem1.Size = New System.Drawing.Size(97, 20)
			Me.toolStripMenuItem1.Text = "Add new Form"
'			Me.toolStripMenuItem1.Click += New System.EventHandler(Me.toolStripMenuItem1_Click)
			' 
			' toolStripMenuItem2
			' 
			Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
			Me.toolStripMenuItem2.Size = New System.Drawing.Size(12, 20)
			' 
			' updateCloseButtonVisibilityToolStripMenuItem
			' 
			Me.updateCloseButtonVisibilityToolStripMenuItem.Name = "updateCloseButtonVisibilityToolStripMenuItem"
			Me.updateCloseButtonVisibilityToolStripMenuItem.Size = New System.Drawing.Size(172, 20)
			Me.updateCloseButtonVisibilityToolStripMenuItem.Text = "Update close Button visibility"
'			Me.updateCloseButtonVisibilityToolStripMenuItem.Click += New System.EventHandler(Me.updateCloseButtonVisibilityToolStripMenuItem_Click)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(956, 621)
			Me.Controls.Add(Me.menuStrip1)
			Me.Cursor = System.Windows.Forms.Cursors.Default
			Me.IsMdiContainer = True
			Me.tabbedMDIManager1.AttachToMdiContainer(Me)
			Me.MainMenuStrip = Me.menuStrip1
			Me.Margin = New System.Windows.Forms.Padding(2)
			Me.Name = "Form1"
			Me.Text = "TabbedMDIManager"
			Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
			Me.menuStrip1.ResumeLayout(False)
			Me.menuStrip1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private tabbedMDIManager1 As Syncfusion.Windows.Forms.Tools.TabbedMDIManager
		Private menuStrip1 As System.Windows.Forms.MenuStrip
		Private WithEvents toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents updateCloseButtonVisibilityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	End Class
End Namespace

