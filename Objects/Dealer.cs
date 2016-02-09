using System.Collections.Generic;

namespace CarDealer.Objects
{
  public class Car
  {
    private string _makeModel
    private int _price
    private int _mileage

    public void SetMakeModel(string newMakeModel)
    {
      _makeModel = newMakeModel;
    }
    public string GetMakeModel()
    {
      return _makeModel;
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }
    public int GetPrice()
    {
      return _price;
    }

    public void SetMileage(int newMileage)
    {
      _mileage = newMileage;
    }
    public int GetMileage()
    {
      return _mileage;
    }

    public Car(string SetMakeModel, int SetPrice, int SetMileage){
      _makeModel = SetMakeModel;
      _price = SetPrice;
      _mileage = SetMileage;
    }
  }
}
