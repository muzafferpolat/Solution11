using Business.Abstracts;
using DataAcces.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryManager : IBaseServices
    {
        
        public void Add()
        {
            Console.WriteLine("CategoryManager çalıştı");
            
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
