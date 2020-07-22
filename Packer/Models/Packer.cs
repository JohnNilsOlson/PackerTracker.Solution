using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Packer
  {
    public string TripName { get; set; }
    public int Id { get; }
    public Dictionary<string, bool> Gear { get; set; }
    private static List<Packer> _instances = new List<Packer> {};
    public Packer(string tripName)
    {
      TripName = tripName;
      _instances.Add(this);
      Id = _instances.Count;
      Dictionary<string, bool> Gear = new Dictionary<string, bool> {};
    }
    public static List<Packer> GetAll()
    {
      return _instances;
    }
    public static Packer Find(int searchId)
    {
      return _instances[searchId - 1];
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public void AddGear(string gearType, bool purchased)
    {
      Gear.Add(gearType, purchased);
    }
  }
}