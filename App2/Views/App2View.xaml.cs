using App2.ViewModels;

namespace App2.Views
{
  public partial class App2View
  {
    public App2View(App2ViewModel viewModel)
    {
      InitializeComponent();
      DataContext = viewModel;
    }
  }
}