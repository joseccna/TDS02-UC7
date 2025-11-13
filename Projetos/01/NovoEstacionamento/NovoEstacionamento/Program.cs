using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Data;
using System.Net.Security;
using NovoEstacionamento.Data;


var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        string connection = "Server=(localdb)\\mssqllocaldb;Database=NovoEstacionamentoDB;Trusted_Connection=True;";
        
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connection));
    })
     .Build();
 