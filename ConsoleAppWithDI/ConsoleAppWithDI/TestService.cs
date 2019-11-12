using System.Threading.Tasks;

namespace ConsoleAppWithDI
{
    public class TestService : ITestService
    {
        public async Task<string> SayHello(string helloFrom)
        {
            await Task.CompletedTask;

            return $"TestService {helloFrom}";
        }
    }
}
