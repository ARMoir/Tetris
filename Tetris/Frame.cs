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
            public static bool Intro { get; set; } = true;
        }

        public static void SetIntro()
        {
            foreach (string line in new string[]
            {
                
                @"                                                                        ",
                @"                                                                        ",
                @"                                                                        ",
                @"                                                                        ",
                @"                              [ ]                                       ",
                @"                              T E T R I S                               ",
                @"                                       [ ]                              ",
                @"                                                                        ",
                @"                                                                        ",
                @"                                                                        ",
                @"                                                                        ",
                @"                                                                        ",
                @"                                                                        ",
                @"                                                                        ",
                @"                                                                        ",
                @"                                                                        ",
                @"                                                                        ",
                @"                           Select Level (0-9)                           ",
                @"                                                                        ",
                @"                                                                        ",
                @"                                                                        ",               
                @"                                                                        ",
            })
            {
                Program.Display.Intro.Append(line + (char)10);
            }
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

        public static void WallList()
        {
            Wall.ValList.Clear();

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
