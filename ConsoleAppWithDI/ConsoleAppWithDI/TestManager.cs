using System;
using System.Threading.Tasks;

namespace ConsoleAppWithDI
{
    public class TestManager : ITestManager
    {
        private readonly ITestService _testService;
    
        public TestManager(ITestService testService)
        {
            _testService = testService;
        }

        public async Task<string> HelloTestService()
        {
            return await _testService.SayHello("from TestManager");
        }

        public async Task Run()
        {
            Console.WriteLine(await HelloTestService());
        }
    }

}
