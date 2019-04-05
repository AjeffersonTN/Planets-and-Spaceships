//Practice: Planet and Spaceships

using System.Collections.Generic;
using System;

namespace lists
{
    public class Program
    {
        static void Main()
        {
            List<string> planetList = new List<string>(){
                "Mercury",
                "Mars",
                };
                 // Utilized Add() to add individual items to the list
                // planetList.Add("Jupiter");
                // planetList.Add("Saturn");

                //created a new list instead of adding one at a time then combined lists
                List<string> newPlanetList = new List<string>(){
                    "Jupiter",
                    "Saturn"
                };
                // Utilized AddRange() to combine the two lists
            planetList.AddRange(newPlanetList);

            planetList.Insert(0, "Earth");
            planetList.Insert(1, "Venus");

            planetList.Add("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 4);

            planetList.Remove("Pluto");

            // planetList.ForEach(planet => Console.WriteLine(planet));
            rockyPlanets.ForEach(planet => Console.WriteLine(planet));
        }
    }
}
