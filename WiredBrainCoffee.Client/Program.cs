using Blazorise;
using Blazorise.Bootstrap;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazorise.Icons.FontAwesome;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Blazored.Modal;
using WiredBrainCoffee.Services;

namespace WiredBrainCoffee.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddBlazoredModal();
            builder.Services.AddBlazorise(options =>
              {
                  options.ChangeTextOnKeyPress = true;
              })
              .AddBootstrapProviders()
              .AddFontAwesomeIcons();

            builder.Services.AddHttpClient<IMenuService, MenuService>(client =>
                client.BaseAddress = new Uri("https://localhost:3001/"));
            builder.Services.AddHttpClient<IContactService, ContactService>(client =>
                client.BaseAddress = new Uri("https://localhost:3001/"));

            var host = builder.Build();

            host.Services
              .UseBootstrapProviders()
              .UseFontAwesomeIcons();

            await host.RunAsync();
        }
    }
}
