using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clean.Architecture.Core.Interfaces;
using Clean.Architecture.Core.ProjectAggregate;
using Clean.Architecture.Core.ProjectAggregate.Specifications.Productos;
using Clean.Architecture.Core.Request;
using Clean.Architecture.SharedKernel.Interfaces;

namespace Clean.Architecture.Core.Services;
public class ProductServices : IProductServices
{
    private readonly IRepository<Product> _repository;
    public ProductServices(IRepository<Product> repository) { 
        _repository = repository;

    }
    public async Task<bool> Agregar(Product product)
    {
        try
        {
            await _repository.AddAsync(product);
            await _repository.SaveChangesAsync();

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public Task<List<Product>> Lista()
    {
        return _repository.ListAsync();
    }

    [Obsolete]
    public async Task<Product> ObtenerPorId(CodigoRequest request)
    {
        //CancellationToken cancellation = default;
        var spec = new ProductByIdSpec(request.Numerico);
        var entity = await _repository.GetBySpecAsync(spec);

        return entity!;
    }
}
