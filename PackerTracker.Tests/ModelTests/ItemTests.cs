using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ItemTracker.Models;
using System;

namespace ItemTracker.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      Item.ClearAll();
    }

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("test",3,2);
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsItems_ItemsList()
    {
      // Arrange
      string name = "Balenciaga TrashBag";
      int weight = 20;
      int cost = 3500;
      Item newItem = new Item(name, weight, cost);
      List<Item> newList = new List<Item> { newItem };

      //Act
      List<Item> result = Item.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnItem_Item()
    {
      //Arrange
      string name = "Crocodile Wallet";
      int weight = 40;
      int cost = 30000;
      Item newItem1 = new Item(name, weight, cost);
      // string name1 = "Crocodile Bag";
      // int weight1 = 90;
      // int cost1 = 50000;
      // Item newItem2 = new Item(name1, weight1, cost1);
      
      //Act
      Item result = Item.Find(2);

      //Assert
      Assert.AreEqual(90, result.Weight);
    }
  }
}
