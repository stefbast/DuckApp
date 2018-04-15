using System.Collections.Generic;

namespace Ducks
{
    class Program
    {
        static void Main()
        {
            var ducks = new List<Duck>
            {
                new Duck()
            };

            foreach (var duck in ducks)
            {
                duck.Quack();
            }
        }
    }
}
