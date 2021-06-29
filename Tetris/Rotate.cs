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
        }

        public static void Now()
        {
            switch (Program.Display.Active)
            {
                case (int)Tetrominos.Block.Tetromino.IBlock:
                    IBlockRotate();
                    break;

                case (int)Tetrominos.Block.Tetromino.JBlock:
                    IBlockRotate();
                    break;

                case (int)Tetrominos.Block.Tetromino.LBlock:
                    IBlockRotate();
                    break;

                case (int)Tetrominos.Block.Tetromino.OBlock:
                    //No Need to Rotate OBlock
                    break;

                case (int)Tetrominos.Block.Tetromino.SBlock:
                    IBlockRotate();
                    break;

                case (int)Tetrominos.Block.Tetromino.TBlock:
                    IBlockRotate();
                    break;

                case (int)Tetrominos.Block.Tetromino.ZBlock:
                    IBlockRotate();
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
                        Check.Count++;
                        break;

                    case 1:
                        Tetrominos.Block.Next.Clear();
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[0] - 4 + (Program.Display.Width * 2));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[1] - 4 + (Program.Display.Width * 2));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[2] - 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[3] - 2 + (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[4] - 0 - (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[5] - 0 - (Program.Display.Width * 0));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[6] + 2 - (Program.Display.Width * 1));
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[7] + 2 - (Program.Display.Width * 1));
                        Check.Count--;
                        break;
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
