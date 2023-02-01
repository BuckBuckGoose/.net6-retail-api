using RentalApi;
using Retail.Domain;
using Retail.Services;
using Retail.Services.ProductService;
using Serilog;

    var builder = WebApplication.CreateBuilder(args);

    var env = builder.Environment.EnvironmentName;

    builder.Configuration.AddJsonFile("appsettings.json", false, true);
    builder.Configuration.AddJsonFile($"appsettings.{env}.json", true, true);
    builder.Configuration.AddEnvironmentVariables();
    //builder.Configuration
    //.AddJsonFile("appsettings.json")
    //.AddJsonFile("appsettings.Development.json") // Todo: environment variable replacement
    //.AddEnvironmentVariables();

    //Buid config here
    var cfg = builder.Configuration.GetSection("apiConfig").Get<ApiConfig>();
    builder.Services.AddSingleton<IApiConfig>(cfg);

    //Logging
    var logger = new LoggerConfiguration()
        .ReadFrom.Configuration(builder.Configuration)
        .Enrich.FromLogContext()
        .CreateLogger();
    builder.Logging.ClearProviders();
    builder.Logging.AddSerilog(logger);


    builder.Services.AddControllers();
// Add services to the container.
    builder.Services.AddScoped<IProductService, ProductService>();
    builder.Services.AddScoped<IInventoryService, InventoryService>();
    builder.Services.AddScoped<IOrderService, OrderService>();
    builder.Services.AddScoped<IPosService, PosService>();

    //Default .NET services
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();