<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPerfil
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim U_NombreLabel As System.Windows.Forms.Label
        Dim U_ApellidoLabel As System.Windows.Forms.Label
        Dim U_EdadLabel As System.Windows.Forms.Label
        Dim U_SexoLabel As System.Windows.Forms.Label
        Dim U_CorreoLabel As System.Windows.Forms.Label
        Dim U_TelefonoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPerfil))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UsuariosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectoDataSet = New Herramienta_IRLKJI.ProyectoDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UsuariosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ExitBT = New System.Windows.Forms.Button()
        Me.UsuariosTableAdapter = New Herramienta_IRLKJI.ProyectoDataSetTableAdapters.UsuariosTableAdapter()
        Me.TableAdapterManager = New Herramienta_IRLKJI.ProyectoDataSetTableAdapters.TableAdapterManager()
        Me.MostrarNombreLabel = New System.Windows.Forms.Label()
        Me.MostrarEdadLabel = New System.Windows.Forms.Label()
        Me.MostrarApellidoLabel = New System.Windows.Forms.Label()
        Me.MostrarSexoLabel = New System.Windows.Forms.Label()
        Me.MostrarTelefonoLabel = New System.Windows.Forms.Label()
        Me.MostrarCorreoLabel = New System.Windows.Forms.Label()
        Me.MostrarUsuarioLabel = New System.Windows.Forms.Label()
        U_NombreLabel = New System.Windows.Forms.Label()
        U_ApellidoLabel = New System.Windows.Forms.Label()
        U_EdadLabel = New System.Windows.Forms.Label()
        U_SexoLabel = New System.Windows.Forms.Label()
        U_CorreoLabel = New System.Windows.Forms.Label()
        U_TelefonoLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UsuariosBindingNavigator.SuspendLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'U_NombreLabel
        '
        U_NombreLabel.AutoSize = True
        U_NombreLabel.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        U_NombreLabel.Location = New System.Drawing.Point(12, 181)
        U_NombreLabel.Name = "U_NombreLabel"
        U_NombreLabel.Size = New System.Drawing.Size(104, 28)
        U_NombreLabel.TabIndex = 4
        U_NombreLabel.Text = "Nombre:"
        '
        'U_ApellidoLabel
        '
        U_ApellidoLabel.AutoSize = True
        U_ApellidoLabel.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        U_ApellidoLabel.Location = New System.Drawing.Point(12, 226)
        U_ApellidoLabel.Name = "U_ApellidoLabel"
        U_ApellidoLabel.Size = New System.Drawing.Size(108, 28)
        U_ApellidoLabel.TabIndex = 6
        U_ApellidoLabel.Text = "Apellido:"
        '
        'U_EdadLabel
        '
        U_EdadLabel.AutoSize = True
        U_EdadLabel.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        U_EdadLabel.Location = New System.Drawing.Point(12, 276)
        U_EdadLabel.Name = "U_EdadLabel"
        U_EdadLabel.Size = New System.Drawing.Size(72, 28)
        U_EdadLabel.TabIndex = 8
        U_EdadLabel.Text = "Edad:"
        '
        'U_SexoLabel
        '
        U_SexoLabel.AutoSize = True
        U_SexoLabel.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        U_SexoLabel.Location = New System.Drawing.Point(12, 316)
        U_SexoLabel.Name = "U_SexoLabel"
        U_SexoLabel.Size = New System.Drawing.Size(71, 28)
        U_SexoLabel.TabIndex = 10
        U_SexoLabel.Text = "Sexo:"
        '
        'U_CorreoLabel
        '
        U_CorreoLabel.AutoSize = True
        U_CorreoLabel.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        U_CorreoLabel.Location = New System.Drawing.Point(12, 361)
        U_CorreoLabel.Name = "U_CorreoLabel"
        U_CorreoLabel.Size = New System.Drawing.Size(93, 28)
        U_CorreoLabel.TabIndex = 12
        U_CorreoLabel.Text = "Correo:"
        '
        'U_TelefonoLabel
        '
        U_TelefonoLabel.AutoSize = True
        U_TelefonoLabel.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        U_TelefonoLabel.Location = New System.Drawing.Point(12, 404)
        U_TelefonoLabel.Name = "U_TelefonoLabel"
        U_TelefonoLabel.Size = New System.Drawing.Size(112, 28)
        U_TelefonoLabel.TabIndex = 14
        U_TelefonoLabel.Text = "Telefono:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(68, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'UsuariosBindingNavigator
        '
        Me.UsuariosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UsuariosBindingNavigator.BindingSource = Me.UsuariosBindingSource
        Me.UsuariosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UsuariosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UsuariosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.UsuariosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UsuariosBindingNavigatorSaveItem})
        Me.UsuariosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UsuariosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UsuariosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UsuariosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UsuariosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UsuariosBindingNavigator.Name = "UsuariosBindingNavigator"
        Me.UsuariosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UsuariosBindingNavigator.Size = New System.Drawing.Size(800, 27)
        Me.UsuariosBindingNavigator.TabIndex = 1
        Me.UsuariosBindingNavigator.Text = "BindingNavigator1"
        Me.UsuariosBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.ProyectoDataSet
        '
        'ProyectoDataSet
        '
        Me.ProyectoDataSet.DataSetName = "ProyectoDataSet"
        Me.ProyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'UsuariosBindingNavigatorSaveItem
        '
        Me.UsuariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UsuariosBindingNavigatorSaveItem.Image = CType(resources.GetObject("UsuariosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UsuariosBindingNavigatorSaveItem.Name = "UsuariosBindingNavigatorSaveItem"
        Me.UsuariosBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.UsuariosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ExitBT
        '
        Me.ExitBT.Location = New System.Drawing.Point(647, 393)
        Me.ExitBT.Name = "ExitBT"
        Me.ExitBT.Size = New System.Drawing.Size(168, 57)
        Me.ExitBT.TabIndex = 16
        Me.ExitBT.Text = "Salir"
        Me.ExitBT.UseVisualStyleBackColor = True
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActividadesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DetalleActividadTableAdapter = Nothing
        Me.TableAdapterManager.EvaluacionTableAdapter = Nothing
        Me.TableAdapterManager.HistorialTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Herramienta_IRLKJI.ProyectoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Me.UsuariosTableAdapter
        '
        'MostrarNombreLabel
        '
        Me.MostrarNombreLabel.AutoSize = True
        Me.MostrarNombreLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MostrarNombreLabel.Location = New System.Drawing.Point(132, 184)
        Me.MostrarNombreLabel.MaximumSize = New System.Drawing.Size(150, 23)
        Me.MostrarNombreLabel.Name = "MostrarNombreLabel"
        Me.MostrarNombreLabel.Size = New System.Drawing.Size(69, 23)
        Me.MostrarNombreLabel.TabIndex = 17
        Me.MostrarNombreLabel.Text = "Label1"
        '
        'MostrarEdadLabel
        '
        Me.MostrarEdadLabel.AutoSize = True
        Me.MostrarEdadLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MostrarEdadLabel.Location = New System.Drawing.Point(132, 279)
        Me.MostrarEdadLabel.MaximumSize = New System.Drawing.Size(150, 23)
        Me.MostrarEdadLabel.Name = "MostrarEdadLabel"
        Me.MostrarEdadLabel.Size = New System.Drawing.Size(69, 23)
        Me.MostrarEdadLabel.TabIndex = 18
        Me.MostrarEdadLabel.Text = "Label1"
        '
        'MostrarApellidoLabel
        '
        Me.MostrarApellidoLabel.AutoSize = True
        Me.MostrarApellidoLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MostrarApellidoLabel.Location = New System.Drawing.Point(132, 229)
        Me.MostrarApellidoLabel.MaximumSize = New System.Drawing.Size(150, 23)
        Me.MostrarApellidoLabel.Name = "MostrarApellidoLabel"
        Me.MostrarApellidoLabel.Size = New System.Drawing.Size(69, 23)
        Me.MostrarApellidoLabel.TabIndex = 19
        Me.MostrarApellidoLabel.Text = "Label1"
        '
        'MostrarSexoLabel
        '
        Me.MostrarSexoLabel.AutoSize = True
        Me.MostrarSexoLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MostrarSexoLabel.Location = New System.Drawing.Point(132, 319)
        Me.MostrarSexoLabel.MaximumSize = New System.Drawing.Size(150, 23)
        Me.MostrarSexoLabel.Name = "MostrarSexoLabel"
        Me.MostrarSexoLabel.Size = New System.Drawing.Size(69, 23)
        Me.MostrarSexoLabel.TabIndex = 20
        Me.MostrarSexoLabel.Text = "Label1"
        '
        'MostrarTelefonoLabel
        '
        Me.MostrarTelefonoLabel.AutoSize = True
        Me.MostrarTelefonoLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MostrarTelefonoLabel.Location = New System.Drawing.Point(132, 407)
        Me.MostrarTelefonoLabel.MaximumSize = New System.Drawing.Size(150, 23)
        Me.MostrarTelefonoLabel.Name = "MostrarTelefonoLabel"
        Me.MostrarTelefonoLabel.Size = New System.Drawing.Size(69, 23)
        Me.MostrarTelefonoLabel.TabIndex = 22
        Me.MostrarTelefonoLabel.Text = "Label1"
        '
        'MostrarCorreoLabel
        '
        Me.MostrarCorreoLabel.AutoSize = True
        Me.MostrarCorreoLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MostrarCorreoLabel.Location = New System.Drawing.Point(132, 364)
        Me.MostrarCorreoLabel.MaximumSize = New System.Drawing.Size(150, 23)
        Me.MostrarCorreoLabel.Name = "MostrarCorreoLabel"
        Me.MostrarCorreoLabel.Size = New System.Drawing.Size(69, 23)
        Me.MostrarCorreoLabel.TabIndex = 23
        Me.MostrarCorreoLabel.Text = "Label1"
        '
        'MostrarUsuarioLabel
        '
        Me.MostrarUsuarioLabel.AutoSize = True
        Me.MostrarUsuarioLabel.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MostrarUsuarioLabel.Location = New System.Drawing.Point(77, 30)
        Me.MostrarUsuarioLabel.MaximumSize = New System.Drawing.Size(100, 23)
        Me.MostrarUsuarioLabel.Name = "MostrarUsuarioLabel"
        Me.MostrarUsuarioLabel.Size = New System.Drawing.Size(84, 23)
        Me.MostrarUsuarioLabel.TabIndex = 24
        Me.MostrarUsuarioLabel.Text = "Label1"
        Me.MostrarUsuarioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 491)
        Me.Controls.Add(Me.MostrarUsuarioLabel)
        Me.Controls.Add(Me.MostrarCorreoLabel)
        Me.Controls.Add(Me.MostrarTelefonoLabel)
        Me.Controls.Add(Me.MostrarSexoLabel)
        Me.Controls.Add(Me.MostrarApellidoLabel)
        Me.Controls.Add(Me.MostrarEdadLabel)
        Me.Controls.Add(Me.MostrarNombreLabel)
        Me.Controls.Add(Me.ExitBT)
        Me.Controls.Add(U_TelefonoLabel)
        Me.Controls.Add(U_CorreoLabel)
        Me.Controls.Add(U_SexoLabel)
        Me.Controls.Add(U_EdadLabel)
        Me.Controls.Add(U_ApellidoLabel)
        Me.Controls.Add(U_NombreLabel)
        Me.Controls.Add(Me.UsuariosBindingNavigator)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MenuPerfil"
        Me.Text = "Perfil"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UsuariosBindingNavigator.ResumeLayout(False)
        Me.UsuariosBindingNavigator.PerformLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ProyectoDataSet As ProyectoDataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As ProyectoDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsuariosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents UsuariosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ExitBT As Button
    Friend WithEvents MostrarNombreLabel As Label
    Friend WithEvents MostrarEdadLabel As Label
    Friend WithEvents MostrarApellidoLabel As Label
    Friend WithEvents MostrarSexoLabel As Label
    Friend WithEvents MostrarTelefonoLabel As Label
    Friend WithEvents MostrarCorreoLabel As Label
    Friend WithEvents MostrarUsuarioLabel As Label
End Class
