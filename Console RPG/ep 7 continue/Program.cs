using System;
using System.Threading.Tasks;
namespace RPG
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Class classcreate = Class.CharacterCreation();


            ///Results of character customization
            Console.WriteLine("\nYour chosen name is " + classcreate.name);
            Console.WriteLine("Your chosen age is " + classcreate.age);
            Console.WriteLine("Your chosen gender is " + classcreate.gender);

            Monster combat = await Monster.EnteringBattle();
            Monster slime = Monster.SlimeInfo();

        }
    }
}
class Class
{
    ///Variables
    public int age;
    public int level;
    public string name;
    public int spellslots;
    public float experience;
    public string gender;
    public string yesorno;
    public int classselect;


    ///Character Creation Method
    public static Class CharacterCreation()
    {
        Class classcreate = new Class();
        while (true)
        {

            Console.WriteLine("Which class do you want to pick?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("(1) Paladin");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" (2) Warrior");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" (3) Wizard");
            Console.ResetColor();
            Console.WriteLine("\nPlease select a class (1-3)\n");

            ///Class Chooser
            while (int.TryParse(Console.ReadLine(), out classcreate.classselect) == false || classcreate.classselect < 1 || classcreate.classselect > 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nPlease enter a valid number between 1 and 3: ");
                Console.ResetColor();
            }

            if (classcreate.classselect == 1)
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nCustomize your Paladin!");
            }
            else if (classcreate.classselect == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nCustomize your Warrior!");
            }
            else if (classcreate.classselect == 3)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nCustomize your Wizard!");
            }
            Console.ResetColor();

            ///Character Attributes
            Console.Write("\nWhat is your age: ");
            while (int.TryParse(Console.ReadLine(), out classcreate.age) == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Please enter a valid age: ");
                Console.ResetColor();
            }
            Console.Write("Are you Male or Female: ");
            classcreate.gender = Console.ReadLine();
            while (true)
            {
                if (classcreate.gender == "Male")
                {

                    break;

                }
                else if (classcreate.gender == "Female")
                {
                    classcreate.gender = "she";
                    break;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Please enter a valid gender: ");
                    Console.ResetColor();
                    classcreate.gender = Console.ReadLine();
                    if (classcreate.gender is "Male")
                    {

                        break;
                    }
                    else if (classcreate.gender is "Female")
                    {

                        break;
                    }
                }
            }
            Console.Write("What is your name: ");
            classcreate.name = Console.ReadLine();
            while (string.IsNullOrEmpty(classcreate.name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Please enter a name: ");
                Console.ResetColor();
                classcreate.name = Console.ReadLine();
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nAre you happy with your choices? (Yes/No) (Picking No will result in a restart of the character customization): ");
            Console.ResetColor();
            classcreate.yesorno = Console.ReadLine();
            if (classcreate.yesorno == "Yes")
            {
                break;
            }
            else if (classcreate.yesorno == "No")
            {
                Console.Clear();
            }
            else
            {
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Please enter a valid answer(Yes/No): ");
                    Console.ResetColor();
                    classcreate.yesorno = Console.ReadLine();
                    if (classcreate.yesorno == "Yes")
                    {
                        break;
                    }
                    else if (classcreate.yesorno == "No")
                    {

                        Console.Clear();

                    }
                }

            }
            break;
        }
        return classcreate;
    }
}
class Monster
{
    public int health = 100;
    public string name = "Slime";



    public static Monster SlimeInfo()
    {
        Monster slime = new Monster();


        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Health - " + slime.health, "\n");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Monster - " + slime.name);
        Console.ResetColor();






        return slime;
    }
    public static async Task<Monster> EnteringBattle()
    {
        Monster combat = new Monster();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nPress enter to enter battle!");
        Console.ReadLine();
        Console.Clear();
        Console.ResetColor();
        Console.WriteLine("Entering battle in 5 seconds...\n");

        await Task.Delay(1000);
        Console.WriteLine("1");
        await Task.Delay(1000);
        Console.WriteLine("2");
        await Task.Delay(1000);
        Console.WriteLine("3");
        await Task.Delay(1000);
        Console.WriteLine("4");
        await Task.Delay(1000);
        Console.WriteLine("5");
        await Task.Delay(1000);
        Console.WriteLine("Let the battle commence!");
        await Task.Delay(1000);

        return combat;

    }


}