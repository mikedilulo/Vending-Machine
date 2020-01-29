using System;
using vending.Controllers;

namespace vending
{
  class Program
  {
    static void Main(string[] args)
    {
      VendingController vc = new VendingController();
      vc.Run();
    }
  }
}
