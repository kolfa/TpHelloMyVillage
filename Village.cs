public class Village{
    private string name;
    private Ressources myRessources;
    public House chefHome;
    public int villageois=0;
    public House [] listHouse;
    public Mine myMine;
    public Forest myForest;
    
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
        this.myForest= new Forest();

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
        //si nbrvillagois>nbv que je possede ->je ne fais rien j'ai pas assez de villagois
        if (nbrVillagois > this.villageois)
        {
            Console.WriteLine ("Il n'ya pas assez de villagois ! ");
        //proteger j'ai assez de pierre et assez de bois
        }else if((Mine.stone_cost * nbrVillagois) > myRessources.GetStone() || (Mine.wood_cost * nbrVillagois) > myRessources.GetWood())
        {
            Console.WriteLine("Ressources insuffaisantes");
        }
        //consommer stone
        myRessources.useStone(Mine.stone_cost * nbrVillagois);
        //consommer wood
        myRessources.useWood(Mine.wood_cost * nbrVillagois);
        //ajouter mine
        myRessources.addStone(myMine.mineStone(nbrVillagois));
        myForest.le
        
    }
    public void cutWood(int nbrVillagois)
    {
        //si nbrvillagois>nbv que je possede ->je ne fais rien j'ai pas assez de villagois
        if (nbrVillagois > this.villageois)
        {
            Console.WriteLine ("Il n'ya pas assez de villagois ! ");
        //proteger j'ai assez de pierre et assez de bois
        }else if((Forest.stone_cost * nbrVillagois) > myRessources.GetStone() || (Forest.wood_cost * nbrVillagois) > myRessources.GetWood())
        {
            Console.WriteLine("Ressources insuffaisantes");
        }
        //consommer stone
        myRessources.useStone(Forest.stone_cost * nbrVillagois);
        //consommer wood
        myRessources.useWood(Forest.wood_cost * nbrVillagois);
        //ajouter wood
        myRessources.addWood(myForest.cutWood(nbrVillagois));

    }
    public void buildHouse(int nbrMaison)
    {
        //ajouter les tests
        myRessources.useStone(House.stone_needed * nbrMaison);
        myRessources .useWood(House.wood_needed * nbrMaison) ;
        for(int i =0; i<nbrMaison;i++)
        {
            addHouse();
        }
    }
    public void upgradeRessource()
    {
        myRessources.upgrade();
        myRessources.level ++;
    }
    public void lookAround()
    {
        if (myRessources.level >= 1)
        {
            myRessources.addStone(1);
            myRessources.addWood(1);
        }
    }

}