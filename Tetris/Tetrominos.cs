using System;
using System.Collections.Generic;
using System.Drawing;
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
                        IBlock(Block.Next, Program.Display.Position);
                        break;

                    case (int)Block.Tetromino.JBlock:
                        Program.Display.Active = (int)Block.Tetromino.JBlock;
                        JBlock(Block.Next, Program.Display.Position);
                        break;

                    case (int)Block.Tetromino.LBlock:
                        Program.Display.Active = (int)Block.Tetromino.LBlock;
                        LBlock(Block.Next, Program.Display.Position);
                        break;

                    case (int)Block.Tetromino.OBlock:
                        Program.Display.Active = (int)Block.Tetromino.OBlock;
                        OBlock(Block.Next, Program.Display.Position);
                        break;

                    case (int)Block.Tetromino.SBlock:
                        Program.Display.Active = (int)Block.Tetromino.SBlock;
                        SBlock(Block.Next, Program.Display.Position);
                        break;

                    case (int)Block.Tetromino.TBlock:
                        Program.Display.Active = (int)Block.Tetromino.TBlock;
                        TBlock(Block.Next, Program.Display.Position);
                        break;

                    case (int)Block.Tetromino.ZBlock:
                        Program.Display.Active = (int)Block.Tetromino.ZBlock;
                        ZBlock(Block.Next, Program.Display.Position);
                        break;
                }

                Preview.Next.Tetromino = -1;
            }
        }

        public static void NewBlock(List<int> New, int Position, int[] X, int[] Y)
        {
            for (int i = 0; i < X.Length; i++)
            {
                New.Add(Position + X[i] + (Program.Display.Width * Y[i]));
            }
        }

        public static void IBlock(List<int> New, int Position)
        {
            int[] X = new int[8] { -4, -3, -2, -1, 0, 1, 2, 3 };
            int[] Y = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
            NewBlock(New, Position, X, Y);
        }

        public static void JBlock(List<int> New, int Position)
        {
            int[] X = new int[8] { -2, -1, 0, 1, 2, 3, 2, 3 };
            int[] Y = new int[8] { 0, 0, 0, 0, 0, 0, 1, 1 };
            NewBlock(New, Position, X, Y);
        }

        public static void LBlock(List<int> New, int Position)
        {
            int[] X = new int[8] { -2, -1, 0, 1, 2, 3, -1, -2 };
            int[] Y = new int[8] { 0, 0, 0, 0, 0, 0, 1, 1 };
            NewBlock(New, Position, X, Y);
        }

        public static void OBlock(List<int> New, int Position)
        {
            int[] X = new int[8] { 0, 1, -1, -2, -2, -1, 1, 0 };
            int[] Y = new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 };
            NewBlock(New, Position, X, Y);
        }

        public static void SBlock(List<int> New, int Position)
        {
            int[] X = new int[8] { 0, 1, 2, 3, -1, -2, 0, 1 };
            int[] Y = new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 };
            NewBlock(New, Position, X, Y);
        }

        public static void TBlock(List<int> New, int Position)
        {
            int[] X = new int[8] { 0, 1, -1, -2, 0, 1, 2, 3 };
            int[] Y = new int[8] { 0, 0, 0, 0, 1, 1, 0, 0 };
            NewBlock(New, Position, X, Y);
        }

        public static void ZBlock(List<int> New, int Position)
        {
            int[] X = new int[8] { 0, 1, 2, 3, -1, -2, 0, 1 };
            int[] Y = new int[8] { 0, 0, 1, 1, 0, 0, 1, 1 };
            NewBlock(New, Position, X, Y);
        }
    }
}
