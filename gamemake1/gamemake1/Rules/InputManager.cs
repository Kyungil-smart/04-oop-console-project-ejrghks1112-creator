

public class InputManager
{
    private PlayerCharacter _player;
    private Map _map;
    private MidStone _midstone;
    
    public InputManager(PlayerCharacter _player, Map _map, MidStone _midstone)
    {
        this._player = _player;
        this._map = _map;
        this._midstone = _midstone;
    }

    public bool PlayerAttack(ConsoleKey inputKey)
    {
        Vector attackPos = _player.PlayerPos;

        switch (inputKey)
        {
            case ConsoleKey.Spacebar:
                attackPos += Vector.Right;
                break;
        }
        
        char checkattack =  _map.GetCell(attackPos.X, attackPos.Y);
        if (checkattack != BasicWord.MIDSTONE) return false;
        
        return true;
    }
    
    
    public bool PlayerMove(ConsoleKey inputKey)
    {
        Vector nextPos = _player.PlayerPos;

        switch (inputKey)
        {
            case ConsoleKey.W:
                nextPos += Vector.Up;
                break;
            case ConsoleKey.S:
                nextPos += Vector.Down;
                break;
            case ConsoleKey.A:
                nextPos += Vector.Left;
                break;
            case ConsoleKey.D:
                nextPos += Vector.Right;
                break;
        }

        char checkMove = _map.GetCell(nextPos.X, nextPos.Y);
        if (checkMove == BasicWord.WALL ||
            checkMove == BasicWord.MIDSTONE ||
            checkMove == BasicWord.ATTACK) return false;

        _map.SetCell(_player.PlayerPos.X, _player.PlayerPos.Y, BasicWord.EMPTY);
        _map.SetCell(nextPos.X, nextPos.Y,BasicWord.PLAYER);
        _player.Move(nextPos);

        return true;
    }
}