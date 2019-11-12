using System.Threading.Tasks;
using Xunit;

namespace ConsoleAppWithDI.Test
{
    public class TestServiceShould
    {
        [Fact]
        public async Task ShouldSayHello()
        {
            var sut = new TestService();

            var testValue = "from test";

            var result = await sut.SayHello(testValue);

            Assert.Equal($"TestService {testValue}", result);
        }
    }
}

