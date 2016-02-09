using Nancy;
using CarDealer.Objects;
// using System.Collections.Generic;

namespace CarMaker
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
      {
        Get["/"]= _ => View["addCar.cshtml"];
        //make view all cars cshtml file so we can be sent there
        Get["/carsAdded"] = _ => {
          
          Car newCar = new Car(Request.Query["Make_model"], Request.Query["Price"], Request.Query["Mileage"]);
          //add save function
          // Request.Form["Price"], Request.Form["Mileage"]
          return View["cars_added.cshtml", newCar];

      };
      // Post["/carsAdded"]= _ => {
      //
      // };
    }
  }
}
