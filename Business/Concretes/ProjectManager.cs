using Business.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ProjectManager
    {
        public void Add(IBaseServices baseServices) 
        {
            baseServices.Add();
            Console.WriteLine("ProjectManager çalıştı");
        }
        public void Update(IBaseServices baseServices)
        {
            baseServices.Update();
            Console.WriteLine("ProjectManager çalıştı");
        }
        public void Delete(IBaseServices baseServices)
        {
            baseServices.Delete();
            Console.WriteLine("ProjectManager çalıştı");
        }
        public void GetAll(IBaseServices baseServices)
        {
            baseServices.GetAll();
            Console.WriteLine("ProjectManager çalıştı");
        }
    }
}
