using Microsoft.Extensions.Logging;

namespace Inf04._2025._06._01MauiApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>();
            return builder.Build();
        }
    }
}
