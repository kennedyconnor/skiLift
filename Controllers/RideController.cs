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

  public class RidesController : ControllerBase
  {
    private readonly RideRepository _repo;
    public RidesController(RideRepository repo)
    {
      _repo = repo;
    }
    //GET api/rides
    [HttpGet]
    public ActionResult<IEnumerable<Ride>> Get()
    {
      try
      {
        var id = HttpContext.User.FindFirstValue("Id");
        return Ok(_repo.GetAll(id));
      }
      catch (Exception e)
      {
        return BadRequest(e);
      }
    }

    // GET api/rides/5
    [HttpGet("{id}")]
    public ActionResult<Ride> Get(int id)
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

    //GET api/rides/user
    [Authorize]
    [HttpGet("user")]

    public ActionResult<IEnumerable<Ride>> GetByUser()
    {
      try
      {
        var id = HttpContext.User.FindFirstValue("Id");
        return Ok(_repo.GetByUser(id));
      }
      catch (Exception e)
      {
        return BadRequest(e);
      }
    }

    //POST api/rides
    [Authorize]
    [HttpPost]
    public ActionResult<Ride> Post([FromBody] Ride data)
    {
      try
      {
        data.UserId = HttpContext.User.FindFirstValue("Id");
        return Ok(_repo.Create(data));
      }
      catch (Exception e)
      {
        return BadRequest(e);
      }
    }

    //PUT api/rides/5
    [HttpPut("{id}")]
    public ActionResult<Ride> Put(int id, [FromBody] Ride data)
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