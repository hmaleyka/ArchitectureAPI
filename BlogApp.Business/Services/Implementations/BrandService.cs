using BlogApp.Business.DTOs.BrandDto;
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

        public async Task<ICollection<Brand>> GetAllAsync()
        {
           var brands = await _repo.GetAllAsync();
            return await brands.ToListAsync();
        }

        public async Task<Brand> GetByIdAsync(int id)
        {
            if (id <= 0) throw new Exception("Bad Request");
            var brand = await _repo.GetByIdAsync(id);
            if (brand == null) throw new Exception("Not Found");
            return brand;
        }
        public async Task<Brand> Create(CreateBrandDto createBrandDto)
        {
            if (createBrandDto == null) throw new Exception("Not null");
            Brand brand = new Brand()
            {
                Name = createBrandDto.Name,
            };
            await _repo.Create(brand);
            await _repo.SaveChangesAsync();
            return brand;
        }

        public async Task<Brand> Update(int id, UpdateBrandDto updateBrandDto)
        {
            var brand = await _repo.GetByIdAsync(id);
            if (brand == null) throw new Exception("Not Found");
            brand.Name = updateBrandDto.Name;
            _repo.Update(brand);
            await _repo.SaveChangesAsync();
            return brand;
        }

        public async Task<Brand> Delete(int id)
        {
            var brand = await _repo.GetByIdAsync(id);
            if (brand == null) throw new Exception("Not Found");
            _repo.Delete(brand);
            await _repo.SaveChangesAsync();
            return brand;
        }
    }
}
