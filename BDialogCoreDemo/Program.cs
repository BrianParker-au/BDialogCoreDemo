using BDialogCore.Extensions;
using BDialogCoreDemo;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>(selector: "#app");
builder.RootComponents.Add<HeadOutlet>(selector: "head::after");


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddBDialogCore();

await builder.Build().RunAsync();
