using App1.ViewModels;
using App1.Views;
using Autodesk.Revit.Attributes;
using Newtonsoft.Json.Linq;
using Nice3point.Revit.Toolkit.External;

namespace App1.Commands
{
  [UsedImplicitly]
  [Transaction(TransactionMode.Manual)]
  public class Command : ExternalCommand
  {
    public override void Execute()
    {
      var viewModel = new App1ViewModel();
      var view = new App1View(viewModel);
      view.ShowDialog();
    }
  }
}