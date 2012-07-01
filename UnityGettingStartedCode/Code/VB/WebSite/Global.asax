<%@ Application Language="VB" %>
<%@ Import Namespace="Microsoft.Practices.Unity" %>
<%@ Import Namespace="Microsoft.Practices.Unity.Configuration" %>

<script runat="server">

  Sub Application_Start(sender as Object, e as EventArgs)
    ' create and populate a new Unity container from configuration
    Dim myContainer = New UnityContainer()
    Dim section As UnityConfigurationSection = CType(ConfigurationManager.GetSection("unity"), UnityConfigurationSection)
    section.Containers("containerOne").Configure(myContainer)
    Application("MyContainer") = myContainer
  End Sub

  Sub Application_End(sender as Object, e as EventArgs)
    Application("MyContainer") = Nothing
  End Sub

</script>
