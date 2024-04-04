// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tGrade\n");
foreach (string currentName in studentNames)
{
    string currentStudent = currentName;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int sumAssignmentScores = 0;

    decimal currentStudentGrade = 0;

    foreach (int score in studentScores)
    {
        // add the exam score to the sum
        sumAssignmentScores += score;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;

    Console.WriteLine($"{currentStudent}:\t\t {currentStudentGrade}\t?");
}

// sophiaSum = sophia[0] + sophia[1] + sophia[3] + sophia[4] + sophia[5];
// andrewSum = andrew[1] + andrew[2] + andrew[3] + andrew[4] + andrew[5];
// emmaSum = emma[1] + emma2 + emma3 + emma4 + emma5;
// loganSum = logan1 + logan2 + logan3 + logan4 + logan5;
// andrewScore = (decimal)andrewSum / currentAssignments;
// emmaScore = (decimal)emmaSum / currentAssignments;
// loganScore = (decimal)loganSum / currentAssignments;

// Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
// Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
// Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();