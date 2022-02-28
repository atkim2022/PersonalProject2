using System;
using System.Collections.Generic;

namespace PersonalProject2
{
    class TestLoadScoreValues
    {
        public static bool RunTest()
        {

            // try and catch for a file that doesn't exist
            // then making sure the values in the file are the things that are being returned
        try
        {
            Program.LoadScoreValues("NotAFile.txt");
            Console.Error.WriteLine("Expected an exception from loading \"NotAFile.txt\"");
            return false;
        }
            
        catch
        {
        }

        try
        {
            Program.LoadScoreValues("FakeFile.txt");
            Console.Error.WriteLine("Expected an exception from loading \"FakeFile.txt\"");
            return false;
        }
            
        catch
        {
        }

        List<int> values = Program.LoadScoreValues("scorestest.txt");
            if (values[0] != 800) 
            {
                return false; 
            }

        List<int> values2 = Program.LoadScoreValues("scorestest.txt");
            if (values2[0] != 50) 
            {
                return false; 
            }

        return true; 
        }
    }
}