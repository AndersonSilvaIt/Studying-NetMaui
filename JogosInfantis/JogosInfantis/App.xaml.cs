using JogosInfantis.Views;

namespace JogosInfantis
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new JogosInfantisView();
        }
    }
}
