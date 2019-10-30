using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Dapper;
using SkiLift.Models;

namespace SkiLift.Repositories
{
  public class RideRepository
  {
    private readonly IDbConnection _db;
    public RideRepository(IDbConnection db)
    {
      _db = db;
    }

    public IEnumerable<Ride> GetAll(string id)
    {
      return _db.Query<Ride>("SELECT * FROM rides WHERE userId = @id", new { id });
    }

    public Ride GetById(int id)
    {
      string query = "SELECT * FROM rides WHERE id = @Id";
      Ride data = _db.QueryFirstOrDefault<Ride>(query, new { id });
      if (data == null) throw new Exception("Invalid ID");
      return data;
    }

    public IEnumerable<Ride> GetByUser(string userId)
    {
      string query = "SELECT * FROM rides WHERE userId = @userId";
      IEnumerable<Ride> data = _db.Query<Ride>(query, new { userId });
      if (data == null) throw new Exception("Invalid ID");
      return data;
    }
    public Ride Create(Ride data)
    {
      string query = @"
            INSERT INTO rides (name, description, userId)
            VALUES (@Name, @Description, @UserId);
            SELECT LAST_INSERT_ID();
            ";
      int id = _db.ExecuteScalar<int>(query, data);
      data.Id = id;
      return data;
    }

    public Ride Update(Ride data)
    {
      string query = @"
            UPDATE rides 
            SET
            name = @Name,
            description = @Description,
            WHERE id = @Id ;
            SELECT * FROM rides WHERE id = @Id ;
           ";
      return _db.QueryFirstOrDefault<Ride>(query, data);
    }


    public string Delete(int id, string userId)
    {
      string query = "DELETE FROM rides WHERE id = @Id AND userId = @UserId;";
      int changedRows = _db.Execute(query, new { id, userId });
      if (changedRows < 1) throw new Exception("Invalid Id");
      return "Successfully Deleted Vault";
    }
  }
}