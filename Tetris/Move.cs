using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Move
    {
        public static class Check
        {
            public static bool Safe { get; set; } = false;
            public enum Diretions { Left = -2, Right = 2 }
        }

        public static void Direction(int Direction)
        {
            try
            {
                Check.Safe = true;

                for (var i = 0; i < Tetrominos.Block.Current.Count; i++)
                {
                    if (Frame.Wall.Values.Contains(Program.Display.FrameChar[Tetrominos.Block.Current[i] + Direction]))
                    {
                        Check.Safe = false;
                    }
                }

                if (Check.Safe)
                {
                    Tetrominos.Block.Next.Clear();

                    for (var i = 0; i < Tetrominos.Block.Current.Count; i++)
                    {
                        Tetrominos.Block.Next.Add(Tetrominos.Block.Current[i] + Direction);
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
