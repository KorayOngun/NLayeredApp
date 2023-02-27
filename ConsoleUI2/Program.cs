

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

class Program
{
   // static bool  isRun = true;
    
    static void Main()
    {
        //ProductTest();
        CategoryTest();
        ProductManager product = new ProductManager(new EfProductDal());
        foreach (var item in product.GetAll())
        {
            Console.WriteLine(item.ProductName);
        }
        #region
        //Product p = new Product();
        //while (isRun)
        //{
        //    Console.WriteLine("işlem seçiniz");
        //    Console.WriteLine("1) Listeleme");
        //    Console.WriteLine("2) silme");
        //    Console.WriteLine("3) ekle");
        //    Console.WriteLine("4) güncelleme");
        //    int a = Convert.ToInt32(Console.ReadLine());
        //    if (a>1)
        //    {
        //        Console.WriteLine("name");
        //        var name = Console.ReadLine();
        //        Random random = new Random();
        //        Console.WriteLine("id");
        //        var ıd = Convert.ToInt32(Console.ReadLine());
        //        var unitStock = random.Next(1000);
        //        Console.WriteLine("unit price");
        //        var price = Convert.ToInt32(Console.ReadLine());
        //        p.ProductId = ıd;
        //        p.UnitsInStokc = (short)unitStock;
        //        p.ProductName = name;
        //        p.UnitPrice = price;
        //        p.CategoryId = 1;

        //    }
        //    switch (a)
        //    {
        //        case 1:
        //            Listele();
        //            break;
        //        case 2:
        //            Delete(p);
        //            break;
        //        case 3:
        //            Add(p);
        //            break;
        //        case 4:
        //            Update(p);
        //            break;
        //        default:
        //            isRun = false;
        //            continue;

        //    }
        //}
        #endregion

    }

    private static void CategoryTest()
    {
        CategoryManager category = new CategoryManager(new EfCategoryDal());
        foreach (var item in category.GetAll())
        {
            Console.WriteLine(item.CategoryName);
        }
    }

    private static void ProductTest()
    {
        ProductManager productDal = new(new EfProductDal());
        foreach (var item in productDal.GetAllByCategoryId(2))
        {
            Console.WriteLine(item.ProductName);
        }
    }
    #region
    //static void Add(Product product)
    //{
    //    productDal.Add(product);
    //}
    //static void Delete(Product product)
    //{
    //    productDal.Delete(product);
    //}
    //static void Listele()
    //{
    //    foreach (var item in productDal.GetAll())
    //    {
    //        Console.WriteLine(item.ProductName);
    //    }
    //}
    //static void Update(Product product)
    //{
    //    productDal.Update(product);
    //}
    #endregion
}
