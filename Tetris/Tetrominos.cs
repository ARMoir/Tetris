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

        public static void DrawTermino(List<int> New, int Position, int[,] Location)
        {
            for (int i = 0; i < (Location.Length / 2); i++)
            {
                New.Add(Position + Location[0, i] + (Program.Display.Width * Location[1, i]));
            }
        }

        public static void IBlock(List<int> New, int Position)
        {
            int[,] Location = new int[,] { { -4, -3, -2, -1, 0, 1, 2, 3 }, { 0, 0, 0, 0, 0, 0, 0, 0 } };
            DrawTermino(New, Position, Location);
        }

        public static void JBlock(List<int> New, int Position)
        {
            int[,] Location = new int[,] { { -2, -1, 0, 1, 2, 3, 2, 3 }, { 0, 0, 0, 0, 0, 0, 1, 1 } };
            DrawTermino(New, Position, Location);
        }

        public static void LBlock(List<int> New, int Position)
        {
            int[,] Location = new int[,] { { -2, -1, 0, 1, 2, 3, -1, -2 }, { 0, 0, 0, 0, 0, 0, 1, 1 } };
            DrawTermino(New, Position, Location);
        }

        public static void OBlock(List<int> New, int Position)
        {
            int[,] Location = new int[,] { { 0, 1, -1, -2, -2, -1, 1, 0 }, { 0, 0, 0, 0, 1, 1, 1, 1 } };
            DrawTermino(New, Position, Location);
        }

        public static void SBlock(List<int> New, int Position)
        {
            int[,] Location = new int[,] { { 0, 1, 2, 3, -1, -2, 0, 1 }, { 0, 0, 0, 0, 1, 1, 1, 1 } };
            DrawTermino(New, Position, Location);
        }

        public static void TBlock(List<int> New, int Position)
        {
            int[,] Location = new int[,] { { 0, 1, -1, -2, 0, 1, 2, 3 }, { 0, 0, 0, 0, 1, 1, 0, 0 } };
            DrawTermino(New, Position, Location);
        }

        public static void ZBlock(List<int> New, int Position)
        {
            int[,] Location = new int[,] { { 0, 1, 2, 3, -1, -2, 0, 1 }, { 0, 0, 1, 1, 0, 0, 1, 1 } };
            DrawTermino(New, Position, Location);
        }
    }
}
