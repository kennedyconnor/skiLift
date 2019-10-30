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

  public class PassengersController : ControllerBase
  {
    private readonly PassengerRepository _repo;
    public PassengersController(PassengerRepository repo)
    {
      _repo = repo;
    }
    //GET api/vaults
    [HttpGet]
    public ActionResult<IEnumerable<Passenger>> Get()
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

    // GET api/vaults/5
    [HttpGet("{id}")]
    public ActionResult<Passenger> Get(int id)
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

    //GET api/vaults/user
    [Authorize]
    [HttpGet("user")]

    public ActionResult<IEnumerable<Passenger>> GetByUser()
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

    //POST api/vaults
    [Authorize]
    [HttpPost]
    public ActionResult<Passenger> Post([FromBody] Passenger data)
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

    //PUT api/vaults/5
    [HttpPut("{id}")]
    public ActionResult<Passenger> Put(int id, [FromBody] Passenger data)
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