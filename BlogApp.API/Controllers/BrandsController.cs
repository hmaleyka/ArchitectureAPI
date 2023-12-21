using BlogApp.Business.DTOs.BrandDto;
using BlogApp.Business.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _service;

        public BrandsController(IBrandService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var brands = await  _service.GetAllAsync();
            return StatusCode(StatusCodes.Status200OK,brands);

        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var brands = await _service.GetByIdAsync(id);
            return StatusCode(StatusCodes.Status200OK, brands);
        }
        [HttpPost] 
        public async Task<IActionResult> Create ([FromForm]CreateBrandDto brandDto)
        {
            await _service.Create(brandDto);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut]
        public async Task<IActionResult> Update(int id , [FromForm]UpdateBrandDto brandDto)
        {
            await _service.Update(id, brandDto);
            return StatusCode(StatusCodes.Status200OK);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return StatusCode(StatusCodes.Status200OK);
        }

    }
}
