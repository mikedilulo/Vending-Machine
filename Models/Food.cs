namespace vending.Models
{
  abstract class Food
  {
    public string Name { get; set; }
    public string Type { get; set; }
    public bool Healthy { get; set; }
    public int Calories { get; set; }
  }
}