using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clean.Architecture.SharedKernel;
using Clean.Architecture.SharedKernel.Interfaces;

namespace Clean.Architecture.Core.ProjectAggregate;
public class Product : EntityBase, IAggregateRoot
{
    //El new es para que no se use el id de la interface IAggregateRoot
    public new int Id { set; get; }
    //el ? indica que puede ser nulo
    public string Name { set; get; } = String.Empty;
    public decimal Price { set; get; }
    public string Category { set; get; } = String.Empty;
    public string Manufacturer { set; get; } = String.Empty;
}
