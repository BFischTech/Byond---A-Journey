using System;
using System.Collections.Generic;
using System.Text;

namespace Byond___A_Journey
{
    class GameTitle
    {
        public static Array DisplayGameTitle()
        {
            var arr = new[]
            {
                @" /$$$$$$$                                      /$$  ",
                @" | $$__  $$                                    | $$ ",
                @" | $$  \ $$ /$$   /$$  /$$$$$$  /$$$$$$$   /$$$$$$$ ",
                @" | $$$$$$$ | $$  | $$ /$$__  $$| $$__  $$ /$$__  $$ ",
                @" | $$__  $$| $$  | $$| $$  \ $$| $$  \ $$| $$  | $$ ",
                @" | $$  \ $$| $$  | $$| $$  | $$| $$  | $$| $$  | $$ ",
                @" | $$$$$$$/|  $$$$$$$|  $$$$$$/| $$  | $$|  $$$$$$$ ",
                @" |_______/  \____  $$ \______/ |__/  |__/ \_______/ ",
                @"            /$$  | $$                               ",
                @"           |  $$$$$$/                               ",
                @"            \______/                      	      ",
                @"Please press any key to continue..."
                
            };
            
            Console.WindowWidth = 160;
            Console.WriteLine("\n\n");
            foreach (string line in arr) 
                Console.WriteLine(line);
            Console.ReadKey();
           
            

            return arr;
        }
    }
}