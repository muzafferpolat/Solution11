using Business.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager : IBaseServices
    {
        public void Add()
        {
            Console.WriteLine("CourseManager çalıştı");
        }

        public void Delete()
        {
            Console.WriteLine("CourseManager çalıştı");
        }

        public void GetAll()
        {
            Console.WriteLine("CourseManager çalıştı");
        }

        public void Update()
        {
            Console.WriteLine("CourseManager çalıştı");
        }
    }
}
