using vending.Interfaces;

namespace vending.Models
{
  class Electronics : IPurchasable
  {
    public string Title { get; set; }
    public string ForDevice { get; set; }
    public float Price { get; set; }

    public string GetPurchasableItems()
    {
      return ($"{Title} - {ForDevice} -- {Price}");
    }
  }
}