namespace MauiAppCadastroEventos.Views;

public partial class ResumoEvento : ContentPage
{
	public ResumoEvento()
	{
		InitializeComponent();

	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CadastroEvento());
    }
}