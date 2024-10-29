using DonantsApp.DAL;
using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Services.Accounts;
using DonantsApp.Services.BloodTypes;
using DonantsApp.Services.Comments;
using DonantsApp.Services.DonationTypes;
using DonantsApp.Services.Models.Interfaces;
using DonantsApp.Services.Posts;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication()
    .ConfigureServices(services =>
    {
        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();
        services.AddSingleton<IAccountService, AccountService>();
        services.AddSingleton<IPostService, PostService>();
        services.AddSingleton<ICommentService, CommentService>();
        services.AddSingleton<IBloodTypeService, BloodTypeService>();
        services.AddSingleton<IDonationTypeService, DonationTypeService>();
        services.AddSingleton<IPostRepository, PostRepository>();
        services.AddSingleton<IAccountRepository, AccountRepository>();
        services.AddSingleton<ICommentRepository, CommentRepository>();
        services.AddSingleton<IBloodTypeRepository, BloodTypeRepository>();
        services.AddSingleton<IDonationTypeRepository, DonationTypeRepository>();
    })
    .Build();

host.Run();
