using Microsoft.AspNetCore.Mvc;
using ItemTracker.Models;

namespace ItemTracker.Controllers
{
  public class ItemController : Controller
  {

    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("/items/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string name, int weight)
    {
      Item newItems = new Item(name, weight);
      return RedirectToAction("Index");
    }

  [HttpPost("/items/delete")]
    public ActionResult Delete()
    {
      Item.ClearAll();
      return View();
    }

    [HttpGet("/items/{id}")]
    public ActionResult Show(int id)
    {
      Item foundItem = Item.Find(id);
      return View(foundItem);
    }

    [HttpPost("/items/{id}")]
    public ActionResult Delete(int id)
    {
      Item.Delete(id);
      return RedirectToAction("Index");
    }




  }
}