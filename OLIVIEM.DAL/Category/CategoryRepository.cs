using OLIVIEM.DAL.Category;
using System;
using System.Collections.Generic;
using System.Text;

namespace OLIVIEM.DAL.Category
{
   public class CategoryRepository
    {
        private ICategorycontext context;

        public CategoryRepository(ICategorycontext Context)
        {
            context = Context;
        }
    }
}
