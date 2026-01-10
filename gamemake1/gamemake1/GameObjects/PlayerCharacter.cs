
public class PlayerCharacter 
{
    public Vector PlayerPos { get; set; }
    public Vector PlayerAttack { get; set; }

    public void Init(int PosX , int PosY)
    {
        PlayerPos = new Vector(){X = PosX, Y = PosY};
        PlayerAttack = new Vector() { X = PosX + 1, Y = PosY };
    }

    public ConsoleKey UserInput()
    {
        ConsoleKey inputKey;

        while (true)
        {
            inputKey = Console.ReadKey(true).Key;

            if (inputKey == ConsoleKey.W ||
                inputKey == ConsoleKey.A ||
                inputKey == ConsoleKey.S ||
                inputKey == ConsoleKey.D ||
                inputKey == ConsoleKey.Spacebar) break;
        }

        return inputKey;
    }

    public void Move(Vector nextPos)
    {
        PlayerPos = nextPos;
    }

    public void Attack(Vector attackPos)
    {
        PlayerAttack = attackPos;
    }
}