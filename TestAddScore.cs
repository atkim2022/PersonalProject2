using System;
using System.Collections.Generic;
using System.IO;
using System.Linq; 

namespace PersonalProject2
{
    class TestAddScore
    {
        public static bool RunTest()
        {
        // List<int> scores = Program.LoadScoreValues("scorestest.txt");
        List<string> scores = new List<string>();
        scores.Add("Kim 870");
        scores.Add("Kim 150");
        scores.Add("Kim 60");

        
        Program.AddScore("Smith", 200, 1, scores);

            if (scores[1] != "Smith 200") 
            {
                return false; 
            }
 
            return true;
        }
    }
}