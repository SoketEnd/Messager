using Messager.DAL.Repositori;

namespace Messager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ActionRepository action = new();

            action.Altion();
        }
    }
}
