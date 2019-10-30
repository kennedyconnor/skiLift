using System.ComponentModel.DataAnnotations;

namespace SkiLift.Models
{
  public class Ride
  {
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Destination { get; set; }
    [Required]
    public int MaxPassengers { get; set; }
    public string UserId { get; set; }

  }
}