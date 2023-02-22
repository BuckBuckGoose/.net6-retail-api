using AutoMapper;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using Retail.Api.Controllers;
using Retail.Api.Test.Fixtures;
using Retail.Domain.Models;
using Retail.DTO.Output;
using Retail.Services;
using System.Collections.Generic;

namespace Rental.Api.Test
{
    [TestFixture]
    public class TestProductController
    {
        #region GetAllAsyncTests


        private ILogger<ProductController> _logger;
        private IMapper _mapper;

        [SetUp]
        public void Setup()
        {
            _logger = new Mock<ILogger<ProductController>>().Object;
            _mapper = new Mock<IMapper>().Object;
        }

        [Test]
        public async Task GetAllProductsAsync_WhenSuccess_ShouldReturn200()
        {
            //Arrange
            var productServiceMock = new Mock<IProductService>();
            productServiceMock
                .Setup(service => service.GetAllProductsAsync())
                .ReturnsAsync(ProductFixture.GetTestProducts());

            var loggerMock = new Mock<ILogger<ProductController>>();
            var mapperMock = new Mock<IMapper>();
            
            var sut = new ProductController(productServiceMock.Object, _logger, _mapper);

            //Act
            var result = await sut.GetAllAsync() as OkObjectResult;

            //Assert
            result.StatusCode.Should().Be(200);
        }

        [Test]
        public async Task GetAllProductsAsync_WhenSuccess_InvokesServiceOnlyOnce()
        {
            //Arrange
            var productServiceMock = new Mock<IProductService>();
            productServiceMock
                .Setup(service => service.GetAllProductsAsync())
                .ReturnsAsync(ProductFixture.GetTestProducts());

            var loggerMock = new Mock<ILogger<ProductController>>();
            var mapperMock = new Mock<IMapper>();

            var sut = new ProductController(productServiceMock.Object, _logger, _mapper);

            //Act
            var result = await sut.GetAllAsync();

            //Assert
            productServiceMock.Verify(service => service.GetAllProductsAsync(), Times.Once());
        }

        [Test]
        public async Task GetAllProductsAsync_WhenSuccess_ReturnsArrayOfProductsDTO()
        {
            //Arrange
            var productServiceMock = new Mock<IProductService>();
            productServiceMock
                .Setup(service => service.GetAllProductsAsync())
                .ReturnsAsync(ProductFixture.GetTestProducts());

            var loggerMock = new Mock<ILogger<ProductController>>();
            var mapperMock = new Mock<IMapper>();

            var sut = new ProductController(productServiceMock.Object, _logger, _mapper);

            //Act
            var result = await sut.GetAllAsync();

            //Assert
            result.Should().BeOfType<OkObjectResult>();
            var objectResult = (OkObjectResult) result;
            objectResult.Value.Should().BeOfType<DisplayProductDto[]>();
        }

        [Test]
        public async Task GetAllProductsAsync_WhenNoProducts_Return404()
        {
            //Arrange
            var productServiceMock = new Mock<IProductService>();
            productServiceMock
                .Setup(service => service.GetAllProductsAsync())
                .ReturnsAsync((IEnumerable<Product>)null);

            var loggerMock = new Mock<ILogger<ProductController>>();
            var mapperMock = new Mock<IMapper>();

            var sut = new ProductController(productServiceMock.Object, _logger, _mapper);

            //Act
            var result = await sut.GetAllAsync();

            //Assert
            result.Should().BeOfType<NotFoundResult>();
            var objectResult = (NotFoundResult) result;
            objectResult.StatusCode.Should().Be(404);
            
        }
        #endregion

        [Test]
        public async Task GetProductAsync_WhenSuccess_ShouldReturn200()
        {
            //Arrange
            var productServiceMock = new Mock<IProductService>();
            productServiceMock
                .Setup(service => service.GetProductAsync(It.IsAny<int>()))
                .ReturnsAsync(ProductFixture.GetSingleProduct());

            var loggerMock = new Mock<ILogger<ProductController>>();
            var mapperMock = new Mock<IMapper>();

            var sut = new ProductController(productServiceMock.Object, _logger, _mapper);

            //Act
            var result = (OkObjectResult)await sut.Get(1);

            //Assert
            result.StatusCode.Should().Be(200);
        }

        [Test]
        public async Task GetProductAsync_WhenNoProducts_Return404()
        {
            //Arrange
            var productServiceMock = new Mock<IProductService>();
            productServiceMock
                .Setup(service => service.GetProductAsync(It.IsAny<int>()))
                .ReturnsAsync((Product)null);

            var loggerMock = new Mock<ILogger<ProductController>>();
            var mapperMock = new Mock<IMapper>();

            var sut = new ProductController(productServiceMock.Object, _logger, _mapper);

            //Act
            var result = await sut.Get(1);

            //Assert
            result.Should().BeOfType<NotFoundResult>();
            var objectResult = (NotFoundResult)result;
            objectResult.StatusCode.Should().Be(404);

        }
    }
}