using MY_Khata.Models;

namespace MY_Khata;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		
		InitializeComponent();
		LoadData();
	}



	private async void LoadData()
	{
		
		mainKhata m=new mainKhata();
		m.users.Add(new User() { Name="Raushan"});
		m.users.Add(new User() { Name="ketan"});
		m.users.Add(new User() { Name="saurabh"});
		User u = new User() { Name = "Vicky Bhaiya" };
		u.transactions.Add(new userTransaction() { date=DateTime.Now,details="udhaar for phone",Balance=-150000});
		m.users.Add(u);

		Balance.Text= "₹" + m.Balance.ToString();
		togive.Text= "₹" + Math.Abs(m.toGive).ToString();
		totake.Text= "₹" + m.toTake.ToString();

		itemListView.ItemsSource = m.users;


    }

    void Adduserbtnclicked(System.Object sender, System.EventArgs e)
    {

    }

    async void itemListView_ItemSelected(System.Object sender, Microsoft.Maui.Controls.SelectedItemChangedEventArgs e)
    {
		if (itemListView.SelectedItem != null)
		{
            var selectedItem = (User)e.SelectedItem;
			await Navigation.PushAsync(new detailpage(selectedItem));
		}


		
    }

    void itemListView_ItemTapped(System.Object sender, Microsoft.Maui.Controls.ItemTappedEventArgs e)
    {
        itemListView.SelectedItem = null;
    }

}


