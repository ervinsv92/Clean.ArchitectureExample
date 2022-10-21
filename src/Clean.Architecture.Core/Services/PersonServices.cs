using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clean.Architecture.Core.Interfaces;
using Clean.Architecture.Core.ProjectAggregate.Specifications.Productos;
using Clean.Architecture.Core.ProjectAggregate;
using Clean.Architecture.Core.Request;
using Clean.Architecture.SharedKernel.Interfaces;
using Clean.Architecture.Core.ProjectAggregate.Specifications.Persons;

namespace Clean.Architecture.Core.Services;
public class PersonServices:IPersonServices
{
    private readonly IRepository<Person> _repository;
    public PersonServices(IRepository<Person> repository)
    {
        _repository = repository;

    }

    public async Task<bool> Actualizar(Person person)
    {
        try
        {
            await _repository.UpdateAsync(person);
            await _repository.SaveChangesAsync();

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<bool> Agregar(Person person)
    {
        try
        {
            await _repository.AddAsync(person);
            await _repository.SaveChangesAsync();

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    [Obsolete]
    public async Task<bool> EliminarPorId(CodigoRequest request)
    {
        try
        {
            var spec = new PersonByIdSpec(request.Numerico);
            var entity = await _repository.GetBySpecAsync(spec);
            await _repository.DeleteAsync(entity!);
            await _repository.SaveChangesAsync();

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public Task<List<Person>> Lista()
    {
        return _repository.ListAsync();
    }

    [Obsolete]
    public async Task<Person> ObtenerPorId(CodigoRequest request)
    {
        //CancellationToken cancellation = default;
        var spec = new PersonByIdSpec(request.Numerico);
        var entity = await _repository.GetBySpecAsync(spec);

        return entity!;
    }
}
