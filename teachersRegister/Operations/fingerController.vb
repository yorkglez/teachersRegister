Imports DPFP
Imports DPFP.Capture

Public Class fingerController
    Implements DPFP.Capture.EventHandler
    Dim fingerprintroute As String = ""
    Public Event OnTemplate(ByVal template)
    Public Property CustomFormat As String
    Public Template As DPFP.Template
    Private Enroller As DPFP.Processing.Enrollment = New DPFP.Processing.Enrollment
    Private Verificador As DPFP.Verification.Verification = New DPFP.Verification.Verification()
    Dim count As Integer
    Dim filename As String
    Public WithEvents fingercapture As DPFP.Capture.Capture = New DPFP.Capture.Capture
    Public WithEvents vecapture As DPFP.Capture.Capture
    Public fs As IO.FileStream
    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete
        Throw New NotImplementedException()
    End Sub

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone
        Throw New NotImplementedException()
    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch
        Throw New NotImplementedException()
    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect
        Throw New NotImplementedException()
    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect
        Throw New NotImplementedException()
    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality
        Throw New NotImplementedException()
    End Sub
End Class
