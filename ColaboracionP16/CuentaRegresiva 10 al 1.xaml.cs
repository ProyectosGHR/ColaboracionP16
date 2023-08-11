namespace ColaboracionP16;

public partial class CuentaRegresiva_10_al_1 : ContentPage
{
	public CuentaRegresiva_10_al_1()
	{
		InitializeComponent();
	}

	private async void OnStartCountdown(object sender, EventArgs e)
	{
		CountdownLabel.Text = "10";

		for (int i = 10; i >= 1; i--)
		{
			CountdownLabel.Text = i.ToString();
			await Task.Delay(1000); // Espera 1 segundo
		}

		CountdownLabel.Text = "¡Fin!";
	}
}