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
        GetUserInput();
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
    private void GetUserInput()
    {
      var key = Console.ReadKey();
      Console.Clear();
      var keyChar = key.KeyChar;
      //NOTE this is the start of the switch statement, this will pass along to the service that will take care of the method.
      switch (keyChar)
      {
        case 'e':
          _running = false;
          break;
        case 'n':
        case 'd':
        case 'q':
        case 'b':
          Service.AddCredit(keyChar);
          Service.PrintItems();
          break;
      }
    }
  }
}