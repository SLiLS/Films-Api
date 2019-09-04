using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interfaces.Models;
using DAL.Interfaces.Repository.Interfaces.Base;

namespace DAL.Interfaces.Repository.Interfaces
{
    interface ICategoryRepository : IBaseRepository<Category, Guid>
    {
    }
}
