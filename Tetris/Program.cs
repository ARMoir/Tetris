using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Program
    {

        public static class Display
        {
            public static List<string> FrameChar { get; set; } = new List<string>();
            public static StringBuilder FrameString { get; set; } = new StringBuilder();
            public static StringBuilder DisplayFrame { get; set; } = new StringBuilder();
            public static ConsoleColor Color { get; set; } = ConsoleColor.Green;
            public static int Width { get; set; } = 0;
            public static int Position { get; set; } = 0;
            public static int Speed { get; set; } = 1000;
        }

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.Clear();
            Frame.SetFrame();
            Display.FrameChar.AddRange(Display.FrameString.ToString().Select(Chars => Chars.ToString()));
            


            //Set the Values for Movement Calculations
            string[] Lines = Display.FrameString.ToString().Split((Char)10);
            Display.Width = Lines[0].Length + 1;
            Display.Position = (Display.Width / 2);

            //Start Thred to Read Keypress
            Task.Factory.StartNew(() => Key.Press());

            //Tetrominos.IBlock();

            while (true) 
            {
                //
                Tetrominos.New();
                Console.ForegroundColor = Display.Color;

                Tetrominos.Block.Current.Clear();
                Tetrominos.Block.Current.AddRange(Tetrominos.Block.Next);
                Tetrominos.Block.Next.Clear();

                for (var i = 0; i < Tetrominos.Block.Current.Count; i++)
                {

                    if (i % 2 == 0)
                    {
                        Display.FrameChar[Tetrominos.Block.Current[i]] = Tetrominos.Block.Values[0];
                    }
                    else
                    {
                        Display.FrameChar[Tetrominos.Block.Current[i]] = Tetrominos.Block.Values[1];
                    }

                    if (Frame.Wall.Values.Contains(Display.FrameChar[Tetrominos.Block.Current[i] + Display.Width]))
                    {
                        Tetrominos.Block.Placed.AddRange(Tetrominos.Block.Current);
                        Tetrominos.Block.Next.Clear();
                        Tetrominos.Block.Set = true;
                        Display.Speed = 1000;
                    }
                    else
                    {
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[i] + Display.Width);
                    }
                    
                }

                //Update Display
                Display.DisplayFrame.Clear();
                Display.FrameChar.ForEach(Item => Display.DisplayFrame.Append(Item));

                //Write Display to Console
                Console.SetCursorPosition(0, 0);
                Console.Write(Display.DisplayFrame);
                System.Threading.Thread.Sleep(Display.Speed);

                for (var i = 0; i < Tetrominos.Block.Current.Count; i++)
                {
                    Display.FrameChar[Tetrominos.Block.Current[i]] = " ";
                }

                for (var i = 0; i < Tetrominos.Block.Placed.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        Display.FrameChar[Tetrominos.Block.Placed[i]] = Tetrominos.Block.Values[0];
                    }
                    else
                    {
                        Display.FrameChar[Tetrominos.Block.Placed[i]] = Tetrominos.Block.Values[1];
                    }
                }

            } 
        }
    }
}
