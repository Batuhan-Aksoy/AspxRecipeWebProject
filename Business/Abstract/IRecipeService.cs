using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRecipeService
    {
        List<RecipeCategoryDTO> GetAll();
        List<RecipeCategoryDTO> GetRecipeByCategoryId(int categoryId);
        Recipe GetRecipeById(int recipeId);
        void Delete(Recipe recipe);
        void Update(Recipe recipe);
        void Add(Recipe recipe);
    }
}
