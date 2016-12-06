using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotM.DataContracts
{
  public class Business
  {
    public string BusinessId { get; set; }

    public string Name { get; set; }

    public IEnumerable<Location> Locations { get; set; }
  }
}
