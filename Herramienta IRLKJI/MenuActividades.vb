Public Class MenuActividades
    Dim ActividadM As Integer
    Private Sub MenuActividades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProyectoDataSet.Actividades' Puede moverla o quitarla según sea necesario.
        Me.ActividadesTableAdapter.Fill(Me.ProyectoDataSet.Actividades)
        NombreALabel.Text = Nulo
        InfoALabel.Text = Nulo
    End Sub

    Private Sub ActividadesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ActividadesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ActividadesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProyectoDataSet)

    End Sub

    Private Sub MostrarInformacion(Act As Integer)
        NombreALabel.Text = Me.ActividadesTableAdapter.MostrarActividadN(Act)
        InfoALabel.Text = Me.ActividadesTableAdapter.MostrarActividadD(Act)
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles AhorcadoPictureBox.MouseEnter
        ActividadM = 3
        MostrarInformacion(ActividadM)
    End Sub

    Private Sub NumerosPictureBox_MouseEnter(sender As Object, e As EventArgs) Handles NumerosPictureBox.MouseEnter
        ActividadM = 2
        MostrarInformacion(ActividadM)
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles AhorcadoPictureBox.MouseLeave, NumerosPictureBox.MouseLeave
        NombreALabel.Text = Nulo
        InfoALabel.Text = Nulo
    End Sub

    Private Sub ExitBT_Click(sender As Object, e As EventArgs) Handles ExitBT.Click
        MenuPrinciapl.Show()
        Me.Close()
    End Sub


    Private Sub PictureBox_Click(sender As Object, e As EventArgs) Handles NumerosPictureBox.Click, AhorcadoPictureBox.Click
        ActividadSeleccionada = ActividadM
        MenuNivel.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Flashcards1.Show()
        Me.Close()

    End Sub
End Class