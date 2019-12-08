using SkiLift.Repositories;
using SkiLift.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace SkiLift.Controllers
{
  [Route("api/[controller]")]
  [ApiController]

  public class Ride_PassengerController : ControllerBase
  {
    private readonly Ride_PassengerRepository _repo;
    public Ride_PassengerController(Ride_PassengerRepository repo)
    {
      _repo = repo;
    }
    //GET api/ride_passengers
    [HttpGet]
    public ActionResult<IEnumerable<Ride_Passenger>> Get()
    {
      try
      {
        var id = HttpContext.User.FindFirstValue("Id");
        return Ok(_repo.GetAllByUser(id));
      }
      catch (Exception e)
      {
        return BadRequest(e);
      }
    }

    // GET api/ride_passengers/5
    [HttpGet("{id}")]
    public ActionResult<Ride_Passenger> Get(int id)
    {
      try
      {
        return Ok(_repo.GetById(id));
      }
      catch (Exception e)
      {
        return BadRequest(e);
      }
    }



    //POST api/ride_passengers
    [Authorize]
    [HttpPost]
    public ActionResult<Ride_Passenger> Post([FromBody] Ride_Passenger data)
    {
      try
      {
        return Ok(_repo.Create(data));
      }
      catch (Exception e)
      {
        return BadRequest(e);
      }
    }

    //PUT api/ride_passengers/5
    [HttpPut("{id}")]
    public ActionResult<Ride_Passenger> Put(int id, [FromBody] Ride_Passenger data)
    {
      try
      {
        data.Id = id;
        return Ok(_repo.Update(data));
      }
      catch (Exception e)
      {
        return BadRequest(e);
      }
    }
    [Authorize]
    [HttpDelete("{id}")]
    public ActionResult<string> Delete(int id)
    {
      try
      {
        var userId = HttpContext.User.FindFirstValue("Id");
        return Ok(_repo.Delete(id, userId));
      }
      catch (Exception e)
      {
        return BadRequest(e);
      }
    }
  }
}