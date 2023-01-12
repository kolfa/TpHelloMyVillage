public class Village{
    private string name;
    private Ressources myRessources;
    public House chefHome;
    private int villageois=0;
    public House [] listHouse;
    
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    
    public Village(string Name)
    {
        this.name = Name;
        this.myRessources = new Ressources();
        this.chefHome = new House();
        this.villageois = House.villageois;
        this.listHouse = new House[1];
        listHouse[0] = this.chefHome ;

    }

    public string  getName()
    {
        return ("Le nom de village est : " + Name);
    }
    public void addHouse()
    {
        
    }

}