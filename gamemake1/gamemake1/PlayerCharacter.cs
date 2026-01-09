
public class PlayerCharacter 
{
    public static Vector PlayerPos { get; private set; }

    public static void Init(int PosX , int PosY)
    {
        PlayerPos = new Vector(){X = PosX, Y = PosY};
    }
}