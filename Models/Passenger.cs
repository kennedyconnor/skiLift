using System.ComponentModel.DataAnnotations;

namespace SkiLift.Models
{
  public class Passenger
  {
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Destination { get; set; }
    public string UserId { get; set; }

    public int[] LatLong { get; set; }

  }
}