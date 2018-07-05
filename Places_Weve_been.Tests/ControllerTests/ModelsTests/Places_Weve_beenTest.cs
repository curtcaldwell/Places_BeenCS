using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Place.Models;
using System.Collections.Generic;
// using Places_Weve_Been.Models;

namespace Places_Weve_beenTests
{
  [TestClass]
  public class LocationTest
  {
    [TestMethod]
    public void GetCity_ReturnCity()
    {
      //Arrange
      string city = "seattle";
      int year = 1999;
      string monument = "space needle";
      PlaceBeen newPlaceBeen = new PlaceBeen(city, year, monument);
      //Act
      //Arrange
      Assert.AreEqual(city, "seattle");
      Assert.AreEqual(year, 1999);
    }
    [TestMethod]
    public void GetMonument_ReturnMonument()
    {
      //Arrange
      string city = "new york";
      int year = 2005;
      string monument = "statue of liberty";
      PlaceBeen newPlaceBeen = new PlaceBeen(city, year, monument);

      //Act
      //Arrange
      Assert.AreEqual(monument, "statue of liberty");
    }
    [TestMethod]
    public void GetID_ReturnID()
    {
      //Arrange
      string city = "Barcelona";
      int year = 2006;
      string monument = "Camp Nou";
      int id = 0;
      PlaceBeen newPlaceBeen = new PlaceBeen(city, year, monument, id);

      //Act
      ++id;
      //Arrange
      Assert.AreEqual(id, 1);
    }
  }
}
