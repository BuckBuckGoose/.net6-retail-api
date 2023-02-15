using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Retail.Domain;
using Retail.Domain.Exceptions;
using Retail.DTO.Output;
using Retail.DTO.Input;
using Retail.Services.ProductService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Retail.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, ILogger<ProductController> logger, IMapper mapper)
        {
            _productService = productService;
            _logger = logger;
            _mapper = mapper;
        }

        // GET: api/<ProductController>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Product>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllAsync()
        {
            var response =  await _productService.GetProductsAsync();
            if (response == null)
            {
                return NotFound();
            }

            var mappedResponse = _mapper.Map<IEnumerable<DisplayProductDto>>(response);
            return Ok(mappedResponse);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _productService.GetProductAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            var mappedResult = _mapper.Map<DisplayProductDto>(result);
            return Ok(mappedResult);
            
        }

        // POST api/<ProductController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task Post(CreateProductDto createdProductDto)
        {

            //_productService.AddProductAsync(product);
            await Task.Delay(1);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task Put(int id, [FromBody] string value)
        {
            await Task.Delay(1);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task Delete(int id)
        {
            await Task.Delay(1);
        }
    }
}
