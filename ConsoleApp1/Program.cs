using Business.Concrate;
using DataAccess.Concrate.EfDAL;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDAL());

            var result = categoryManager.GetCategories();
            foreach (var item in result)
            {
                Console.WriteLine(item.Name);

            }
            Console.ReadLine();
        }
    }
}
