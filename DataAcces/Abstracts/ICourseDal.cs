﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Abstracts
{
    public interface ICourseDal
    {
        void Add(Category category);
        void Update();
        void Delete();
        void GetAll();
    }
}
