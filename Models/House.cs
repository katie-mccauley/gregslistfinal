using System.ComponentModel.DataAnnotations;
namespace Gregslist.Models
{
  public class House
  {
    public string Id { get; set; }

    [Required]
    [MinLength(2)]
    public string Name { get; set; }

    [Required]
    [MinLength(6)]
    public string Description { get; set; }

    [Range(1950, int.MaxValue)]
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