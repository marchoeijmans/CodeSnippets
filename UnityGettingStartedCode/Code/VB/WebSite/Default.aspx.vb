Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Unity.Configuration
Imports MyObjects

Partial Class _Default
  Inherits System.Web.UI.Page

  Private myContainer As IUnityContainer = Nothing
  Private outMessage As String = String.Empty

  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    ' get the existing populated Unity container from Application object if available
    Dim retrievedContainer As Object = Application("MyContainer")
    If retrievedContainer Is Nothing Then
      outMessage = "ERROR: Unity Container not populated in Global.asax.<p />"
    Else
      ' found an existing container, so cast it to the correct type
      myContainer = DirectCast(retrievedContainer, IUnityContainer)
      outMessage = "Retrieved the populated Unity Container from the Application object.<p />"
    End If
    lbl_Output.Text &= outMessage
  End Sub

  Protected Sub btn_GetInterface_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_GetInterface.Click
    ' resolve an instance of the class registered for IMyInterface
    Dim myInstance As IMyInterface = myContainer.Resolve(Of IMyInterface)()
    ' display the result of calling the class method
    lbl_Output.Text &= myInstance.GetObjectStringResult()
  End Sub

  Protected Sub btn_RegisterNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_RegisterNew.Click
    ' register a new default (un-named) mapping with the container
    ' this replaces the existing mapping in the container for IMyInterface
    myContainer.RegisterType(Of IMyInterface, MyOtherObject)()
    lbl_Output.Text &= "Registered a new mapping for IMyInterface to MyOtherObject."
  End Sub

  Protected Sub btn_GetLogger_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_GetLogger.Click
    ' get the logger name selected in the list box 
    ' this name specifies the type of logger required
    Dim loggerType As String = lst_LoggerType.SelectedValue
    ' resolve an instance of the appropriate class registered for ILogger 
    ' using the specified mapping name (may be empty for the default mapping)
    Dim myInstance As ILogger = myContainer.Resolve(Of ILogger)(loggerType)
    ' get the logger to write a message and display the result
    lbl_Output.Text &= myInstance.WriteMessage("HELLO UNITY!")
  End Sub

  Protected Sub btn_ConstructorInjection_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_ConstructorInjection.Click
    ' resolve an instance of the concrete MyObjectWithInjectedLogger class 
    ' this class contains a reference to ILogger in the constructor parameters
    Dim myInstance As MyObjectWithInjectedLogger = myContainer.Resolve(Of MyObjectWithInjectedLogger)()
    ' get the injected logger to write a message and display the result
    lbl_Output.Text &= myInstance.GetObjectStringResult()
  End Sub

  Protected Sub btn_ReloadContainer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_ReloadContainer.Click
    ' reload the existing Unity container configuration from the Web.config file
    Dim section As UnityConfigurationSection = CType(ConfigurationManager.GetSection("unity"), UnityConfigurationSection)
    section.Containers("containerOne").Configure(myContainer)
    lbl_Output.Text &= "Reloaded the original Unity Container configuration."
  End Sub

End Class
