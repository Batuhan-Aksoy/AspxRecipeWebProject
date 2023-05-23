using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RecipeContentDTO : IDTO
    {
        public int ContentId { get; set; }
        public string ContentName { get; set; }
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }

    }
}
