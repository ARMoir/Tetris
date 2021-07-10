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
            public static bool Paused { get; set; } = false;
            public static bool Drop { get; set; } = false;
        }

        public static void Check()
        {
            Set.Delay = 480 - (Score.ScoreBoard.Rows * 10);
        }

        public static void Pause()
        {

            if (Set.Paused)
            {
                Console.Clear();
                Set.Paused = false;
            }
            else
            {             
                Set.Paused = true;
            }   
        }
    }
}
