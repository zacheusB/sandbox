using BlazorTestProj.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;


        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTk0NDU4QDMxMzkyZTM0MmUzMGtaZlVsTk9KZ2xNc0ZRdFZGV0hqRXZTNCs5WnphNmlCVXJyYUdQV1BnYUk9;NTk0NDU5QDMxMzkyZTM0MmUzMFFxOTBmTHVaYnhrRmFocDdiMUthUVBmeFNkb0kxVlZiSDVCempIcHIyZkk9;NTk0NDYwQDMxMzkyZTM0MmUzMGMwWG4vNlJGZ3hUc05PL2RKSlB1dlh4T2VzcnBaWUxSUUZuTkl2alRLYTQ9;NTk0NDYxQDMxMzkyZTM0MmUzMEJJVkQxa00rR2ZJN2dhVDV1UDBQQzkvYXRrejRzN0pTT3Z3eTVRYXdqeE09;NTk0NDYyQDMxMzkyZTM0MmUzMEJWbFd5eFU5WW9lSnZvMGJmSDd0a28wUnlYVlNRbW96UC9HSE5DS295Vms9;NTk0NDYzQDMxMzkyZTM0MmUzMG1UQ0VROFBoR0Y1MnE0SmlCaXppTis5U01RY0NuTnBnTnZ2UVNOTGFvWHc9;NTk0NDY0QDMxMzkyZTM0MmUzMGVESWx6UXVBZEVBZFh4NmhTWmRlM1ZFbG5obFJONndlcnJFWU82SGY5UDg9;NTk0NDY1QDMxMzkyZTM0MmUzMEVxY082enRlbHM0eG0zaVUvRWdQcTZPWnhaS1RvSmNPUFl1MjUxZ09pNGs9;NTk0NDY2QDMxMzkyZTM0MmUzMG9Wem9XaERkRUZlMVdzWXVOSmVXclFjRGQ2bHpqUzVMQkpCNDFQZDlkR2c9;NTk0NDY3QDMxMzkyZTM0MmUzMEJpTGhFUWF0d3hxU2RoelNUVGEydVNMR0tvMXBMN1QzTVNzMkZQYWtUTm89;NTk0NDY4QDMxMzkyZTM0MmUzME5rbVhtbWdpUXBDSmxHMkt3VEV1d0src1JvZVRqMnd1YWxoWFpJZFVBd1k9");
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
        builder.Services.AddSyncfusionBlazor();
        await builder.Build().RunAsync();