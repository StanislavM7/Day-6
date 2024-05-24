using ArenaGameEngine;

namespace ArenaGameConsole
{
    class ConsoleGameEventListener : GameEventListener
    {
        public override void GameRound(Hero attacker, Hero defender, int attack)
        {
            string message = $"{attacker.Name} attacked {defender.Name} for {attack} points";
            if (defender.IsAlive)
            {
                message = message + $" but {defender.Name} survived.";
            }
            else
            {
                message = message + $" and {defender.Name} died.";
            }
            Console.WriteLine(message);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Sir John");
            Rogue rogue = new Rogue("Slim Shady");
            Dragon dragon = new Dragon("Sky");
            Wizard wizard = new Wizard("Electro");
            
            Arena arena = new Arena(knight, rogue);
            arena.EventListener = new ConsoleGameEventListener();

            Arena arena = new Arena(dragon, wizard);
            arena.EventListener = new ConsoleGameEventListener();

            Console.WriteLine("Battle begins.");
            Hero winner = arena.Battle();
            Console.WriteLine($"Battle ended.  Winner is: {winner.Name}");
            Console.ReadLine();
        }
    }
}
