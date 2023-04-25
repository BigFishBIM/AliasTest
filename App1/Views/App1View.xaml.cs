using App1.ViewModels;

namespace App1.Views
{
  public partial class App1View
  {
    public App1View(App1ViewModel viewModel)
    {
      InitializeComponent();
      DataContext = viewModel;
    }
  }
}