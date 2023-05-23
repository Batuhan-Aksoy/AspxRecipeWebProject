using DataAccess.Core;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstarct
{
    public interface IRecipeDAL : IEntityRepositoryBase<Recipe>
    {
        List<RecipeCategoryDTO> GetRecipeCategoryDetail();
    }
}
