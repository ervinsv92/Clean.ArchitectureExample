using Clean.Architecture.Core.Interfaces;
using Clean.Architecture.Core.ProjectAggregate;
using Clean.Architecture.Core.Request;
using Microsoft.AspNetCore.Mvc;

namespace Clean.Architecture.Web.Api;
public class ProductController : BaseApiController
{
    private readonly IProductServices _service;

    public ProductController(IProductServices service) { 
        _service = service;
    }

    [HttpPost("Agregar")]
    public async Task<bool> Agregar(Product product) {
        return await _service.Agregar(product);
    }

    [HttpGet]
    public async Task<List<Product>> Lista()
    {
        return await _service.Lista();
    }


    [HttpPost("ObtenerPorId")]
    public async Task<Product> ObtenerPorId(CodigoRequest request)
    {
        return await _service.ObtenerPorId(request);
    }
}
