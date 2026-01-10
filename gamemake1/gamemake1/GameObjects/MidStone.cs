
public class MidStone
{
    public Vector StonePos { get; private set; }
    
    public void Init(int PosX , int PosY )
    {
        StonePos = new Vector(){X = PosX, Y = PosY};
    }

    public void GetAttack()
    {
        
    }
}