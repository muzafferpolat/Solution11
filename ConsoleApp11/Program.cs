using Business.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Category category = new Category();
            category.Id = 1;
            CategoryManager categoryManager = new CategoryManager();
            categoryManager.Add(category);
            Console.ReadLine();
        }
    }
}
