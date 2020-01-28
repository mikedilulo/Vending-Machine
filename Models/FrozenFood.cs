using vending.Interfaces;

namespace vending.Models
{
  class Frozen : IPurchasable
  {
    public string Title { get; set; }
    public int Calories { get; set; }
    public float Price { get; set; }

    public string GetPurchasableItems()
    {
      return ($"{Title} - {Calories} -- {Price}");
    }
  }
}