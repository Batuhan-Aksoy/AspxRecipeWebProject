using DataAccess.Abstarct;
using DataAccess.Concrate.DBContext;
using DataAccess.Core.EfRepositoryBase;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrate.EfDAL
{
    public class EfContentDAL : EfRepositoryBase<Content, RecipeDBContext>, IContentDAL
    {
        public List<RecipeContentDTO> GetRecipeContentDetail()
        {
            using (RecipeDBContext context = new RecipeDBContext())
            {

                var result = from r in context.Recipes
                             join c in context.Contents
                             on r.Id equals c.RecipeId
                             select new RecipeContentDTO()
                             {
                                 RecipeId = r.Id,
                                 RecipeName = r.Name,
                                 ContentId = c.Id,
                                 ContentName = c.Name
                             };

                return result.ToList();
            }
        }
    }
}
