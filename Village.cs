public class Village{
    private string name;
    private Ressources myRessources;
    public House chefHome;
    public int villageois=0;
    public House [] listHouse;
    public Mine myMine;
    
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int GetWood() {
        return myRessources.GetWood();
    }

    public int GetStone() {
        return myRessources.GetStone();
    }
    
    public Village(string Name)
    {
        this.name = Name;
        this.myRessources = new Ressources();
        this.chefHome = new House();
        this.villageois = House.villageois;
        this.listHouse = new House[1];
        listHouse[0] = this.chefHome ;
        this.myMine= new Mine();

    }

    public string  getName()
    {
        return ("Le nom de village est : " + Name);
    }
    private void addHouse()
    {
        // Console.WriteLine("Veuillez indiquer le nombre de maisons à rentrer : "); 
        // int nbrHouse = int.Parse(Console.ReadLine());
        House[] addNewHouse = new House[listHouse.Length +1];
        for(int i =0;i<listHouse.Length;i++)
        {
            addNewHouse[i] = listHouse[i];
        }
        addNewHouse[addNewHouse.Length-1]= chefHome;
        listHouse = addNewHouse;
        this.villageois =listHouse.Length * House.villageois;
    }
    public void mineStone(int nbrVillagois)
    {
        //consommer stone
        myRessources.useStone(Mine.stone_cost * nbrVillagois);
        //consommer wood
        myRessources.useWood(Mine.wood_cost * nbrVillagois);
        //ajouter mine
        myRessources.addStone(myMine.mineStone(nbrVillagois));
        
    }


//Lorsqu’un villageois utilise la methode `mineStone` celui-ci consomme `Mine.stone_cost` 
//et `Mine.wood_cost` 

//Et celui-ci vous rapportera `Mine.gain_stone` (créer une methode dans la classes `Ressource` `public addStone(int nbr)` qui ajouteras nbr a stone).
}