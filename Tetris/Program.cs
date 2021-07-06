﻿using System;
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
            public static int Active { get; set; } = 0;
            public static int Position { get; set; } = 0;
            public static int Speed { get; set; } = 480;
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

            while (!Tetrominos.Block.Placed.Contains(Display.Position)) 
            {
                Tetrominos.New();
                Console.ForegroundColor = Display.Color;
                Rotate.Check.Lock = false;

                Tetrominos.Block.Current.Clear();
                Tetrominos.Block.Current.AddRange(Tetrominos.Block.Next);
                Tetrominos.Block.Next.Clear();

                Score.RowCheck();

                for (var i = 0; i < Tetrominos.Block.Placed.Count; i++)
                {
                    Program.Display.FrameChar[Tetrominos.Block.Placed[i]] = "*";
                }

                try
                {
                    for (var i = 0; i < Tetrominos.Block.Current.Count; i++)
                    {

                        Display.FrameChar[Tetrominos.Block.Current[i]] = "#";

                        if (Frame.Wall.Values.Contains(Display.FrameChar[Tetrominos.Block.Current[i] + Display.Width]))
                        {
                            Tetrominos.Block.Placed.AddRange(Tetrominos.Block.Current);
                            Tetrominos.Block.Current.Clear();
                            Tetrominos.Block.Next.Clear();
                            Tetrominos.Block.Set = true;
                            Display.Speed = 480;
                        }
                        else
                        {
                            Tetrominos.Block.Next.Add(Tetrominos.Block.Current[i] + Display.Width);
                        }
                    }
                }
                catch (Exception)
                {
                    Rotate.Now();
                }

                for (var i = 0; i < Tetrominos.Block.Placed.Count; i++)
                {
                    Program.Display.FrameChar[Tetrominos.Block.Placed[i]] = "*";
                }

                Score.RowCheck();
                Score.Rows();

                //Update Display
                Display.DisplayFrame.Clear();
                Display.FrameChar.ForEach(Item => Display.DisplayFrame.Append(Item));

                //Write Display to Console
                Console.SetCursorPosition(0, 0);
                Display.DisplayFrame.Replace("##", "[]");
                Display.DisplayFrame.Replace("**", "[]");
               //Display.DisplayFrame.Replace(((int)Display.Status.Active).ToString(), "[");

                Console.Write(Display.DisplayFrame);
                System.Threading.Thread.Sleep(Display.Speed);

                Display.FrameChar.Clear();
                Display.FrameChar.AddRange(Display.FrameString.ToString().Select(Chars => Chars.ToString()));
            } 
        }
    }
}
