using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces.Models
{
  public  class FilmModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<CategoryFilmModel> CategoryFilms { get; set; }
    }
}
