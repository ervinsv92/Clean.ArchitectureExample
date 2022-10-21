using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Core.Request;
public class CodigoRequest
{
    public int Numerico { get; set; }
    public string Texto { get; set; } = String.Empty;
}
