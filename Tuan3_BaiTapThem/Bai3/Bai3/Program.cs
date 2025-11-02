namespace Bai1
{
  class Program
  {
    struct Product
    {
      private string name;
      private double price;
      private int quantity;
      private string category;
    }
    // khoi tao danh sach san pham
    Dictionary<string, Product> products = new Dictionary<string, Product>();
    // them du lieu san pham moi
    public void addProduct(string name, double price, int quantity, string category)
    {
      System.Console.WriteLine("Nhap so luong san pham ban muon them: ");
      int n = int.Parse(Console.ReadLine());
      for (int i = 0; i < n; i++)
      {
        System.Console.WriteLine("Nhap ten san pham: ");
        name = Console.ReadLine();
        System.Console.WriteLine("Nhap gia san pham: ");
        price = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Nhap so luong san pham: ");
        quantity = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Nhap danh muc san pham: ");
        category = Console.ReadLine();
        products[name] = new Product(name, price, quantity, category);
      }
      System.Console.WriteLine("Done");
    }
    public void searchByName(string name)
    {
      foreach (var product in products)
      {
        if (product.Key.Contains(name))
        {
          System.Console.WriteLine("Ten san pham: " + product.Key);
          System.Console.WriteLine("Gia san pham: " + product.Value.price);
          System.Console.WriteLine("So luong san pham: " + product.Value.quantity);
          System.Console.WriteLine("Danh muc san pham: " + product.Value.category);
        }
      }
    }
    // tinh san pham ban chay nhat theo so luong ban duoc
    public void bestSell()
    {
      string bestProduct = "";
      int max = 0;
      foreach (var product in products)
      {
        if (product.Value.quantity > max)
        {
          max = product.Value.quantity;
          bestProduct = product.Key;
        }
      }
      System.Console.WriteLine("San pham ban chay nhat: " + bestProduct);
      System.Console.WriteLine("So luong ban duoc: " + max);
    }
    // tinh san pham ban chay nhat theo danh muc
    public void bestSellByCategory(string category)
    {
      string bestProduct = "";
      int max = 0;
      foreach (var product in products)
      {
        if (product.Value.category == category)
        {
          if (product.Value.quantity > max)
          {
            max = product.Value.quantity;
            bestProduct = product.Key;
          }
        }
      }
      System.Console.WriteLine("San pham ban chay nhat trong danh muc " + category + ": " + bestProduct);
      System.Console.WriteLine("So luong ban duoc: " + max);
    }
    // tinh tong doanh thu theo danh muc
    public void totalCategory(string category)
    {
      double total = 0;
      foreach (var product in products)
      {
        if (product.Value.category == category)
        {
          total += product.Value.price * product.Value.quantity;
        }
      }
      System.Console.WriteLine("Tong doanh thu trong danh muc " + category + ": " + total);
    }
    static void Main(string[] args)
    {
      Program program = new Program();
      do
      {
        System.Console.WriteLine(____MENU____);
        System.Console.WriteLine("1. Thêm dữ liệu sản phẩm mới");
        System.Console.WriteLine("2. Trả về thông tin sản phẩm dựa theo mã sản phẩm");
        System.Console.WriteLine("3. Tính sản phẩm bán chạy nhất theo số lượng bán được");
        System.Console.WriteLine("4. Tính sản phẩm bán chạy nhất theo danh mục");
        System.Console.WriteLine("5. Tính tổng doanh thu theo danh mục");
        System.Console.WriteLine("6. Thoát");
        System.Console.WriteLine("Chọn chức năng: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
          case 1:
            program.addProduct();
            break;
          case 2:
            System.Console.WriteLine("Nhap ten san pham can tim: ");
            string name = Console.ReadLine();
            program.searchByName(name);
            break;
          case 3:
            program.bestSell();
            break;
          case 4:
            System.Console.WriteLine("Nhap danh muc can tim: ");
            string category = Console.ReadLine();
            program.bestSellByCategory(category);
            break;
          case 5:
            System.Console.WriteLine("Nhap danh muc can tinh tong doanh thu: ");
            string cat = Console.ReadLine();
            program.totalCategory(cat);
            break;
          case 6:
            return;
          default:
            System.Console.WriteLine("Chuc nang khong hop le. Vui long chon lai.");
            break;
        }
      } while (true);
    }
  }
}