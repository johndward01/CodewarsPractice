using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsPractice;
internal class Methods
{
    public static string EvenOrOdd(int number)
    {
        if (number % 2 == 0)
        {
            return "Even";
        }
        else
        {
            return "Odd";
        }
    }
}
