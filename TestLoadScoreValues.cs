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
            Program.LoadFile("NotAFile.txt");
            Console.Error.WriteLine("Expected an exception from loading \"NotAFile.txt\"");
            return false;
        }
            
        catch 
        {
            
        }

        }
    }
}