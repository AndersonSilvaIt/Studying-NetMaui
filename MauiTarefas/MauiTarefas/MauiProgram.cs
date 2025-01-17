using MauiTarefas.Pages;
using MauiTarefas.ViewModels;
using Microsoft.Extensions.Logging;

namespace MauiTarefas
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<TarefasPage>();
            builder.Services.AddSingleton<DetalhesPage>();
            builder.Services.AddSingleton<TarefasPageViewModel>();
            builder.Services.AddSingleton<DetalhesPageViewModel>();
          
            return builder.Build();
        }
    }
}
