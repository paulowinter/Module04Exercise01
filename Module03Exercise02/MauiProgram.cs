using Microsoft.Extensions.Logging;
using Module03Exercise02.Services;
using Module03Exercise02.View;
namespace Module03Exercise02
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
            //Service
            builder.Services.AddSingleton<IConfigurationService, MyService>();

            //ContentPage
            builder.Services.AddTransient<LoginPage>();

            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}