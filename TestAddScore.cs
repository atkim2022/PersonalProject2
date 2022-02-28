using System;
using System.Collections.Generic;

namespace PersonalProject2
{
    class TestAddScore
    {
        public static bool RunTest()
        {
        List<int> scores = Program.LoadScoreValues(testscores.txt);
        Program.AddScore("Smith", 200, 1, scores);

        List<int> values = Program.LoadScoreValues("scorestest.txt");
            if (values[1] != 200) 
            {
                return false; 
            }
 
            return true;
        }
    }
}