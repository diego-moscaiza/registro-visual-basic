Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration


Module Module1
    Public configuracion As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("SistemaProyecto.My.MySettings.BASEMAGBRI")
    Public conexion As New SqlConnection(configuracion.ConnectionString)
    Sub Abrir()
        If conexion.State = 0 Then
            conexion.Open()
        End If
    End Sub

    Sub Cerrar()
        If conexion.State = 1 Then
            conexion.Close()
        End If
    End Sub

End Module
