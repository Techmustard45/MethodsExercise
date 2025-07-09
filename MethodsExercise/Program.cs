namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please input your favorite color: ");
            string color = Console.ReadLine();
            Console.WriteLine("Please input your favorite animal: ");
            string animal = Console.ReadLine();
            Console.WriteLine("Please input your favorite band: ");
            string band = Console.ReadLine();
            
            Console.WriteLine($"Hello, {name}! I am your program. I see your favorite color is {color}. I like that one too! Do you also like the {animal}? That's my favorite animal. I also heard that {band} is good, but I've never listened to them.");
        }
        
    }
}
