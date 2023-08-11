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

    private void langAhu_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Langosta_ahumada());
    }

	private void NumerosPares0a100_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Numeros_pares_0_al_100());
	}

	private void CuentaRegresiva_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new CuentaRegresiva_10_al_1());
	}
}

