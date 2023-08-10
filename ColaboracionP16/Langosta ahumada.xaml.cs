namespace ColaboracionP16;

public partial class Langosta_ahumada : ContentPage
{
	public Langosta_ahumada()
	{
		InitializeComponent();
	}

    private void calBtn_Clicked(object sender, EventArgs e)
    {
        try
        {
            int cantidad = Convert.ToInt32(cantEn.Text);
            double totalPagar;

            if (cantidad > 300)
            {
                totalPagar = cantidad * 75.00;
            }
            else if (cantidad > 200 && cantidad <= 300)
            {
                totalPagar = cantidad * 85.00;
            }
            else
            {
                totalPagar = cantidad * 95.00;
            }

            cantTotal.Text = "TOTAL: " + totalPagar;
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", ex.Message, "Aceptar");
        }
    }
}