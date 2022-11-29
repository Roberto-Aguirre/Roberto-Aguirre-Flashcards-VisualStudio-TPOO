Public Class Form1

    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProyectoDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)
        'TODO: esta línea de código carga datos en la tabla 'ProyectoDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.ProyectoDataSet.Usuarios)
    End Sub

    Private Sub UsuariosBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProyectoDataSet)

    End Sub

    Private Sub UsuariosBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs) Handles UsuariosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProyectoDataSet)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim UserD, UserP, PswD, PswP As String
        Dim P As Integer
        Nulo = ""
        If Id_UsuarioTextBox.Text IsNot Nulo And U_ContraseñaTextBox.Text IsNot Nulo Then
            UserD = Me.UsuariosTableAdapter.BUsuario(Id_UsuarioTextBox.Text)
            UserP = Id_UsuarioTextBox.Text
            P = StrComp(UserP, UserD, vbBinaryCompare)
            If P = 0 Then
                PswD = Me.UsuariosTableAdapter.BContraseña(UserD)
                PswP = U_ContraseñaTextBox.Text
                P = StrComp(PswP, PswD, vbBinaryCompare)
                If P = 0 Then
                    MenuPrinciapl.Show()
                    Me.Hide()
                    UsuarioActual = UserD
                Else
                    MsgBox("La contraseña es incorrecta")
                End If
            Else
                MsgBox("El usuario no esta registrado o lo ha escrito incorrectamente, asegure de escribir correctamente su nombre usario.")
            End If
        Else
            MsgBox("Debe llenar todos los espacios")
        End If
    End Sub


    Private Sub Clear()
        Id_UsuarioTextBox.Text = Nulo
        U_ContraseñaTextBox.Text = Nulo
    End Sub
    Private Sub Registro_Click(sender As Object, e As EventArgs) Handles Registro.Click
        RegistarCuenta.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Clear()
    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
