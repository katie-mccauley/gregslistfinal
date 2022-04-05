using Gregslist.DB;
using Gregslist.Models;

namespace Gregslist.Services;
public class HousesService
{
  internal List<House> GetAll()
  {
    return FakeDb.Houses;
  }

  internal House GetById(string id)
  {
    House found = FakeDb.Houses.Find(h => h.Id == id);
    if (found == null)
    {
      throw new Exception("Invalid Id");

    }
    return found;

  }
  internal void Delete(string id)
  {
    House found = GetById(id);
    FakeDb.Houses.Remove(found);
  }

  internal House CreateHouse(House newHouse)
  {
    FakeDb.Houses.Add(newHouse);
    return newHouse;
  }

  internal House EditHouse(House editHouse)
  {
    House original = GetById(editHouse.Id);
    original.Name = editHouse.Name ?? original.Name;
    original.Description = editHouse.Description ?? original.Description;
    original.Year = editHouse.Year ?? original.Year;
    return original;
  }
}