using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Specification;

namespace Clean.Architecture.Core.ProjectAggregate.Specifications.Productos;
public class ProductByIdSpec :Specification<Product>, ISingleResultSpecification
{
    public ProductByIdSpec(int id) {
        Query.Where(x => x.Id == id);
    }
}
