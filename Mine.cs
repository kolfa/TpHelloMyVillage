public class Mine
{
    public static int gain_stone = 10;
    public static int stone_cost = 2;
    public static int wood_cost = 1;
    private int level = 1;
    public Mine()
    {
        Console.WriteLine ("Mine created");
    }
    public int mineStone(int nbrVillagois)
    {
        return nbrVillagois * Mine.gain_stone;
    }
    public int getLevel()
    {
        return this.level;
    }

}