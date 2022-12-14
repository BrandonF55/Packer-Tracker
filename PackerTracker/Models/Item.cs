using System.Collections.Generic;

namespace ItemTracker.Models
{
  public class Item
  {
    public string Name {get; set;}
    public int Weight {get; set;}
    // public int Cost {get; set;}
    public int Id {get; }
    private static List<Item> _itemList = new List<Item>();

  

    public Item(string name, int weight)
    {
      Name = name;
      Weight = weight;
      // Cost = cost;
      _itemList.Add(this);
      Id = _itemList.Count;
  
    }

    public static void Delete(int searchId)
    {
      Item deleteItem = Item.Find(searchId);
      _itemList.Remove(deleteItem);
    }

    public static List<Item> GetAll()
    {
      return _itemList;
    }

    public static void ClearAll()
    {
      _itemList.Clear();
    }

    public static Item Find(int searchId)
    {
      return _itemList[searchId-1];
    }







  }
}