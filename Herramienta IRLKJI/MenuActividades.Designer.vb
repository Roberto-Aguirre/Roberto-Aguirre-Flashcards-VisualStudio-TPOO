<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuActividades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuActividades))
        Me.NumerosPictureBox = New System.Windows.Forms.PictureBox()
        Me.AhorcadoPictureBox = New System.Windows.Forms.PictureBox()
        Me.ActividadesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ActividadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.ActividadesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TableAdapterManager = New Herramienta_IRLKJI.ProyectoDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NombreALabel = New System.Windows.Forms.Label()
        Me.InfoALabel = New System.Windows.Forms.Label()
        Me.ActividadesTableAdapter = New Herramienta_IRLKJI.ProyectoDataSetTableAdapters.ActividadesTableAdapter()
        Me.ExitBT = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.NumerosPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AhorcadoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActividadesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ActividadesBindingNavigator.SuspendLayout()
        CType(Me.ActividadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumerosPictureBox
        '
        Me.NumerosPictureBox.Image = CType(resources.GetObject("NumerosPictureBox.Image"), System.Drawing.Image)
        Me.NumerosPictureBox.Location = New System.Drawing.Point(470, 84)
        Me.NumerosPictureBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NumerosPictureBox.Name = "NumerosPictureBox"
        Me.NumerosPictureBox.Size = New System.Drawing.Size(75, 82)
        Me.NumerosPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NumerosPictureBox.TabIndex = 0
        Me.NumerosPictureBox.TabStop = False
        Me.NumerosPictureBox.Tag = ""
        '
        'AhorcadoPictureBox
        '
        Me.AhorcadoPictureBox.Image = Global.Herramienta_IRLKJI.My.Resources.Resources.Imagen5
        Me.AhorcadoPictureBox.Location = New System.Drawing.Point(359, 84)
        Me.AhorcadoPictureBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AhorcadoPictureBox.Name = "AhorcadoPictureBox"
        Me.AhorcadoPictureBox.Size = New System.Drawing.Size(75, 82)
        Me.AhorcadoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AhorcadoPictureBox.TabIndex = 1
        Me.AhorcadoPictureBox.TabStop = False
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
        Me.ActividadesBindingNavigator.Size = New System.Drawing.Size(600, 22)
        Me.ActividadesBindingNavigator.TabIndex = 2
        Me.ActividadesBindingNavigator.Text = "BindingNavigator1"
        Me.ActividadesBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(26, 19)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'ActividadesBindingSource
        '
        Me.ActividadesBindingSource.DataMember = "Actividades"
        Me.ActividadesBindingSource.DataSource = Me.ProyectoDataSet
        '
        'ProyectoDataSet
        '
        Me.ProyectoDataSet.DataSetName = "ProyectoDataSet"
        Me.ProyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 19)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(26, 19)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(26, 19)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(26, 19)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 22)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(38, 26)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 22)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(26, 19)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(26, 19)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 22)
        '
        'ActividadesBindingNavigatorSaveItem
        '
        Me.ActividadesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ActividadesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ActividadesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ActividadesBindingNavigatorSaveItem.Name = "ActividadesBindingNavigatorSaveItem"
        Me.ActividadesBindingNavigatorSaveItem.Size = New System.Drawing.Size(26, 19)
        Me.ActividadesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActividadesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DetalleActividadTableAdapter = Nothing
        Me.TableAdapterManager.EvaluacionTableAdapter = Nothing
        Me.TableAdapterManager.HistorialTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Herramienta_IRLKJI.ProyectoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(202, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 44)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Actividades"
        '
        'NombreALabel
        '
        Me.NombreALabel.AutoSize = True
        Me.NombreALabel.Font = New System.Drawing.Font("Arial Black", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreALabel.Location = New System.Drawing.Point(45, 210)
        Me.NombreALabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NombreALabel.Name = "NombreALabel"
        Me.NombreALabel.Size = New System.Drawing.Size(144, 36)
        Me.NombreALabel.TabIndex = 6
        Me.NombreALabel.Text = "Actividad"
        '
        'InfoALabel
        '
        Me.InfoALabel.AutoSize = True
        Me.InfoALabel.Location = New System.Drawing.Point(16, 254)
        Me.InfoALabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.InfoALabel.MaximumSize = New System.Drawing.Size(188, 65)
        Me.InfoALabel.Name = "InfoALabel"
        Me.InfoALabel.Size = New System.Drawing.Size(62, 13)
        Me.InfoALabel.TabIndex = 7
        Me.InfoALabel.Text = "Informacion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ActividadesTableAdapter
        '
        Me.ActividadesTableAdapter.ClearBeforeFill = True
        '
        'ExitBT
        '
        Me.ExitBT.Location = New System.Drawing.Point(401, 284)
        Me.ExitBT.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ExitBT.Name = "ExitBT"
        Me.ExitBT.Size = New System.Drawing.Size(126, 46)
        Me.ExitBT.TabIndex = 17
        Me.ExitBT.Text = "Salir"
        Me.ExitBT.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Herramienta_IRLKJI.My.Resources.Resources.Imagen5
        Me.PictureBox1.Location = New System.Drawing.Point(254, 84)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'MenuActividades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ExitBT)
        Me.Controls.Add(Me.InfoALabel)
        Me.Controls.Add(Me.NombreALabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ActividadesBindingNavigator)
        Me.Controls.Add(Me.AhorcadoPictureBox)
        Me.Controls.Add(Me.NumerosPictureBox)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "MenuActividades"
        Me.Text = "Actividades"
        CType(Me.NumerosPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AhorcadoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActividadesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ActividadesBindingNavigator.ResumeLayout(False)
        Me.ActividadesBindingNavigator.PerformLayout()
        CType(Me.ActividadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NumerosPictureBox As PictureBox
    Friend WithEvents AhorcadoPictureBox As PictureBox
    Friend WithEvents ProyectoDataSet As ProyectoDataSet
    Friend WithEvents ActividadesBindingSource As BindingSource
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
    Friend WithEvents Label1 As Label
    Friend WithEvents NombreALabel As Label
    Friend WithEvents InfoALabel As Label
    Friend WithEvents ActividadesTableAdapter As ProyectoDataSetTableAdapters.ActividadesTableAdapter
    Friend WithEvents ExitBT As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
