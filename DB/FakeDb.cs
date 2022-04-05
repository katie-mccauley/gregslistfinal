using Gregslist.Models;
namespace Gregslist.DB;
public static class FakeDb
{
  public static List<Car> Cars { get; set; } = new List<Car>(){
    new Car("Nissan Truck", "sexy white truck", 2019),
    new Car("Toyato Truck", "Grey big truck", 2013),
    new Car("Infinity Car", "blue old car", 1999)
  };

  public static List<House> Houses { get; set; } = new List<House>(){
    new House("White House", "Big pretty house in Boise", 2003),
    new House("Red Robbin", "Red house in alley", 2006)
  };
}