namespace L_09.Task_05
{
    public abstract class AnimalBase
    {
        public string name = "Noname";

        public string whereLive = "Nowhere";

        public virtual void GetInfo()
        {
            Console.WriteLine($" Name animal: {name}");
            Console.WriteLine($" Where live animal: {whereLive}");
        }
    }
}