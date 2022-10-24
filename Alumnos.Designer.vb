<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Alumnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alumnos))
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.panelBusqueda = New System.Windows.Forms.Panel()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelContenido = New System.Windows.Forms.Panel()
        Me.panelDatos = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.txtDirección = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.txtIDNI = New System.Windows.Forms.TextBox()
        Me.lblIDNI = New System.Windows.Forms.Label()
        Me.dataAlumnos = New System.Windows.Forms.DataGridView()
        Me.panelLateral = New System.Windows.Forms.Panel()
        Me.btnNuevo = New System.Windows.Forms.PictureBox()
        Me.PanelTitulo.SuspendLayout()
        Me.panelBusqueda.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelContenido.SuspendLayout()
        Me.panelDatos.SuspendLayout()
        CType(Me.dataAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLateral.SuspendLayout()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.Blue
        Me.PanelTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelTitulo.Controls.Add(Me.lblTitulo)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(674, 39)
        Me.PanelTitulo.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.Red
        Me.btnCerrar.Location = New System.Drawing.Point(635, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(36, 32)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Lavender
        Me.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitulo.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(246, 22)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Registro Alumnos Matusita"
        '
        'panelBusqueda
        '
        Me.panelBusqueda.BackColor = System.Drawing.Color.White
        Me.panelBusqueda.Controls.Add(Me.txtBuscar)
        Me.panelBusqueda.Controls.Add(Me.PictureBox1)
        Me.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelBusqueda.Location = New System.Drawing.Point(0, 39)
        Me.panelBusqueda.Name = "panelBusqueda"
        Me.panelBusqueda.Size = New System.Drawing.Size(674, 38)
        Me.panelBusqueda.TabIndex = 1
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(62, 6)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(505, 26)
        Me.txtBuscar.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'panelContenido
        '
        Me.panelContenido.BackColor = System.Drawing.Color.White
        Me.panelContenido.Controls.Add(Me.panelDatos)
        Me.panelContenido.Controls.Add(Me.dataAlumnos)
        Me.panelContenido.Controls.Add(Me.panelLateral)
        Me.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenido.Location = New System.Drawing.Point(0, 77)
        Me.panelContenido.Name = "panelContenido"
        Me.panelContenido.Size = New System.Drawing.Size(674, 291)
        Me.panelContenido.TabIndex = 2
        '
        'panelDatos
        '
        Me.panelDatos.BackColor = System.Drawing.Color.White
        Me.panelDatos.Controls.Add(Me.Button2)
        Me.panelDatos.Controls.Add(Me.Button1)
        Me.panelDatos.Controls.Add(Me.btnGuardar)
        Me.panelDatos.Controls.Add(Me.txtObservaciones)
        Me.panelDatos.Controls.Add(Me.lblObservaciones)
        Me.panelDatos.Controls.Add(Me.txtDirección)
        Me.panelDatos.Controls.Add(Me.lblDireccion)
        Me.panelDatos.Controls.Add(Me.txtCelular)
        Me.panelDatos.Controls.Add(Me.lblTelefono)
        Me.panelDatos.Controls.Add(Me.txtNombres)
        Me.panelDatos.Controls.Add(Me.lblNombres)
        Me.panelDatos.Controls.Add(Me.txtIDNI)
        Me.panelDatos.Controls.Add(Me.lblIDNI)
        Me.panelDatos.Location = New System.Drawing.Point(4, 3)
        Me.panelDatos.Name = "panelDatos"
        Me.panelDatos.Size = New System.Drawing.Size(667, 276)
        Me.panelDatos.TabIndex = 2
        Me.panelDatos.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(441, 226)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 43)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(309, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 43)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Modificar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.LimeGreen
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(176, 228)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(126, 43)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(176, 162)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(391, 48)
        Me.txtObservaciones.TabIndex = 9
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.Location = New System.Drawing.Point(33, 174)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(114, 20)
        Me.lblObservaciones.TabIndex = 8
        Me.lblObservaciones.Text = "Observaciones"
        '
        'txtDirección
        '
        Me.txtDirección.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirección.Location = New System.Drawing.Point(176, 109)
        Me.txtDirección.Multiline = True
        Me.txtDirección.Name = "txtDirección"
        Me.txtDirección.Size = New System.Drawing.Size(391, 32)
        Me.txtDirección.TabIndex = 7
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(33, 109)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(75, 20)
        Me.lblDireccion.TabIndex = 6
        Me.lblDireccion.Text = "Dirección"
        '
        'txtCelular
        '
        Me.txtCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.Location = New System.Drawing.Point(176, 80)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(391, 26)
        Me.txtCelular.TabIndex = 5
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(33, 86)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(78, 20)
        Me.lblTelefono.TabIndex = 4
        Me.lblTelefono.Text = "N° Celular"
        '
        'txtNombres
        '
        Me.txtNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.Location = New System.Drawing.Point(176, 48)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(391, 26)
        Me.txtNombres.TabIndex = 3
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.Location = New System.Drawing.Point(33, 54)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(73, 20)
        Me.lblNombres.TabIndex = 2
        Me.lblNombres.Text = "Nombres"
        '
        'txtIDNI
        '
        Me.txtIDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDNI.Location = New System.Drawing.Point(176, 10)
        Me.txtIDNI.Name = "txtIDNI"
        Me.txtIDNI.Size = New System.Drawing.Size(391, 26)
        Me.txtIDNI.TabIndex = 1
        '
        'lblIDNI
        '
        Me.lblIDNI.AutoSize = True
        Me.lblIDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDNI.Location = New System.Drawing.Point(33, 16)
        Me.lblIDNI.Name = "lblIDNI"
        Me.lblIDNI.Size = New System.Drawing.Size(57, 20)
        Me.lblIDNI.TabIndex = 0
        Me.lblIDNI.Text = "N° DNI"
        '
        'dataAlumnos
        '
        Me.dataAlumnos.AllowUserToAddRows = False
        Me.dataAlumnos.AllowUserToDeleteRows = False
        Me.dataAlumnos.AllowUserToResizeColumns = False
        Me.dataAlumnos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dataAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataAlumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dataAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataAlumnos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataAlumnos.EnableHeadersVisualStyles = False
        Me.dataAlumnos.Location = New System.Drawing.Point(0, 0)
        Me.dataAlumnos.Name = "dataAlumnos"
        Me.dataAlumnos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataAlumnos.RowHeadersVisible = False
        Me.dataAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataAlumnos.Size = New System.Drawing.Size(573, 291)
        Me.dataAlumnos.TabIndex = 1
        '
        'panelLateral
        '
        Me.panelLateral.Controls.Add(Me.btnNuevo)
        Me.panelLateral.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelLateral.Location = New System.Drawing.Point(573, 0)
        Me.panelLateral.Name = "panelLateral"
        Me.panelLateral.Size = New System.Drawing.Size(101, 291)
        Me.panelLateral.TabIndex = 0
        '
        'btnNuevo
        '
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(3, 203)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(74, 66)
        Me.btnNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.TabStop = False
        '
        'Alumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 368)
        Me.Controls.Add(Me.panelContenido)
        Me.Controls.Add(Me.panelBusqueda)
        Me.Controls.Add(Me.PanelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Alumnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        Me.panelBusqueda.ResumeLayout(False)
        Me.panelBusqueda.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelContenido.ResumeLayout(False)
        Me.panelDatos.ResumeLayout(False)
        Me.panelDatos.PerformLayout()
        CType(Me.dataAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLateral.ResumeLayout(False)
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents panelBusqueda As Panel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelContenido As Panel
    Friend WithEvents panelLateral As Panel
    Friend WithEvents btnNuevo As PictureBox
    Friend WithEvents dataAlumnos As DataGridView
    Friend WithEvents panelDatos As Panel
    Friend WithEvents txtDirección As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents lblNombres As Label
    Friend WithEvents txtIDNI As TextBox
    Friend WithEvents lblIDNI As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents lblObservaciones As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
