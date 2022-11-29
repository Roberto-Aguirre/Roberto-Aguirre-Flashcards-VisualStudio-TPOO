Public Class Flashcards1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click, Button5.Click, Button4.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) 
        MenuActividades.Show()
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) 
        EJERCICIO.Show()
        Me.Close()

    End Sub

    Private Sub Flashcards1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click, Label4.Click

    End Sub
End Class