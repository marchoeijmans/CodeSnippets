Imports Microsoft.VisualBasic

Public Class MyLogger
  Implements ILogger

  Public Function WriteMessage(ByVal message As String) As String Implements ILogger.WriteMessage
    ' write to log file here
    Return "Hi, I'm the MyLogger, and this is the output I logged: '" & message & "'."
  End Function

End Class
