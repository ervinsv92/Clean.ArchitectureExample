using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clean.Architecture.SharedKernel.Interfaces;
using Clean.Architecture.SharedKernel;

namespace Clean.Architecture.Core.ProjectAggregate;
public class Person : EntityBase, IAggregateRoot
{
    public new int Id {set;get;}
    public string Name { set; get; } = string.Empty;
    public string LastName { set; get; } = string.Empty;
}
