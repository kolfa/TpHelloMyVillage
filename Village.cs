public class Village{
    private string name;
    Ressources myRessources = new Ressources();
    private Ressources myRessources;
    

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Village(string name)
    {
        this.name = Name;
    }
    public string  getName()
    {
        return ("Le nom de village est : " + Name);
    }

}