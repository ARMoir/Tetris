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
        }

        public static void RowCheck()
        {
            Tetrominos.Block.Placed.Sort();

            for (var i = 0; i < Tetrominos.Block.Placed.Count; i++)
            {
                Program.Display.FrameChar[Tetrominos.Block.Placed[i]] = ((int)Program.Display.Status.Placed).ToString();

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
                            Row.Cleared.AddRange(Tetrominos.Block.Placed.Except(Row.Complete).ToList());
                            Tetrominos.Block.Placed.Clear();
                            Tetrominos.Block.Placed.AddRange(Row.Cleared);
                            Row.Cleared.Clear();
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
