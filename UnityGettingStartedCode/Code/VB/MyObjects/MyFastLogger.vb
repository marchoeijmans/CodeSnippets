Imports Microsoft.VisualBasic

Public Class MyFastLogger
  Implements ILogger

  Public Function WriteMessage(ByVal message As String) As String Implements ILogger.WriteMessage
    ' write to log file here
    Return "Hi, I'm the MyFastLogger, and this is the output I logged: '" & message & "', and I did it really quickly!"
  End Function

End Class
