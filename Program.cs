using catalog.api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextPool<CatalogContext>(options => 
                                options.UseNpgsql(builder.Configuration
                                .GetConnectionString("Database")));

builder.AddGraphQL().AddTypes();

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);
