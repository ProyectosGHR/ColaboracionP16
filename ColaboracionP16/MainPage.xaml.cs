namespace ColaboracionP16;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void pagoxHora_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SueldoSemanal());
    }
}

