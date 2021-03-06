using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PackerTracker.Models;

namespace PackerTracker.Controllers
{
  public class PackerController : Controller
  {
    [HttpGet("/packer")]
    public ActionResult Index()
    {
      List<Packer> allPackers = Packer.GetAll();
      return View(allPackers);
    }
    [HttpGet("/packer/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/packer")]
    public ActionResult New(string tripName)
    {
      Packer newPacker = new Packer(tripName);
      return RedirectToAction("Index");
    }
    [HttpGet("/packer/{Id}")]
    public ActionResult Show(int Id)
    {
      Packer foundPacker = Packer.Find(Id);
      return View(foundPacker);
    }
    [HttpPost("/packer/delete")]
    public ActionResult DeleteAll()
    {
      Packer.ClearAll();
      return View();
    }
    [HttpGet("/packer/{Id}/addgear")]
    public ActionResult AddGear(int Id)
    {
      Packer foundPacker = Packer.Find(Id);
      return View(foundPacker);
    }
    [HttpPost("/packer/{Id}/gearadded")]
    public ActionResult Show(int Id, string gearType, bool purchased)
    {
      Packer foundPacker = Packer.Find(Id);
      foundPacker.AddGear(gearType, purchased);
      return RedirectToAction("Show");
    }
  }
}