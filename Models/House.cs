using System.ComponentModel.DataAnnotations;
namespace Gregslist.Models
{
  public class House
  {
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int? Year { get; set; }

    public House(string name, string description, int? year)
    {
      Id = Guid.NewGuid().ToString();
      Name = name;
      Description = description;
      Year = year;
    }
  }
}