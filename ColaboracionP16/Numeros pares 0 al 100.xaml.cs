using System.Collections.ObjectModel;

namespace ColaboracionP16;

public partial class Numeros_pares_0_al_100 : ContentPage
{
	public Numeros_pares_0_al_100()
	{
		InitializeComponent();
		Numeroslbl.Text = PopulateEvenNumbers();

	}
	private string PopulateEvenNumbers()
	{
		string cadena = "";
		for (int i = 0; i < 101; i += 2)
		{
			cadena += i + ",";
		}

		return cadena;
	}

}