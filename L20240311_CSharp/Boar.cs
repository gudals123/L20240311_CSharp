class Boar: Monster
{
    public Boar()
    {
        name = "멧돼지";
    }
    ~Boar()
    {
        Console.WriteLine("고블린 소멸자");
    }

    public override void Move()
    {
        base.Move();
        Console.WriteLine("이 뒤둥거린다");
    }

}

