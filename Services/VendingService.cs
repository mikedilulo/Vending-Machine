using System.Collections.Generic;
using vending.Models;

namespace vending.Services
{
  class VendingService
  {
    private Machine Machine { get; set; } = new Machine();

    //NOTE Messages are the only thing that can be called from the service
    public List<string> Messages = new List<string>();


    //NOTE getting things to print to the page

    public void PrintItems()
    {
      int index = 1;
      Messages.Add("-----Items-----");
      foreach (var item in Machine.Items)
      {
        Messages.Add(index.ToString() + ") " + item.GetPurchasableItems());
        index++;
      }
      Messages.Add("press (p) to purchase a new item or (q) to quit");
    }
  }
}