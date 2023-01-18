using FichadorPersonal.ViewModel;

namespace FichadorPersonal.View;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}

