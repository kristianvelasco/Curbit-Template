using Authorization.Infrastructure;
using AuthorizationAPI.Services;
using AuthorizationAPI.Services.Interfaces;
using Common.Data.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder
    .Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

void ConfigureServices(IServiceCollection services)
{
   // services.AddAzureClients(builder =>
   //{
   //    builder.AddServiceBusClient(Environment.GetEnvironmentVariable("ServiceBusConnectionString"));
   //});

    services.AddScoped<IDatabaseContextFactory, AuthorizationContextDesignFactory>();
    services.AddTransient<IRoleService, RoleService>();
    services.AddTransient<IUserService, UserService>();
    services.AddTransient<IStoreService, StoreService>();
    services.AddTransient<ICustomerService, CustomerService>();
};

app.Run();
