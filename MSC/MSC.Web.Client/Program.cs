using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MSC.Shared.Services;
using MSC.Web.Client.Services;
using MSCShared.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the MSC.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<API_Access>();
builder.Services.AddScoped<NotifierService>();
builder.Services.AddScoped<LocalStorageService>();
builder.Services.AddScoped<CommonFunctionsService>();
builder.Services.AddScoped<VariableService>();


await builder.Build().RunAsync();
