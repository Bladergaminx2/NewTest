using NewTest;
using NUnit.Framework;
using System.Linq;

namespace TestProject
{
    public class EmployeeTests
    {
        private EmployeeService _service;

        [SetUp]
        public void Setup()
        {
            _service = new EmployeeService();
        }

        [Test]
        public void TestThemNhanVien()
        {
            var employee = new Employee { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com" };
            _service.ThemNhanVien(employee);
            var employeeThem = _service.LayDanhSachNhanVien().FirstOrDefault(e => e.Id == 1);

            Assert.That(employeeThem, Is.Not.Null, "Nhân viên không được thêm thành công.");
            Assert.That(employeeThem.FirstName, Is.EqualTo(employee.FirstName), "Tên nhân viên không khớp.");
        }

        [Test]
        public void TestSuaNhanVien()
        {
            var employee = new Employee { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com" };
            _service.ThemNhanVien(employee);
            var employeeMoi = new Employee { FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com" };
            _service.SuaNhanVien(1, employeeMoi);
            var employeeSua = _service.LayDanhSachNhanVien().FirstOrDefault(e => e.Id == 1);

            Assert.That(employeeSua, Is.Not.Null, "Nhân viên không tồn tại sau khi sửa.");
            Assert.That(employeeSua.FirstName, Is.EqualTo(employeeMoi.FirstName), "Tên mới không khớp.");
            Assert.That(employeeSua.LastName, Is.EqualTo(employeeMoi.LastName), "Họ mới không khớp.");
            Assert.That(employeeSua.Email, Is.EqualTo(employeeMoi.Email), "Email mới không khớp.");
        }

        [Test]
        public void TestXoaNhanVien()
        {
            var employee = new Employee { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com" };
            _service.ThemNhanVien(employee);
            _service.XoaNhanVien(1);
            var employeeXoa = _service.LayDanhSachNhanVien().FirstOrDefault(e => e.Id == 1);

            Assert.That(employeeXoa, Is.Null, "Nhân viên không được xóa thành công.");
        }
    }
}
