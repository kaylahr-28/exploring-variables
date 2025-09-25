namespace exploring_vars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables
            //--names
            string heroFirstName = "Kaylah";
            string heroLastName = "Rouzier";
            string heroFullName;
            string villainTitle = "Super Evil Guy";
            string minionTitle = "Smaller, Less Evil Guy";
            string villainName;
            string minion1Name;
            string minion2Name;
            //--integers
            int heroHealth = 100;
            int heroStrength = 50;
            int bossHealth = 100;
            int bossStrength = 25;
            int minion1Health = 50;
            int minion2Health = 50;
            int minionStrength = 5;

            // start code instructions
            heroFullName = heroFirstName + " " + heroLastName;
            Console.WriteLine("Behold, the legendary hero of programming, whose name is.. " + heroFullName);

            villainName = "Ricky";
            minion1Name = "Flip";
            minion2Name = "Flop";

            //introduce villain and minions
            Console.WriteLine(heroFullName + "'s arch nemesis is " + villainName + " the " + villainTitle);
            Console.WriteLine(villainName + " the " + villainTitle + " is helped out by " + minionTitle + " " + minion1Name + " and " + minionTitle + " " + minion2Name);

            //prepare for battle
            Console.WriteLine("The fighters enter the room..");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Boss' health: " + bossHealth);
            Console.WriteLine("Minion 1's health: " + minion1Health);
            Console.WriteLine("Minion 2's health: " + minion2Health);

            //fight

        }
    }
}
