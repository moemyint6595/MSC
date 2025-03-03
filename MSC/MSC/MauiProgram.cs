using Microsoft.Extensions.Logging;
using MSC.Services;
using MSC.Shared.Services;
using MSCShared.Services;

namespace MSC
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

            // Add device-specific services used by the MSC.Shared project
            builder.Services.AddSingleton<IFormFactor, FormFactor>();
            //builder.Services.AddScoped<API_Access>();
            builder.Services.AddScoped<NotifierService>();
            builder.Services.AddScoped<LocalStorageService>();
            builder.Services.AddScoped<CommonFunctionsService>();
            builder.Services.AddScoped<VariableService>();

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
