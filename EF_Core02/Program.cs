using EF_Core02.Contexts;

namespace EF_Core02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using EventHubContext dbContext = new EventHubContext();
        }
    }
}
