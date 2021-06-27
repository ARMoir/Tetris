﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Tetrominos
    {
        public static class Block
        {
            public static string[] Values { get; set; } = { "[", "]"};
            public static List<int> Current { get; set; } = new List<int>();
            public static List<int> Next { get; set; } = new List<int>();
            public static List<int> Placed { get; set; } = new List<int>();
            public static bool Set { get; set; } = true;
            public static Random Random { get; set; } = new Random();
        }

        public static void New()
        {
            if(Block.Set)
            {
                Block.Set = false;
                Block.Random.Next(0,8);
                IBlock();
            }
        }

        public static void IBlock()
        {
            Block.Current.Add(Program.Display.Position + Program.Display.Width);
            Block.Current.Add(Program.Display.Position + Program.Display.Width + 1);
            Block.Current.Add(Program.Display.Position + (Program.Display.Width * 2));
            Block.Current.Add(Program.Display.Position + (Program.Display.Width * 2) + 1);
            Block.Current.Add(Program.Display.Position + (Program.Display.Width * 3));
            Block.Current.Add(Program.Display.Position + (Program.Display.Width * 3) +1);
            Block.Current.Add(Program.Display.Position + (Program.Display.Width * 4));
            Block.Current.Add(Program.Display.Position + (Program.Display.Width * 4) + 1);
            Block.Next.Add(Program.Display.Position + Program.Display.Width);
            Block.Next.Add(Program.Display.Position + Program.Display.Width + 1);
            Block.Next.Add(Program.Display.Position + (Program.Display.Width * 2));
            Block.Next.Add(Program.Display.Position + (Program.Display.Width * 2) + 1);
            Block.Next.Add(Program.Display.Position + (Program.Display.Width * 3));
            Block.Next.Add(Program.Display.Position + (Program.Display.Width * 3) + 1);
            Block.Next.Add(Program.Display.Position + (Program.Display.Width * 4));
            Block.Next.Add(Program.Display.Position + (Program.Display.Width * 4) + 1);
            //Program.Display.FrameChar[Program.Display.Position + (Program.Display.Width)] = "[";
            //Program.Display.FrameChar[Program.Display.Position + (Program.Display.Width) + 1] = "]";
            //Program.Display.FrameChar[Program.Display.Position + (Program.Display.Width * 2)] = "[";
            //Program.Display.FrameChar[Program.Display.Position + (Program.Display.Width * 2) + 1] = "]";
            //Program.Display.FrameChar[Program.Display.Position + (Program.Display.Width * 3)] = "[";
            //Program.Display.FrameChar[Program.Display.Position + (Program.Display.Width * 3) + 1] = "]";
            //Program.Display.FrameChar[Program.Display.Position + (Program.Display.Width * 4)] = "[";
            //Program.Display.FrameChar[Program.Display.Position + (Program.Display.Width * 4) + 1] = "]";
        }

        public static void JBlock()
        {

        }

        public static void LBlock()
        {

        }

        public static void OBlock()
        {

        }

        public static void SBlock()
        {

        }

        public static void TBlock()
        {

        }

        public static void ZBlock()
        {

        }
    }
}
