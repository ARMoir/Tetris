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
            public static Random Random { get; set; } = new Random();
        }

        public static void New()
        {
            if(Block.Set)
            {
                Block.Set = false;
                
                switch (Block.Random.Next(7))
                {
                    case 0:
                        IBlock();
                        break;

                    case 1:
                        JBlock();
                        break;

                    case 2:
                        LBlock();
                        break;

                    case 3:
                        OBlock();
                        break;

                    case 4:
                        SBlock();
                        break;

                    case 5:
                        TBlock();
                        break;

                    case 6:
                        ZBlock();
                        break;
                }
            }
        }

        public static void IBlock()
        {
            Block.Next.Add(Program.Display.Position);
            Block.Next.Add(Program.Display.Position + 1);
            Block.Next.Add(Program.Display.Position + (Program.Display.Width * 1));
            Block.Next.Add(Program.Display.Position + (Program.Display.Width * 1) + 1);
            Block.Next.Add(Program.Display.Position + (Program.Display.Width * 2));
            Block.Next.Add(Program.Display.Position + (Program.Display.Width * 2) + 1);
            Block.Next.Add(Program.Display.Position + (Program.Display.Width * 3));
            Block.Next.Add(Program.Display.Position + (Program.Display.Width * 3) + 1);
        }

        public static void JBlock()
        {
            Block.Next.Add(Program.Display.Position - 1);
            Block.Next.Add(Program.Display.Position - 2);
            Block.Next.Add(Program.Display.Position - 1 + (Program.Display.Width * 1));
            Block.Next.Add(Program.Display.Position - 2 + (Program.Display.Width * 1));
            Block.Next.Add(Program.Display.Position + Program.Display.Width);
            Block.Next.Add(Program.Display.Position + (Program.Display.Width) + 1);
            Block.Next.Add(Program.Display.Position + (Program.Display.Width) + 2);
            Block.Next.Add(Program.Display.Position + (Program.Display.Width) + 3);
        }

        public static void LBlock()
        {
            Block.Next.Add(Program.Display.Position + 2);
            Block.Next.Add(Program.Display.Position + 3);
            Block.Next.Add(Program.Display.Position - 1 + (Program.Display.Width * 1));
            Block.Next.Add(Program.Display.Position - 2 + (Program.Display.Width * 1));
            Block.Next.Add(Program.Display.Position + Program.Display.Width);
            Block.Next.Add(Program.Display.Position + (Program.Display.Width) + 1);
            Block.Next.Add(Program.Display.Position + (Program.Display.Width) + 2);
            Block.Next.Add(Program.Display.Position + (Program.Display.Width) + 3);
        }

        public static void OBlock()
        {
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
            Block.Next.Add(Program.Display.Position);
            Block.Next.Add(Program.Display.Position + 1);
            Block.Next.Add(Program.Display.Position + 2);
            Block.Next.Add(Program.Display.Position + 3);
            Block.Next.Add(Program.Display.Position - 1 + (Program.Display.Width * 1));
            Block.Next.Add(Program.Display.Position - 2 + (Program.Display.Width * 1));
            Block.Next.Add(Program.Display.Position + Program.Display.Width);
            Block.Next.Add(Program.Display.Position + (Program.Display.Width) + 1);

        }

        public static void TBlock()
        {
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
