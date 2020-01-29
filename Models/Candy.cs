using vending.Interfaces;

namespace vending.Models
{
  class Candy : IPurchasable
  {
    public string Title { get; set; }
    public int SweetnessLevel { get; set; }
    public float Price { get; set; }

    public string GetPurchasableItems()
    {
      return ($"{Title} - {SweetnessLevel} -- ${Price}");
    }



    public Candy(string title, int sweetnessLevel, float price)
    {
      Title = title;
      SweetnessLevel = sweetnessLevel;
      Price = price;
    }
  }
}