
public class MidStone
{
    public static Vector StonePos { get; private set; }

    public static void Init(int PosX , int PosY)
    {
        StonePos = new Vector(){X = PosX, Y = PosY};
    }
}