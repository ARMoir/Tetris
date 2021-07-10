﻿using System;
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
            switch (Program.Display.Active)
            {
                case (int)Tetrominos.Block.Tetromino.IBlock:
                    IBlockRotate();
                    break;

                case (int)Tetrominos.Block.Tetromino.JBlock:
                    JBlockRotate();
                    break;

                case (int)Tetrominos.Block.Tetromino.LBlock:
                    LBlockRotate();
                    break;

                case (int)Tetrominos.Block.Tetromino.OBlock:
                    //No Need to Rotate OBlock
                    break;

                case (int)Tetrominos.Block.Tetromino.SBlock:
                    SBlockRotate();
                    break;

                case (int)Tetrominos.Block.Tetromino.TBlock:
                    TBlockRotate();
                    break;

                case (int)Tetrominos.Block.Tetromino.ZBlock:
                    ZBlockRotate();
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

        public static void IBlockRotate()
        {
            try
            {
                switch (Check.Count)
                {
                    case 0:
                        Check.Next.Clear();
                        Check.Next.Add(Tetrominos.Block.Current[0] + 4 - (Program.Display.Width * 2));
                        Check.Next.Add(Tetrominos.Block.Current[1] + 4 - (Program.Display.Width * 2));
                        Check.Next.Add(Tetrominos.Block.Current[2] + 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[3] + 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[4] + 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[5] + 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[6] - 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[7] - 2 + (Program.Display.Width * 1));
                        WallCheck();
                        if (Check.Pass) { Check.Count = 1; };
                        break;

                    case 1:
                        Check.Next.Clear();
                        Check.Next.Add(Tetrominos.Block.Current[0] - 4 + (Program.Display.Width * 2));
                        Check.Next.Add(Tetrominos.Block.Current[1] - 4 + (Program.Display.Width * 2));
                        Check.Next.Add(Tetrominos.Block.Current[2] - 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[3] - 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[4] - 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[5] - 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[6] + 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[7] + 2 - (Program.Display.Width * 1));
                        WallCheck();
                        if (Check.Pass) { Check.Count = 0; };
                        break;
                }
            }
            catch (Exception)
            {
            }
        }

        public static void JBlockRotate()
        {
            try
            {
                switch (Check.Count)
                {
                    case 0:
                        Check.Next.Clear();
                        Check.Next.Add(Tetrominos.Block.Current[0] + 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[1] + 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[2] + 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[3] + 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[4] - 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[5] - 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[6] - 0 - (Program.Display.Width * 2));
                        Check.Next.Add(Tetrominos.Block.Current[7] - 0 - (Program.Display.Width * 2));
                        WallCheck();
                        if (Check.Pass) { Check.Count = 1; };
                        break;

                    case 1:
                        Check.Next.Clear();
                        Check.Next.Add(Tetrominos.Block.Current[0] + 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[1] + 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[2] + 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[3] + 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[4] - 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[5] - 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[6] - 4 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[7] - 4 + (Program.Display.Width * 0));
                        WallCheck();
                        if (Check.Pass) { Check.Count = 2; };
                        break;

                    case 2:
                        Check.Next.Clear();
                        Check.Next.Add(Tetrominos.Block.Current[0] - 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[1] - 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[2] - 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[3] - 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[4] + 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[5] + 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[6] + 0 + (Program.Display.Width * 2));
                        Check.Next.Add(Tetrominos.Block.Current[7] + 0 + (Program.Display.Width * 2));
                        WallCheck();
                        if (Check.Pass) { Check.Count = 3; };
                        break;

                    case 3:
                        Check.Next.Clear();
                        Check.Next.Add(Tetrominos.Block.Current[0] - 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[1] - 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[2] - 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[3] - 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[4] + 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[5] + 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[6] + 4 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[7] + 4 + (Program.Display.Width * 0));
                        WallCheck();
                        if (Check.Pass) { Check.Count = 0; };
                        break;
                }
            }
            catch (Exception)
            {
            }
        }

        public static void LBlockRotate()
        {
            try
            {
                switch (Check.Count)
                {
                    case 0:
                        Check.Next.Clear();
                        Check.Next.Add(Tetrominos.Block.Current[0] + 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[1] + 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[2] + 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[3] + 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[4] - 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[5] - 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[6] + 4 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[7] + 4 + (Program.Display.Width * 0));
                        WallCheck();
                        if (Check.Pass) { Check.Count = 1; };
                        break;

                    case 1:
                        Check.Next.Clear();
                        Check.Next.Add(Tetrominos.Block.Current[0] + 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[1] + 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[2] + 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[3] + 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[4] - 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[5] - 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[6] + 0 - (Program.Display.Width * 2));
                        Check.Next.Add(Tetrominos.Block.Current[7] + 0 - (Program.Display.Width * 2));
                        WallCheck();
                        if (Check.Pass) { Check.Count = 2; };
                        break;

                    case 2:
                        Check.Next.Clear();
                        Check.Next.Add(Tetrominos.Block.Current[0] - 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[1] - 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[2] - 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[3] - 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[4] + 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[5] + 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[6] - 4 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[7] - 4 + (Program.Display.Width * 0));
                        WallCheck();
                        if (Check.Pass) { Check.Count = 3; };
                        break;

                    case 3:
                        Check.Next.Clear();
                        Check.Next.Add(Tetrominos.Block.Current[0] - 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[1] - 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[2] - 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[3] - 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[4] + 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[5] + 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[6] + 0 + (Program.Display.Width * 2));
                        Check.Next.Add(Tetrominos.Block.Current[7] + 0 + (Program.Display.Width * 2));
                        WallCheck();
                        if (Check.Pass) { Check.Count = 0; };
                        break;
                }
            }
            catch (Exception)
            {
            }
        }

        public static void SBlockRotate()
        {
            try
            {
                switch (Check.Count)
                {
                    case 0:
                        Check.Next.Clear();
                        Check.Next.Add(Tetrominos.Block.Current[0] + 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[1] + 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[2] - 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[3] - 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[4] + 4 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[5] + 4 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[6] + 2 - (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[7] + 2 - (Program.Display.Width * 0));
                        WallCheck();
                        if (Check.Pass) { Check.Count = 1; };
                        break;

                    case 1:
                        Check.Next.Clear();
                        Check.Next.Add(Tetrominos.Block.Current[0] - 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[1] - 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[2] + 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[3] + 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[4] - 4 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[5] - 4 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[6] - 2 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[7] - 2 + (Program.Display.Width * 0));
                        WallCheck();
                        if (Check.Pass) { Check.Count = 0; };
                        break;
                }
            }
            catch (Exception)
            {
            }
        }

        public static void TBlockRotate()
        {
            try
            {
                switch (Check.Count)
                {
                    case 0:
                        Check.Next.Clear();
                        Check.Next.Add(Tetrominos.Block.Current[0] + 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[1] + 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[2] + 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[3] + 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[4] + 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[5] + 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[6] - 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[7] - 2 - (Program.Display.Width * 1));
                        WallCheck();
                        if (Check.Pass) { Check.Count = 1; };
                        break;

                    case 1:
                        Check.Next.Clear();
                        Check.Next.Add(Tetrominos.Block.Current[0] + 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[1] + 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[2] + 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[3] + 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[4] - 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[5] - 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[6] - 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[7] - 2 + (Program.Display.Width * 1));
                        WallCheck();
                        if (Check.Pass) { Check.Count = 2; };
                        break;

                    case 2:
                        Check.Next.Clear();
                        Check.Next.Add(Tetrominos.Block.Current[0] + 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[1] + 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[2] - 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[3] - 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[4] - 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[5] - 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[6] + 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[7] + 2 + (Program.Display.Width * 1));
                        WallCheck();
                        if (Check.Pass) { Check.Count = 3; };
                        break;

                    case 3:
                        Check.Next.Clear();
                        Check.Next.Add(Tetrominos.Block.Current[0] + 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[1] + 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[2] - 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[3] - 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[4] + 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[5] + 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[6] + 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[7] + 2 - (Program.Display.Width * 1));
                        WallCheck();
                        if (Check.Pass) { Check.Count = 0; };
                        break;
                }
            }
            catch (Exception)
            {
            }
        }

        public static void ZBlockRotate()
        {
            try
            {
                switch (Check.Count)
                {
                    case 0:
                        Check.Next.Clear();
                        Check.Next.Add(Tetrominos.Block.Current[0] + 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[1] + 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[2] + 0 - (Program.Display.Width * 2));
                        Check.Next.Add(Tetrominos.Block.Current[3] + 0 - (Program.Display.Width * 2));
                        Check.Next.Add(Tetrominos.Block.Current[4] + 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[5] + 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[6] + 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[7] + 2 - (Program.Display.Width * 1));
                        WallCheck();
                        if (Check.Pass) { Check.Count = 1; };
                        break;

                    case 1:
                        Check.Next.Clear();
                        Check.Next.Add(Tetrominos.Block.Current[0] - 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[1] - 0 + (Program.Display.Width * 0));
                        Check.Next.Add(Tetrominos.Block.Current[2] - 0 + (Program.Display.Width * 2));
                        Check.Next.Add(Tetrominos.Block.Current[3] - 0 + (Program.Display.Width * 2));
                        Check.Next.Add(Tetrominos.Block.Current[4] - 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[5] - 2 - (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[6] - 2 + (Program.Display.Width * 1));
                        Check.Next.Add(Tetrominos.Block.Current[7] - 2 + (Program.Display.Width * 1));
                        WallCheck();
                        if (Check.Pass) { Check.Count = 0; };
                        break;
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
