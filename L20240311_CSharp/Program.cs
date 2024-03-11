using static System.Net.Mime.MediaTypeNames;
using System.Collections;
using System.ComponentModel;
using static System.Formats.Asn1.AsnWriter;


class Program
{
    //overloading
    //name mangling: 인자가 다르면 메소드 이름도 다르게 본다.
    static void Add<T,Y>(T a, Y b)
    {
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
    class Store<T>
    {
        public T Data;
    }



    static void Main(string[] args)
    {
        


        Console.WriteLine("====================");
        Console.WriteLine("게임 시작 몬스터 생성");
        Console.WriteLine("====================");
        Console.WriteLine();
        int monsterCountTotal = 0;

        
        bool isRunning = true;
        while (isRunning)
        { 
            //init
            Random random = new Random();
            int monsterCount = random.Next(1, 11);
            //Monster[] monsters = new Monster[monsterCount];
            List<Monster> monsters = new List<Monster>();       //몬스터의 숫자가 변할수있기 때문에 List를 사용한다.
            monsterCountTotal += monsterCount;

            Dictionary<string,Monster> monsterTypr = new Dictionary<string, Monster>();
            monsterTypr["slime"] = new Slime();
            monsterTypr["goblin"] = new Goblin();
            monsterTypr["boar"] = new Boar();


            //Engine.Load
            for (int i = 0; i < monsterCount; i++)
            {
                int monsterType = random.Next(0, 100);
                if (monsterType <20)
                {
                    monsters.Add(new Slime());
                }
                else if (monsterType > 20 && monsterType < 50)
                {
                    monsters.Add(new Goblin());
                }
                else
                {
                    monsters.Add(new Boar());
                }
            }
            //Update
            foreach (var monster in monsters)
            {
                monster.Move();
            }


            bool isRunning2 = true;
            while (isRunning2)
            {
                Console.WriteLine("====================");
                Console.WriteLine("다음 스테이지 (Y / N)");
                string? key = Console.ReadLine();
                if (key == "y" || key == "Y")
                {
                    isRunning2 = false;
                }
                else if (key == "n" || key == "N")
                {
                    Console.WriteLine();
                    Console.WriteLine("====================");
                    Console.WriteLine("     게임 종료");
                    Console.WriteLine("====================");
                    isRunning = false;
                    isRunning2 = false;
                }
                else
                {
                    Console.WriteLine("잘못 입력했습니다 다시 입력하세요");
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine($"소환된 몬스터의 수 : {monsterCountTotal}");


        /*        Player player = new Player();
                player.Move();

                Slime[] slimes = new Slime[3];
                for (int i = 0; i < slimes.Length; i++)
                {
                    slimes[i] = new Slime();
                }


                Goblin[] goblins = new Goblin[3];
                for (int i = 0; i < goblins.Length; i++)
                {
                    goblins[i] = new Goblin();
                }


                Boar[] boars = new Boar[3];
                for (int i = 0; i < boars.Length; i++)
                {
                    boars[i] = new Boar();
                }

                bool isRunning = true;
                while (true)
                {
                    //Input
                    player.Move();

                    for (int i = 0; i < slimes.Length; i++)
                    {
                        slimes[i].Move();
                    }

                    for (int i = 0; i < goblins.Length; i++)
                    {
                        goblins[i].Move();
                    }
                    for (int i = 0; i < boars.Length; i++)
                    {
                        boars[i].Move();
                    }

                    //Render*/
    }



}



