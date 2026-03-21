using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Orders.Frontend;
using Orders.Frontend.Repositories;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7147/") }); // aca le paegamos el url de backend https://localhost:7147
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddSweetAlert2();

await builder.Build().RunAsync();
 

//using Blazored.Modal;
//using CurrieTechnologies.Razor.SweetAlert2;
//using Microsoft.AspNetCore.Components.Authorization;
//using Microsoft.AspNetCore.Components.Web;
//using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
//using MudBlazor.Services;
//using Orders.Frontend;
//using Orders.Frontend.AuthenticationProviders;
//using Orders.Frontend.Repositories;
//using Orders.Frontend.Services;

//var builder = WebAssemblyHostBuilder.CreateDefault(args);
//builder.RootComponents.Add<App>("#app");
//builder.RootComponents.Add<HeadOutlet>("head::after");

////var uriBack = "https://ordersbackend.azurewebsites.net/";
//var uriBack = "https://localhost:7154/";

//builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri(uriBack) });
//builder.Services.AddScoped<IRepository, Repository>();
//builder.Services.AddSweetAlert2();
//builder.Services.AddAuthorizationCore();
//builder.Services.AddBlazoredModal();
//builder.Services.AddMudServices();

//builder.Services.AddScoped<AuthenticationProviderJWT>();
//builder.Services.AddScoped<AuthenticationStateProvider, AuthenticationProviderJWT>(x => x.GetRequiredService<AuthenticationProviderJWT>());
//builder.Services.AddScoped<ILoginService, AuthenticationProviderJWT>(x => x.GetRequiredService<AuthenticationProviderJWT>());

//await builder.Build().RunAsync();