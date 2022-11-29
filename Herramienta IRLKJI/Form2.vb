Public Class MenuPrinciapl


    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub MenuPrinciapl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Perfil_Click(sender As Object, e As EventArgs) Handles Perfil.Click
        MenuPerfil.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles ActividadesPictureBox.Click
        MenuActividades.Show()
        Me.Close()
    End Sub
End Class