using DataAccess.Core;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstarct
{
    public interface IContentDAL : IEntityRepositoryBase<Content>
    {
        List<RecipeContentDTO> GetRecipeContentDetail();
    }
}
