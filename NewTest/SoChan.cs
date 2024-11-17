using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTest
{
    public class SoChan
    {
        public List<int> TimSoChan(List<int> numbers)
        {
            return numbers.Where(n => n % 2 == 0).ToList();
        }
    }
}
