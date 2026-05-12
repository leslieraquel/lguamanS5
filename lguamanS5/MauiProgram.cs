using lguamanS5.Repositories;
using lguamanS5.utilities;
using Microsoft.Extensions.Logging;

namespace lguamanS5
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

            string dbPath = FileAccessHelper.getFolderPath("personaDB.db3");

            builder.Services.AddSingleton<personaRepositorie>(s => ActivatorUtilities.CreateInstance<personaRepositorie>(s, dbPath));
#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
