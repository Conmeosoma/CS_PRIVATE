namespace Bai1;

public class CONGNHAN : Person
{
    private string maCongNhan;
    private ChucVu _chucVu;

    public CONGNHAN(string maCongNhan, ChucVu chucVu)
    {
        this.maCongNhan = maCongNhan;
        _chucVu = chucVu;
    }

    public CONGNHAN(string maCongNhan, string hoTen, int tuoi, string diaChi, ChucVu chucVu) : base(hoTen, tuoi, diaChi)
    {
        this.maCongNhan = maCongNhan;
        _chucVu = chucVu;
    }

    public string MaCongNhan
    {
        get => maCongNhan;
        set => maCongNhan = value ?? throw new ArgumentNullException(nameof(value));
    }

    public ChucVu ChucVu
    {
        get => _chucVu;
        set => _chucVu = value;
    }

    // tinh luong
    public double tinhLuong()
    {
        double soLuong = 8000000;
        switch (_chucVu)
        {
            case ChucVu.TruongNhom:
            {
                return soLuong * 3.0;
            }
            case ChucVu.PhoNhom:
            {
                return soLuong * 2.5;
            }
            case ChucVu.CongNhanBac1:
            {
                return soLuong * 2.0;
            }
            case ChucVu.CongNhanBac2:
            {
                return soLuong * 1.5;
            }
            case ChucVu.CongNhanBac3:
            {
                return soLuong * 1.2;
            }
            default:
            {
                return soLuong;
            }
        }
    }

    public void toString()
    {
        Console.WriteLine("Ma cong nhan: " + maCongNhan + "Ho ten: " + HoTen + "Dia chi: " + DiaChi + "Chuc vu: " +
                          ChucVu);
    }
}