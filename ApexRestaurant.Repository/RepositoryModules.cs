using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ApexRestaurant.Repository
{
public static class RepositoryModules
{
public static void Register(IServiceCollection services, string connection,
string migrationsAssembly)
{
    services.AddDbContext<RestaurantContext>(options =>
options.UseSqlServer(connection, builder =>
builder.MigrationsAssembly(migrationsAssembly)));

}
}
}