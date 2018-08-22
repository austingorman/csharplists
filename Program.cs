using System;
using System.Collections.Generic;

namespace lists
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> planetList = new List<string>() { "Mercury", "Mars" };
      planetList.Add("Jupiter");
      planetList.Add("Saturn");
      List<string> newList = new List<string>() { "Uranus", "Neptune" };
      planetList.AddRange(newList);
      planetList.Insert(1, "Venus");
      planetList.Insert(2, "Earth");
      planetList.Add("Pluto");

      List<string> rockyPlanets = planetList.GetRange(0, 3);

      planetList.Remove("Pluto");

      List<Dictionary<string, string>> planetProbes = new List<Dictionary<string, string>>();

      planetProbes.Add(new Dictionary<string, string>(){
        {"Jupiter", "Juno"}
    });

      planetProbes.Add(new Dictionary<string, string>(){
        {"Mercury", "Mariner 10"}
    });

      planetProbes.Add(new Dictionary<string, string>(){
        {"Saturn", "Voyager 1"}
    });

      foreach (string planet in planetList)
      {
        List<string> visitedProbes = new List<string>();
        foreach (Dictionary<string, string> probe in planetProbes)
        {
          if (probe.ContainsKey(planet))
          {
            visitedProbes.Add(probe[planet]);
          }
        }
        Console.WriteLine($"{planet}: {String.Join(", ", visitedProbes)}");
      }
    }
  }
}
