using System.Collections.Generic;
using vending.Interfaces;

namespace vending.Models
{
  class Machine
  {
    public List<IPurchasable> Items { get; set; } = new List<IPurchasable>();



    public void Setup()
    {
      Food sleepykins = new Food("Sleepy Kins", "Chewy", 2.99f);
      Food wirekins = new Food("Wire Kins", "Energy Proficient", 4.99f);
      Food lazykins = new Food("Lazy Kins", "Rock Hard", 1.99f);
      Food gamingkins = new Food("Gaming Kins", "Fatty", 7.99f);
      Frozen salmon = new Frozen("Salmon", 200, 5.99f);
      Frozen oysters = new Frozen("Oysters", 150, 3.99f);
      Frozen halibut = new Frozen("Halibut", 400, 9.99f);
      Frozen crab = new Frozen("Crab", 75, 15.99f);
      Candy skittles = new Candy("Skittles", 10, 4.99f);
      Candy starbursts = new Candy("Starbursts", 50, 3.99f);
      Candy tootsieRolls = new Candy("Tootsie Rolls", 75, 8.99f);
      Candy mikeAndIkes = new Candy("Mike and Ikes", 90, 6.99f);
      Electronics cdPlayer = new Electronics("CD Player", "All Devices", 20.99f);
      Electronics gamePlayer = new Electronics("Game Player", "Android", 39.99f);
      Electronics appPlayer = new Electronics("App Player", "iPhone", 79.99f);
      Electronics countPlayer = new Electronics("Count Player", "Samsung", 10.99f);

      //NOTE The name of the AddRange Method is the same name of the List that is referenced at the top of the file

      Items.AddRange(new IPurchasable[]
      {
        sleepykins, wirekins, lazykins, gamingkins, salmon, oysters, halibut, crab, skittles, starbursts, tootsieRolls, mikeAndIkes, cdPlayer, gamePlayer, appPlayer, countPlayer
      });


    }

    public Machine()
    {
      Setup();
    }
  }
}