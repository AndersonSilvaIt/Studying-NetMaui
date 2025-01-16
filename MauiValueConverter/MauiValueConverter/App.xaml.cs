using MauiValueConverter.Services;
using MauiValueConverter.Views;

namespace MauiValueConverter
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var services = new ServiceCollection();
            services.AddTransient<IAlunoService, AlunoService>();

            var serviceProvider = services.BuildServiceProvider();

            var alunoService = serviceProvider.GetService<IAlunoService>();

            MainPage = new NavigationPage(new AlunosView(alunoService));
        }
    }
}
