using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotM.DataContracts
{
  public class DealRank
  {
    public byte StaticRank { get; set; }

    public int[] PublishingVersions { get; set; }

    public byte[] WeightedRanks { get; set; }

    public byte[] WeightedRanks1 { get; set; }

  }
}
