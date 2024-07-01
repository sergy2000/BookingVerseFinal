using BookingVerseFinal.Components.Services;
using BookingVerseFinal.Services;

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
            
            builder.Services.AddScoped<EventService>();
            builder.Services.AddScoped<ShoppingCartService>();
            builder.Services.AddScoped<UserService>();
            builder.Services.AddMauiBlazorWebView();

            #if DEBUG 
            builder.Services.AddBlazorWebViewDeveloperTools();
#endif
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7174/api/") });

           

            return builder.Build();
        }
    }
}