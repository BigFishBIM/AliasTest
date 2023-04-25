using App2.ViewModels;
using App2.Views;
using Autodesk.Revit.Attributes;
using Nice3point.Revit.Toolkit.External;

namespace App2.Commands
{
  [UsedImplicitly]
  [Transaction(TransactionMode.Manual)]
  public class Command : ExternalCommand
  {
    public override void Execute()
    {
      var viewModel = new App2ViewModel();
      var view = new App2View(viewModel);
      view.ShowDialog();
    }
  }
}
