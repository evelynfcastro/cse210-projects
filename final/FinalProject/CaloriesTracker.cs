using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
public class CaloriesTracker
{
  private List<string> _meals = new List<string>();
  

  public void AddList( string meal)
  {
        _meals.Add(meal);
  }

  public List<string> GetValues()
  {
        return _meals;
  }

}