using BlazorBattles.Client;
using BlazorBattles.Client.Services;
using Blazored.LocalStorage;
using Blazored.Toast;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredToast();
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IBananaService, BananaService>();
builder.Services.AddScoped<IUnitService,UnitService>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomStateAuthProvider>();

builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();


await builder.Build().RunAsync();