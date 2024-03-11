namespace MY_Khata;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		var navp = new NavigationPage(new MainPage());
		navp.BackgroundColor = Colors.Green;
		navp.BarTextColor = Colors.White;
		navp.Title = "My Khata";
		MainPage = navp;
	}
}

