using Microsoft.AspNetCore.Mvc;
using Gregslist.Models;
using Gregslist.Services;

namespace Gregslist.Controllers;
[ApiController]
[Route("/api/[controller]")]
public class CarsController : ControllerBase
{
  private readonly CarsService _cs;

  public CarsController(CarsService cs)
  {
    _cs = cs;

  }

  [HttpGet]
  public ActionResult<List<Car>> GetAll()
  {
    try
    {
      List<Car> cars = _cs.GetAll();
      return Ok(cars);

    }
    catch (Exception e)
    {
      return BadRequest(e.Message);

    }

  }

  [HttpGet("{id}")]
  public ActionResult<Car> GetById(string id)
  {
    try
    {
      Car car = _cs.GetById(id);
      return Ok(car);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("{id}")]
  public ActionResult<String> Delete(string id)
  {
    try
    {
      _cs.Delete(id);
      return Ok("Deleted for goooddd!");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPost]
  public ActionResult<Car> Create([FromBody] Car newCar)
  {
    try
    {
      Car car = _cs.CreateCar(newCar);
      return Ok(car);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPut("{id}")]
  public ActionResult<Car> EditCar(string id, [FromBody] Car editcar)
  {
    try
    {
      editcar.Id = id;
      Car updated = _cs.EditCar(editcar);
      return Ok(updated);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

}