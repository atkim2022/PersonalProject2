# High Score Tracker Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

To provide an efficient tool that sorts scores.  

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

The video shows the program taking in a player name and score then sorting it in a list of other scores. 

### 3a iii.

Describes the input and output of the program demonstrated in the video.

My program receives a player name and score then returns the list of all scores sorted in increasing order. 

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
List<string> scores = File.ReadAllLines("scores.txt").ToList(); 
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
 foreach (string value in scores)
            {

                Console.WriteLine($"{value}");
            }
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in the variable {scores}.

### 3b iv.

Describes what the data contained in the list represents in your program

The list "scores" stores each line of strings in the scores.txt file. 

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

Without a list, I would not have a consolidated way to store all of the old and new score values. I would need an unknown amount of variables, and constantly create new ones to store inputted score values. This would be cumbersome and impossible to keep track of. 

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
  public static List<int> LoadScoreValues(string filename)
        {
            List<string> lines = File.ReadAllLines(filename).ToList(); 
            if (File.Exists(filename) == false)
            {
            throw new Exception ($"The file could not be loaded."); 
            }
            List<int> values = new List<int>();
            int K = 0;
            while (K < lines.Count) 
            {
                values.Add(GetScoreValue(lines[K])); 
                K++; 
            }
            return values;
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
values = LoadScoreValues("scores.txt");
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

The scores.txt file is stored in two columns. The first column is the players name and the second column is the players score. This method loads the file and extracts the second column into a List<int>. Loading these scores is a main function of my program, because the scores are needed to sort the user inputted score in. 

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

1. Check to see if the specified filename exists.
2. If it does not, throw an exception stating the file cannot be loaded
3. Load the file as a List and store it in a variable named, "lines"
4. Create a List called values.
5. Loop through each line
6. For each line, use GetScoreValue to extract the second column as an int
7. Add the int to values
8. Return values

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

LoadScoreValues("scores.txt")

Second call:

LoadScoreValues("dontexist.txt")

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
Testing that the file name does exist. This will skip the body of the if statement. 

Condition(s) tested by the second call:

Testing that the file name does not exist. This will execute the body of the if statement. 

### 3d iii.

Result of the first call:

The result of calling an existing file name will result in iteration that adds all of the file's lines to a variable called values. 

Result of the second call:

The result of calling a non-existent file name will result in an exception being thrown. 