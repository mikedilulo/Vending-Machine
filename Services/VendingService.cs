using System;
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
      Messages.Add($"Credit: {Machine.Credit}\n");
      foreach (var item in Machine.Items)
      {
        //NOTE this gives the number next to the items and displays them in the console
        Messages.Add(index.ToString() + ") " + item.GetPurchasableItems());
        index++;
      }
      Messages.Add("press (n) to insert nickle \n");
      Messages.Add("press (d) to insert dime ");
      Messages.Add("press (q) to insert quarter ");
      Messages.Add("press (b) to insert dollar");
      Messages.Add("press (e) to insert exit \n");
    }
    //NOTE this is the switch statement to add credits. It takes in a char coin because its a single character that is being readkey.
    public void AddCredit(char coin)
    {
      switch (coin)
      {
        case 'n':
          Machine.Credit += 0.05f;
          break;
        case 'd':
          Machine.Credit += 0.10f;
          break;
        case 'q':
          Machine.Credit += 0.25f;
          break;
        case 'b':
          Machine.Credit += 1.00f;
          break;
      }
    }
  }
}