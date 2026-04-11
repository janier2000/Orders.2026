using Blazored.Modal;
using Orders.Frontend;
using Orders.Frontend.Services;
using Orders.Frontend.Repositories;
using Microsoft.AspNetCore.Components.Web;
using CurrieTechnologies.Razor.SweetAlert2;
using Orders.Frontend.AuthenticationProviders;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7147/") }); // aca le paegamos el url de backend https://localhost:7147

//cambio temporal
builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7147/") }); // aca le paegamos el url de backend https://localhost:7147

builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddSweetAlert2();
builder.Services.AddAuthorizationCore();

builder.Services.AddBlazoredModal(); //este es el modal



// este se utiliza para pobrar el usuario localmente
//builder.Services.AddScoped<AuthenticationStateProvider, AuthenticationProviderTest>();

// aca si  va consumir la api
builder.Services.AddScoped<AuthenticationProviderJWT>();
builder.Services.AddScoped<AuthenticationStateProvider, AuthenticationProviderJWT>(x => x.GetRequiredService<AuthenticationProviderJWT> ());
builder.Services.AddScoped<ILoginService, AuthenticationProviderJWT>(x => x.GetRequiredService<AuthenticationProviderJWT>());


await builder.Build().RunAsync();