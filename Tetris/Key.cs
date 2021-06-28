﻿using System;
using System.Collections.Generic;

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
            do
            {
                var Key = Console.ReadKey().Key;

                switch (Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        Tetrominos.Block.Next.Clear();
                        //Tetrominos.Block.Next.Reverse();
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[0]);
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[1]);
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[2] - Program.Display.Width + 2);
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[3] - Program.Display.Width + 2);
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[4] - (Program.Display.Width * 2) - 2);
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[5] - (Program.Display.Width * 2) - 2);
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[6] - (Program.Display.Width * 3) - 4);
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[7] - (Program.Display.Width * 3) - 4);
                        break;

                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        Tetrominos.Block.Next.Clear();

                        for (var i = 0; i < Tetrominos.Block.Current.Count; i++)
                        {
                            Tetrominos.Block.Next.Add(Tetrominos.Block.Current[i] - 2);
                        }
                        break;

                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        Program.Display.Speed = 10;
                        break;

                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:

                        Tetrominos.Block.Next.Clear();

                        for (var i = 0; i < Tetrominos.Block.Current.Count; i++)
                        {
                            Tetrominos.Block.Next.Add(Tetrominos.Block.Current[i] + 2);
                        }
                        break;

                    case ConsoleKey.Delete:

                        //Reset.Now();
                        break;

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

            } while (true);
        }
    }
}
