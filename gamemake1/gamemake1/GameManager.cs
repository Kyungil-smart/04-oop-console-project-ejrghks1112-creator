

public class GameManager
{
    public static bool IsGamming { get; set; }
    private Map _map;
    private MidStone _midstone;
    private PlayerCharacter _player;
    private Store _store;
    
    public void Run()
    {
        Init();
        
        while (IsGamming)
        {
            Console.SetCursorPosition(0, 4);
            _map.PrintMap();
        }
    }

    private void Init()
    {
        IsGamming = true;
        _player = new PlayerCharacter();
        _map = new Map();
        _map.Init();

    }
}