using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Dapper;
using SkiLift.Models;

namespace SkiLift.Repositories
{
  public class Ride_PassengerRepository
  {
    private readonly IDbConnection _db;
    public Ride_PassengerRepository(IDbConnection db)
    {
      _db = db;
    }

    public IEnumerable<Ride_Passenger> GetAll(string id)
    {
      return _db.Query<Ride_Passenger>("SELECT * FROM ride_passengers WHERE userId = @id", new { id });
    }

    public Ride_Passenger GetById(int id)
    {
      string query = "SELECT * FROM ride_passengers WHERE id = @Id";
      Ride_Passenger data = _db.QueryFirstOrDefault<Ride_Passenger>(query, new { id });
      if (data == null) throw new Exception("Invalid ID");
      return data;
    }

    public IEnumerable<Ride_Passenger> GetByUser(string userId)
    {
      string query = "SELECT * FROM ride_passengers WHERE userId = @userId";
      IEnumerable<Ride_Passenger> data = _db.Query<Ride_Passenger>(query, new { userId });
      if (data == null) throw new Exception("Invalid ID");
      return data;
    }
    public Ride_Passenger Create(Ride_Passenger data)
    {
      string query = @"
            INSERT INTO ride_passengers (name, description, userId)
            VALUES (@Name, @Description, @UserId);
            SELECT LAST_INSERT_ID();
            ";
      int id = _db.ExecuteScalar<int>(query, data);
      data.Id = id;
      return data;
    }

    public Ride_Passenger Update(Ride_Passenger data)
    {
      string query = @"
            UPDATE ride_passengers 
            SET
            name = @Name,
            description = @Description,
            WHERE id = @Id ;
            SELECT * FROM ride_passengers WHERE id = @Id ;
           ";
      return _db.QueryFirstOrDefault<Ride_Passenger>(query, data);
    }


    public string Delete(int id, string userId)
    {
      string query = "DELETE FROM ride_passengers WHERE id = @Id AND userId = @UserId;";
      int changedRows = _db.Execute(query, new { id, userId });
      if (changedRows < 1) throw new Exception("Invalid Id");
      return "Successfully Deleted Vault";
    }
  }
}