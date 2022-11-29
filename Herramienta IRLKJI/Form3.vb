Public Class RegistarCuenta
    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsuariosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProyectoDataSet)

    End Sub

    Private Sub RegistarCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProyectoDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.ProyectoDataSet.Usuarios)
        SexoComboBox.Items.Add("Masculino")
        SexoComboBox.Items.Add("Femenino")
        SexoComboBox.Items.Add("Otro")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub RegistrarBT_Click(sender As Object, e As EventArgs) Handles RegistrarBT.Click
        Dim Read As Boolean
        Dim User As String
        Nulo = ""
        Read = NombreTextBox.Text IsNot Nulo AndAlso ApellidoTextBox.Text IsNot Nulo AndAlso EdadTextBox.Text IsNot Nulo AndAlso SexoComboBox.Text IsNot Nulo
        Read = CorreoTextBox.Text IsNot Nulo AndAlso TelefonoTextBox.Text IsNot Nulo
        If UsuarioTextBox.Text IsNot Nulo Then
            User = Me.UsuariosTableAdapter.BUsuario(UsuarioTextBox.Text)
            If StrComp(Nulo, User, vbBinaryCompare) = 0 Then
                If ContraseñaTextBox.Text IsNot Nulo Then
                    If Read Then
                        Registro()
                    Else
                        MsgBox("Toodos los recaudros son obligatorios a excepcion del correo electronico y el numero de telefono.")
                    End If
                Else
                    MsgBox("Debe ingresar una contraseña")
                End If
            Else
                MsgBox("El nombre de usuario ya esta registrado, escriba otro.")
            End If
        Else
            MsgBox("Debe ingresar un nombre de usuario.")
        End If
    End Sub

    Private Sub Registro()
        Me.UsuariosTableAdapter.RegistrarUsuario(UsuarioTextBox.Text, NombreTextBox.Text, ApellidoTextBox.Text, EdadTextBox.Text, SexoComboBox.Text, CorreoTextBox.Text, TelefonoTextBox.Text, ContraseñaTextBox.Text)
        Me.UsuariosTableAdapter.Fill(Me.ProyectoDataSet.Usuarios)
        MsgBox("La cuenta ha sido registrada")
SaveErr:
    End Sub
    Private Sub Clear()
        UsuarioTextBox.Text = Nulo
        NombreTextBox.Text = Nulo
    End Sub
End Class