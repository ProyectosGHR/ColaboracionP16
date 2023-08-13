namespace ColaboracionP16;

public partial class ConvertirDolares : ContentPage
{
	public ConvertirDolares()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        decimal cantidadPesos;
        if (decimal.TryParse(txtCantidad.Text, out cantidadPesos))
        {
           
            decimal tipoCambio = 0.05m;

            decimal cantidadDolares = cantidadPesos * tipoCambio;
            lblCantidadDolares.Text = cantidadDolares.ToString("C");
        }
        else
        {
            DisplayAlert("Error", "Ingresa una cantidad válida en pesos mexicanos.", "Aceptar");
        }
    }
}