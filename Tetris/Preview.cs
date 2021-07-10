using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Preview
    {
        public static class Next
        {
            public static int Tetromino { get; set; } = -1;
            public static int Position { get; set; } = 748;
            public static List<int> Draw { get; set; } = new List<int>();
            public static Random Random { get; set; } = new Random();
        }

        public static void Tetromino()
        {
            if (Next.Tetromino < 0)
            {
                Next.Tetromino = Next.Random.Next(7);
            }

            Next.Draw.Clear();

            switch (Next.Tetromino)
            {
                case (int)Tetrominos.Block.Tetromino.IBlock:
                    Tetrominos.IBlock(Next.Draw, Next.Position, Program.Display.Width);
                    break;

                case (int)Tetrominos.Block.Tetromino.JBlock:
                    Tetrominos.JBlock(Next.Draw, Next.Position, Program.Display.Width);
                    break;

                case (int)Tetrominos.Block.Tetromino.LBlock:
                    Tetrominos.LBlock(Next.Draw, Next.Position, Program.Display.Width);
                    break;

                case (int)Tetrominos.Block.Tetromino.OBlock:
                    Tetrominos.OBlock(Next.Draw, Next.Position, Program.Display.Width);
                    break;

                case (int)Tetrominos.Block.Tetromino.SBlock:
                    Tetrominos.SBlock(Next.Draw, Next.Position, Program.Display.Width);
                    break;

                case (int)Tetrominos.Block.Tetromino.TBlock:
                    Tetrominos.TBlock(Next.Draw, Next.Position, Program.Display.Width);
                    break;

                case (int)Tetrominos.Block.Tetromino.ZBlock:
                    Tetrominos.ZBlock(Next.Draw, Next.Position, Program.Display.Width);
                    break;
            }

            for (var i = 0; i < Next.Draw.Count; i++)
            {
                Program.Display.FrameChar[Next.Draw[i]] = "#";
            }
        }
    }
}
