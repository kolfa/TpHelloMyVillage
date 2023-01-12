public class Ressources
{
    private int wood;
    private int stones;
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
    public Ressources ()
    {
        this.wood =10;
        this.stones= 10;
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

}