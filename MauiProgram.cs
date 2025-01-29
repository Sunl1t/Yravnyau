using Intuit.Ipp.Core.Configuration;
using Microsoft.Exchange.WebServices.Auth.Validation;
using Microsoft.Extensions.Logging;
using Yravnyai;
namespace Yravnyai
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

            return builder.Build();
        }
    }

        ////добавляем FirebaseDatabaseService вручную и передаем нужный URL:
        //builder.Services.AddSingleton<FirebaseDatabaseService>(sp => 
        //{
        //    var httpClient = sp.GetRequiredService<HttpClient>();
    
        //    var baseUrl = "https://chemistry1-2b136-default-rtdb.europe-west1.firebasedatabase.app/";
        //    var authToken = ""; 
        //    return new FirebaseDatabaseService(HttpClient, BaseUrl, AuthToken);
        //});
}
