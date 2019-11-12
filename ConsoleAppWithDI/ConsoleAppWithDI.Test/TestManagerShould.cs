using Moq;
using System.Threading.Tasks;
using Xunit;

namespace ConsoleAppWithDI.Test
{
    public class TestManagerShould
    {
        [Fact]
        public async Task SayHelloTestService_Actual()
        {
            ITestService actualTestService = new TestService();
            var sut = new TestManager(actualTestService);
            var result = await sut.HelloTestService();

            Assert.Equal("TestService from TestManager", result);
        }

        [Fact]
        public async Task SayHelloTestService_Mock()
        {
            var mockTestService = new Mock<ITestService>();
            mockTestService.Setup(m => m.SayHello(It.IsAny<string>())).ReturnsAsync("MockTestService");

            var sut = new TestManager(mockTestService.Object);
            var result = await sut.HelloTestService();

            Assert.Equal("MockTestService", result);
        }

    }
}
