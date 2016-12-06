using OffersEmail.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffersEmail.Testing
{
  public static class TestData
  {
    public static DealVM GenerateDealsJson(int value, DealType type = DealType.CardLinked)
    {
      return new DealVM(null);
    }

    public static DealVM GetCardLink(string accountType = null)
    {
      return new DealVM(null);
    }

    public static DealVM GetCardLinkWithFeedbackData()
    {
      return new DealVM(null);
    }

    public static DealVM GetReminderActivateAccountModel()
    {
      return new DealVM(null);
    }

    public static DealVM GetShareDealsModel(int value = 0)
    {
      return new DealVM(null);
    }

    public static DealVM GetConfirmEmail()
    {
      return new DealVM(null);
    }

    public static DealVM GetReminderActivateAccountWithBusinessesModel(string id)
    {
      return new DealVM(null);
    }


  }
}
