using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQL
{
    public class MBASE
    {
        Category _category;
        List<Category> list;



        public MBASE()
        {
            list = new List<Category>();

        }
        public void Add(Category category)
        {
            Console.WriteLine("fgdfsgdf");
            list.Add(category);
        }
    }
}
