using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using System.Xml.Schema;
using Byond___A_Journey;


namespace Byond___A_Journey
{
    class Introduction
    {
        public static void Intro()
        {
            Console.WriteLine("Please input your name followed by pressing enter.\n");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " welcome to the world of Byond!\n");
            Console.WriteLine(
                "Please press the button inside [ ] to undertake the action.\n");
            Console.WriteLine(
                "You wake up in a lush meadow and see a figure in the distance.  Oddly you can't recall falling asleep and you know you definitely haven't seen this place before.  Plus...you don't like to sleep in the grass.  How odd, you also don't remember putting on this simple robe.  Functional but not flattering.\n");

            Choice:
            Console.WriteLine(
                "[W]alk towards the mysterious being.\n" +
                "[T]ry to go get yourself to wake up, this has to be a weird dream and you want it to end.\n" +
                "[G]o away from the mysterious being.");

            string choice = Console.ReadLine()?.ToLower();
            Console.Clear();

            switch (choice)
            {
                case "w":
                {
                    Console.WriteLine(
                        "You're transfixed by the shape across the way.As you wipe the sleep from your eyes you cautiously approach it. \"Greetings " +
                        name +
                        " and welcome to your waystation to the afterlife.  We designed a quick test to sort out what kind of \"after-life\" experience your kind deserve.  Nevermind all the questions you have right now about all this; rest assured you will have plenty of time to answer them all.  For now just focus on the tasks at hand and try not to worry too much - it's just eternity after all.\" \n");
                    break;
                }
                case "t":
                {
                    Console.WriteLine(
                        " You don't like this, it feels weird and the sooner it stops the better.  You close your eyes and try to make it stop.");
                    Console.WriteLine("\"" + name +
                                      " this isn't a dream.  Please open your eyes and allow me to help you.  Go on and get up, you can't keep your eyes shut forever.\"");
                    Console.WriteLine(
                        "\"Welcome to your waystation to the afterlife.  We designed a quick test to sort out what kind of \"after-life\" experience your kind deserve.  Nevermind all the questions you have right now about all this; rest assured you will have plenty of time to answer them all.  For now just focus on the tasks at hand and try not to worry too much - it's just eternity after all.\" \n");
                    break;
                }
                case "g":
                {
                    Console.WriteLine(
                        "You're not sure what that thing is in the distance but you decide it makes sense to steer clear.  You turn around and head the other way.  Suddenly you're face to face with the very ... person ? ... you were trying to avoid.");
                    Console.WriteLine("\"Where do you think you're going " + name + "?\"");
                    Console.WriteLine(
                        "\"Don't fear me I'm merely a temporary corporeal figure to put you at ease and guide you to the begining of your journey\"");
                    Console.WriteLine(
                        "\"Welcome to your waystation to the afterlife.  We designed a quick test to sort out what kind of \"after-life\" experience your kind deserve.  Nevermind all the questions you have right now about all this; rest assured you will have plenty of time to answer them all.  For now just focus on the tasks at hand and try not to worry too much - it's just eternity after all.\" \n");
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid Command.  Please try again.");
                    goto Choice;
                }
            }

            CosmeticTest.DisplayCosmeticTest();
        }
    }
}