namespace AppStreaming.Properties.Login;

public partial class Acesso : ContentPage
{
	public Acesso()
	{
		InitializeComponent();
	}
    private async void Login_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Pages.TelaPrincipal());
    }
}