namespace Bai1;

public class StudentManager
{
    private List<Student> Students = new List<Student>();

    public void add(Student s)
    {
        Console.WriteLine("Nhap so luong sinh vien ban muon them: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Nhap ten sinh vien: ");
            string ten = Console.ReadLine();
            Console.WriteLine("Nhap lop sinh vien: ");
            string lop = Console.ReadLine();
            Console.WriteLine("Nhap GPA sinh vien: ");
            double GPA = double.Parse(Console.ReadLine());
            Students.Add(new Student(ten, lop, GPA));
        }
    }

    public void ShowAllStudents()
    {
        Console.WriteLine("Hien thi thong tin");
        foreach (Student st in Students)
        {
            st.toString();
        }
    }
    public void FindTopStudent()
  {
    int 
  }

}