using System;
using Microsoft.EntityFrameworkCore;

namespace PartyTime
{
  public class Plants
  {
    public int Id { get; set; }
    public string Species { get; set; }
    public string LocatedPlanted { get; set; }
    public DateTime PlantDate { get; set; } = DateTime.Now;
    public DateTime LastWateredDate { get; set; } = DateTime.Now; 
    public string LightNeeded { get; set; }
    public int WaterNeeded { get; set; }
  }
}