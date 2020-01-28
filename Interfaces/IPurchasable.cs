namespace vending.Interfaces
{
  interface IPurchasable
  {
    public float Price { get; set; }
    public string Title { get; set; }


    string GetPurchasableItems();
  }
}