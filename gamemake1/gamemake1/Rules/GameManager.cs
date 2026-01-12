

public class GameManager
{
    public bool IsGamming { get; set; }
    private Map _map;
    private MidStone _midstone;
    private PlayerCharacter _player;
    private Store _store;
    private InputManager _input;
    private Coins _coins;
    private Random rand3 = new Random();
    
    public void Run()
    {
        Init();
        
        while (IsGamming)
        {
            //화면에 현제 가지고 있는 코인의 개수 표시
            Console.SetCursorPosition(22, 4);
            _coins.PrintCoin();
            
            Console.SetCursorPosition(0, 4);
            _map.PrintMap();

            ConsoleKey inputKey = _player.UserInput();
            _input.PlayerMove(inputKey);
            // 때리면 랜덤하게 코인 드롭 
            bool isHit = _input.PlayerAttack(inputKey);
            if (isHit)
            {
                for (int i = rand3.Next(1, 3); i < 4; i++)
                {
                   _midstone.GetAttack();
                }
            }
            // 코인을 주우면 브론즈는 1원 실버는 3원 골드는 5원을 얻는다?
            if (_input.GetCoin())
            {
                _coins.PickupCoin();
            }
            // 상점칸위에 캐릭터가 올라가면 상점으로 이동? or 상점을 오픈
            if (_input.OnStore())
            {
                _store.InStore();
            }
            //상점에선 코인을 기반으로 물품 구매 가능?
            
        }
    }

    private void Init()
    {
        IsGamming = true;
        _player = new PlayerCharacter();
        _map = new Map();
        _midstone = new MidStone(_map);
        _input = new InputManager(_player, _map, _midstone);
        _coins = new Coins(_midstone, _input);
        _store = new Store(_coins);
        
        _map.Init();
        _map.PlayerInMap(_player);
        _map.StoneInMap(_midstone);
        _map.StoreInMap(_store);
    }
}