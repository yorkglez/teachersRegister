
Imports MySql.Data.MySqlClient
Imports System
Imports System.IO
Imports System.Collections
Module db_conection 
    Dim text As String
    Private db, user, password, server, data As String
    Dim sr As System.IO.StreamReader
    Dim line As Integer = 1
    Dim sline As String = ""
    'Dim obj As New StreamReader("G:\test.txt")'
    Dim cadconnection As String = "server=localhost; database= attendancesclock_db; user id= root ; password=root12"
    Public dt As DataTable
    Public conn As MySqlConnection = New MySqlConnection(cadconnection)
    Public Sub connectdb()
        Try
            If Not conn Is Nothing Then
                conn.Close()
            End If
            conn.Open()
            Console.WriteLine("Success connection")
        Catch ex As Exception
            Console.WriteLine("Error de conexion")
        End Try
    End Sub

    Public Function getExtensions()
        connectdb()
        Dim sql As String = "SELECT * FROM View_ExtensionsSelect"
        Dim cmd As New MySqlDataAdapter(sql, conn)
        Dim table As New DataTable()
        Try
            cmd.Fill(table)
            Return table
        Catch ex As Exception
            MsgBox("Error occured: Could get data" & ex.ToString)
            Return False
        Finally
            conn.Close()
            table = Nothing
            cmd = Nothing
        End Try
    End Function

    Public Function insert(ByVal array() As String, ByVal imgby As Byte())
        connectdb()
        Dim cmd As New MySqlCommand
        Dim sql As String
        Try
            sql = "INSERT INTO empleado (idEmpleado,Nombre, FechaN, Domicilio, Telefono, Sexo, Puesto, Curp, Area,Contrasena, Rfc, IMSS, tSangre, Huella, Imagen)" &
                            "VALUES ( @idEmpleado, @Nombre, @FechaN, @Domicilio, @Telefono, @Sexo, @Puesto, @Curp, @Area, @Contrasena, @Rfc, @IMSS, @tSangre, @Huella, @Imagen)"
            cmd.Connection = conn
            cmd.CommandText = sql
            cmd.Parameters.AddWithValue("@idEmpleado", array(0))
            cmd.Parameters.AddWithValue("@Nombre", array(1))
            cmd.Parameters.AddWithValue("@FechaN", array(2))
            cmd.Parameters.AddWithValue("@Domicilio", array(3))
            cmd.Parameters.AddWithValue("@Telefono", array(4))
            cmd.Parameters.AddWithValue("@Sexo", array(5))
            cmd.Parameters.AddWithValue("@Puesto", array(6))
            cmd.Parameters.AddWithValue("@Curp", array(7))
            cmd.Parameters.AddWithValue("@Area", array(8))
            cmd.Parameters.AddWithValue("@Contrasena", array(9))
            cmd.Parameters.AddWithValue("@Rfc", array(10))
            cmd.Parameters.AddWithValue("@IMSS", array(11))
            cmd.Parameters.AddWithValue("@tSangre", array(12))
            cmd.Parameters.AddWithValue("@Huella", array(13))
            cmd.Parameters.AddWithValue("@Imagen", imgby)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
            MsgBox("Error occured: Could not insert record" & ex.ToString)
        Finally
            conn.Close()
        End Try
    End Function
    Public Function updatee(ByVal array() As String, ByVal imgby As Byte())
        connectdb()
        Dim cmd As New MySqlCommand
        Dim sql As String
        Try
            sql = "UPDATE empleado SET Nombre=@Nombre, FechaN=@FechaN, Domicilio=@Domicilio, Telefono=@Telefono," &
                     "Sexo=@Sexo, Puesto=@Puesto, Curp=@Curp, Area=@Area, Contrasena=@Contrasena, Rfc=@Rfc, IMSS=@IMSS, tSangre=@tSangre, Imagen=@Imagen where idEmpleado= @id"
            cmd.Connection = conn
            cmd.CommandText = sql
            cmd.Parameters.AddWithValue("@id", array(0))
            cmd.Parameters.AddWithValue("@Nombre", array(1))
            cmd.Parameters.AddWithValue("@FechaN", array(2))
            cmd.Parameters.AddWithValue("@Domicilio", array(3))
            cmd.Parameters.AddWithValue("@Telefono", array(4))
            cmd.Parameters.AddWithValue("@Sexo", array(5))
            cmd.Parameters.AddWithValue("@Puesto", array(6))
            cmd.Parameters.AddWithValue("@Curp", array(7))
            cmd.Parameters.AddWithValue("@Area", array(8))
            cmd.Parameters.AddWithValue("@Contrasena", array(9))
            cmd.Parameters.AddWithValue("@Rfc", array(10))
            cmd.Parameters.AddWithValue("@IMSS", array(11))
            cmd.Parameters.AddWithValue("@tSangre", array(12))
            cmd.Parameters.AddWithValue("@Imagen", imgby)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Error occured: Could not update" & ex.ToString)
            Return False
        Finally
            conn.Close()
        End Try
    End Function
    Public Function delete(ByVal id As String)
        connectdb()
        Dim cmd As New MySqlCommand
        Dim sql As String
        Try
            sql = "DELETE FROM empleado WHERE idEmpleado = @id"
            cmd.Connection = conn
            cmd.CommandText = sql
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
            MsgBox("Error occured: Could not delete" & ex.ToString)
        Finally
            conn.Close()
        End Try
    End Function
    Public Function search(ByVal name As String) As DataTable
        Dim sql As String = "SELECT * FROM empleado WHERE Nombre LIKE '%" & name & "%'"
        connectdb()
        Dim cmd As New MySqlDataAdapter(sql, conn)
        dt = New DataTable
        Try
            cmd.Fill(dt)
            Return dt
        Catch ex As Exception
            ' MsgBox("Error al llenar la tabla" & sql)
            Return dt
        Finally
            conn.Close()
            dt = Nothing
            cmd = Nothing
        End Try
    End Function
    Public Function getusers() As DataTable
        Dim sql As String = "SELECT * FROM empleado;"
        connectdb()
        Dim cmd As New MySqlDataAdapter(sql, conn)
        Dim table As New DataTable()
        Try
            cmd.Fill(table)
            Return table
        Catch ex As Exception
            Return table
        Finally
            conn.Close()
            table = Nothing
            cmd = Nothing
        End Try
    End Function
End Module
