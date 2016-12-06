using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotM.DataContracts
{
  public class Location
  {
    public string BusinessId { get; set; }

    public string CountryOrRegion { get; set; }

    public double Longitude { get; set; }

    public double Latitude { get; set; }
  }
}
