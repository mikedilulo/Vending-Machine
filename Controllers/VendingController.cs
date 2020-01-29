using System;
using vending.Services;

namespace vending.Controllers
{
  class VendingController
  {
    private VendingService Service { get; set; } = new VendingService();
    private bool _running = true;

    public void Run()
    {
      Console.Clear();
      Service.PrintItems();
      while (_running)
      {
        PrintMessages();
        _running = false;
      }
    }
    private void PrintMessages()
    {
      foreach (string message in Service.Messages)
      {
        Console.WriteLine(message);
      }
      Service.Messages.Clear();
    }
  }
}