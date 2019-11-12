using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWithDI
{
    public interface ITestManager
    {
        Task Run();

        Task<string> HelloTestService();
    }
}
