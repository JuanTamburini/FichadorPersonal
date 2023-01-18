using FichadorPersonal.ViewModel;

namespace FichadorPersonal.View;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}

