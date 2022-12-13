using System.Collections.Generic;

namespace CarDealer.Models
{
  public class Car
  {
    public string Description { get; set; }
    public int Id { get; }
    public string MakeModel { get; set; }
    public int Miles { get; set; }
    public int Price { get; set; }
    public string Year { get; set; }
    private static List<Car> _instances = new List<Car> { };

    public Car(string description, string makeModel, int miles, int price, string year)
    {
      Description = description;
      MakeModel = makeModel;
      Miles = miles;
      Price = price;
      Year = year;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Car Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
