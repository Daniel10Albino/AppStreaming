using AppStreaming.Properties.Pages;
using Microsoft.Maui.Controls.Platform;

namespace AppStreaming.Properties.Views;

public partial class HomeViews : ContentPage
{
    public HomeViews()
    {
        InitializeComponent();


    }
    private async void btEntrar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Login.Acesso());
    }



    private async void btCadastrar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TelaInicialPage());
    }
}


