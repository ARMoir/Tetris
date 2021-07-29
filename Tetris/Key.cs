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
                        if (!Rotate.Check.Lock)
                        {
                            Move.Direction((int)Move.Check.Diretions.Left);
                            Rotate.Check.Lock = true;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        Speed.Set.Delay /= 5;
                        Speed.Set.Drop = true;
                        break;

                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        if (!Rotate.Check.Lock)
                        {
                            Move.Direction((int)Move.Check.Diretions.Right);
                            Rotate.Check.Lock = true;
                        }
                        break;

                    case ConsoleKey.Spacebar:
                        Speed.Set.Delay = 1;
                        Speed.Set.Drop = true;
                        break;

                    case ConsoleKey.P:
                        Speed.Pause();
                        break;

                    case ConsoleKey.Escape:
                    case ConsoleKey.Q:
                        Environment.Exit(-1);
                        break;

                    case ConsoleKey.D0:
                        Frame.Wall.Intro = false;
                        Score.ScoreBoard.Level = 0;
                        break;

                    case ConsoleKey.D1:
                        Frame.Wall.Intro = false;
                        Score.ScoreBoard.Level = 1;
                        break;

                    case ConsoleKey.D2:
                        Frame.Wall.Intro = false;
                        Score.ScoreBoard.Level = 2;
                        break;

                    case ConsoleKey.D3:
                        Frame.Wall.Intro = false;
                        Score.ScoreBoard.Level = 3;
                        break;

                    case ConsoleKey.D4:
                        Frame.Wall.Intro = false;
                        Score.ScoreBoard.Level = 4;
                        break;

                    case ConsoleKey.D5:
                        Frame.Wall.Intro = false;
                        Score.ScoreBoard.Level = 5;
                        break;

                    case ConsoleKey.D6:
                        Frame.Wall.Intro = false;
                        Score.ScoreBoard.Level = 6;
                        break;

                    case ConsoleKey.D7:
                        Frame.Wall.Intro = false;
                        Score.ScoreBoard.Level = 7;
                        break;

                    case ConsoleKey.D8:
                        Frame.Wall.Intro = false;
                        Score.ScoreBoard.Level = 8;
                        break;

                    case ConsoleKey.D9:
                        Frame.Wall.Intro = false;
                        Score.ScoreBoard.Level = 9;
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
