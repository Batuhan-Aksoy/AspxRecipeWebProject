using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IContentService
    {
        List<RecipeContentDTO> GetContentsByRecipeId(int recipeId);
        Content GetContentById(int contentId);
        void Add(Content content);
        void Update(Content content);

        void Delete(Content content);
    }
}
