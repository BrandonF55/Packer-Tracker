using System.Collections.Generic;

namespace PackageTracker.Models
{
  public class Package
  {
    public string Name { get; set; }
    public int Weight { get; set; }
    public int Cost { get; set; }
    public int Id { get; set; }
    private List<Package> packageList = new List<Package>();



    public Package(string name, int weight, int cost, int id)
    {
      Name = name;
      Weight = weight;
      Cost = cost;
      packageList.Add(this);
      Id = _instances.Count;

    }

    public static List<Package> GetAll()
    {
      return packageList;
    }

    public static void ClearAll()
    {
      packageList.Clear();
    }

    public static Package Find(int searchId)
    {
      return packageList[searchId - 1];
    }







  }
}