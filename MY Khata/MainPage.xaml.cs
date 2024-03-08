using MY_Khata.Models;

namespace MY_Khata;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		LoadData();
	}



	private async void LoadData()
	{
		
		mainKhata m=new mainKhata();
		m.users.Add(new User() { Name="Raushan",Balance=2000});
		m.users.Add(new User() { Name="ketan",Balance=200000});
		m.users.Add(new User() { Name="Vicky bhaiya",Balance=-150000});
		m.users.Add(new User() { Name="saurabh",Balance=30000});

		Balance.Text= "₹" + m.Balance.ToString();
		togive.Text= "₹" + m.toGive.ToString();
		totake.Text= "₹" + m.toTake.ToString();

    }

	
}


