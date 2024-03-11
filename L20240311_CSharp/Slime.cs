class Slime : Monster
{
    public Slime()
    {
        name = "슬라임";
    }
    ~Slime()
    {
        Console.WriteLine("슬라임 소멸자");
    }



    public override void Move()
    {
        base.Move();
        Console.WriteLine("이 미끄러진다");
    }

}
