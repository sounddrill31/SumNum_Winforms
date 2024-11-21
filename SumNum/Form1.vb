Imports System.ComponentModel

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' handle result

        Dim Limit As Integer = Integer.Parse(LimitN.Text)
        Dim arr(Limit) As Integer
        Dim p_n = 0
        Dim n_n = 0


        For i As Integer = 0 To (Limit - 1)
            Dim temp As String = InputBox("Enter Element")
            If (Integer.Parse(temp) >= 0) Then
                p_n = p_n + Integer.Parse(temp)
            Else
                n_n = n_n + Integer.Parse(temp)
            End If
        Next i

        PositiveSum.Text = p_n
        NegativeSum.Text = n_n
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' clear the screen
        LimitN.Text = String.Empty
        PositiveSum.Text = String.Empty
        NegativeSum.Text = String.Empty
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Exit program
        Close()
    End Sub
End Class
