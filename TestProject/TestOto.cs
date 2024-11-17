using NUnit.Framework;
using System.Linq;
using NewTest;

namespace TestProject
{
    public class TestOto
    {
        private XeOtoService _service;

        [SetUp]
        public void Setup()
        {
            _service = new XeOtoService();
        }

        [Test]
        public void TestThemXe()
        {
            var xe = new Oto { Ma = 1, Ten = "Toyota", Gia = 500000, Ghichu = "Mới" };
            _service.ThemXe(xe);
            var xeThem = _service.LayDanhSachXe().FirstOrDefault(x => x.Ma == 1);

            Assert.That(xeThem, Is.Not.Null, "Xe không được thêm thành công.");
            Assert.That(xeThem.Ten, Is.EqualTo(xe.Ten), "Tên xe không đúng.");
            Assert.That(xeThem.Gia, Is.EqualTo(xe.Gia), "Giá xe không đúng.");
        }

        [Test]
        public void TestSuaXe()
        {
            var xe = new Oto { Ma = 1, Ten = "Toyota", Gia = 500000, Ghichu = "Mới" };
            _service.ThemXe(xe);
            var xeMoi = new Oto { Ten = "Honda", Gia = 600000, Ghichu = "Cũ" };
            _service.SuaXe(1, xeMoi);
            var xeSua = _service.LayDanhSachXe().FirstOrDefault(x => x.Ma == 1);

            Assert.That(xeSua, Is.Not.Null, "Xe không tồn tại sau khi sửa.");
            Assert.That(xeSua.Ten, Is.EqualTo(xeMoi.Ten), "Tên xe sau khi sửa không đúng.");
            Assert.That(xeSua.Gia, Is.EqualTo(xeMoi.Gia), "Giá xe sau khi sửa không đúng.");
            Assert.That(xeSua.Ghichu, Is.EqualTo(xeMoi.Ghichu), "Ghi chú sau khi sửa không đúng.");
        }

        [Test]
        public void TestXoaXe()
        {
            var xe = new Oto { Ma = 1, Ten = "Toyota", Gia = 500000, Ghichu = "Mới" };
            _service.ThemXe(xe);
            _service.XoaXe(1);
            var xeXoa = _service.LayDanhSachXe().FirstOrDefault(x => x.Ma == 1);

            Assert.That(xeXoa, Is.Null, "Xe không được xóa thành công.");
        }
    }
}
