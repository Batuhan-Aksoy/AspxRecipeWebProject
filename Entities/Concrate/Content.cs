using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class Content : IEntity
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public string Name { get; set; }

    }
}
