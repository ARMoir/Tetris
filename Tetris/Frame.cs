using System;
using System.Collections.Generic;
using System.Linq;
using Tetris;

namespace Tetris
{
    class Frame
    {
        public static class Wall
        {
            public static string[] Values { get; set; } = { "!", "=", "*"};
            public static List<int> ValList { get; set; } = new List<int>();
        }
        public static void SetFrame()
        {
            foreach (string line in new string[]
            {
                @"ROWS:                   <! . . . . . . . . . .!>                        ",
                @"SCORE:                  <! . . . . . . . . . .!>             UP: ROTATE ",
                @"lEVEL:                  <! . . . . . . . . . .!>             DOWN: DROP ",
                @"                        <! . . . . . . . . . .!>             ESC: EXIT  ",
                @"                        <! . . . . . . . . . .!>                        ",
                @"                        <! . . . . . . . . . .!>                        ",
                @"                        <! . . . . . . . . . .!>                        ",
                @"                        <! . . . . . . . . . .!>                        ",
                @"                        <! . . . . . . . . . .!>                        ",
                @"                        <! . . . . . . . . . .!>                        ",
                @"                        <! . . . . . . . . . .!>                        ",
                @"                        <! . . . . . . . . . .!>                        ",
                @"                        <! . . . . . . . . . .!>                        ",
                @"                        <! . . . . . . . . . .!>                        ",
                @"                        <! . . . . . . . . . .!>                        ",
                @"                        <! . . . . . . . . . .!>                        ",
                @"                        <! . . . . . . . . . .!>                        ",
                @"                        <! . . . . . . . . . .!>                        ",
                @"                        <! . . . . . . . . . .!>                        ",
                @"                        <! . . . . . . . . . .!>                        ",
                @"                        <!====================!>                        ",
                @"                          \/\/\/\/\/\/\/\/\/\/                          ",
            })
            {
                Program.Display.FrameString.Append(line + (char)10);
            }
        }

        public static void PopWallValList()
        {
            for (var i = 0; i < Program.Display.FrameChar.Count; i++)
            {

                if (Wall.Values.Contains(Program.Display.FrameChar[i]))
                {
                    Wall.ValList.Add(i);
                }
            }
        }
    }

}
