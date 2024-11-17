using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTest
{
    public class Oto
    {
        public int Ma { get; set; }
        public string Ten { get; set; }
        public decimal Gia { get; set; }
        public string Ghichu { get; set; }
    }

    public class XeOtoService
    {
        private List<Oto> xeOtos = new List<Oto>();

        public void ThemXe(Oto xe)
        {
            xeOtos.Add(xe);
        }

        public List<Oto> LayDanhSachXe()
        {
            return xeOtos;
        }

        public void SuaXe(int ma, Oto xeMoi)
        {
            var xe = xeOtos.FirstOrDefault(x => x.Ma == ma);
            if (xe != null)
            {
                xe.Ten = xeMoi.Ten;
                xe.Gia = xeMoi.Gia;
                xe.Ghichu = xeMoi.Ghichu;
            }
        }

        public void XoaXe(int ma)
        {
            var xe = xeOtos.FirstOrDefault(x => x.Ma == ma);
            if (xe != null)
            {
                xeOtos.Remove(xe);
            }
        }
    }
}
