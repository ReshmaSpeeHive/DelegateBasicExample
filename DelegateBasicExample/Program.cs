

Program1 program1= new Program1();

program1.Main();
class Program1
{
    delegate void LogDel(string text);
    static void LogTextToscreen(string text)
    {
        Console.WriteLine($"{DateTime.Now}: {text}");
    }
   public void Main()
    {

        LogDel logDel = new LogDel(LogTextToscreen);
        LogDel logDelfile = new LogDel(LogTextToFile);
        Console.WriteLine("please enter the name");
        var name = Console.ReadLine();
        logDel(name);
        logDelfile(name); 
        Console.ReadKey();
    }
    static void LogTextToFile(string text)
    {
        using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
        {
            sw.WriteLine($"{DateTime.Now}:{text}");
        }
    }
}
