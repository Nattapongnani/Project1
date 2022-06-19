using System.Windows.Input;

namespace Project1;

public partial class Table : ContentPage
{
	public Table()
	{
		InitializeComponent();
	}

	/*
	public ICommand GoToDetailsCommand => new Command(GoToDetails);
	void GoToDetails(object o)
	{
		Shell.Current.GoToAsync($"{nameof(Takeout)}");
	}*/

	async void GoToDetails(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Takeout());
	}


}