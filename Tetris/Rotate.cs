using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Rotate
    {

        public static class Check
        {
            public static int Count { get; set; } = 0;
            public static bool Lock { get; set; } = false;
            public static bool Pass { get; set; } = false;
            public static List<int> Next { get; set; } = new List<int>();
        }

        public static void Now()
        {
            int[,] R1 = new int[,] { { 0 }, { 0 } };
            int[,] R2 = new int[,] { { 0 }, { 0 } };
            int[,] R3 = new int[,] { { 0 }, { 0 } };
            int[,] R4 = new int[,] { { 0 }, { 0 } };

            switch (Program.Display.Active)
            {
                case (int)Tetrominos.Block.Tetromino.IBlock:
                    R1 = new int[,] { { 4, 4, 2, 2, 0, 0, -2, -2 }, { -2, -2, -1, -1, 0, 0, 1, 1 } };
                    R2 = new int[,] { { -4, -4, -2, -2, 0, 0, 2, 2 }, { 2, 2, 1, 1, 0, 0, 1, 1 } };
                    R3 = R1;
                    R4 = R2;
                    break;

                case (int)Tetrominos.Block.Tetromino.JBlock:
                    R1 = new int[,] { { 2, 2, 0, 0, -2, -2, 0, 0 }, { 1, 1, 0, 0, -1, -1, -2, -2 } };
                    R2 = new int[,] { { 2, 2, 0, 0, -2, -2, -4, -4 }, { -1, -1, 0, 0, 1, 1, 0, 0 } };
                    R3 = new int[,] { { -2, -2, 0, 0, 2, 2, 0, 0 }, { -1, -1, 0, 0, 1, 1, 2, 2 } };
                    R4 = new int[,] { { -2, -2, 0, 0, 2, 2, 4, 4 }, { 1, 1, 0, 0, -1, -1, 0, 0 } };
                    break;

                case (int)Tetrominos.Block.Tetromino.LBlock:
                    R1 = new int[,] { { 2, 2, 0, 0, -2, -2, 4, 4 }, { 1, 1, 0, 0, -1, -1, 0, 0 } };
                    R2 = new int[,] { { 2, 2, 0, 0, -2, -2, 0, 0 }, { -1, -1, 0, 0, 1, 1, -2, -2 } };
                    R3 = new int[,] { { -2, -2, 0, 0, 2, 2, -4, -4 }, { -1, -1, 0, 0, 1, 1, 0, 0 } };
                    R4 = new int[,] { { -2, -2, 0, 0, 2, 2, 0, 0 }, { 1, 1, 0, 0, -1, -1, 2, 2 } };
                    break;

                case (int)Tetrominos.Block.Tetromino.SBlock:
                    R1 = new int[,] { { 0, 0, -2, -2, 4, 4, 2, 2 }, { 0, 0, -1, -1, -1, -1, 0, 0 } };
                    R2 = new int[,] { { 0, 0, 2, 2, -4, -4, -2, -2 }, { 0, 0, 1, 1, 1, 1, 0, 0 } };
                    R3 = R1;
                    R4 = R2;
                    break;

                case (int)Tetrominos.Block.Tetromino.TBlock:
                    R1 = new int[,] { { 0, 0, 2, 2, 2, 2, -2, -2 }, { 0, 0, 1, 1, -1, -1, -1, -1 } };
                    R2 = new int[,] { { 0, 0, 2, 2, -2, -2, -2, -2 }, { 0, 0, -1, -1, -1, -1, 1, 1 } };
                    R3 = new int[,] { { 0, 0, -2, -2, -2, -2, 2, 2 }, { 0, 0, -1, -1, 1, 1, 1, 1 } };
                    R4 = new int[,] { { 0, 0, -2, -2, 2, 2, 2, 2 }, { 0, 0, 1, 1, 1, 1, -1, -1 } };
                    break;

                case (int)Tetrominos.Block.Tetromino.ZBlock:
                    R1 = new int[,] { { 0, 0, 0, 0, 2, 2, 2, 2 }, { 0, 0, -2, -2, 1, 1, -1, -1 } };
                    R2 = new int[,] { { 0, 0, 0, 0, -2, -2, -2, -2 }, { 0, 0, 2, 2, -1, -1, 1, 1 } };
                    R3 = R1;
                    R4 = R2;
                    break;
            }

            switch (Check.Count)
            {
                case 0:
                    Check.Next.Clear();

                    for (int i = 0; i < (R1.Length / 2); i++)
                    {
                        Check.Next.Add(Tetrominos.Block.Current[i] + R1[0, i] + (Program.Display.Width * R1[1, i]));
                    }

                    WallCheck();
                    if (Check.Pass) { Check.Count = 1; };
                    break;

                case 1:
                    Check.Next.Clear();

                    for (int i = 0; i < (R2.Length / 2); i++)
                    {
                        Check.Next.Add(Tetrominos.Block.Current[i] + R2[0, i] + (Program.Display.Width * R2[1, i]));
                    }

                    WallCheck();
                    if (Check.Pass) { Check.Count = 2; };
                    break;

                case 2:
                    Check.Next.Clear();

                    for (int i = 0; i < (R3.Length / 2); i++)
                    {
                        Check.Next.Add(Tetrominos.Block.Current[i] + R3[0, i] + (Program.Display.Width * R3[1, i]));
                    }

                    WallCheck();
                    if (Check.Pass) { Check.Count = 3; };
                    break;

                case 3:
                    Check.Next.Clear();

                    for (int i = 0; i < (R4.Length / 2); i++)
                    {
                        Check.Next.Add(Tetrominos.Block.Current[i] + R4[0, i] + (Program.Display.Width * R4[1, i]));
                    }

                    WallCheck();
                    if (Check.Pass) { Check.Count = 0; };
                    break;
            }


        }

        public static void WallCheck()
        {
            Check.Pass = true;
            Frame.WallList();

            for (var i = 0; i < Check.Next.Count; i++)
            {
                if (Frame.Wall.ValList.Contains(Check.Next[i]) || Check.Next[i] < 0)
                {
                    Check.Pass = false;
                }
            }

            if (Check.Pass)
            {
                Tetrominos.Block.Next.Clear();
                Tetrominos.Block.Next.AddRange(Check.Next);
            }
        }
    }
}
