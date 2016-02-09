using Nancy;
using CarDealer.Objects;
using System.Collections.Generic;

namespace CarDealer
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"]= _ => View["addCar.cshtml"];
      //make view all cars cshtml file so we can be sent there
    };
    Post["/carsAdded"]= _ => {
      Car newCar = new Car (Request.Form["Make_model"], Request.Form["Price"], Request.Form["Mileage"]);
      //add save function
      return View["cars_added.cshtml"];
    };
  }
}
