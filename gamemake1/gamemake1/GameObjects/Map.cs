

public class Map
{
    private char[,] map = new char[20,20];

    public void Init()
    {
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                if (i == 0 || j == 0 || i == map.GetLength(0) - 1 || j == map.GetLength(1) - 1)
                {
                    map[i, j] = BasicWord.WALL;
                }
                else
                {
                    map[i, j] = BasicWord.EMPTY;
                }
            }
        }
    }

    public void PrintMap()
    {
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                Console.Write(map[i,j]);
            }

            Console.WriteLine();
        }
    }

    public char GetCell(int x, int y) => map[x, y];
    public void SetCell(int x, int y, char value) => map[x, y] = value;

    public void PlayerInMap(PlayerCharacter player)
    {
        int x = 1;
        int y = 2;
        SetCell(x,y, BasicWord.PLAYER);
        player.Init(x,y);
    }

    public void StoneInMap(MidStone stone)
    {
        int x = map.GetLength(0) / 2;
        int y = map.GetLength(1) / 2;
        SetCell(x, y, BasicWord.MIDSTONE);
        stone.Init(x, y);
    }

    public void StoreInMap(Store store)
    {
        int x = map.GetLength(0) - 2;
        int y = map.GetLength(1) / 2;
        SetCell(x, y, BasicWord.STORE);
        Store.Init(x, y);
    }
    
}