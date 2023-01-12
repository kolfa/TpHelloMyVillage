Village myVillage = new Village("Victor le createur");
myVillage.cutWood(50); // affichera Il n'y a pas assez de villageois
Console.WriteLine(myVillage.GetStone()); // afficher 10
Console.WriteLine(myVillage.GetWood()); // afficher 10
myVillage.cutWood(6); // affichera Il n'y a pas assez de ressource
Console.WriteLine(myVillage.GetStone()); // afficher 10
Console.WriteLine(myVillage.GetWood()); // afficher 10
myVillage.cutWood(5);myVillage.cutWood(5); // affichera Il n'y a pas assez de ressource
Console.WriteLine(myVillage.GetStone()); // afficher 0
Console.WriteLine(myVillage.GetWood()); // afficher 55
myVillage.cutWood(5); // affichera Il n'y a pas assez de ressource



