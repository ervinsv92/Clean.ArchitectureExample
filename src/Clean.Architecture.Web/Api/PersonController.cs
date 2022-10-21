using Clean.Architecture.Core.Interfaces;
using Clean.Architecture.Core.ProjectAggregate;
using Clean.Architecture.Core.Request;
using Microsoft.AspNetCore.Mvc;

namespace Clean.Architecture.Web.Api;
public class PersonController : BaseApiController
{
    private readonly IPersonServices _service;

    public PersonController(IPersonServices service)
    {
        _service = service;
    }

    [HttpPost("Agregar")]
    public async Task<bool> Agregar(Person person)
    {
        return await _service.Agregar(person);
    }

    [HttpPost("Actualizar")]
    public async Task<bool> Actualizar(Person person)
    {
        return await _service.Actualizar(person);
    }

    [HttpGet]
    public async Task<List<Person>> Lista()
    {
        return await _service.Lista();
    }


    [HttpPost("ObtenerPorId")]
    public async Task<Person> ObtenerPorId(CodigoRequest request)
    {
        return await _service.ObtenerPorId(request);
    }

    [HttpPost("EliminarPorId")]
    public async Task<bool> EliminarPorId(CodigoRequest request)
    {
        return await _service.EliminarPorId(request);
    }
}
