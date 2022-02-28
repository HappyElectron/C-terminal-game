using System;
namespace WizardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(Convert.ToString(Console.ReadLine()));
            user.Stinky();
        }
    }
    public class User
    {
        public string Name { get; set; }
        public User(string name)
        {
            Name = name;
        }
        public void Stinky()
        {
            Console.WriteLine("{0} is stinky", Name);
        }
    }
}
