Imports Microsoft.VisualBasic

Public Class MyObjectWithInjectedLogger
  Implements IMyInterface

  Private theLogger As ILogger

  Public Sub New(ByVal log As ILogger)
    theLogger = log
  End Sub

  Public Function GetObjectStringResult() As String Implements IMyInterface.GetObjectStringResult
    Dim output As String = theLogger.WriteMessage("SOME REALLY IMPORTANT MESSAGE")
    Return "Hi, I'm the 'MyObjectWithInjectedLogger' object, and I've got a reference to some type of Logger!<p />" & output
  End Function

End Class
