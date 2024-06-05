using BookingVerseFinal.Components.Services;
using Microsoft.Extensions.Logging;
using System.IO;

namespace BookingVerseFinal
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
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<EventService>();
            builder.Services.AddSingleton<UserService>();

            // Pfad zur Datenbankdatei
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "mydatabase.db3");

            // Registrieren Sie die Database-Klasse als Singleton und übergeben Sie den dbPath
            builder.Services.AddSingleton<Database>(s => ActivatorUtilities.CreateInstance<Database>(s, dbPath));

            return builder.Build();
        }
    }
}
