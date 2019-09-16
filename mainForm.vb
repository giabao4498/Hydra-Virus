Imports System.ComponentModel

Public Module GlobalVariables
    Public isFirstForm As Boolean = True
End Module

Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oathLabel.Text = "Cut off one head, two more shall take its place!" + Environment.NewLine + "Hail Hydra!"

        If (isFirstForm = True) Then
            isFirstForm = False
        Else
            Randomize()
            Me.Location = New Point(Rnd() * (Screen.PrimaryScreen.Bounds.Width - Me.Width + 1),
                                    Rnd() * (Screen.PrimaryScreen.Bounds.Height - Me.Height + 1))
        End If

        System.Media.SystemSounds.Hand.Play()
    End Sub

    Private Sub mainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
        Dim newForm1 As New mainForm, newForm2 As New mainForm
        newForm1.Show()
        newForm2.Show()
        e.Cancel = True
    End Sub
End Class