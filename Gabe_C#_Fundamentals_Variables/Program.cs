using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabe_C__Fundamentals_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string characterName = "Guy";
            int health = 100;
            float shield = 50;



            
            string myString = "Name: " + characterName;
            string healthText = "Health: " + health;
            string shieldText = "Shield: " + shield;



            Console.WriteLine("{0,70}", "Journey of a Guy");
            Console.ReadKey();
            Console.Clear();



            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("{0,0}", myString);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("{0,50}", healthText);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("{0,60}", shieldText);
            Console.ForegroundColor = ConsoleColor.White;







            
            

            //Line clear
            Console.ReadKey();
            Console.Clear();

            //Enemy attacking Text
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Oh no enemy fire!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadKey();
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("You took 50 Shield damage...");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadKey();
            Console.Clear();


            //Updated HUD
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("{0,0}", myString);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("{0,50}", healthText);
            Console.ForegroundColor = ConsoleColor.Gray;
            shield = shield - 50;
            shieldText = "Shield: " + shield;
            Console.Write("{0,60}", shieldText);

            Console.ReadKey();
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("uh oh Live Grenade!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadKey();
            Console.Clear();
            Console.Write("Game over!");
            Console.ReadKey();


            
           
           












        }
    }
}
