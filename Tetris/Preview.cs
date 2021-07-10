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
                    PIBlock();
                    break;

                case (int)Tetrominos.Block.Tetromino.JBlock:
                    PJBlock();
                    break;

                case (int)Tetrominos.Block.Tetromino.LBlock:
                    PLBlock();
                    break;

                case (int)Tetrominos.Block.Tetromino.OBlock:
                    POBlock();
                    break;

                case (int)Tetrominos.Block.Tetromino.SBlock:
                    PSBlock();
                    break;

                case (int)Tetrominos.Block.Tetromino.TBlock:
                    PTBlock();
                    break;

                case (int)Tetrominos.Block.Tetromino.ZBlock:
                    PZBlock();
                    break;
            }

            for (var i = 0; i < Next.Draw.Count; i++)
            {
                Program.Display.FrameChar[Next.Draw[i]] = "#";
            }
        }

        public static void PIBlock()
        {
            Next.Draw.Add(Next.Position - 4 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position - 3 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position - 2 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position - 1 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position + 0 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position + 1 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position + 2 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position + 3 + (Program.Display.Width * 0));

        }

        public static void PJBlock()
        {
            Next.Draw.Add(Next.Position - 2 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position - 1 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position + 0 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position + 1 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position + 2 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position + 3 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position + 2 + (Program.Display.Width * 1));
            Next.Draw.Add(Next.Position + 3 + (Program.Display.Width * 1));
        }

        public static void PLBlock()
        {
            Next.Draw.Add(Next.Position - 2 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position - 1 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position + 0 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position + 1 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position + 2 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position + 3 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position - 1 + (Program.Display.Width * 1));
            Next.Draw.Add(Next.Position - 2 + (Program.Display.Width * 1));
        }

        public static void POBlock()
        {
            Next.Draw.Add(Next.Position + 0 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position + 1 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position - 1 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position - 2 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position - 2 + (Program.Display.Width * 1));
            Next.Draw.Add(Next.Position - 1 + (Program.Display.Width * 1));
            Next.Draw.Add(Next.Position + 1 + (Program.Display.Width * 1));
            Next.Draw.Add(Next.Position + 0 + (Program.Display.Width * 1));
        }

        public static void PSBlock()
        {
            Next.Draw.Add(Next.Position + 0 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position + 1 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position + 2 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position + 3 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position - 1 + (Program.Display.Width * 1));
            Next.Draw.Add(Next.Position - 2 + (Program.Display.Width * 1));
            Next.Draw.Add(Next.Position + 0 + (Program.Display.Width * 1));
            Next.Draw.Add(Next.Position + 1 + (Program.Display.Width * 1));

        }

        public static void PTBlock()
        {
            Next.Draw.Add(Next.Position + 0 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position + 1 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position - 1 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position - 2 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position + 0 + (Program.Display.Width * 1));
            Next.Draw.Add(Next.Position + 1 + (Program.Display.Width * 1));
            Next.Draw.Add(Next.Position + 2 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position + 3 + (Program.Display.Width * 0));
        }

        public static void PZBlock()
        {
            Next.Draw.Add(Next.Position + 0 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position + 1 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position + 2 + (Program.Display.Width * 1));
            Next.Draw.Add(Next.Position + 3 + (Program.Display.Width * 1));
            Next.Draw.Add(Next.Position - 1 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position - 2 + (Program.Display.Width * 0));
            Next.Draw.Add(Next.Position + 0 + (Program.Display.Width * 1));
            Next.Draw.Add(Next.Position + 1 + (Program.Display.Width * 1));
        }
    }
}
