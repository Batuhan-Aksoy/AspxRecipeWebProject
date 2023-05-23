using DataAccess.Abstarct;
using DataAccess.Concrate.DBContext;
using DataAccess.Core.EfRepositoryBase;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrate.EfDAL
{
    public class EfRecipeDAL : EfRepositoryBase<Recipe, RecipeDBContext>, IRecipeDAL
    {
        public List<RecipeCategoryDTO> GetRecipeCategoryDetail()
        {
            using (RecipeDBContext context = new RecipeDBContext())
            {

                return (from r in context.Recipes
                        join c in context.Categories
                        on r.CategoryId equals c.Id
                        select new RecipeCategoryDTO()
                        {
                            Id = r.Id,
                            Name = r.Name,
                            CategoryName = c.Name,
                            CreatedBy = r.CreatedBy,
                            CreatedDate = r.CreatedDate,
                            CategoryId = c.Id
                        }).ToList();

            }
        }

       
    }
}
