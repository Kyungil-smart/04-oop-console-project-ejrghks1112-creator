

public class Store
{
    private Coins _coins;
    public static Vector StorePos { get; private set; }

    public Store(Coins _coins)
    {
        this._coins = _coins;
    }
    
    public static void Init(int PosX , int PosY)
    {
        StorePos = new Vector(){X = PosX, Y = PosY};
    }

    public void InStore()
    {
        Console.Clear();
        Console.WriteLine("========== 상점 ==========");
        Console.WriteLine($"=현재 사용가능한 금액 : {_coins.playerCoin} =");
        Console.WriteLine("=1.                      =");
        Console.WriteLine("=2.                      =");
        Console.WriteLine("=3.                      =");
        Console.WriteLine("==========================");

        ConsoleKeyInfo storeNumber = Console.ReadKey(true);
        if (storeNumber.Key == ConsoleKey.D1)
        {
            if (_coins.UseCoin(30))
            {
                Console.SetCursorPosition(27, 0);
                Console.WriteLine("1번 품목 구매 코인차감");
            }
            else
            {
                Console.SetCursorPosition(27, 0);
                Console.WriteLine("코인 부족으로 인한 구매 불가");
            }
        }
        else if (storeNumber.Key == ConsoleKey.D2)
        {
            if (_coins.UseCoin(300))
            {
                Console.SetCursorPosition(27, 0);
                Console.WriteLine("2번 품목 구매 코인차감");
            }
            else
            {
                Console.SetCursorPosition(27, 0);
                Console.WriteLine("코인 부족으로 인한 구매 불가");
            }
        }
        else if (storeNumber.Key == ConsoleKey.D3)
        {
            if (_coins.UseCoin(3000))
            {
                Console.SetCursorPosition(27, 0);
                Console.WriteLine("3번 품목 구매 코인차감");
            }
            else
            {
                Console.SetCursorPosition(27, 0);
                Console.WriteLine("코인 부족으로 인한 구매 불가");
            }
        }
        else
        {
            if (_coins.UseCoin(30000))
            {
                Console.SetCursorPosition(27, 0);
                Console.WriteLine("4번 품목 구매 코인차감");
            }
            else
            {
                Console.SetCursorPosition(27, 0);
                Console.WriteLine("코인 부족으로 인한 구매 불가");
            }
        }
        
    }
}