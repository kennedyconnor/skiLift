using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Dapper;
using SkiLift.Models;

namespace SkiLift.Repositories
{
  public class PassengerRepository
  {
    private readonly IDbConnection _db;
    public PassengerRepository(IDbConnection db)
    {
      _db = db;
    }

    public IEnumerable<Passenger> GetAll(string id)
    {
      return _db.Query<Passenger>("SELECT * FROM vaults WHERE userId = @id", new { id });
    }

    public Passenger GetById(int id)
    {
      string query = "SELECT * FROM vaults WHERE id = @Id";
      Passenger data = _db.QueryFirstOrDefault<Passenger>(query, new { id });
      if (data == null) throw new Exception("Invalid ID");
      return data;
    }

    public IEnumerable<Passenger> GetByUser(string userId)
    {
      string query = "SELECT * FROM vaults WHERE userId = @userId";
      IEnumerable<Passenger> data = _db.Query<Passenger>(query, new { userId });
      if (data == null) throw new Exception("Invalid ID");
      return data;
    }
    public Passenger Create(Passenger data)
    {
      string query = @"
            INSERT INTO vaults (name, description, userId)
            VALUES (@Name, @Description, @UserId);
            SELECT LAST_INSERT_ID();
            ";
      int id = _db.ExecuteScalar<int>(query, data);
      data.Id = id;
      return data;
    }

    public Passenger Update(Passenger data)
    {
      string query = @"
            UPDATE vaults 
            SET
            name = @Name,
            description = @Description,
            WHERE id = @Id ;
            SELECT * FROM vaults WHERE id = @Id ;
           ";
      return _db.QueryFirstOrDefault<Passenger>(query, data);
    }


    public string Delete(int id, string userId)
    {
      string query = "DELETE FROM vaults WHERE id = @Id AND userId = @UserId;";
      int changedRows = _db.Execute(query, new { id, userId });
      if (changedRows < 1) throw new Exception("Invalid Id");
      return "Successfully Deleted Vault";
    }
  }
}