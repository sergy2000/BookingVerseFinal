using BookingVerseFinal.Components.Services;

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
            #endif

            builder.Services.AddSingleton<EventService>();
            builder.Services.AddSingleton<UserService>();

            return builder.Build();
        }
    }
}