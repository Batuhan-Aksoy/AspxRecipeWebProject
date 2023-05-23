using Business.Abstract;
using DataAccess.Abstarct;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrate
{
    public class ContentManager : IContentService
    {
        IContentDAL _contentDAL;
        public ContentManager(IContentDAL contentDAL)
        {
            _contentDAL = contentDAL;
        }

        public void Add(Content content)
        {
            _contentDAL.Add(content);
        }

        public void Delete(Content content)
        {
            _contentDAL.Delete(content);
        }

        public Content GetContentById(int contentId)
        {
           return _contentDAL.Get(c => c.Id == contentId);
        }

        public List<RecipeContentDTO> GetContentsByRecipeId(int recipeId)
        {
            var contents =  _contentDAL.GetRecipeContentDetail();
            var result = from content in contents
                    where content.RecipeId == recipeId
                    select content;
            return result.ToList();
            
        }

        public void Update(Content content)
        {
            _contentDAL.Update(content);
        }
    }
}
