using Microsoft.Extensions.Logging;

namespace MauiApp1;

public static class MauiProgram
{
    // Método estático que crea y configura una instancia de MauiApp y la devuelve
    public static MauiApp CreateMauiApp()
    {
        // Se crea un nuevo builder de MauiApp
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>() // Configura el builder para usar la clase App como la aplicación principal
            .ConfigureFonts(fonts =>
            {
                // Configura las fuentes personalizadas para la aplicación
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug(); // Agrega la salida de registro de depuración en modo DEBUG
#endif

        // Se construye y devuelve la instancia de MauiApp configurada
        return builder.Build();
    }
}
