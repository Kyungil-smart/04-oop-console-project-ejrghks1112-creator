

public class Map
{
    private char[,] _map = new char[20,20];
    private Random rand1 = new Random();

    public void Init()
    {
        for (int i = 0; i < _map.GetLength(0); i++)
        {
            for (int j = 0; j < _map.GetLength(1); j++)
            {
                if (i == 0 || j == 0 || i == _map.GetLength(0) - 1 || j == _map.GetLength(1) - 1)
                {
                    _map[i, j] = BasicWord.WALL;
                }
                else
                {
                    _map[i, j] = BasicWord.EMPTY;
                }
            }
        }
    }

    public void PrintMap()
    {
        for (int i = 0; i < _map.GetLength(0); i++)
        {
            for (int j = 0; j < _map.GetLength(1); j++)
            {
                Console.Write(_map[i,j]);
            }

            Console.WriteLine();
        }
    }

    public char GetCell(int x, int y) => _map[x, y];
    public void SetCell(int x, int y, char value) => _map[x, y] = value;

    public void PlayerInMap(PlayerCharacter player)
    {
        int x = 1;
        int y = 2;
        SetCell(x,y, BasicWord.PLAYER);
        player.Init(x,y);
    }

    public void StoneInMap(MidStone stone)
    {
        int x = _map.GetLength(0) / 2;
        int y = _map.GetLength(1) / 2;
        SetCell(x, y, BasicWord.MIDSTONE);
        stone.Init(x, y);
    }

    public void StoreInMap(Store store)
    {
        int x = _map.GetLength(0) - 2;
        int y = _map.GetLength(1) / 2;
        SetCell(x, y, BasicWord.STORE);
        Store.Init(x, y);
    }
    
    public void CheckCell(out int posX, out int posY)
    {
        while (true)
        {
            posX = rand1.Next(1, 19);
            posY = rand1.Next(1, 19);

            if (_map[posX, posY] == BasicWord.EMPTY)
                break;
        }
    }
    
}