using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTest
{
    public class Hieu4PT
    {
        private int[] Numbers { get; set; }

        public Hieu4PT(int a, int b, int c, int d)
        {
            Numbers = new int[] { a, b, c, d };
        }

        public int TinhTongHieu()
        {
            int hieu = Numbers[0];
            for (int i = 1; i < Numbers.Length; i++)
            {
                hieu -= Numbers[i];
            }
            return hieu;
        }
    }
}
