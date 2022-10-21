using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clean.Architecture.Core.ProjectAggregate;
using Clean.Architecture.Core.Request;

namespace Clean.Architecture.Core.Interfaces;
public interface IProductServices
{
    //Por ahora se va a devolver ese objeto, pero deberia der un DTO
    Task<List<Product>> Lista();

    //El bool deberia ser un objeto de response
    Task<bool> Agregar(Product product);
    Task<Product> ObtenerPorId(CodigoRequest request);

}
