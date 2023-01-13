public class Ressources
{
    private int wood;
    private int stones;
    public int level ;
    private int wood_max;
    private int stone_max;
    private int Wood
    {
        get {return wood;}
        set {this.wood =value;}
    }
    private int Stones
    {
        get {return stones;}
        set {this.stones= value;}
    }
    private int Level
    {
        get {return level;}
        set {this.level= value;}
    }
    private int Wood_max
    {
        get {return wood_max;}
        set {this.wood_max= value;}
    }
    private int Stone_max
    {
        get {return stone_max;}
        set {this.stone_max= value;}
    }
    
    public Ressources ()
    {
        this.wood = 10;
        this.stones = 10;
        this.level = 1;
        this.Stone_max = 250;
        this.wood_max = 250;
    }
    public int GetWood() 
    {
        return Wood;
    }

    public int GetStone() 
    {
        return Stones;
    }
    public void useStone(int nbr)
    {
        if (Stones < nbr )
        {
            Console.WriteLine("Attention, quantité non suffusante !");
        }else
        {
            Console.WriteLine("Quantité suffisante : " + Stones);
            this.Stones -= nbr;
        }
    }
    public void useWood(int nbr)
    {
        if ((Wood - nbr) < 0 )
        {
            Console.WriteLine("Attention, quantité non suffusante !");
        }else
        {
            Console.WriteLine("Quantité suffisante : " + Wood);
            this.Wood -= nbr;
        }
    }
    public void addStone(int nbr)
    {
        //manque test
        this.Stones += nbr;
    }
    public void addWood(int nbr)
    {
        //manque test
        this.Wood += nbr;
    }
    public void upgrade ()
    {
        //tester si j'ai assez de ressources

        useStone(Stone_max*(80/100));
        useWood(Wood_max*(80/100));
        Stone_max *=2;
        Wood_max *=2;

    }
    

}