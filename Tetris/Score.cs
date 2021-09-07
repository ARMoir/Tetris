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
            public static int Counting { get; set; } = 0;
            public static int Bonus { get; set; } = 0;
        }

        public static class ScoreBoard
        {
            public static int Rows { get; set; } = 0;
            public static int Level { get; set; } = 0;
            public static int Score { get; set; } = 0;
        }

        public static void RowCheck()
        {
            
            Tetrominos.Block.Placed.Sort();

            for (var i = 1; i < Tetrominos.Block.Placed.Count; i++)
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
                        
                        ScoreBoard.Rows++;

                        if ((ScoreBoard.Rows / 5) > ScoreBoard.Level)
                        {
                            ScoreBoard.Level = (ScoreBoard.Rows / 5);

                        }

                        Row.Counting++;
                        Row.Cleared.AddRange(Tetrominos.Block.Placed.Except(Row.Complete).ToList());

                        Tetrominos.Block.Placed.Clear();
                        Tetrominos.Block.Placed.AddRange(Row.Cleared);

                        Row.Cleared.Clear();

                        for (var j = 0; j < Program.Display.Height; j++)
                        {
                            for (var k = 0; k < Tetrominos.Block.Placed.Count; k++)
                            {
                                if (Row.Complete.Contains(Tetrominos.Block.Placed[k] + Program.Display.Width))
                                {
                                    Tetrominos.Block.Placed[k] +=  Program.Display.Width;
                                }
                            }

                            for (var k = 0; k < Row.Complete.Count; k++)
                            {
                                Row.Complete[k] -= Program.Display.Width;
                            }
                        }
                    }
                }
                else
                {
                    Row.Complete.Clear();
                }
            }

            Row.Complete.Clear();
        }

        public static void RowScore()
        {
            Row.Counting = 0;
            Row.Bonus = 0;

            for (var i = 0; i < 4; i++)
            {
                RowCheck();
            }

            switch (Row.Counting)
            {
                case 1:
                    Row.Bonus = 40;
                    break;

                case 2:
                    Row.Bonus = 100;
                    break;

                case 3:
                    Row.Bonus = 300;
                    break;

                case 4:
                    Row.Bonus = 1200;
                    break;
            }

            ScoreBoard.Score += Row.Bonus * (ScoreBoard.Level + 1);

        }

        public static void PopScoreBoard(int Val, int Loc)
        {
            List<string> Pop = new List<string>();

            Pop.Clear();
            Pop.AddRange(Val.ToString().Select(Chars => Chars.ToString()));

            for (var i = 0; i < Pop.Count; i++)
            {
                Program.Display.FrameChar[Loc + i] = Pop[i];
            }
        }
    }
}
