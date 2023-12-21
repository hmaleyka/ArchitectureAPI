using BlogApp.Business.DTOs.BrandDto;
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
        Task<ICollection<Brand>> GetAllAsync();

        Task<Brand> GetByIdAsync(int id);
        Task <Brand>Create(CreateBrandDto brand);
        Task<Brand>Update(int id, UpdateBrandDto brand);

        Task<Brand> Delete(int id);
        
    }
}
