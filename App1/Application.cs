using App1.Commands;
using Nice3point.Revit.Toolkit.External;

namespace App1
{
  [UsedImplicitly]
  public class Application : ExternalApplication
  {
    public override void OnStartup()
    {
      CreateRibbon();
    }

    private void CreateRibbon()
    {
      var panel = Application.CreatePanel("Panel name", "App1");

      var showButton = panel.AddPushButton<Command>("Button text");
      showButton.SetImage("/App1;component/Resources/Icons/RibbonIcon16.png");
      showButton.SetLargeImage("/App1;component/Resources/Icons/RibbonIcon32.png");
    }
  }
}