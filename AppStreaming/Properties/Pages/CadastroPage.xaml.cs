
namespace AppStreaming.Properties.Pages;

public partial class CadastroPage : ContentPage
{
    private readonly int dataAtual;

    public CadastroPage()
    {
        InitializeComponent();
    }

    private void Cadastrar_Clicked(object sender, EventArgs e)
    {
        var nome = NomeCompleto.Text;
        var data = DataNascimento.Date;

        DisplayAlert("Cadastro De Usuario", string.Format("Olá {0} Seu Cadastro Foi Realizado", nome), "OK");

    }

}
