using System.Collections.Generic;

namespace Packer.Models
{
  public class Packer
  {
    public string TripName { get; set; }
    public int Id { get; }
    public Dictionary<string, string> Gear { get; set; }
    private static List<Packer> _instances = new List<Packer> {};
    public Packer(string tripName)
    {
      TripName = tripName;
      _instances.Add(this);
      Id = _instances.Count;
      Dictionary<string, string> gear = new Dictionary<string, string> {};
    }
    public static List<Packer> GetAll()
    {
      return _instances;
    }
    public static Packer Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}