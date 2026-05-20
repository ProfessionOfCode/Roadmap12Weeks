using Roadmap12Weeks.Weeks.week1;

namespace Roadmap12Weeks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var asyncAwaitmgmt = new AsyncAwaitManagement();
            var beforeResult = asyncAwaitmgmt.Before();
            var afterResult = asyncAwaitmgmt.After();
            var beforeAsyncResult = asyncAwaitmgmt.BeforeAsync().Result;
            var afterAsyncResult = asyncAwaitmgmt.AfterAsync().Result;
            Console.WriteLine(beforeResult);
            Console.WriteLine(afterResult);
            Console.WriteLine(beforeAsyncResult);
            Console.WriteLine(afterAsyncResult);
        }
    }
}
