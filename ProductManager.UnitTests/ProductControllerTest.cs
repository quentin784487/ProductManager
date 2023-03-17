using Microsoft.AspNetCore.Mvc;
using ProductManager.CORE.Domain.Ports.Incoming;
using Web.API.Controllers;
using Xunit;

namespace ProductManager.UnitTests
{
    public class ProductControllerTest : IClassFixture<ProductController>
    {
        private readonly ProductController _controller;
        private readonly IGetProducts _getProducts;

        public ProductControllerTest(IGetProducts getProducts)
        {
            _getProducts = getProducts;
            _controller = new ProductController(_getProducts);
        }

        [Fact]
        public async void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = await _controller.Get();

            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }
    }
}
