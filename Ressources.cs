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
    private Ressources ()
    {
        this.wood =10;
        this.stones= 10;
    }
    private int  getWood(int wood)
    {
        return this.wood =Wood;
    }
    private int getStones(int stones)
    {
        return this.stones = Stones ;
    }
    public void useStone(int nbr)
    {
        if (nbr > Stones )
        {
            Console.WriteLine("Attention, quantité non suffusante !");
        }else
        {
            Console.WriteLine("Quantité suffisante : " + Stones);
        }
    }
    public void useWood(int nbr)
    {
        if (nbr > Wood )
        {
            Console.WriteLine("Attention, quantité non suffusante !");
        }else
        {
            Console.WriteLine("Quantité suffisante : " + Wood);
        }
    }

}