public class Player
{
    public Player() 
    { 

    }
    ~Player()
    {
        Console.WriteLine("플레이어 소멸자");
    }

    private bool attack;
    public void Move()
    {
        Console.WriteLine("플레이어가 이동을 합니다");
    }
    public void Attack()
    {
        if (attack)
        {
            Console.WriteLine("플레이어가 공격을 합니다");
        }
    }
}

