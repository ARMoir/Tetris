using System;
using System.Collections.Generic;
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
            public static Random Random { get; set; } = new Random();
        }

        public static void New()
        {
            if(Block.Set)
            {
                Block.Set = false;
                Rotate.Check.Count = 0;

                switch (Block.Random.Next(7))
                {
                    case (int)Block.Tetromino.IBlock:
                        JBlock();
                        break;

                    case (int)Block.Tetromino.JBlock:
                        JBlock();
                        break;

                    case (int)Block.Tetromino.LBlock:
                        JBlock();
                        break;

                    case (int)Block.Tetromino.OBlock:
                        JBlock();
                        break;

                    case (int)Block.Tetromino.SBlock:
                        JBlock();
                        break;

                    case (int)Block.Tetromino.TBlock:
                        JBlock();
                        break;

                    case (int)Block.Tetromino.ZBlock:
                        JBlock();
                        break;
                }
            }
        }

        public static void IBlock()
        {
            Program.Display.Active = (int)Block.Tetromino.IBlock;
            Block.Next.Add(Program.Display.Position - 4 + (Program.Display.Width * 0));
            Block.Next.Add(Program.Display.Position - 3 + (Program.Display.Width * 0));
            Block.Next.Add(Program.Display.Position - 2 + (Program.Display.Width * 0));
            Block.Next.Add(Program.Display.Position - 1 + (Program.Display.Width * 0));
            Block.Next.Add(Program.Display.Position + 0 + (Program.Display.Width * 0));
            Block.Next.Add(Program.Display.Position + 1 + (Program.Display.Width * 0));
            Block.Next.Add(Program.Display.Position + 2 + (Program.Display.Width * 0));
            Block.Next.Add(Program.Display.Position + 3 + (Program.Display.Width * 0));

        }

        public static void JBlock()
        {
            Program.Display.Active = (int)Block.Tetromino.JBlock;
            Block.Next.Add(Program.Display.Position - 2 + (Program.Display.Width * 0));
            Block.Next.Add(Program.Display.Position - 1 + (Program.Display.Width * 0));
            Block.Next.Add(Program.Display.Position + 0 + (Program.Display.Width * 0));
            Block.Next.Add(Program.Display.Position + 1 + (Program.Display.Width * 0));
            Block.Next.Add(Program.Display.Position + 2 + (Program.Display.Width * 0));
            Block.Next.Add(Program.Display.Position + 3 + (Program.Display.Width * 0));
            Block.Next.Add(Program.Display.Position + 2 + (Program.Display.Width * 1));
            Block.Next.Add(Program.Display.Position + 3 + (Program.Display.Width * 1));
        }

        public static void LBlock()
        {
            Program.Display.Active = (int)Block.Tetromino.LBlock;
            Block.Next.Add(Program.Display.Position + 0 + (Program.Display.Width * 0));
            Block.Next.Add(Program.Display.Position + 1 + (Program.Display.Width * 0));
            //Block.Next.Add(Program.Display.Position + 2);
            //Block.Next.Add(Program.Display.Position + 3);
            //Block.Next.Add(Program.Display.Position - 1 + (Program.Display.Width * 1));
            //Block.Next.Add(Program.Display.Position - 2 + (Program.Display.Width * 1));
            //Block.Next.Add(Program.Display.Position + Program.Display.Width);
            //Block.Next.Add(Program.Display.Position + (Program.Display.Width) + 1);
            //Block.Next.Add(Program.Display.Position + (Program.Display.Width) + 2);
            //Block.Next.Add(Program.Display.Position + (Program.Display.Width) + 3);
        }

        public static void OBlock()
        {
            Program.Display.Active = (int)Block.Tetromino.OBlock;
            Block.Next.Add(Program.Display.Position);
            Block.Next.Add(Program.Display.Position + 1);
            Block.Next.Add(Program.Display.Position - 1);
            Block.Next.Add(Program.Display.Position - 2);
            Block.Next.Add(Program.Display.Position - 1 + (Program.Display.Width * 1));
            Block.Next.Add(Program.Display.Position - 2 + (Program.Display.Width * 1));
            Block.Next.Add(Program.Display.Position + Program.Display.Width);
            Block.Next.Add(Program.Display.Position + (Program.Display.Width) + 1);
        }

        public static void SBlock()
        {
            Program.Display.Active = (int)Block.Tetromino.SBlock;
            Block.Next.Add(Program.Display.Position);
            Block.Next.Add(Program.Display.Position + 1);
            //Block.Next.Add(Program.Display.Position + 2);
            //Block.Next.Add(Program.Display.Position + 3);
            //Block.Next.Add(Program.Display.Position - 1 + (Program.Display.Width * 1));
            //Block.Next.Add(Program.Display.Position - 2 + (Program.Display.Width * 1));
            //Block.Next.Add(Program.Display.Position + Program.Display.Width);
            //Block.Next.Add(Program.Display.Position + (Program.Display.Width) + 1);

        }

        public static void TBlock()
        {
            Program.Display.Active = (int)Block.Tetromino.TBlock;
            Block.Next.Add(Program.Display.Position);
            Block.Next.Add(Program.Display.Position + 1);
            Block.Next.Add(Program.Display.Position - 1 + (Program.Display.Width * 1));
            Block.Next.Add(Program.Display.Position - 2 + (Program.Display.Width * 1));
            Block.Next.Add(Program.Display.Position + Program.Display.Width);
            Block.Next.Add(Program.Display.Position + (Program.Display.Width) + 1);
            Block.Next.Add(Program.Display.Position + (Program.Display.Width) + 2);
            Block.Next.Add(Program.Display.Position + (Program.Display.Width) + 3);
        }

        public static void ZBlock()
        {
            Program.Display.Active = (int)Block.Tetromino.ZBlock;
            Block.Next.Add(Program.Display.Position - 3);
            Block.Next.Add(Program.Display.Position - 4);
            Block.Next.Add(Program.Display.Position - 1);
            Block.Next.Add(Program.Display.Position - 2);
            Block.Next.Add(Program.Display.Position - 1 + (Program.Display.Width * 1));
            Block.Next.Add(Program.Display.Position - 2 + (Program.Display.Width * 1));
            Block.Next.Add(Program.Display.Position + Program.Display.Width);
            Block.Next.Add(Program.Display.Position + (Program.Display.Width) + 1);
        }
    }
}
