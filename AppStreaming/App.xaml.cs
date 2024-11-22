using AppStreaming.Properties.Pages;
using AppStreaming.Properties.Views;

namespace AppStreaming
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            
            MainPage = new AppShell();
        }
    }
}
