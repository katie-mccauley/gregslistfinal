using Gregslist.DB;
using Gregslist.Models;

namespace Gregslist.Services;

public class CarsService
{
  internal List<Car> GetAll()
  {
    return FakeDb.Cars;
  }

  internal Car GetById(string id)
  {
    Car found = FakeDb.Cars.Find(c => c.Id == id);
    if (found == null)
    {
      throw new Exception("Invalid Id");

    }
    return found;
  }

  internal void Delete(string id)
  {
    Car found = GetById(id);
    FakeDb.Cars.Remove(found);
  }

  internal Car CreateCar(Car newCar)
  {
    FakeDb.Cars.Add(newCar);
    return newCar;
  }

  internal Car EditCar(Car editcar)
  {
    Car original = GetById(editcar.Id);
    original.Name = editcar.Name ?? original.Name;
    original.Description = editcar.Description ?? original.Description;
    original.Year = editcar.Year ?? original.Year;
    return original;
  }
}