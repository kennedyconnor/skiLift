using System;
using System.Data;
using System.Linq;
using BCrypt.Net;
using Dapper;
using skiLift.Models;
namespace skiLift.Repositories
{
  public class UserRepository
  {
    IDbConnection _db;
  }
}