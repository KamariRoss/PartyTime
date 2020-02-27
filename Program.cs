using System;
using System.Linq;

namespace PartyTime
{
  class Program
  {
    static void Main(string[] args)
    {
      // entered a new connections for database
      var db = new PlantsContext();

      //CREATE
      var gardening = true;
      while(gardening)
      {
        //Get user input
        Console.WriteLine("(VIEW PLANT), (ADD PLANT), (REMOVE PLANT), (WATER PLANT), (PLANT LOCATION), (VIEW DRY PLANTS), (QUIT)");
        var input = Console.ReadLine().ToLower();
        //Get plant inputs
        if(input == "add plant")
        {
          Console.WriteLine("What is the name of your name plant?");
          var plantName = Console.ReadLine().ToLower();
          Console.WriteLine("What is the location of the plant");
          var plantLocation = Console.ReadLine().ToLower();
          Console.WriteLine("How much light is needed for the plant?");
          var plantLight = Console.ReadLine().ToLower();
          Console.WriteLine("How many ounces of water does your plant need? ");
          var plantWater = Convert.ToInt32(Console.ReadLine());

          //Store inputs into object
          var newPlant = new Plants
          {
            Species = plantName,
            LocatedPlanted = plantLocation,
            LightNeeded = plantLight,
            WaterNeeded = plantWater
          };
          db.Plant.Add(newPlant);
          db.SaveChanges();
        }
        // view all plants
        else if(input == "view plant")
        {

          var currentPlants = db.Plant.OrderByDescending(p => p.LocatedPlanted);
          foreach (var plants in currentPlants)
          {
              Console.WriteLine($"The plants are { plants.Species}, the location is { plants.LocatedPlanted}, the needed is { plants.LightNeeded} and the water needed is { plants.WaterNeeded}");
          }
        }
          // DELETE
        else if (input == "remove plant")
        {
        Console.WriteLine("What plant would you like to delete?");
        var plantDead = Console.ReadLine().ToLower();
        var plantDelete = db.Plant.First(p => p.Species == ($"{plantDead}"));
        db.Plant.Remove(plantDelete);
        db.SaveChanges();
        }
        else if (input == "plant location")
        {
          Console.WriteLine("What location do you want to know the plants are in?");
          var locationRequest = Console.ReadLine().ToLower();
          var viewPlantLocation = db.Plant.Where(p =>p.LocatedPlanted == ($"{locationRequest}"));
          foreach (var plants in viewPlantLocation)
          {
              Console.WriteLine($"{plants.Species} is located in {locationRequest}");
          }
        }
        else if (input == "water plant")
        {
          // ask user which plant they want to water
          Console.WriteLine("Which plant would you like to water?");
          var dryPlant = Console.ReadLine().ToLower(); 
          // find the plant from the list
          var findDryPlant = db.Plant.First(p =>p.Species == ($"{dryPlant}"));
          //update date time for lastWaterdate
          findDryPlant.LastWateredDate = DateTime.Today;
          // print out results to user
          Console.WriteLine($"Congratulations! Your {dryPlant} was watered on {DateTime.Now}");
          db.SaveChanges();
        }
        else if (input == "view dry plants")
        {
          //search quiery that finds plants water dates
          var viewDryPlant = db.Plant.Where(p => p.LastWateredDate != DateTime.Today);
          // compares them to this date
          // print out dry plants
          foreach (var plants in viewDryPlant)
          {
              Console.WriteLine($"The {plants.Species} was last watered on {plants.LastWateredDate}");
          }
        }
        else if (input == null || input!= "quit"|| input!=  "view dry plants"|| input!= "water plant"|| input!=  "plant location"|| input!= "remove plant"|| input !="view plant")
        {
          Console.WriteLine("Please try again. invalid answer");
          gardening = true;
        }
      
        else if(input== "quit")
        {
          gardening = false;
          Console.WriteLine("Happy Gardening!");
        }
                
      }

    }
  }
}
