using System;
using System.Collections.Generic;
using System.Text;
using Byond___A_Journey;

namespace Byond___A_Journey
{
    public static class OutcomeTest1
    {
       public static void DisplayOutcomeTest1()
        {
            //write out 3 options for a player to choose from..

            Console.WriteLine("A mist descends and obscures your vision. \n");
            Console.WriteLine("You hear a battle in the distance.  The sounds of war fill the air.\n");
            Console.WriteLine("Choose wisely.\n");

            Choice1:
            Console.WriteLine(
                "[A]pproach the battle.  Now it is time to test your mettle and revel in glory.  You thirst for the exhilaration only war can bring.\n");
            Console.WriteLine(
                "[S]et up a shop.  There is no reason to place oneself in danger.  A peaceful existence running a simple business is all that is needed.\n"
            );
            Console.WriteLine(
                "[T]end to the wounded.  Someone must protect the weak, you know in your heart you must be their salvation.\n");


            string choice3 = Console.ReadLine()?.ToLower();
            Console.Clear();

            switch (choice3)
            {
                case "a":
                {
                    Console.WriteLine(
                        "Eagerly you bound towards the fight.  As the noise grows so does the anticipation in your heart.  This truly is a remarkable place.");
                    break;
                }
                case "s":
                {
                    Console.WriteLine(
                        "You set up a shop.  You have a place to rest and a place to prosper; a place to live and work.\n");
                    Console.WriteLine(
                        "A gentle breeze blows through the shop.  You are content to rest and enjoy the peace of the moment.");
                    break;
                }
                case "t":
                {
                    Console.WriteLine(
                        "Your hear swells with love and compassion as you aid these poor souls.  For now you are content to protect them.  Hopefully one day peace shall be brokered.");
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid Command.  Please try again.");
                    goto Choice1;
                }
            }
        }
    }
}