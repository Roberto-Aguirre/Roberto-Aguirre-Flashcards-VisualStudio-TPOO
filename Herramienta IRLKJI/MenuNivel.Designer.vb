<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuNivel
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuNivel))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InfoALabel = New System.Windows.Forms.Label()
        Me.NombreALabel = New System.Windows.Forms.Label()
        Me.DescripcionLabel = New System.Windows.Forms.Label()
        Me.ProyectoDataSet = New Herramienta_IRLKJI.ProyectoDataSet()
        Me.ActividadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActividadesTableAdapter = New Herramienta_IRLKJI.ProyectoDataSetTableAdapters.ActividadesTableAdapter()
        Me.TableAdapterManager = New Herramienta_IRLKJI.ProyectoDataSetTableAdapters.TableAdapterManager()
        Me.ActividadesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ActividadesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ExitBT = New System.Windows.Forms.Button()
        CType(Me.ProyectoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActividadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActividadesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ActividadesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(542, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Nivel 1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(542, 221)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(190, 48)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Nivel 2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(542, 285)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(190, 48)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Nivel 3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(494, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nivel de dificultad"
        '
        'InfoALabel
        '
        Me.InfoALabel.AutoSize = True
        Me.InfoALabel.Location = New System.Drawing.Point(85, 221)
        Me.InfoALabel.MaximumSize = New System.Drawing.Size(250, 80)
        Me.InfoALabel.Name = "InfoALabel"
        Me.InfoALabel.Size = New System.Drawing.Size(76, 16)
        Me.InfoALabel.TabIndex = 9
        Me.InfoALabel.Text = "Informacion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'NombreALabel
        '
        Me.NombreALabel.AutoSize = True
        Me.NombreALabel.Font = New System.Drawing.Font("Arial Black", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreALabel.Location = New System.Drawing.Point(298, 21)
        Me.NombreALabel.Name = "NombreALabel"
        Me.NombreALabel.Size = New System.Drawing.Size(196, 48)
        Me.NombreALabel.TabIndex = 8
        Me.NombreALabel.Text = "Actividad"
        '
        'DescripcionLabel
        '
        Me.DescripcionLabel.AutoSize = True
        Me.DescripcionLabel.Location = New System.Drawing.Point(250, 120)
        Me.DescripcionLabel.MaximumSize = New System.Drawing.Size(250, 80)
        Me.DescripcionLabel.Name = "DescripcionLabel"
        Me.DescripcionLabel.Size = New System.Drawing.Size(79, 16)
        Me.DescripcionLabel.TabIndex = 10
        Me.DescripcionLabel.Text = "Descripcion"
        '
        'ProyectoDataSet
        '
        Me.ProyectoDataSet.DataSetName = "ProyectoDataSet"
        Me.ProyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ActividadesBindingSource
        '
        Me.ActividadesBindingSource.DataMember = "Actividades"
        Me.ActividadesBindingSource.DataSource = Me.ProyectoDataSet
        '
        'ActividadesTableAdapter
        '
        Me.ActividadesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActividadesTableAdapter = Me.ActividadesTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DetalleActividadTableAdapter = Nothing
        Me.TableAdapterManager.EvaluacionTableAdapter = Nothing
        Me.TableAdapterManager.HistorialTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Herramienta_IRLKJI.ProyectoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'ActividadesBindingNavigator
        '
        Me.ActividadesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ActividadesBindingNavigator.BindingSource = Me.ActividadesBindingSource
        Me.ActividadesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ActividadesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ActividadesBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ActividadesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ActividadesBindingNavigatorSaveItem})
        Me.ActividadesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ActividadesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ActividadesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ActividadesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ActividadesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ActividadesBindingNavigator.Name = "ActividadesBindingNavigator"
        Me.ActividadesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ActividadesBindingNavigator.Size = New System.Drawing.Size(808, 27)
        Me.ActividadesBindingNavigator.TabIndex = 11
        Me.ActividadesBindingNavigator.Text = "BindingNavigator1"
        Me.ActividadesBindingNavigator.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 20)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'ActividadesBindingNavigatorSaveItem
        '
        Me.ActividadesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ActividadesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ActividadesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ActividadesBindingNavigatorSaveItem.Name = "ActividadesBindingNavigatorSaveItem"
        Me.ActividadesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ActividadesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ExitBT
        '
        Me.ExitBT.Location = New System.Drawing.Point(326, 381)
        Me.ExitBT.Name = "ExitBT"
        Me.ExitBT.Size = New System.Drawing.Size(168, 57)
        Me.ExitBT.TabIndex = 18
        Me.ExitBT.Text = "Salir"
        Me.ExitBT.UseVisualStyleBackColor = True
        '
        'MenuNivel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 450)
        Me.Controls.Add(Me.ExitBT)
        Me.Controls.Add(Me.ActividadesBindingNavigator)
        Me.Controls.Add(Me.DescripcionLabel)
        Me.Controls.Add(Me.InfoALabel)
        Me.Controls.Add(Me.NombreALabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "MenuNivel"
        Me.Text = "Seleccion de Nivel"
        CType(Me.ProyectoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActividadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActividadesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ActividadesBindingNavigator.ResumeLayout(False)
        Me.ActividadesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents InfoALabel As Label
    Friend WithEvents NombreALabel As Label
    Friend WithEvents DescripcionLabel As Label
    Friend WithEvents ProyectoDataSet As ProyectoDataSet
    Friend WithEvents ActividadesBindingSource As BindingSource
    Friend WithEvents ActividadesTableAdapter As ProyectoDataSetTableAdapters.ActividadesTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ActividadesBindingNavigator As BindingNavigator
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
    Friend WithEvents ActividadesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ExitBT As Button
End Class
