using System;
class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine( "Student Gradebook");
        Console.Write( "Enter the number of students: ");
        int numStudents = int.Parse( Console.ReadLine() );

        double[] grades = new double[numStudents];

        //input student grades
        for (int i = 0; i < numStudents; i++)
        {
              Console.Write($"Enter the grade for students {i + 1}; "); 
              grades[i] = double.Parse( Console.ReadLine() );
        }

                // Calculate the average grade
                double sum = 0;
                for (int i = 0; i < numStudents; i++)
                {
                    sum += grades[i];
                }
                double average= sum / numStudents;

                // Find the highest and lowest grades
                double highest = grades[0];
                double lowest = grades[0];
                for (int i = 1; i < numStudents; i++)
                {
                    if (grades[i] > highest)
                    highest = grades[i];
                    if (grades[i] < lowest)
                    lowest = grades[i];

                }

                    //Display the results
                    Console.WriteLine($"Grades: {string.Join(", ", grades)}");
                    Console.WriteLine($"Average Grade: {average:F2}");
                    Console.WriteLine($"Highest Grade: {highest:F2}");
                    Console.WriteLine($"Lowest Grade: {lowest:F2}");
    }
}