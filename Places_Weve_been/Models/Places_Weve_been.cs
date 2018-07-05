using System;
using System.Collections.Generic;

namespace Place.Models
{
  public class PlaceBeen
  {
    private string _city;
    private int _year;
    private string _monument;
    private int _id;

    private static List<PlaceBeen> _instances = new List<PlaceBeen> {};

    public PlaceBeen (string city, int year, string monument, int id = 0)
    {
      _city = city;
      _year = year;
      _monument = monument;
      _id = id;
    }
    public string GetCity()
    {
      return _city;
    }
    public int GetYear()
    {
      return _year;
    }
    public string GetMonument()
    {
      return _monument;
    }
    public int GetID()
    {
      return ++_id;
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
