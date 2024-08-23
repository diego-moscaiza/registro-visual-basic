<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usuariosOK
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelRegistro = New System.Windows.Forms.Panel()
        Me.TxtVendedor = New System.Windows.Forms.Label()
        Me.LblVendedor = New System.Windows.Forms.Label()
        Me.CbxVendedor = New System.Windows.Forms.CheckBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnGuardarCambios = New System.Windows.Forms.Button()
        Me.TxtLogin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataListado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdUsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreyApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIO2TableAdapter = New SistemaProyecto.BASEMAGBRIDataSetTableAdapters.USUARIO2TableAdapter()
        Me.BASEMAGBRIDataSet = New SistemaProyecto.BASEMAGBRIDataSet()
        Me.USUARIO2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtDNI = New System.Windows.Forms.MaskedTextBox()
        Me.PanelRegistro.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BASEMAGBRIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USUARIO2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelRegistro
        '
        Me.PanelRegistro.BackColor = System.Drawing.Color.White
        Me.PanelRegistro.Controls.Add(Me.TxtDNI)
        Me.PanelRegistro.Controls.Add(Me.TxtVendedor)
        Me.PanelRegistro.Controls.Add(Me.LblVendedor)
        Me.PanelRegistro.Controls.Add(Me.CbxVendedor)
        Me.PanelRegistro.Controls.Add(Me.TxtPassword)
        Me.PanelRegistro.Controls.Add(Me.BtnVolver)
        Me.PanelRegistro.Controls.Add(Me.BtnGuardar)
        Me.PanelRegistro.Controls.Add(Me.Label5)
        Me.PanelRegistro.Controls.Add(Me.BtnGuardarCambios)
        Me.PanelRegistro.Controls.Add(Me.TxtLogin)
        Me.PanelRegistro.Controls.Add(Me.Label4)
        Me.PanelRegistro.Controls.Add(Me.TxtTelefono)
        Me.PanelRegistro.Controls.Add(Me.Label3)
        Me.PanelRegistro.Controls.Add(Me.Label2)
        Me.PanelRegistro.Controls.Add(Me.TxtNombreCompleto)
        Me.PanelRegistro.Controls.Add(Me.Label1)
        Me.PanelRegistro.Location = New System.Drawing.Point(0, 0)
        Me.PanelRegistro.Name = "PanelRegistro"
        Me.PanelRegistro.Size = New System.Drawing.Size(519, 287)
        Me.PanelRegistro.TabIndex = 22
        '
        'TxtVendedor
        '
        Me.TxtVendedor.AutoSize = True
        Me.TxtVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVendedor.Location = New System.Drawing.Point(37, 192)
        Me.TxtVendedor.Name = "TxtVendedor"
        Me.TxtVendedor.Size = New System.Drawing.Size(79, 20)
        Me.TxtVendedor.TabIndex = 26
        Me.TxtVendedor.Text = "Vendedor"
        '
        'LblVendedor
        '
        Me.LblVendedor.AutoSize = True
        Me.LblVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVendedor.Location = New System.Drawing.Point(261, 195)
        Me.LblVendedor.Name = "LblVendedor"
        Me.LblVendedor.Size = New System.Drawing.Size(20, 20)
        Me.LblVendedor.TabIndex = 25
        Me.LblVendedor.Text = "X"
        '
        'CbxVendedor
        '
        Me.CbxVendedor.AutoSize = True
        Me.CbxVendedor.BackColor = System.Drawing.Color.Transparent
        Me.CbxVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxVendedor.ForeColor = System.Drawing.Color.Transparent
        Me.CbxVendedor.Location = New System.Drawing.Point(240, 195)
        Me.CbxVendedor.Name = "CbxVendedor"
        Me.CbxVendedor.Size = New System.Drawing.Size(15, 14)
        Me.CbxVendedor.TabIndex = 14
        Me.CbxVendedor.UseVisualStyleBackColor = False
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(240, 149)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(120, 26)
        Me.TxtPassword.TabIndex = 9
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolver.ForeColor = System.Drawing.Color.White
        Me.BtnVolver.Location = New System.Drawing.Point(366, 233)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(86, 31)
        Me.BtnVolver.TabIndex = 19
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Location = New System.Drawing.Point(41, 233)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(96, 31)
        Me.BtnGuardar.TabIndex = 16
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "password"
        '
        'BtnGuardarCambios
        '
        Me.BtnGuardarCambios.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnGuardarCambios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardarCambios.ForeColor = System.Drawing.Color.White
        Me.BtnGuardarCambios.Location = New System.Drawing.Point(165, 233)
        Me.BtnGuardarCambios.Name = "BtnGuardarCambios"
        Me.BtnGuardarCambios.Size = New System.Drawing.Size(171, 31)
        Me.BtnGuardarCambios.TabIndex = 18
        Me.BtnGuardarCambios.Text = "Guardar cambios"
        Me.BtnGuardarCambios.UseVisualStyleBackColor = False
        '
        'TxtLogin
        '
        Me.TxtLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLogin.Location = New System.Drawing.Point(240, 118)
        Me.TxtLogin.Name = "TxtLogin"
        Me.TxtLogin.Size = New System.Drawing.Size(120, 26)
        Me.TxtLogin.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "login"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefono.Location = New System.Drawing.Point(240, 85)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(120, 26)
        Me.TxtTelefono.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Telefono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DNI"
        '
        'TxtNombreCompleto
        '
        Me.TxtNombreCompleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreCompleto.Location = New System.Drawing.Point(240, 17)
        Me.TxtNombreCompleto.Name = "TxtNombreCompleto"
        Me.TxtNombreCompleto.Size = New System.Drawing.Size(212, 26)
        Me.TxtNombreCompleto.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombres y Apellidos"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(520, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(143, 20)
        Me.ToolStripMenuItem1.Text = "Escribe Nuevo Usuario"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.Red
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(62, 20)
        Me.ToolStripMenuItem2.Text = "Eliminar"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(14, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(212, 20)
        Me.TextBox1.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.No
        Me.Panel2.Location = New System.Drawing.Point(0, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(519, 29)
        Me.Panel2.TabIndex = 24
        '
        'DataListado
        '
        Me.DataListado.AllowDrop = True
        Me.DataListado.AllowUserToAddRows = False
        Me.DataListado.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataListado.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataListado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.IdUsuarioDataGridViewTextBoxColumn, Me.NombreyApellidosDataGridViewTextBoxColumn, Me.DNIDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.LoginDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.VendedorDataGridViewTextBoxColumn, Me.IdCargoDataGridViewTextBoxColumn})
        Me.DataListado.Cursor = System.Windows.Forms.Cursors.No
        Me.DataListado.Location = New System.Drawing.Point(0, 57)
        Me.DataListado.Name = "DataListado"
        Me.DataListado.ReadOnly = True
        Me.DataListado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataListado.Size = New System.Drawing.Size(519, 230)
        Me.DataListado.StandardTab = True
        Me.DataListado.TabIndex = 21
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'IdUsuarioDataGridViewTextBoxColumn
        '
        Me.IdUsuarioDataGridViewTextBoxColumn.DataPropertyName = "idUsuario"
        Me.IdUsuarioDataGridViewTextBoxColumn.HeaderText = "idUsuario"
        Me.IdUsuarioDataGridViewTextBoxColumn.Name = "IdUsuarioDataGridViewTextBoxColumn"
        Me.IdUsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreyApellidosDataGridViewTextBoxColumn
        '
        Me.NombreyApellidosDataGridViewTextBoxColumn.DataPropertyName = "Nombre_y_Apellidos"
        Me.NombreyApellidosDataGridViewTextBoxColumn.HeaderText = "Nombre_y_Apellidos"
        Me.NombreyApellidosDataGridViewTextBoxColumn.Name = "NombreyApellidosDataGridViewTextBoxColumn"
        Me.NombreyApellidosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DNIDataGridViewTextBoxColumn
        '
        Me.DNIDataGridViewTextBoxColumn.DataPropertyName = "DNI"
        Me.DNIDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.DNIDataGridViewTextBoxColumn.Name = "DNIDataGridViewTextBoxColumn"
        Me.DNIDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LoginDataGridViewTextBoxColumn
        '
        Me.LoginDataGridViewTextBoxColumn.DataPropertyName = "Login"
        Me.LoginDataGridViewTextBoxColumn.HeaderText = "Login"
        Me.LoginDataGridViewTextBoxColumn.Name = "LoginDataGridViewTextBoxColumn"
        Me.LoginDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VendedorDataGridViewTextBoxColumn
        '
        Me.VendedorDataGridViewTextBoxColumn.DataPropertyName = "Vendedor"
        Me.VendedorDataGridViewTextBoxColumn.HeaderText = "Vendedor"
        Me.VendedorDataGridViewTextBoxColumn.Name = "VendedorDataGridViewTextBoxColumn"
        Me.VendedorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdCargoDataGridViewTextBoxColumn
        '
        Me.IdCargoDataGridViewTextBoxColumn.DataPropertyName = "idCargo"
        Me.IdCargoDataGridViewTextBoxColumn.HeaderText = "idCargo"
        Me.IdCargoDataGridViewTextBoxColumn.Name = "IdCargoDataGridViewTextBoxColumn"
        Me.IdCargoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'USUARIO2TableAdapter
        '
        Me.USUARIO2TableAdapter.ClearBeforeFill = True
        '
        'BASEMAGBRIDataSet
        '
        Me.BASEMAGBRIDataSet.DataSetName = "BASEMAGBRIDataSet"
        Me.BASEMAGBRIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'USUARIO2BindingSource
        '
        Me.USUARIO2BindingSource.DataMember = "USUARIO2"
        Me.USUARIO2BindingSource.DataSource = Me.BASEMAGBRIDataSet
        '
        'TxtDNI
        '
        Me.TxtDNI.Location = New System.Drawing.Point(240, 53)
        Me.TxtDNI.Mask = "99999999"
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(100, 20)
        Me.TxtDNI.TabIndex = 27
        '
        'usuariosOK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 288)
        Me.Controls.Add(Me.PanelRegistro)
        Me.Controls.Add(Me.DataListado)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "usuariosOK"
        Me.Text = "usuariosOK"
        Me.PanelRegistro.ResumeLayout(False)
        Me.PanelRegistro.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BASEMAGBRIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USUARIO2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelRegistro As Panel
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnGuardarCambios As Button
    Friend WithEvents TxtLogin As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNombreCompleto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataListado As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Public WithEvents CbxVendedor As CheckBox
    Friend WithEvents USUARIO2TableAdapter As BASEMAGBRIDataSetTableAdapters.USUARIO2TableAdapter
    Friend WithEvents BASEMAGBRIDataSet As BASEMAGBRIDataSet
    Friend WithEvents USUARIO2BindingSource As BindingSource
    Friend WithEvents LblVendedor As Label
    Friend WithEvents TxtVendedor As Label
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents IdUsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreyApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DNIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoginDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VendedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TxtDNI As MaskedTextBox
End Class
