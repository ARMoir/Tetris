using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Reset
    {
        public static void Now()
        {
            Program.Display.FrameChar.Clear();
            Program.Display.Intro.Clear();
            Program.Display.FrameString.Clear();
            Program.Display.DisplayFrame.Clear();
            Program.Display.Active = 0;

            Frame.Wall.ValList.Clear();
            Frame.Wall.Intro = true;

            Move.Check.Safe = false;

            Preview.Next.Tetromino = -1;
            Preview.Next.Draw.Clear();

            Rotate.Check.Count = 0;
            Rotate.Check.Lock = false;
            Rotate.Check.Next.Clear();

            Score.Row.Complete.Clear();
            Score.Row.Cleared.Clear();
            Score.Row.Counting = 0;
            Score.Row.Bonus = 0;

            Score.ScoreBoard.Rows= 0;
            Score.ScoreBoard.Level = 0;
            Score.ScoreBoard.Score = 0;

            Speed.Set.Delay = 480;
            Speed.Set.Paused = false;
            Speed.Set.Drop = false;

            Tetrominos.Block.Current.Clear();
            Tetrominos.Block.Next.Clear();
            Tetrominos.Block.Placed.Clear();
            Tetrominos.Block.Set = true;

        }
    }
}
