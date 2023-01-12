Village myVillage = new Village("Victor le createur");
Console.WriteLine(myVillage.getName());
myVillage.cutWood(2);
myVillage.mineStone(2);
myVillage.cutWood(4);
myVillage.mineStone(4);
Console.WriteLine(myVillage.GetWood()); // affiche 58
Console.WriteLine(myVillage.GetStone()); // affiche 46
myVillage.buildHouse(2);
Console.WriteLine(myVillage.listHouse.Length); // affiche 3
Console.WriteLine(myVillage.villageois); // affiche 30
myVillage.cutWood(15);
myVillage.mineStone(15); // affiche Il n'y a pas assez de ressources
Console.WriteLine(myVillage.GetWood()); // affiche 187
Console.WriteLine(myVillage.GetStone()); // affiche 10
myVillage.buildHouse(4); // affiche Il n'y a pas assez de ressources



