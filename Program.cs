using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorWeatherApp;
using System.Net.Http.Json;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

var httpClient = builder.Services.BuildServiceProvider().GetRequiredService<HttpClient>();
var rootSettings = await httpClient.GetFromJsonAsync<RootSettings>("appsettings.json");

if (rootSettings == null)
{
    throw new InvalidOperationException("rootSettings could not be loaded.");
}

// Register rootSettings as a singleton service
builder.Services.AddSingleton(rootSettings);

await builder.Build().RunAsync();
