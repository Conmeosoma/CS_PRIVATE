namespace Bai1;

public class Student
{
    private string ten;
    private string lop;
    private double GPA;

    public Student()
    {
    }

    public Student(string ten, string lop, double gpa)
    {
        this.ten = ten;
        this.lop = lop;
        GPA = gpa;
    }

    public string Ten
    {
        get => ten;
        set => ten = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Lop
    {
        get => lop;
        set => lop = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double Gpa
    {
        get => GPA;
        set => GPA = value;
    }

    public void UpdateGPA(double newGPA)
    {
        if (newGPA < 0 || newGPA > 10)
        {
            Console.WriteLine("Invalid GPA score");
        }
        else
        {
            Gpa = newGPA;
            Console.WriteLine("GPA has been updated");
        }
    }
    public void toString()
    {
        System.Console.WriteLine("Ten: " + ten + "Lop: " + lop + "GPA: " + GPA);
    }



}