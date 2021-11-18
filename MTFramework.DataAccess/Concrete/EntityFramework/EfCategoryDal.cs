using MTFramework.Core.DataAccess.EntityFramework;
using MTFramework.DataAccess.Abstract;
using MTFramework.DataAccess.Concrete.EntityFramework.Contexts;
using MTFramework.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTFramework.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal: EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}
