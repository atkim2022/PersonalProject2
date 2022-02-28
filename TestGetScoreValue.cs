using System;
using System.Collections.Generic;

namespace PersonalProject2
{
    class TestGetScoreValue
    {
        public static bool RunTest()
        {
            int result = Program.GetScoreValue("Kim", 20);
          
            if (result != 20) 
            {
                return false; 
            }

            int result2 = Program.GetScoreValue("Smith", 50);
          
            if (result2 != 50) 
            {
                return false; 
            }

            return true;
        }
    }
}