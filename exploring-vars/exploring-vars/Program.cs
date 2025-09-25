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

            //evil guys attack hero </3
            //boss first
            Console.WriteLine(villainName + " the " + villainTitle + " attacks " + heroFullName);
            Console.WriteLine(villainName + " the " + villainTitle + " deals " + bossStrength + " damage!");
            //take current health, subtract damage then store new val back into health
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            //minions attack
            Console.WriteLine("The minions attack!");
            Console.WriteLine(minion1Name + " deals " + minionStrength + " damage!");
            //subtract from hero health
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            Console.WriteLine(minion2Name + " deals " + minionStrength + " damage!");
            //subtract from hero health
            heroHealth -= minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            //hero attacks
            Console.WriteLine(heroFullName + " attacks each villain for " + heroStrength + " damage!");
            //subtract from villains health
            bossHealth -= heroStrength;
            minion1Health -= heroStrength;
            minion2Health -= heroStrength;

            //results in console
            Console.WriteLine(villainName + " the " + villainTitle + " now has " + bossHealth + " health!");
            Console.WriteLine(minionTitle + " " + minion1Name + " now has " + minion1Health + " health!");
            Console.WriteLine(minionTitle + " " + minion2Name + " now has " + minion2Health + " health!");

            //minions are dead
            Console.WriteLine(minion1Name + " and " + minion2Name + " have been defeated!");

            //end of round buff
            Console.WriteLine(heroFullName + " has " + heroHealth + " health!");
            Console.WriteLine(heroFullName + " eats an apple to restore health!");
            heroHealth++;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");


            //final round
            Console.WriteLine("The remaining fighters continue the fight!");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Boss' health: " + bossHealth);
            //boss attacks first
            Console.WriteLine(villainName + " the " + villainTitle + " attacks " + heroFullName);
            Console.WriteLine(villainName + " the " + villainTitle + " deals " + bossStrength + " damage!");
            heroHealth -= bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            Console.WriteLine(heroFullName + " attacks " + villainName + " the " + villainTitle + " for " + heroStrength + " damage!");
            //subtract from villains health
            bossHealth -= heroStrength;
            Console.WriteLine(villainName + " the " + villainTitle + " now has " + bossHealth + " health!");

            //final results
            Console.WriteLine(heroFullName + " is victorious!");
            Console.WriteLine("Wealth, glory, and straight A+'s to the winner!");

        }
    }
}
