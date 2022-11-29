Public Class MenuNivel
    Private Sub MenuNivel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProyectoDataSet.Actividades' Puede moverla o quitarla según sea necesario.
        Me.ActividadesTableAdapter.Fill(Me.ProyectoDataSet.Actividades)
        MostrarInfo()
    End Sub

    Private Sub ActividadesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ActividadesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ActividadesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProyectoDataSet)

    End Sub

    Private Sub MostrarInfo()
        NombreALabel.Text = Me.ActividadesTableAdapter.MostrarActividadN(ActividadSeleccionada)
        InfoALabel.Text = Me.ActividadesTableAdapter.MostrarActividadI(ActividadSeleccionada)
        DescripcionLabel.Text = Me.ActividadesTableAdapter.MostrarActividadD(ActividadSeleccionada)
    End Sub

    Private Sub ExitBT_Click(sender As Object, e As EventArgs) Handles ExitBT.Click
        MenuActividades.Show()
        Me.Close()
    End Sub
End Class