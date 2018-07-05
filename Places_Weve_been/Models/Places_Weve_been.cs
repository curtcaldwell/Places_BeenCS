using System;
using System.Collections.Generic;

namespace Place.Models
{
  public class PlaceBeen
  {
    private string _city;
    private int _year;

    private static List<PlaceBeen> _instances = new List<PlaceBeen> {};

    public PlaceBeen (string city, int year)
    {
      _city = city;
      _year = year;
    }
    public string GetCity()
    {
      return _city;
    }
    public int GetYear()
    {
      return _year;
    }
    public static List<PlaceBeen> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
  }
}
