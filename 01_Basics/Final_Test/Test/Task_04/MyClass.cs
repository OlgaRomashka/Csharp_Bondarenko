namespace Test.Task_04;

public class MyClass
{
    public static event Action OnTenthCalled;
    private static int _counter;
    

    public void SomeMethod()
    {
        _counter++;

        if (_counter < 10) return;
        
        OnTenthCalled?.Invoke();
        _counter = 0;
    }
}