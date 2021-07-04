using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Score
    {
        public static class Row
        {
            public static List<int> Complete { get; set; } = new List<int>();
            public static List<int> Cleared { get; set; } = new List<int>();
            public static int Count { get; set; } = 0;
        }

        public static void RowCheck()
        {
            Program.Display.FrameChar[10] = Row.Count.ToString();
            Tetrominos.Block.Placed.Sort();

            for (var i = 0; i < Tetrominos.Block.Placed.Count; i++)
            {

                if (i > 0)
                {
                    if (Tetrominos.Block.Placed[i] == (Tetrominos.Block.Placed[i - 1] + 1))
                    {

                        if (!Row.Complete.Contains(Tetrominos.Block.Placed[i - 1]))
                        {
                            Row.Complete.Add(Tetrominos.Block.Placed[i - 1]);
                        }

                        if (!Row.Complete.Contains(Tetrominos.Block.Placed[i]))
                        {
                            Row.Complete.Add(Tetrominos.Block.Placed[i]);
                        }

                        if (Row.Complete.Count == 20)
                        {
                            Row.Count++;
                            
                            Row.Cleared.AddRange(Tetrominos.Block.Placed.Except(Row.Complete).ToList());
                            Tetrominos.Block.Placed.Clear();
                            Tetrominos.Block.Placed.AddRange(Row.Cleared);
                            Row.Cleared.Clear();

                            for (var j = 0; j < 20; j++)
                            {
                                for (var k = 0; k < Tetrominos.Block.Placed.Count; k++)
                                {
                                    if (Row.Complete.Contains(Tetrominos.Block.Placed[k] + Program.Display.Width))
                                    {
                                        Tetrominos.Block.Placed[k] = Tetrominos.Block.Placed[k] + Program.Display.Width;
                                    }
                                }

                                for (var k = 0; k < Row.Complete.Count; k++)
                                {
                                    Row.Complete[k] = Row.Complete[k] - Program.Display.Width;
                                }
                            }
                        }
                    }
                    else
                    {
                        Row.Complete.Clear();
                    }
                }
            }
            Row.Complete.Clear();
        }
    }
}
