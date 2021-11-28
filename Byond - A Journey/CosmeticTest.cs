using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using System.Xml.Schema;
using Byond___A_Journey;

namespace Byond___A_Journey
{
    public static class CosmeticTest
    {
        public static void DisplayCosmeticTest()
        {
            Choice1:
            Console.WriteLine("You face three paths in front of you but can only choose one.\n");
            Console.WriteLine(
                "[T]o the left you spy a spritely ocean scene.  Some abodes dot the cliffs and the beaches are a perfect white.  In the distance a gull, no a pelican, wait...a bird ... softly calls.  A hint of salt wafts in the air.  The horizon is dappled with purples, pinks, oranges and full of beauty.");
            Console.WriteLine(
                "[A]s you gaze forward a marvelous cityscape appears.  It might be the 1920s, Earth, New York or perhaps it's the 3020s on IO, Founders Point. Time seems elusive here but the striking mechanical wonders shift hazily to and fro shimmering with the promise of technological progress.");
            Console.WriteLine(
                "[U]pon turning to your right a vast meadow spreads, greens and yellows of all sorts catching the light.The meadow is home to many beautiful trees and bushes.Amongst the flowers you spy a few people who seem to be quite at peace amongst themselves.A gentle music carries forth from the birds nestled about all seem to be singing in harmony.");


            string choice = Console.ReadLine()?.ToLower();

            if (choice != null) {
                    OutcomeTest1.DisplayOutcomeTest1();
            }

           
                if (choice == "t")
                {
                    AfterLife.Outcome[0] = 1;
                }
                else
                {
                    if (choice == "a")
                    {
                        AfterLife.Outcome[0] = 2;
                    }
                    else
                    {
                        if (choice == "u")
                        {
                            AfterLife.Outcome[0] = 3;
                        }
                    }
                }
            }
        }
    }