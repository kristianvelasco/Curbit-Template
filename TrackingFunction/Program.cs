using Common.Data.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Tracking.Infrastructure;
using TrackingFunction.Services;
using TrackingFunction.Services.Interfaces;

IHost host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices(services => {
        // services.AddAzureClients(builder =>
        //{
        //    builder.AddServiceBusClient(Environment.GetEnvironmentVariable("ServiceBusConnectionString"));
        //});

        services.AddScoped<IDatabaseContextFactory, TrackingContextDesignFactory>();
        services.AddTransient<ITrackingService, TrackingService>();
 })
     .Build();
 host.RunAsync();
