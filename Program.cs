using OpenQA.Selenium;
using Mype.ConsoleMvc;
using System.Text;

namespace Slave
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Application application = new();
            application.AddController<SeleniumController>();
            application.Run();

        }
    }
}
