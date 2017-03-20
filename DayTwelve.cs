
class Student : Person
{
    private int[] testScores;

    public Student(string fn, string ln, int ids, int[] ts)
    {
        testScores = ts;
        firstName = fn;
        lastName = ln;
        id = ids;
    }

    public char calculate()
    {
        int sum = 0;
        int score = 0;

        foreach (int i in testScores)
        { sum = sum + i; }

        score = sum / (int)testScores.Length;

        if (score < 40) return 'T';
        else if (score < 55) return 'D';
        else if (score < 70) return 'P';
        else if (score < 80) return 'A';
        else if (score < 90) return 'E';
        else return 'O';



    }

}