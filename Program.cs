using System;
using System.Collections.Generic;

namespace PersonalProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return;
            }
        }
        public static void TestAll()
        {
            bool testLoadScoreValues = TestLoadScoreValues.RunTest();
            Console.WriteLine($"Test LoadScoreValues(string filename): {testLoadScoreValues}");

            bool testGetScoreValue = TestGetScoreValue.RunTest();
            Console.WriteLine($"Test GetScoreValue(string score): {testGetScoreValue}");

            bool testFindInsertionPoint = TestFindInsertionPoint.RunTest();
            Console.WriteLine($"Test FindInsertionPoint(List<int> values, int newScore): {testFindInsertionPoint}");

            bool testAddScore = TestAddScore.RunTest();
            Console.WriteLine($"Test AddScore(string name, int score, int insertAt, List<string> scores): {testAddScore}");
        }

        public static List<int> LoadScoreValues(string filename)
        {
            // Check to see if the specified filename exists.
            // If it does not, throw an exception stating the file cannot be loaded
            // Load the file as a List and store it in a variable named, "lines"
            // Create a List called values.
            // Loop through each line
            // For each line, use GetScoreValue to extract the second column as an int
            // Add the int to values
            // Return values
            return values;
        }  

        public static int GetScoreValue(string score)
        {
            // Split the specified score string into two strings using ' ' as a delimiter
            // Store the result in a variable called parts
            // Parse the second element as an int int.Parse(parts[1])
            // Return the result
            return 2;
        }
        
        public static int FindInsertionPoint(List<int> values, int newScore)
        {
            // 1. Initialize a counter variable, insertAt, to 0.
            // 2. Loop through each value in values
            //    * If the new score is greater than the current value, we should insert above
            //      that score so we return `insertAt`.
            //    * Otherwise, the new score should not be inserted above this score so we
            //      increment `insertAt` by 1 and continue.
            // 3. If we reach the end of the list, `insertAt` should be the length of the list
            //    so we return `insertAt`.
            return -1;
        }

        public static void AddScore(string name, int score, int insertAt, List<string> scores)
        {
            // Create a string variable entry which will be the new row to add to the high score list.
            // Assign entry to be $"{name} {score}"
            // Insert entry into scores at the index insertAt
            // Use File.WriteLines to write each line of the scores list to the file "scores.txt"
            return; 
        }
    }
}
