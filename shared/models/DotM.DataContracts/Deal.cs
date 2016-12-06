using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotM.DataContracts
{
  public class Deal
  {
    public string Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public double Price { get; set; }

    public string StartTime { get; set; }

    public string EndTime { get; set; }

    public string DealStatusId { get; set; }

    public int DealType { get; set; }

    public string ProviderDealId { get; set; }

    public DealProvider DealProvider { get; set; }

    public List<Category> Categories { get; set; }

    public DealRank DealRank { get; set; }

    public SeoUrl SeoUrl { get; set; }

    public string LocationType { get; set; }

    public DealInfo DealInfo { get; set; }

    public Business Business { get; set; }

    public IEnumerable<DealImage> Images { get; set; }

    public IEnumerable<string> Keywords { get; set; }

    public TargetingData TargetingData { get; set; }
  }
}
