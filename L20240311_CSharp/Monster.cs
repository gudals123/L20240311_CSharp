public class Monster
{
    public int gold = 0;
    private bool attack;
    private bool dead;
    protected string name;

    //생성자
    public Monster()
    {
        name = "몬스터";
        //메모리 할당
        //new Mesh();
        //new Texture();
        //.....

    }
    //소멸자
    ~Monster()
    {
        Console.WriteLine("몬스터 소멸자");
    }

    public int Gold
    {
        get
        {
            return gold;
        }
        set
        {
            gold = value;
        }
    }



    public virtual void Move()
    {
        Console.Write($"{name}");
    }
    public void Attack()
    {
        if(attack)
        {
            Console.WriteLine($"{name}가 공격을 합니다");
        }
            
    }
    private void Dead()
    {
        if (dead)
        {
            Console.WriteLine($"{name}가 죽어 {gold} Gold를 남깁니다.");
        }
    }
}

