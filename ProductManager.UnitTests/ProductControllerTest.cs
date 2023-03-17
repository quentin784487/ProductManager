using Microsoft.AspNetCore.Mvc;
using Web.API.Controllers;

namespace ProductManager.UnitTests
{
    public class ProductControllerTest
    {
        private readonly ProductController _controller;

        public ProductControllerTest()
        {
            _controller = new ProductController();
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
