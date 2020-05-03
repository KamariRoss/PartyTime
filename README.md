Party Thyme
With the seasons changing to springtime, it is time to start planting our gardens. For this assignment, you will be building an app that allows users to track their gardens. This will us track what plants we have planted, how long ago they were planted and other details.

Objectives
Create a console app that uses an ORM to talk to a database
Working with EF Core
Reenforce SQL basics
Requirements
Create a .NET console app that stores data in a database.
Query the database using EF Core.
Resources
EF Core Notes
Explorer Mode
.NET
Create a new console application that will store the list of plants the user has planted.

You will be creating a class for your plant.

a Plant has the following properties

Id - primary key
Species - The type of plant
LocatedPlanted - where is the plant plated
PlantedDate - When was the plant planted
LastWateredDate - When was the last time a plant was water
LightNeeded - How much sunlight is needed
WaterNeeded - how much water is needed
Your Plants will be stored in a database called PlantDatabase.

When the console application runs, it should let the user choose one of the following actions:

View All the current plants
this command will show the all the plants in a the list, ordered by LocationPlanted
Plant a new plant
This command will let the user type in the information for a plant and add it to the list
Remove a plant
This will delete a plant by Id
Water
This will update the plant's LastWateredDate to the Current Time. The user will select the plant by Id
View all the plants that have not been watered today
Location summary
This will all the plants that are in given location
quit the program
this will stop the program
