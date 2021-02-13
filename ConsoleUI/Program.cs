using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLİD 
    //Open Closed Principled
    //Yeni bir özellik ekliyorsan mevcuttaki hiç bir koduna dokunamazsın.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------");
            ProductTest();
            //CategoryTest();

            Console.WriteLine("-----------------------");
            Console.ReadLine();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine("--->" + category.CategoryName + "<---");
            }
        }
        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + " / " + product.CategoryName);
                }
            }
            else
                Console.WriteLine(result.Message);
          
        }
    }
}
