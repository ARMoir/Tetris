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

        public static class ScoreBoard
        {
            public static List<string> RowChar { get; set; } = new List<string>();
            public static List<string> LevelChar { get; set; } = new List<string>();
            public static List<string> ScoreChar { get; set; } = new List<string>();
            public static int RowCount { get; set; } = 0;
            public static int Level { get; set; } = 1;
            public static int Score { get; set; } = 0;
        }

        public static void RowCheck()
        {
            
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
                            ScoreBoard.RowCount++;
                            
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

        public static void PopRows()
        {
            ScoreBoard.RowChar.Clear();
            ScoreBoard.RowChar.AddRange(ScoreBoard.RowCount.ToString().Select(Chars => Chars.ToString()));

            for (var i = 0; i < ScoreBoard.RowChar.Count; i++)
            {
                Program.Display.FrameChar[6 + i] = ScoreBoard.RowChar[i];
            }
        }

        public static void PopLevel()
        {
            ScoreBoard.Level = (ScoreBoard.RowCount / 5);
            ScoreBoard.LevelChar.Clear();
            ScoreBoard.LevelChar.AddRange(ScoreBoard.Level.ToString().Select(Chars => Chars.ToString()));

            for (var i = 0; i < ScoreBoard.LevelChar.Count; i++)
            {
                Program.Display.FrameChar[152 + i] = ScoreBoard.LevelChar[i];
            }
        }

        public static void PopScore()
        {
            ScoreBoard.ScoreChar.Clear();
            ScoreBoard.ScoreChar.AddRange(ScoreBoard.Score.ToString().Select(Chars => Chars.ToString()));

            for (var i = 0; i < ScoreBoard.ScoreChar.Count; i++)
            {
                Program.Display.FrameChar[79 + i] = ScoreBoard.ScoreChar[i];
            }
        }
    }
}
