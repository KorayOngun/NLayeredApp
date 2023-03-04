

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

class Program
{
   // static bool  isRun = true;
    
    static void Main()
    {
        // Data Transformation Object
        //ProductTest();
        //CategoryTest();
        //ProductDetails();
    }

    private static void ProductDetails()
    {
        ProductManager manager = new ProductManager(new EfProductDal());
        var result = manager.GetProductDetails();
        if (result.Success == true) 
        {
            foreach (var item in result.Data )
            {
                Console.WriteLine($"{item.ProductName}/{item.CategoryName}");
            }
        }
        else
        {
            Console.WriteLine(result.Message); 
        }
       
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
        foreach (var item in productDal.GetAllByCategoryId(2).Data)
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
