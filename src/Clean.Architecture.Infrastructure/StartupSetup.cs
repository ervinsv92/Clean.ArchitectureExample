using Clean.Architecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Clean.Architecture.Infrastructure;

public static class StartupSetup
{
    //Metodo de extencion, le agrega un nuevo metodo al objeto IServiceCollection, se le podria hacer lo mismo a un string, etc
    public static void AddDbContext(this IServiceCollection services, string connectionString) =>
      services.AddDbContext<AppDbContext>(options =>
          options.UseSqlServer(connectionString)); // will be created in web project root
}
