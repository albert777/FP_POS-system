﻿Public Class Administrator_Main
    Private Sub Administrator_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub

    Private Sub Administrator_Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
        Dim obj = New Main_Form()
        obj.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim obj = New Main_Form()
        obj.Show()
        Me.Dispose()
    End Sub
End Class