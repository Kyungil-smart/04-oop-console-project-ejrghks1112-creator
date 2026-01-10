

public class GameManager
{
    public bool IsGamming { get; set; }
    private Map _map;
    private MidStone _midstone;
    private PlayerCharacter _player;
    private Store _store;
    private InputManager _input;
    
    public void Run()
    {
        Init();
        
        while (IsGamming)
        {
            Console.SetCursorPosition(0, 4);
            _map.PrintMap();

            ConsoleKey inputKey = _player.UserInput();
            _input.PlayerMove(inputKey);
            bool isHit = _input.PlayerAttack(inputKey);
            if (isHit)
            {
                _midstone.GetAttack();
            }
        }
    }

    private void Init()
    {
        IsGamming = true;
        _player = new PlayerCharacter();
        _map = new Map();
        _midstone = new MidStone();
        _store = new Store();
        _input = new InputManager(_player, _map, _midstone);
        
        _map.Init();
        _map.PlayerInMap(_player);
        _map.StoneInMap(_midstone);
        _map.StoreInMap(_store);
    }
}