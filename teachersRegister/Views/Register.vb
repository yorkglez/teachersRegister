Public Class Register
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboxExtensions.DataSource = getExtensions()
        cboxExtensions.DisplayMember = "name"
        cboxExtensions.ValueMember = "idExtension"
    End Sub


End Class