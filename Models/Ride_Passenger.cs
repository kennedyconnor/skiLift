using System.ComponentModel.DataAnnotations;

namespace SkiLift.Models
{
  public class Ride_Passenger
  {
    public int Id { get; set; }
    [Required]
    public string RideId { get; set; }
    [Required]
    public string PassengerId { get; set; }

  }
}