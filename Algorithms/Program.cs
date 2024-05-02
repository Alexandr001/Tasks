// See https://aka.ms/new-console-template for more information

var instance = Singleton.Instance;
var instance2 = Singleton.Instance;
class Singleton
{
    private static Singleton _instance;

    public static Singleton Instance => _instance ??= new Singleton();

    static Singleton()
    {
        Console.WriteLine("Static Constructor");
    }

    private Singleton()
    {
        Console.WriteLine("Default Constructor");
    }
}
