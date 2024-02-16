using Business.Abstracts;
using DataAcces.Concretes;
using Entities.Concretes;
using System;

namespace Business.Concretes
{
    public class CategoryManager : IBaseServices
    {
        CategoryDal categoryDal;
        public CategoryManager() => categoryDal = new CategoryDal();
        public void Add(Category category)
        {
            Console.WriteLine("CategoryManager çalıştı");
            categoryDal.Add(category);
        }
        public void Delete()
        {
            Console.WriteLine("CategoryManager çalıştı");
        }
        public void GetAll()
        {
            Console.WriteLine("CategoryManager çalıştı");
        }
        public void Update()
        {
            Console.WriteLine("CategoryManager çalıştı");
        }
    }
}
