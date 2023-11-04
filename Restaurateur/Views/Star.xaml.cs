using Restaurateur.ViewModels;

namespace Restaurateur.Views;

public partial class Star : ContentView
{
	public Star()
	{
		InitializeComponent();

		BindingContext = new StarViewModel();
	}
}