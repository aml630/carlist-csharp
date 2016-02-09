using Nancy;
using CarDealer.Objects;
using System.Collections.Generic;
using CarDealer;


namespace CarMaker
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
      {
        Get["/"]= _ => View["addCar.cshtml"];
        //make view all cars cshtml file so we can be sent there
        Get["/view_all_cars"] = _ => {
          List<Car> allCars = Car.GetAll();
          return View["view_all_cars.cshtml", allCars];
          };
          Post["/cars_added"]= _ => {
            Car newCar = new Car (Request.Form["Make_model"],Request.Form["Price"], Request.Form["Mileage"]);
            newCar.Save(newCar);
            return View["cars_added.cshtml", newCar];
          };
          Post["/cars_cleared"]= _ => {
            Car.ClearAll();
            return View["cars_cleared.cshtml"];
          };
        }
      }
    }
