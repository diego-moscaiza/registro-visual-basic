Imports System.Data.SqlClient

Public Class usuariosOK
    Sub Mostrar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir()
            da = New SqlDataAdapter("mostrar_usuario", conexion)
            da.Fill(dt)
            DataListado.DataSource = dt
            Cerrar()
            DataListado.Columns(0).Width = 60
            DataListado.Columns(2).Width = 150
            DataListado.Columns(7).Width = 60
            DataListado.Columns(1).Visible = False
            DataListado.Columns(8).Visible = False

        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        'Dim cmd As New SqlCommand'
        Dim unused As New SqlCommand

        If TxtDNI.Text <> "" Then
            Abrir()

            ' -> SIMPLIFICAMOS usando "WITH" para juntar 2 declaraciones que empiezan igual por ejm =:>
            ' cmd = New SqlCommand("insertar_usuario", conexion)
            ' cmd.CommandType = 4

            ' -> SIMPLIFICAMOS el declarar 2 veces en una sola declaracion como
            ' Dim cmd As SqlCommand = New SqlCommand ==> "Dim cmd As New SqlCommand"

            Dim cmd As New SqlCommand("insertar_usuario", conexion) With {
                .CommandType = 4
            }

            cmd.Parameters.AddWithValue("@Nombre_y_Apellidos", TxtNombreCompleto.Text)
            cmd.Parameters.AddWithValue("@DNI", TxtDNI.Text)
            cmd.Parameters.AddWithValue("@Telefono", TxtTelefono.Text)
            cmd.Parameters.AddWithValue("@Login", TxtLogin.Text)
            cmd.Parameters.AddWithValue("@Password", TxtPassword.Text)
            cmd.Parameters.AddWithValue("@Vendedor", CbxVendedor.CheckState)
            cmd.Parameters.AddWithValue("@idCargo", 0)

            cmd.ExecuteNonQuery()
            Cerrar()
        Else
            MsgBox("ESCRIBA SU DNI")
        End If

        Mostrar()

    End Sub

    Private Sub UsuariosOK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BASEMAGBRIDataSet.USUARIO2' Puede moverla o quitarla según sea necesario.
        Me.USUARIO2TableAdapter.Fill(Me.BASEMAGBRIDataSet.USUARIO2)
        Mostrar()
        PanelRegistro.Visible = False

    End Sub

    Private Sub BtnGuardarCambios_Click(sender As Object, e As EventArgs) Handles BtnGuardarCambios.Click
        Dim cmd As New SqlCommand

        If TxtDNI.Text <> "" Then

            Try
                Abrir()

                ' -> SIMPLIFICAMOS usando "WITH" para juntar 2 declaraciones que empiezan igual por ejm =:>

                cmd = New SqlCommand("editar_usuario", conexion) With {
                    .CommandType = 4
                }
                cmd.Parameters.AddWithValue("@Nombre_y_Apellidos", TxtNombreCompleto.Text)
                cmd.Parameters.AddWithValue("@DNI", TxtDNI.Text)
                cmd.Parameters.AddWithValue("@Telefono", TxtTelefono.Text)
                cmd.Parameters.AddWithValue("@Login", TxtLogin.Text)
                cmd.Parameters.AddWithValue("@Password", TxtPassword.Text)
                cmd.Parameters.AddWithValue("@Vendedor", CbxVendedor.CheckState)
                cmd.Parameters.AddWithValue("@idUsuario", DataListado.SelectedCells.Item(1).Value)
                cmd.ExecuteNonQuery()

                Cerrar()
                Mostrar()

                PanelRegistro.Visible = False
            Catch ex As Exception
            End Try

        Else
            MsgBox("ESCRIBA SU DNI")
        End If

        Mostrar()

    End Sub

    Private Sub DataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellContentClick
        If e.ColumnIndex = Me.DataListado.Columns.Item("Eliminar").Index Then
            Dim chkell As DataGridViewCheckBoxCell = Me.DataListado.Rows(e.RowIndex).Cells("Eliminar")
            chkell.Value = Not chkell.Value
        End If

    End Sub

    Private Sub DataListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellDoubleClick
        TxtNombreCompleto.Text = DataListado.SelectedCells.Item(2).Value
        TxtDNI.Text = DataListado.SelectedCells.Item(3).Value
        TxtTelefono.Text = DataListado.SelectedCells.Item(4).Value
        TxtLogin.Text = DataListado.SelectedCells.Item(5).Value
        TxtPassword.Text = DataListado.SelectedCells.Item(6).Value
        CbxVendedor.Text = DataListado.SelectedCells.Item(7).Value

        If CbxVendedor.Text = "1" Then
            LblVendedor.Text = "SÍ"
            CbxVendedor.Checked = True

        ElseIf CbxVendedor.Text = "0" Then
            LblVendedor.Text = "NO"
            CbxVendedor.Checked = False
        End If

        PanelRegistro.Visible = True
        BtnGuardar.Enabled = False
        BtnGuardarCambios.Enabled = True

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        PanelRegistro.Visible = False
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        PanelRegistro.Visible = True

        TxtNombreCompleto.Text = ""
        TxtDNI.Text = ""
        TxtTelefono.Text = ""
        TxtLogin.Text = ""
        TxtPassword.Text = ""
        CbxVendedor.Checked = False

        BtnGuardar.Enabled = True
        BtnGuardarCambios.Enabled = False
    End Sub


    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim result As DialogResult
        Dim cmd As SqlCommand
        result = MessageBox.Show("¿Realmente desea eliminar los registros seleccionados?", "Elimando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.OK Then
            For Each row As DataGridViewRow In DataListado.Rows
                Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                If marcado Then
                    Dim onekey As Integer = Convert.ToInt32(row.Cells("IdUsuarioDataGridViewTextBoxColumn").Value)
                    Abrir()
                    cmd = New SqlCommand("eliminar_usuario", conexion) With {
                        .CommandType = 4
                    }
                    cmd.Parameters.AddWithValue("@idusuario", onekey)
                    cmd.ExecuteNonQuery()
                    Cerrar()

                End If
            Next
            Mostrar()
        Else
        End If

    End Sub

    Private Sub CbxVendedor_CheckedChanged(sender As Object, e As EventArgs) Handles CbxVendedor.CheckedChanged
        If CbxVendedor.Checked = True Then
            CbxVendedor.Text = "1"
            LblVendedor.Text = "SÍ"

        ElseIf CbxVendedor.Checked = False Then
            CbxVendedor.Text = "0"
            LblVendedor.Text = "NO"
        End If
    End Sub
End Class