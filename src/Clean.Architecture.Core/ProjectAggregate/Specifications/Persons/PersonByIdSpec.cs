using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Specification;

namespace Clean.Architecture.Core.ProjectAggregate.Specifications.Persons;
public class PersonByIdSpec : Specification<Person>, ISingleResultSpecification
{
    public PersonByIdSpec(int id)
    {
        Query.Where(x => x.Id == id);
    }
}
