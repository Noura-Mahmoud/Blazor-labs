using BlazorAppTracksAndTrainee;
using BlazorAppTracksAndTrainee.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorAppTracksAndTrainee
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddHttpClient<ITrackService, TrackService>(
                                client => client.BaseAddress = new Uri("https://localhost:7233")
                                );
            builder.Services.AddHttpClient<ITraineeService, TraineeService>(
                                c => c.BaseAddress = new Uri("https://localhost:7233")
                                );
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}