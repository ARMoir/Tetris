using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Speed
    {
        public static class Set
        {
            public static int Delay { get; set; } = 480;
        }

        public static void Check()
        {
            switch (Score.ScoreBoard.Level)
            {
                case int n when (n > 28):
                    Set.Delay = 10;
                    break;

                case int n when (n > 18):
                    Set.Delay = 20;
                    break;

                case int n when (n > 15):
                    Set.Delay = 30;
                    break;

                case int n when (n > 12):
                    Set.Delay = 40;
                    break;

                case int n when (n > 9):
                    Set.Delay = 50;
                    break;

                case 9:
                    Set.Delay = 60;
                    break;

                case 8:
                    Set.Delay = 80;
                    break;

                case 7:
                    Set.Delay = 130;
                    break;

                case 6:
                    Set.Delay = 180;
                    break;

                case 5:
                    Set.Delay = 230;
                    break;

                case 4:
                    Set.Delay = 280;
                    break;

                case 3:
                    Set.Delay = 330;
                    break;

                case 2:
                    Set.Delay = 380;
                    break;

                case 1:
                    Set.Delay = 430;
                    break;

                case 0:
                    Set.Delay = 480;
                    break;
            }
            
        }
    }
}
