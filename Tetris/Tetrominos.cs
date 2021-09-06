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
                        break;

                    case (int)Block.Tetromino.JBlock:
                        Program.Display.Active = (int)Block.Tetromino.JBlock;
                        break;

                    case (int)Block.Tetromino.LBlock:
                        Program.Display.Active = (int)Block.Tetromino.LBlock;
                        break;

                    case (int)Block.Tetromino.OBlock:
                        Program.Display.Active = (int)Block.Tetromino.OBlock;
                        break;

                    case (int)Block.Tetromino.SBlock:
                        Program.Display.Active = (int)Block.Tetromino.SBlock;
                        break;

                    case (int)Block.Tetromino.TBlock:
                        Program.Display.Active = (int)Block.Tetromino.TBlock;
                        break;

                    case (int)Block.Tetromino.ZBlock:
                        Program.Display.Active = (int)Block.Tetromino.ZBlock;
                        break;
                }

                SetTermino(Block.Next, Program.Display.Position, Program.Display.Active);
                Preview.Next.Tetromino = -1;
            }
        }

        public static void SetTermino(List<int> New, int Position, int Tetromino)
        {
            int[,] Minos = new int[,] { { 0 }, { 0 } };

            switch (Tetromino)
            {
                case (int)Block.Tetromino.IBlock:
                    Minos = new int[,] { { -4, -3, -2, -1, 0, 1, 2, 3 }, { 0, 0, 0, 0, 0, 0, 0, 0 } };
                    break;

                case (int)Block.Tetromino.JBlock:
                    Minos = new int[,] { { -2, -1, 0, 1, 2, 3, 2, 3 }, { 0, 0, 0, 0, 0, 0, 1, 1 } };
                    break;

                case (int)Block.Tetromino.LBlock:
                    Minos = new int[,] { { -2, -1, 0, 1, 2, 3, -1, -2 }, { 0, 0, 0, 0, 0, 0, 1, 1 } };
                    break;

                case (int)Block.Tetromino.OBlock:
                    Minos = new int[,] { { 0, 1, -1, -2, -2, -1, 1, 0 }, { 0, 0, 0, 0, 1, 1, 1, 1 } };
                    break;

                case (int)Block.Tetromino.SBlock:
                    Minos = new int[,] { { 0, 1, 2, 3, -1, -2, 0, 1 }, { 0, 0, 0, 0, 1, 1, 1, 1 } };
                    break;

                case (int)Block.Tetromino.TBlock:
                    Minos = new int[,] { { 0, 1, -1, -2, 0, 1, 2, 3 }, { 0, 0, 0, 0, 1, 1, 0, 0 } };
                    break;

                case (int)Block.Tetromino.ZBlock:
                    Minos = new int[,] { { 0, 1, 2, 3, -1, -2, 0, 1 }, { 0, 0, 1, 1, 0, 0, 1, 1 } };
                    break;
            }
            for (int i = 0; i < (Minos.Length / 2); i++)
            {
                New.Add(Position + Minos[0, i] + (Program.Display.Width * Minos[1, i]));
            }
        }
    }
}
