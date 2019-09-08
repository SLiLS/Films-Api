using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces.Models
{
   public class CategoryFilmModel
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public virtual CategoryModel Category { get; set; }
        public Guid FilmId { get; set; }
        public FilmModel Film { get; set; }
    }
}
