using System;
using System.Collections.Generic;

namespace PersonalProject2
{
    class TestFindInsertionPoint
    {
        public static bool RunTest()
        {
            List<int> values = new List<int>();
            values.Add(200);
            values.Add(150);
            values.Add(10);

            int insertAt = Program.FindInsertionPoint(values, 20);
            if (insertAt != 2)
            {
                return false;
            }

            return true;
        }
    }
}