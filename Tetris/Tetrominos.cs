using System;
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
            public static List<int> Current { get; set; } = new List<int>();
            public static List<int> Next { get; set; } = new List<int>();
            public static List<int> Placed { get; set; } = new List<int>();
            public static bool Set { get; set; } = true;
            public enum Tetromino { IBlock, JBlock, LBlock, OBlock, SBlock, TBlock, ZBlock }
            public static Random Random { get; set; } = new Random();
        }

        public static void New()
        {
            if(Block.Set)
            {
                Block.Set = false;          
                Rotate.Check.Count = 0;

                switch (Preview.Next.Tetromino)
                {
                    case (int)Block.Tetromino.IBlock:
                        Program.Display.Active = (int)Block.Tetromino.IBlock;
                        IBlock(Block.Next, Program.Display.Position, Program.Display.Width);
                        break;

                    case (int)Block.Tetromino.JBlock:
                        Program.Display.Active = (int)Block.Tetromino.JBlock;
                        JBlock(Block.Next, Program.Display.Position, Program.Display.Width);
                        break;

                    case (int)Block.Tetromino.LBlock:
                        Program.Display.Active = (int)Block.Tetromino.LBlock;
                        LBlock(Block.Next, Program.Display.Position, Program.Display.Width);
                        break;

                    case (int)Block.Tetromino.OBlock:
                        Program.Display.Active = (int)Block.Tetromino.OBlock;
                        OBlock(Block.Next, Program.Display.Position, Program.Display.Width);
                        break;

                    case (int)Block.Tetromino.SBlock:
                        Program.Display.Active = (int)Block.Tetromino.SBlock;
                        SBlock(Block.Next, Program.Display.Position, Program.Display.Width);
                        break;

                    case (int)Block.Tetromino.TBlock:
                        Program.Display.Active = (int)Block.Tetromino.TBlock;
                        TBlock(Block.Next, Program.Display.Position, Program.Display.Width);
                        break;

                    case (int)Block.Tetromino.ZBlock:
                        Program.Display.Active = (int)Block.Tetromino.ZBlock;
                        ZBlock(Block.Next, Program.Display.Position, Program.Display.Width);
                        break;
                }

                Preview.Next.Tetromino = -1;
            }
        }

        public static void IBlock(List<int> New, int Position, int Width)
        {
            New.Add(Position - 4 + (Width * 0));
            New.Add(Position - 3 + (Width * 0));
            New.Add(Position - 2 + (Width * 0));
            New.Add(Position - 1 + (Width * 0));
            New.Add(Position + 0 + (Width * 0));
            New.Add(Position + 1 + (Width * 0));
            New.Add(Position + 2 + (Width * 0));
            New.Add(Position + 3 + (Width * 0));

        }

        public static void JBlock(List<int> New, int Position, int Width)
        {
            New.Add(Position - 2 + (Width * 0));
            New.Add(Position - 1 + (Width * 0));
            New.Add(Position + 0 + (Width * 0));
            New.Add(Position + 1 + (Width * 0));
            New.Add(Position + 2 + (Width * 0));
            New.Add(Position + 3 + (Width * 0));
            New.Add(Position + 2 + (Width * 1));
            New.Add(Position + 3 + (Width * 1));
        }

        public static void LBlock(List<int> New, int Position, int Width)
        {
            New.Add(Position - 2 + (Width * 0));
            New.Add(Position - 1 + (Width * 0));
            New.Add(Position + 0 + (Width * 0));
            New.Add(Position + 1 + (Width * 0));
            New.Add(Position + 2 + (Width * 0));
            New.Add(Position + 3 + (Width * 0));
            New.Add(Position - 1 + (Width * 1));
            New.Add(Position - 2 + (Width * 1));
        }

        public static void OBlock(List<int> New, int Position, int Width)
        {
            New.Add(Position + 0 + (Width * 0));
            New.Add(Position + 1 + (Width * 0));
            New.Add(Position - 1 + (Width * 0));
            New.Add(Position - 2 + (Width * 0));
            New.Add(Position - 2 + (Width * 1));
            New.Add(Position - 1 + (Width * 1));
            New.Add(Position + 1 + (Width * 1));
            New.Add(Position + 0 + (Width * 1));
        }

        public static void SBlock(List<int> New, int Position, int Width)
        {
            New.Add(Position + 0 + (Width * 0));
            New.Add(Position + 1 + (Width * 0));
            New.Add(Position + 2 + (Width * 0));
            New.Add(Position + 3 + (Width * 0));
            New.Add(Position - 1 + (Width * 1));
            New.Add(Position - 2 + (Width * 1));
            New.Add(Position + 0 + (Width * 1));
            New.Add(Position + 1 + (Width * 1));

        }

        public static void TBlock(List<int> New, int Position, int Width)
        {
            New.Add(Position + 0 + (Width * 0));
            New.Add(Position + 1 + (Width * 0));
            New.Add(Position - 1 + (Width * 0));
            New.Add(Position - 2 + (Width * 0));
            New.Add(Position + 0 + (Width * 1));
            New.Add(Position + 1 + (Width * 1));
            New.Add(Position + 2 + (Width * 0));
            New.Add(Position + 3 + (Width * 0));
        }

        public static void ZBlock(List<int> New, int Position, int Width)
        {
            New.Add(Position + 0 + (Width * 0));
            New.Add(Position + 1 + (Width * 0));
            New.Add(Position + 2 + (Width * 1));
            New.Add(Position + 3 + (Width * 1));
            New.Add(Position - 1 + (Width * 0));
            New.Add(Position - 2 + (Width * 0));
            New.Add(Position + 0 + (Width * 1));
            New.Add(Position + 1 + (Width * 1));
        }
    }
}
