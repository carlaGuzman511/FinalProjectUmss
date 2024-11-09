using DonantsApp.DAL;
using DonantsApp.DAL.Models.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication()
    .ConfigureServices((context, services) =>
    {
        IConfiguration? configuration = context.Configuration;
        string? connectionString = configuration["ConnectionString"];

        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();

        services.AddSingleton<IPostRepository>(provider => new PostRepository(connectionString));
        services.AddSingleton<IAccountRepository>(provider => new AccountRepository(connectionString));
        services.AddSingleton<ICommentRepository>(provider => new CommentRepository(connectionString));
        services.AddSingleton<IBloodTypeRepository>(provider => new BloodTypeRepository(connectionString));
        services.AddSingleton<IDonationTypeRepository>(provider => new DonationTypeRepository(connectionString));
        services.AddSingleton<IPostTypeRepository>(provider => new PostTypeRepository(connectionString));
    })
    .ConfigureAppConfiguration((hostingContext, config) =>
    {
        config.AddJsonFile("local.settings.json", optional: true, reloadOnChange: true);
    })
    .Build();

host.Run();
