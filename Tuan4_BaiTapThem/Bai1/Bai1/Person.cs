namespace Bai1;

public class Person
{
    private string hoTen;
    private int tuoi;
    private string diaChi;

    public Person()
    {
    }

    public Person(string hoTen, int tuoi, string diaChi)
    {
        this.hoTen = hoTen;
        this.tuoi = tuoi;
        this.diaChi = diaChi;
    }

    public string HoTen
    {
        get => hoTen;
        set => hoTen = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Tuoi
    {
        get => tuoi;
        set => tuoi = value;
    }

    public string DiaChi
    {
        get => diaChi;
        set => diaChi = value ?? throw new ArgumentNullException(nameof(value));
    }
}