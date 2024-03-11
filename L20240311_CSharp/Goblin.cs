class Goblin: Monster
{
    public Goblin()
    {
        name = "고블린";
    }
    ~Goblin()
    {
        Console.WriteLine("고블린 소멸자");
    }


    public override void Move()
    {
        base.Move();
        Console.WriteLine("이 걸어간다");
    }
}

