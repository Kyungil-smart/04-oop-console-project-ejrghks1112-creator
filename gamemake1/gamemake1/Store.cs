

public class Store
{
    public static Vector StorePos { get; private set; }

    public static void Init(int PosX , int PosY)
    {
        StorePos = new Vector(){X = PosX, Y = PosY};
    }
}