using ArenaGame;

namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of battles:");
            int rounds = Int32.Parse(Console.ReadLine());
            int oneWins = 0, twoWins = 0;

            Hero one = new Knight("Sir Lancelot", Weapon.Sword);
            Hero two = new Rogue("Robih Hood", Weapon.Knife);

            Hero three = new Mage("Gandalf");
            Hero four = new Bard("Jimmy");

            for (int i = 0; i < rounds; i++)
            {
                Console.WriteLine($"Arena fight between: {three.Name} and {four.Name}");
                Arena arena = new Arena(three, four);
                Hero winner = arena.Battle();
                Console.WriteLine($"Winner is: {winner.Name}");
                if (winner == three) oneWins++; else twoWins++;
            }
            Console.WriteLine();
            Console.WriteLine($"{three.Name} has {oneWins} wins.");
            Console.WriteLine($"{four.Name} has {twoWins} wins.");

            Console.ReadLine();
        }
    }
}
