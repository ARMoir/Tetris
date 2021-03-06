using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Program
    {

        public static class Display
        {
            public static List<string> FrameChar { get; set; } = new List<string>();
            public static StringBuilder Intro { get; set; } = new StringBuilder();
            public static StringBuilder FrameString { get; set; } = new StringBuilder();
            public static StringBuilder DisplayFrame { get; set; } = new StringBuilder();
            public static ConsoleColor Color { get; set; } = ConsoleColor.Green;
            public static int Width { get; set; } = 0;
            public static int Height { get; set; } = 0;
            public static int Active { get; set; } = 0;
            public static int Position { get; set; } = 0;
        }

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.Clear();
            Frame.SetFrame();
            Display.FrameChar.AddRange(Display.FrameString.ToString().Select(Chars => Chars.ToString()));          

            //Set the Values for Movement Calculations
            string[] Lines = Display.FrameString.ToString().Split((Char)10);
            Display.Height = Lines.Length;
            Display.Width = Lines[0].Length + 1;
            Display.Position = (Display.Width / 2);

            //Can only set Window Size in Windows
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Console.SetWindowSize(Display.Width, Display.Height);
            }

            //Start Thred to Read Keypress
            Task.Factory.StartNew(() => Key.Press());

            Console.ForegroundColor = Display.Color;
            Frame.SetIntro();
            Console.Write(Display.Intro);      

            while (Frame.Wall.Intro)
            {
                //Show the intro Screen 
                System.Threading.Thread.Sleep(Speed.Set.Delay);
            }
            Console.Clear();
            Speed.Check();

            while (!Tetrominos.Block.Placed.Contains(Display.Position)) 
            {
                Preview.Tetromino();
                Tetrominos.New();
                Console.ForegroundColor = Display.Color;
                Rotate.Check.Lock = false;

                Tetrominos.Block.Current.Clear();
                Tetrominos.Block.Current.AddRange(Tetrominos.Block.Next);
                Tetrominos.Block.Next.Clear();

                for (var i = 0; i < Tetrominos.Block.Placed.Count; i++)
                {
                    Display.FrameChar[Tetrominos.Block.Placed[i]] = "*";
                }

                for (var i = 0; i < Tetrominos.Block.Current.Count; i++)
                {

                    Display.FrameChar[Tetrominos.Block.Current[i]] = "#";

                    if (Frame.Wall.Values.Contains(Display.FrameChar[Tetrominos.Block.Current[i] + Display.Width]))
                    {
                        Speed.Check();
                        Speed.Set.Drop = false;

                        Tetrominos.Block.Placed.AddRange(Tetrominos.Block.Current);
                        Tetrominos.Block.Current.Clear();
                        Tetrominos.Block.Next.Clear();
                        Tetrominos.Block.Set = true;
                    }
                    else
                    {
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[i] + Display.Width);
                    }
                }

                for (var i = 0; i < Tetrominos.Block.Placed.Count; i++)
                {
                    Display.FrameChar[Tetrominos.Block.Placed[i]] = "*";
                }

                if(Speed.Set.Drop)
                {
                    Score.ScoreBoard.Score++;
                }

                while (Speed.Set.Paused)
                {
                    //Game Paused
                    System.Threading.Thread.Sleep(Speed.Set.Delay);
                }

                Score.RowScore();
                Score.PopScoreBoard(Score.ScoreBoard.Rows, 6);
                Score.PopScoreBoard(Score.ScoreBoard.Score, 79);
                Score.PopScoreBoard(Score.ScoreBoard.Level, 152);

                //Update Display
                Display.DisplayFrame.Clear();
                Display.FrameChar.ForEach(Item => Display.DisplayFrame.Append(Item));

                //Write Display to Console
                Console.SetCursorPosition(0, 0);
                Display.DisplayFrame.Replace("##", "[]");
                Display.DisplayFrame.Replace("**", "[]");

                Console.Write(Display.DisplayFrame);
                System.Threading.Thread.Sleep(Speed.Set.Delay);

                Display.FrameChar.Clear();
                Display.FrameChar.AddRange(Display.FrameString.ToString().Select(Chars => Chars.ToString()));
            }

            Reset.Now();
            Main(args);
        }
    }
}
