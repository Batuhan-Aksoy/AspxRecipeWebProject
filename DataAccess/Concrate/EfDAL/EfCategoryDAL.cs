using DataAccess.Abstarct;
using DataAccess.Concrate.DBContext;
using DataAccess.Core.EfRepositoryBase;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrate.EfDAL
{
    public class EfCategoryDAL : EfRepositoryBase<Category, RecipeDBContext>, ICategoryDAL
    {

    }
}
