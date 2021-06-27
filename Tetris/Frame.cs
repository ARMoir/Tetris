using System;
using Tetris;

namespace Tetris
{
    class Frame
    {
        public static class Wall
        {
            public static string[] Values { get; set; } = { "!", "=", ">","[","]" };
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
    }
}
