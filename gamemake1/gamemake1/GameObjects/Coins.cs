

public class Coins
{
    private MidStone _midstone { get; set; }
    private InputManager _input;
    public int playerCoin = 0;

    public Coins(MidStone _midstone, InputManager _input)
    {
        this._midstone = _midstone;
        this._input = _input;
    }
    
    public void PrintCoin()
    {
        Console.WriteLine($"현재 플레이어의 총 코인 수 : {playerCoin}");
    }

    public int PickupCoin()
    {
        if (_input == null) return playerCoin;
        char checkCoin = _input.checkGetCoin;
        switch (checkCoin)
        {
            case '1':
                playerCoin += 1;
                break;
            case '2':
                playerCoin += 3;
                break;
            case '3':
                playerCoin += 5;
                break;
        }

        return playerCoin;
    }

    public bool UseCoin(int useCoin)
    {
        if (playerCoin >= useCoin)
        {
            playerCoin -= useCoin;
            return true;
        }
        else return false;
    }
}