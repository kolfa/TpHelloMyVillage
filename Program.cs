﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine(House.wood_needed); // affichera 3
// Console.WriteLine(House.stone_needed); // affichera 3

Village myVillage = new Village("Victor le createur");
myVillage.mineStone(50); // Affichera: Il n'y a pas assez de villageois
Console.WriteLine(myVillage.GetStone()); // Affichera 10
Console.WriteLine(myVillage.GetWood());// Affichera 10
myVillage.mineStone(6); // Affichera : Il n'y a pas assez de ressources
Console.WriteLine(myVillage.GetStone()); // Affichera 10
Console.WriteLine(myVillage.GetWood()); // Affichera 10
myVillage.mineStone(5);myVillage.mineStone(5);
Console.WriteLine(myVillage.GetStone()); // Affichera 90
Console.WriteLine(myVillage.GetWood()); // Affichera 0
myVillage.mineStone(5); // Affichera : Il n'y a pas assez de ressources



