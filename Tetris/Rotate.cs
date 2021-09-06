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
            public static List<int> Next { get; set; } = new List<int>();
        }

        public static void Now()
        {
            int[,] R1 = new int[1, 8];int[,] R2 = new int[1, 8];
            int[,] R3 = new int[1, 8];int[,] R4 = new int[1, 8];

            switch (Program.Display.Active)
            {
                case (int)Tetrominos.Block.Tetromino.IBlock:
                    R1 = new int[,] { { 4, 4, 2, 2, 0, 0, -2, -2 }, { -2, -2, -1, -1, 0, 0, 1, 1 } };
                    R2 = Inverse(R1); R3 = R1; R4 = R2;
                    break;

                case (int)Tetrominos.Block.Tetromino.SBlock:
                    R1 = new int[,] { { 0, 0, -2, -2, 4, 4, 2, 2 }, { 0, 0, -1, -1, -1, -1, 0, 0 } };
                    R2 = Inverse(R1); R3 = R1; R4 = R2;
                    break;

                case (int)Tetrominos.Block.Tetromino.ZBlock:
                    R1 = new int[,] { { 0, 0, 0, 0, 2, 2, 2, 2 }, { 0, 0, -2, -2, 1, 1, -1, -1 } };
                    R2 = Inverse(R1); R3 = R1; R4 = R2;
                    break;

                case (int)Tetrominos.Block.Tetromino.JBlock:
                    R1 = new int[,] { { 2, 2, 0, 0, -2, -2, 0, 0 }, { 1, 1, 0, 0, -1, -1, -2, -2 } };
                    R2 = new int[,] { { 2, 2, 0, 0, -2, -2, -4, -4 }, { -1, -1, 0, 0, 1, 1, 0, 0 } };
                    R3 = Inverse(R1); R4 = Inverse(R2);
                    break;

                case (int)Tetrominos.Block.Tetromino.LBlock:
                    R1 = new int[,] { { 2, 2, 0, 0, -2, -2, 4, 4 }, { 1, 1, 0, 0, -1, -1, 0, 0 } };
                    R2 = new int[,] { { 2, 2, 0, 0, -2, -2, 0, 0 }, { -1, -1, 0, 0, 1, 1, -2, -2 } };
                    R3 = Inverse(R1); R4 = Inverse(R2);
                    break;

                case (int)Tetrominos.Block.Tetromino.TBlock:
                    R1 = new int[,] { { 0, 0, 2, 2, 2, 2, -2, -2 }, { 0, 0, 1, 1, -1, -1, -1, -1 } };
                    R2 = new int[,] { { 0, 0, 2, 2, -2, -2, -2, -2 }, { 0, 0, -1, -1, -1, -1, 1, 1 } };
                    R3 = Inverse(R1); R4 = Inverse(R2);
                    break;
            }

            try
            {
                Check.Next.Clear();

                switch (Check.Count)
                {
                    case 0:
                        Rotation(R1);
                        if (WallCheck()) { Check.Count = 1; };
                        break;

                    case 1:
                        Rotation(R2);
                        if (WallCheck()) { Check.Count = 2; };
                        break;

                    case 2:
                        Rotation(R3);
                        if (WallCheck()) { Check.Count = 3; };
                        break;

                    case 3:
                        Rotation(R4);
                        if (WallCheck()) { Check.Count = 0; };
                        break;
                }
            }
            catch (Exception)
            {
            }
        }

        public static bool WallCheck()
        {
            bool Pass = true;
            Frame.WallList();

            for (var i = 0; i < Check.Next.Count; i++)
            {
                if (Frame.Wall.ValList.Contains(Check.Next[i]) || Check.Next[i] < 0)
                {
                    Pass = false;
                }
            }

            if (Pass)
            {
                Tetrominos.Block.Next.Clear();
                Tetrominos.Block.Next.AddRange(Check.Next);
            }

            return Pass;
        }

        public static void Rotation(int[,] Rotation)
        {
            for (int i = 0; i < (Rotation.Length / 2); i++)
            {
                Check.Next.Add(Tetrominos.Block.Current[i] + Rotation[0, i] + (Program.Display.Width * Rotation[1, i]));
            }
        }

        public static int[,] Inverse(int[,] Orginal)
        {
            int[,] Inverse = new int[2,8];

            for (int i = 0; i < (Orginal.Length / 2); i++)
            {
                Inverse[0, i] = Orginal[0, i] * -1;
                Inverse[1, i] = Orginal[1, i] * -1;
            }

            return Inverse;
        }
    }
}
