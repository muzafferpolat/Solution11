using DataAcces.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        Category category;
        MQL.MBASE _mBase;
        public CategoryDal()
        {
            category = new Category();
            _mBase = new MQL.MBASE();
        }
        
        public void Add(Category category)
        {
            Console.WriteLine("Added");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted");
        }

        public void GetAll()
        {
            Console.WriteLine("Listed");
        }

        public void Update()
        {
            Console.WriteLine("Updated");
        }
    }
}
