namespace MY_Khata;
using Models;
public partial class detailpage : ContentPage
{
	private User user;
	public detailpage(User user)
	{
		InitializeComponent();
		this.user = user;
		detailpagecontent.Title = user.Name;
		LoadData();
		
	}

	private async void LoadData()
	{
		totake.Text = "₹ " + user.absamount;
		totake.TextColor = user.amountColor;
		toGiveText.Text = user.Balance < 0 ? "You will give" : user.Balance > 0 ? "You will get" : "No Due";
		itemListView.ItemsSource = user.transactions;

    }

    async void Button_Clicked_took(System.Object sender, System.EventArgs e)
    {
		user.transactions.Add(new userTransaction() { date=DateTime.Now,details="test",Balance=-100});

    }
}
