namespace Project1;

public partial class Table : ContentPage
{
	public Table()
	{
		InitializeComponent();
	}

	void Handle_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Takeout());
	}
}