using System;

namespace VendingConsoleApp
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var vm = new VendingMachine();
            vm.Run();
        }
    }
}