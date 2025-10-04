// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Student student1 = new Student("David", new GradeAvarageCalculator());
student1.Grades.AddRange(new double?[] { 12, 10, null, 11, 9, null, 12, 8, 10, null, null });

Student student2 = new Student("Oksana", new GradeAvaragePunishCalculator());
student2.Grades.AddRange(new double?[] { 12, 11, 10, 9, 8, 12, null });

Console.WriteLine($"Student: {student1.Name}");
Console.WriteLine($"Grades: {string.Join(", ", student1.Grades)}");
Console.WriteLine($"Average: {student1.CalculateAverage():F2}");
Console.WriteLine();

Console.WriteLine($"Student: {student2.Name}");
Console.WriteLine($"Grades: {string.Join(", ", student2.Grades)}");
Console.WriteLine($"Average: {student2.CalculateAverage():F2}");


public class Student
{
    public string Name { get; set; }
    public List<double?> Grades { get; set; }
    private readonly IGradeAvarageCalculator calculator; 

    public Student(string name, IGradeAvarageCalculator calculator)
    {
        Name = name;
        Grades = new List<double?>();
        this.calculator = calculator;
    }

    public double CalculateAverage() => calculator.CalculateAvarage(Grades);
}

public interface IGradeAvarageCalculator
{
    double CalculateAvarage(IEnumerable<double?> grades); 
}

public class GradeAvarageCalculator : IGradeAvarageCalculator
{
    public double CalculateAvarage(IEnumerable<double?> grades)
    {
        double sum = 0;
        int count = 0;
        foreach (var grade in grades)
        {
            if (grade.HasValue)
            {
                sum += grade.Value;
                count++;
            }
        }
        return count == 0 ? 0 : sum / count;
    }
}

public class GradeAvaragePunishCalculator : IGradeAvarageCalculator
{
    public double CalculateAvarage(IEnumerable<double?> grades)
    {
        double sum = 0;
        int present = 0;
        int total = 0;

        foreach (var grade in grades)
        {
            total++;
            if (grade.HasValue)
            {
                sum += grade.Value;
                present++;
            }
        }

        if (total == 0) return 0;

        int absent = total - present;
        double avg = sum / total;

        return absent >= 5 ? avg * 0.9 : avg;
    }
}
