using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces.Models
{
   public class CategoryModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<CategoryFilmModel> CategoryFilms { get; set; }
    }
}
