Imports Microsoft.VisualBasic

Public Class MyOtherObject
  Implements IMyInterface

  Public Function GetObjectStringResult() As String Implements IMyInterface.GetObjectStringResult
    Return "Hi, I'm the OTHER Real Object (not the real Real Object)!"
  End Function

End Class
