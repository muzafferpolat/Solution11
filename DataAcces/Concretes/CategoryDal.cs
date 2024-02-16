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
        
        
        public void Add()
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
