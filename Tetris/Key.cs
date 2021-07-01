using System;
using System.Collections.Generic;
using System.Linq;

namespace Tetris
{
    class Key
    {
        /// <summary>
        /// Keys that change the color when pressed
        /// </summary>
        private static Dictionary<ConsoleKey, ConsoleColor> colorKeys = new()
        {
            { ConsoleKey.R, ConsoleColor.Red },
            { ConsoleKey.G, ConsoleColor.Green },
            { ConsoleKey.B, ConsoleColor.Blue },
            { ConsoleKey.C, ConsoleColor.Cyan },
            { ConsoleKey.M, ConsoleColor.Magenta },
            { ConsoleKey.Y, ConsoleColor.Yellow }
        };

        public static void Press()
        {

            while (true) 
            {
                var Key = Console.ReadKey().Key;

                switch (Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if(!Rotate.Check.Lock)
                        {
                            Rotate.Now();
                            Rotate.Check.Lock = true;
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        Move.Direction((int)Move.Check.Diretions.Left);
                        break;

                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        Program.Display.Speed = 100;
                        break;

                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        Move.Direction((int)Move.Check.Diretions.Right);
                        break;

                    case ConsoleKey.Spacebar:
                        Program.Display.Speed = 1;
                        break;

                    case ConsoleKey.Delete:

                        //Reset.Now();
                        break;

                    case ConsoleKey.Escape:
                    case ConsoleKey.Q:
                        Environment.Exit(-1);
                        break;

                    default:
                        if (colorKeys.ContainsKey(Key))
                        {
                            ConsoleColor color = colorKeys[Key];
                            Program.Display.Color = Program.Display.Color == color ? ConsoleColor.White : color;
                        }
                        break;
                }
            } 
        }
    }
}
