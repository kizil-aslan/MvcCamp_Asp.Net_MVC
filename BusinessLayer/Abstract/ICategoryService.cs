﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> List();
        void CategoryAdd(Category category);
        Category GetByID(int id);
        void DeleteCategory(Category category);
        void CategoryUpdate(Category category);
    }
}
