using FichadorPersonal.View;

namespace FichadorPersonal;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("RegisterForm", typeof(RegisterFormPage));
	}
}
