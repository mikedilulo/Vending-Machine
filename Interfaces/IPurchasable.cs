namespace vending.Interfaces
{
  interface IPurchasable
  {
    public string Title { get; set; }
    public float Price { get; set; }


    //NOTE This is enforcing that there will be a method that is called. This method is a string and takes in no parameters. It does not matter what we do with it outside of the Interface. In the burger shack example this is why there different returns on the Models as far as a string goes.
    string GetPurchasableItems();
  }
}