public class Forest
{
    public static int gain_wood = 10;
    public static int stone_cost = 2;
    public static int wood_cost = 1;
    private int level = 1;

    public int cutWood(int nbr)
    {
        return Forest.gain_wood * nbr;
    }
    public int getLevel()
    {
        return this.level;
    }
    

}