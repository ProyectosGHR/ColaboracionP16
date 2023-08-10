namespace ColaboracionP16;

public partial class SueldoSemanal : ContentPage
{
	public SueldoSemanal()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            double horasTrabajadas = Convert.ToDouble(HT.Text);
            double pagoXHora = Convert.ToDouble(PxH.Text);

            double totalSueldo = horasTrabajadas * pagoXHora;

            sueldo.Text = "Sueldo a pagar: $" + totalSueldo;
        } catch (Exception ex) { DisplayAlert("Error", ex.Message, "Aceptar"); }
       
    }
}