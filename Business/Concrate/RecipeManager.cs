using Business.Abstract;
using DataAccess.Abstarct;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Business.Concrate
{
    public class RecipeManager : IRecipeService
    {
        IRecipeDAL _recipeDAL;
        public RecipeManager(IRecipeDAL recipeDAL)
        {
            _recipeDAL = recipeDAL;
        }

        public void Add(Recipe recipe)
        {
            _recipeDAL.Add(recipe);
        }

        public void Delete(Recipe recipe)
        {
            _recipeDAL.Delete(recipe);
        }

        public List<RecipeCategoryDTO> GetAll()
        {
            return _recipeDAL.GetRecipeCategoryDetail();
        }

        public List<RecipeCategoryDTO> GetRecipeByCategoryId(int categoryId)
        {

            var recipes =  _recipeDAL.GetRecipeCategoryDetail();
            var result = from recipe in recipes
                         where recipe.CategoryId == categoryId
                         select recipe;
            return result.ToList();

        }

        public Recipe GetRecipeById(int recipeId)
        {
            return _recipeDAL.Get(r => r.Id == recipeId);
        }

        public void Update(Recipe recipe)
        {
            _recipeDAL.Update(recipe);
        }
    }
}
