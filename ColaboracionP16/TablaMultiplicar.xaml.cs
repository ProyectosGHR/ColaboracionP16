namespace ColaboracionP16;

public partial class TablaMultiplicar : ContentPage
{
    public TablaMultiplicar()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        int valor = 0;
        int n = Convert.ToInt32(num.Text);

        for (int i = 1; i <= 10; i++)
        {
            valor = i * n;
            tablanum.Text += "Tabla: " + n + " X " + i + " = " + valor + "\n";
        }
    }
}