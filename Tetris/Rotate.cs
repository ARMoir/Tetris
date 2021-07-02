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

        public static void IBlockRotate()
        {
            try
            {
                switch (Check.Count)
                {
                    case 0:
                        Tetrominos.Block.Next.Clear();
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[0] + 4 - (Program.Display.Width * 2));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[1] + 4 - (Program.Display.Width * 2));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[2] + 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[3] + 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[4] + 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[5] + 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[6] - 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[7] - 2 + (Program.Display.Width * 1));
                        Check.Count = 1;
                        break;

                    case 1:
                        Tetrominos.Block.Next.Clear();
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[0] - 4 + (Program.Display.Width * 2));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[1] - 4 + (Program.Display.Width * 2));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[2] - 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[3] - 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[4] - 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[5] - 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[6] + 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[7] + 2 - (Program.Display.Width * 1));
                        Check.Count = 0;
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
                        Tetrominos.Block.Next.Clear();
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[0] + 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[1] + 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[2] + 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[3] + 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[4] - 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[5] - 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[6] - 0 - (Program.Display.Width * 2));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[7] - 0 - (Program.Display.Width * 2));
                        Check.Count++;
                        break;

                    case 1:
                        Tetrominos.Block.Next.Clear();
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[0] + 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[1] + 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[2] + 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[3] + 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[4] - 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[5] - 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[6] - 4 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[7] - 4 + (Program.Display.Width * 0));
                        Check.Count++;
                        break;

                    case 2:
                        Tetrominos.Block.Next.Clear();
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[0] - 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[1] - 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[2] - 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[3] - 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[4] + 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[5] + 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[6] + 0 + (Program.Display.Width * 2));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[7] + 0 + (Program.Display.Width * 2));
                        Check.Count++;
                        break;

                    case 3:
                        Tetrominos.Block.Next.Clear();
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[0] - 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[1] - 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[2] - 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[3] - 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[4] + 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[5] + 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[6] + 4 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[7] + 4 + (Program.Display.Width * 0));
                        Check.Count = 0;
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
                        Tetrominos.Block.Next.Clear();
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[0] + 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[1] + 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[2] + 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[3] + 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[4] - 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[5] - 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[6] + 4 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[7] + 4 + (Program.Display.Width * 0));
                        Check.Count++;
                        break;

                    case 1:
                        Tetrominos.Block.Next.Clear();
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[0] + 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[1] + 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[2] + 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[3] + 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[4] - 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[5] - 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[6] + 0 - (Program.Display.Width * 2));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[7] + 0 - (Program.Display.Width * 2));
                        Check.Count++;
                        break;

                    case 2:
                        Tetrominos.Block.Next.Clear();
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[0] - 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[1] - 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[2] - 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[3] - 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[4] + 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[5] + 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[6] - 4 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[7] - 4 + (Program.Display.Width * 0));
                        Check.Count++;
                        break;

                    case 3:
                        Tetrominos.Block.Next.Clear();
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[0] - 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[1] - 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[2] - 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[3] - 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[4] + 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[5] + 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[6] + 0 + (Program.Display.Width * 2));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[7] + 0 + (Program.Display.Width * 2));
                        Check.Count = 0;
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
                        Tetrominos.Block.Next.Clear();
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[0] + 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[1] + 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[2] - 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[3] - 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[4] + 4 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[5] + 4 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[6] + 2 - (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[7] + 2 - (Program.Display.Width * 0));
                        Check.Count = 1;
                        break;

                    case 1:
                        Tetrominos.Block.Next.Clear();
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[0] - 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[1] - 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[2] + 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[3] + 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[4] - 4 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[5] - 4 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[6] - 2 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[7] - 2 + (Program.Display.Width * 0));
                        Check.Count = 0;
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
                        Tetrominos.Block.Next.Clear();
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[0] + 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[1] + 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[2] + 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[3] + 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[4] + 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[5] + 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[6] - 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[7] - 2 - (Program.Display.Width * 1));
                        Check.Count++;
                        break;

                    case 1:
                        Tetrominos.Block.Next.Clear();
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[0] + 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[1] + 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[2] + 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[3] + 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[4] - 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[5] - 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[6] - 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[7] - 2 + (Program.Display.Width * 1)); 
                        Check.Count++;
                        break;

                    case 2:
                        Tetrominos.Block.Next.Clear();
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[0] + 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[1] + 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[2] - 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[3] - 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[4] - 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[5] - 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[6] + 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[7] + 2 + (Program.Display.Width * 1));
                        Check.Count++;
                        break;

                    case 3:
                        Tetrominos.Block.Next.Clear();
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[0] + 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[1] + 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[2] - 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[3] - 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[4] + 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[5] + 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[6] + 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[7] + 2 - (Program.Display.Width * 1));
                        Check.Count = 0;
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
                        Tetrominos.Block.Next.Clear();
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[0] + 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[1] + 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[2] + 0 - (Program.Display.Width * 2));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[3] + 0 - (Program.Display.Width * 2));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[4] + 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[5] + 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[6] + 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[7] + 2 - (Program.Display.Width * 1));
                        Check.Count = 1;
                        break;

                    case 1:
                        Tetrominos.Block.Next.Clear();
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[0] - 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[1] - 0 + (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[2] - 0 + (Program.Display.Width * 2));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[3] - 0 + (Program.Display.Width * 2));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[4] - 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[5] - 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[6] - 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[7] - 2 + (Program.Display.Width * 1));
                        Check.Count = 0;
                        break;
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
