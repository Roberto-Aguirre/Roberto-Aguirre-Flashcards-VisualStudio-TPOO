<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrinciapl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrinciapl))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Salir = New System.Windows.Forms.PictureBox()
        Me.Perfil = New System.Windows.Forms.PictureBox()
        Me.ActividadesPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.Salir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Perfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActividadesPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(161, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Menu Principal"
        '
        'Salir
        '
        Me.Salir.Image = CType(resources.GetObject("Salir.Image"), System.Drawing.Image)
        Me.Salir.Location = New System.Drawing.Point(392, 126)
        Me.Salir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(91, 95)
        Me.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Salir.TabIndex = 3
        Me.Salir.TabStop = False
        '
        'Perfil
        '
        Me.Perfil.Image = CType(resources.GetObject("Perfil.Image"), System.Drawing.Image)
        Me.Perfil.Location = New System.Drawing.Point(88, 116)
        Me.Perfil.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Perfil.Name = "Perfil"
        Me.Perfil.Size = New System.Drawing.Size(98, 112)
        Me.Perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Perfil.TabIndex = 4
        Me.Perfil.TabStop = False
        '
        'ActividadesPictureBox
        '
        Me.ActividadesPictureBox.Image = CType(resources.GetObject("ActividadesPictureBox.Image"), System.Drawing.Image)
        Me.ActividadesPictureBox.Location = New System.Drawing.Point(231, 116)
        Me.ActividadesPictureBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ActividadesPictureBox.Name = "ActividadesPictureBox"
        Me.ActividadesPictureBox.Size = New System.Drawing.Size(110, 112)
        Me.ActividadesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ActividadesPictureBox.TabIndex = 6
        Me.ActividadesPictureBox.TabStop = False
        '
        'MenuPrinciapl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.ActividadesPictureBox)
        Me.Controls.Add(Me.Perfil)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "MenuPrinciapl"
        Me.Text = "Menu Principal"
        CType(Me.Salir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Perfil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActividadesPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Salir As PictureBox
    Friend WithEvents Perfil As PictureBox
    Friend WithEvents ActividadesPictureBox As PictureBox
End Class
