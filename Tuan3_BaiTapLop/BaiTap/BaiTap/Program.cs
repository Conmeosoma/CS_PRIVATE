namespace Program
{
  struct Student
  {
    public int Id;
    public string Name;
    public double Score;

    public Student(int Id, string name, double score)
    {
      this.Id = Id;
      this.Name = name;
      this.Score = score;

    }
  }
    public class Program
    {
      static Student st = new Student();
      static List<Student> students = new List<Student>();
      public static void showStudents()
      {
        foreach (Student st in students)
        {
          Console.WriteLine("Id: " + st.Id + "Name: " + st.Name + "Score: " + st.Score);
        }
      }
      public static void check()
      {
        for (int i = 0; i < 5; i++)
        {
          if (students[i].Score >= 5)
          {
            System.Console.WriteLine("Student " + students[i].Name + " passed.");
          }
          else
          {
            System.Console.WriteLine("Student " + students[i].Name + " failed.");
          }
        }
      }
      public static void Main(string[] args)
      {
        Student st1 = new Student(1, "a", 9.12);
        Student st2 = new Student(2, "ab", 5.3);
        Student st3 = new Student(3, "abc", 1.2);
        students.Add(st1);
        students.Add(st2);
        students.Add(st3);
        showStudents();
        check();
      }
    }
   

}