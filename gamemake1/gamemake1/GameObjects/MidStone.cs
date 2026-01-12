

public class MidStone
{
    public Vector StonePos { get; private set; }
    private Random rand2 = new Random();
    private Map _map;

    public MidStone(Map _map)
    {
        this._map = _map;
    }
    
    public void Init(int PosX , int PosY )
    {
        StonePos = new Vector(){X = PosX, Y = PosY};
    }

    public void GetAttack()
    {
        _map.CheckCell(out int x, out int y);
        _map.SetCell(x, y, dropCoin());
        Init(x, y);
    }

    public char dropCoin()
    {
        int dropChance = rand2.Next(1, 100);
        if (dropChance <= 70)
            return BasicWord.BRONZECOIN;
        else if (dropChance <= 95)
            return BasicWord.SILVERCOIN;
        else
            return BasicWord.GOLDENCOIN;
        
    }

}