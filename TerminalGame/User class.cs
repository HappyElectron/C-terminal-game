public class User
{
    public string Name { get; set; }
    public int Xp { get; set; }
    public User()
    {
        Console.WriteLine("Enter your name: ");
        Name = Console.ReadLine();
        Xp = 0;
    }
    public void Setup()
    {
        Console.WriteLine("Hello {0}, and welcome to the realm of magic!", Name);
        Thread.Sleep(4000);
        Console.WriteLine("You are a wizard who has been set upon the mystical quest of getting 100 'xp'. Your currently have {0} 'xp'", Xp);
        Thread.Sleep(4000);
        Console.WriteLine("Gain levels by defeating monsters and challenges with spells!");
        Thread.Sleep(4000);
    }
}