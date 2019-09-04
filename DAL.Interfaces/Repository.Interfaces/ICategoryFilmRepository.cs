using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interfaces.Repository.Interfaces.Base;
using DAL.Interfaces.Models;

namespace DAL.Interfaces.Repository.Interfaces
{
  public  interface ICategoryFilmRepository : IBaseRepository<CategoryFilm,Guid>
    {
    }
}
