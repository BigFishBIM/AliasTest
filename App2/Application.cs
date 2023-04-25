using App2.Commands;
using Nice3point.Revit.Toolkit.External;

namespace App2
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
      var panel = Application.CreatePanel("Panel name", "App2");

      var showButton = panel.AddPushButton<Command>("Button text");
      showButton.SetImage("/App2;component/Resources/Icons/RibbonIcon16.png");
      showButton.SetLargeImage("/App2;component/Resources/Icons/RibbonIcon32.png");
    }
  }
}