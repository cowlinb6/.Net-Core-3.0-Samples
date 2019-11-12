using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWithDI
{
    public interface ITestService
    {
        Task<string> SayHello(string helloFrom);
    }
}
