Imports Microsoft.VisualBasic

Public Class MyRealObject
  Implements IMyInterface

  Public Function GetObjectStringResult() As String Implements IMyInterface.GetObjectStringResult
    Return "Hi, I'm the Real Object!"
  End Function

End Class
