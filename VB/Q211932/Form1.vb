﻿Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace Q211932
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Orders' table. You can move, or remove it, as needed.
			Me.ordersTableAdapter.Fill(Me.nwindDataSet.Orders)

		End Sub
	End Class
End Namespace