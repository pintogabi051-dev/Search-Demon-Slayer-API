
using SearchDemonSlayerAPI.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SearchDemonSlayerAPI;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress = new Uri("https://www.demonslayer-api.com/")
    });
    
builder.Services.AddScoped<DemonSlayerService>();

await builder.Build().RunAsync();
