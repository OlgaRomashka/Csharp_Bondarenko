using System.Numerics;

namespace L_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var eagle1 = new Eagle("Eagle");
            var duck1 = new Duck("Duck");
            var duck2 = new Duck("Duck");
            var ostrich1 = new Ostrich("Ostrich");
            var penguin1 = new Penguin("Penguin");

            GetInfo(eagle1);
            GetInfo(duck1);
            GetInfo(duck2);
            GetInfo(ostrich1);
            GetInfo(penguin1);

            var egg1 = penguin1.LayEgg();

            GetInfo(egg1);
        }

        static public void GetInfo(BirdsBase bird)
        {
            Console.WriteLine(TellAboutBird(bird));
        }

        static public void GetInfo(Egg egg)
        {
            Console.WriteLine("Parent is:" + egg.Parent.Name);
        }

        static string TellAboutBird(BirdsBase bird)
        {
                string s = bird.Name;

                if (bird.Fly())
                {
                    s = s + ": Fly :";
                }
                if (bird.Walk())
                {
                    s = s + ": Walk :";
                }
                if (bird.Swim())
                {
                    s = s + ": Swim :";
                }
                if (bird.Run())
                {
                    s = s + ": Run :";
                }
                return s;     
         }   
    }
}
