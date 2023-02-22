using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Retail.Domain;
using Retail.Domain.Exceptions;
using Retail.DTO.Output;
using Retail.DTO.Input;
using Retail.Services;
using Retail.Domain.Models;


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
            var response =  await _productService.GetAllProductsAsync();
            if (response == null || response.Count() == 0)
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
        public async Task<IActionResult> Get([FromRoute] int id)
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
        public async Task<IActionResult> Post([FromBody]CreateProductDto createdProductDto)
        {
            var newProduct = _mapper.Map<Product>(createdProductDto);
            await _productService.AddProductAsync(newProduct);
            // Todo: Return the created object
            return CreatedAtAction(nameof(Get), new {id = newProduct.Id }, newProduct);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Put([FromRoute]int id, [FromBody]UpdateProductDto updateProductDto)
        {
            var product = _mapper.Map<Product>(updateProductDto);
            product.Id = id;
            await _productService.UpdateProductAsync(product);
            return Ok(product);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete([FromRoute]int id)
        {
            await _productService.DeleteProduct(id);
            return Ok();
        }
    }
}
