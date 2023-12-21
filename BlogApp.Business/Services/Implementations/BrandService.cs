using BlogApp.Business.Services.Interfaces;
using BlogApp.Core.Entities.Common;
using BlogApp.DAL.Repositories.Implementations;
using BlogApp.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Services.Implementations
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _repo;

        public BrandService(IBrandRepository repo)
        {
            _repo = repo;
        }
        public async Task<ICollection<Brand>> GetAllAsync(Expression<Func<Brand, bool>>? expression = null,
            Expression<Func<Brand, object>>? OrderByExpression = null,
            bool isDescending = false
            , params string[] includes)
        {
           var brands = await _repo.GetAllAsync();
            return await brands.ToListAsync();
        }

    }
}
