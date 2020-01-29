using vending.Interfaces;

namespace vending.Models
{
  class Food : IPurchasable
  {
    public string Title { get; set; }
    public string Type { get; set; }
    public float Price { get; set; }

    public string GetPurchasableItems()
    {
      return ($"{Title} - {Type} -- ${Price}");
    }





    public Food(string title, string type, float price)
    {
      Title = title;
      Type = type;
      Price = price;
    }
  }
}