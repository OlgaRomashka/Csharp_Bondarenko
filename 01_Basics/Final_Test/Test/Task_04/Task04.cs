namespace Test.Task_04;

public class Task04
{
    public static void Execute()
    {
        MyClass[] classes =
        [
            new MyClass(),
            new MyClass(),
            new MyClass(),
            new MyClass(),
        ];

        var counter = 0;
        
        MyClass.OnTenthCalled += () =>
        {
            counter++;
            Console.WriteLine($"10th CALL: {counter}");
        };
        
        var rnd = new Random();

        for (var i = 0; i < 77; i++)
        {
            var index = rnd.Next(0, classes.Length);

            classes[index].SomeMethod();
        }
        
       
    }
}