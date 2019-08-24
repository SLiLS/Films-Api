using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Implementation.Models
{
  public  class CategoryFilm
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public Guid FilmId { get; set; }
        public  Film Film { get; set; }
    }
}
