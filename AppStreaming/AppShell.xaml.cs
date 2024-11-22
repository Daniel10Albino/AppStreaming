using AppStreaming.Properties.Pages;
using AppStreaming.Properties.Views;

namespace AppStreaming
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }
        private void Cadastrar_Cliclken(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Cadastrar_Cliclken()); ;
        }
}

    internal class Cadastrar_Cliclken : Page;


}