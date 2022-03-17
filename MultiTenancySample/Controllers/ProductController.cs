using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MultiTenancy.RestfulApi.DTOs;
using System.Threading.Tasks;

namespace MultiTenancy.RestfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateProductRequestDto request)
        {
            return Ok(await _service.CreateAsync(request.Name, request.Description, request.Rate));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            return Ok(await _service.GetByIdAsync(id));
        }
    }
}
