using BlogApp.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Services.Interfaces
{
    public  interface IBrandService
    {
        Task<ICollection<Brand>> GetAllAsync(Expression<Func<Brand, bool>>? expression = null,
            Expression<Func<Brand, object>>? OrderByExpression = null,
            bool isDescending = false
            , params string[] includes);
    }
}
