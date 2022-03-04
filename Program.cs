using System;
using System.Collections.Generic;
using System.IO;
using System.Linq; 

namespace PersonalProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 && args [0] == "test")
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

        /// <summary>
        /// The scores.txt file is stored in two columns. The first column is the players name and the second column is 
        /// the players score. This method loads the file and extracts the second column into a List<int>.
        /// </summary>
        /// <param name="filename"></param>
        /// <returns>"values"</returns>
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

            List<string> lines = File.ReadAllLines("scores.txt").ToList(); 
            if (File.Exists(filename) == false)
            {
            throw new Exception ($"The file could not be loaded."); 
            }

            List<int> values = new List<int>();
            int K = 0;
            while (K < lines.Count) // Feedback(jcollard 2022-03-04): Try lines.Count
            {
                // Feedback(jcollard 2022-03-04): You'll need to convert the
                // line to an int value. Luckily, you have a method to do that
                // -- GetScoreValue(lines[K])
                values.Add(GetScoreValue(lines[K])); 
                K++; 
            }
            return values;
        }  

        /// <summary>
        /// This is a helper method which, given a score string of the format "name score", extracts the score value 
        /// from the second column, parses it into an int value, and finally returns it.
        /// </summary>
        /// <param name="score"></param>
        /// <returns>"value"</returns>
        public static int GetScoreValue(string score)
        {
            string parts = score.Split(' ');
            int result = int.Parse(parts[1]);

            return result;
            // Split the specified score string into two strings using ' ' as a delimiter
            // Store the result in a variable called parts
            // Parse the second element as an int int.Parse(parts[1])
            // Return the result
        }
        
        /// <summary>
        /// Given a list of score values and a newScore to insert into the high scores table, returns the index 
        /// where the new score should be inserted.
        /// </summary>
        /// <param name="values"></param>
        /// <param name="newScore"></param>
        /// <returns>"insertAt"</returns>
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
            int insertAt = 0;
            while (newScore < values[insertAt])
            {
                insertAt++;
            }
            return insertAt;
        }

        /// <summary>
        /// Given the name, score, insertion location, and a list of strings containing the current high scores, inserts 
        /// the name and score at the specified location. Then writes the results to "scores.txt".
        /// </summary>
        /// <param name="name"></param>
        /// <param name="score"></param>
        /// <param name="insertAt"></param>
        /// <param name="scores"></param>
        public static void AddScore(string name, int score, int insertAt, List<string> scores)
        {
            string entry;
            entry = ($"{name} {score}");
            scores.Insert(insertAt, entry); 
            return; 
            // Create a string variable entry which will be the new row to add to the high score list.
            // Assign entry to be $"{name} {score}"
            // Insert entry into scores at the index insertAt
            // Use File.WriteLines to write each line of the scores list to the file "scores.txt"
        }
    }
}
