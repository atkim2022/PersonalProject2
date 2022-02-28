using System;
using System.Collections.Generic;

namespace PersonalProject2
{
    class TestFindInsertionPoint
    {
        public static bool RunTest()
        {
            List<int> values = Program.LoadScoreValues("scorestest.txt");
            Program.FindInsertionPoint(values, 20);

            if (insertAt != 2)
            {
                return false;
            }

            return true;
        }
    }
}