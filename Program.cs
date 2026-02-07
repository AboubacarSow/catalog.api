using catalog.api.Data;
using catalog.api.Data.EFCore.Seeders;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextPool<CatalogContext>(options => 
                                options.UseNpgsql(builder.Configuration
                                .GetConnectionString("Database")));
builder.Services.AddScoped<ISeeder,Seeder>();



builder.AddGraphQL().AddTypes();

var app = builder.Build();
using(var scope = app.Services.CreateAsyncScope())
{
    //Migration at Start-Up Project
    var db = scope.ServiceProvider.GetRequiredService<CatalogContext>();
    var pendingMigrations = await db.Database.GetPendingMigrationsAsync();
    if(pendingMigrations.Any())
        await db.Database.MigrateAsync();
    // Seeding at Start-Up Project
    var seeder= scope.ServiceProvider.GetRequiredService<ISeeder>();
    await seeder.SeedAsync();
}
app.MapGraphQL();

app.RunWithGraphQLCommands(args);
