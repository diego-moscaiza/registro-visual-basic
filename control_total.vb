Imports System.Data.SqlClient

Public Class control_total
    Sub CargarUsuarios()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir()
            da = New SqlDataAdapter("validar_usuario", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@login", txtUser.Text)
            da.SelectCommand.Parameters.AddWithValue("@password", txtPassword.Text)
            da.Fill(dt)
            datalistado.DataSource = dt
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub Contar()
        Dim x As Integer
        x = datalistado.Rows.Count
        txtContador.Text = CStr(x)
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Try
            CargarUsuarios()
            Contar()
            If txtContador.Text > 0 Then
                usuariosOK.ShowDialog()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnCerrarVentana_Click(sender As Object, e As EventArgs) Handles btnCerrarVentana.Click
        Cerrar()
    End Sub

    Private Sub PbLogo_Click(sender As Object, e As EventArgs) Handles pbLogo.Click
        CargarUsuarios()
    End Sub

    Private Sub TxtUser_Click(sender As Object, e As EventArgs) Handles txtUser.Click
        txtUser.Text = ""
        txtUser.Focus()
    End Sub

    Private Sub TxtPassword_Click(sender As Object, e As EventArgs) Handles txtPassword.Click
        txtPassword.Text = ""
        txtPassword.Focus()
    End Sub

End Class







