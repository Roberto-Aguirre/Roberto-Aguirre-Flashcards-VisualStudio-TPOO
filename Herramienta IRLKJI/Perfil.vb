Public Class MenuPerfil
    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProyectoDataSet)

    End Sub

    Private Sub UsuariosBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles UsuariosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProyectoDataSet)

    End Sub

    Private Sub Perfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProyectoDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.ProyectoDataSet.Usuarios)
        InfoUsuario()
    End Sub
    Private Sub InfoUsuario()
        MostrarUsuarioLabel.Text = UsuarioActual
        MostrarNombreLabel.Text = Me.UsuariosTableAdapter.BNombre(UsuarioActual)
        MostrarApellidoLabel.Text = Me.UsuariosTableAdapter.BApellido(UsuarioActual)
        MostrarEdadLabel.Text = Me.UsuariosTableAdapter.BEdad(UsuarioActual)
        MostrarSexoLabel.Text = Me.UsuariosTableAdapter.BSexo(UsuarioActual)
        MostrarCorreoLabel.Text = Me.UsuariosTableAdapter.BCorreo(UsuarioActual)
        MostrarTelefonoLabel.Text = Me.UsuariosTableAdapter.BTelefono(UsuarioActual)
    End Sub
    Private Sub ExitBT_Click(sender As Object, e As EventArgs) Handles ExitBT.Click
        Me.Close()
        MenuPrinciapl.Show()
    End Sub
End Class