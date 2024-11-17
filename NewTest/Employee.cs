using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTest
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }

    public class EmployeeService
    {
        private List<Employee> _employees = new List<Employee>();

        public void ThemNhanVien(Employee employee)
        {
            _employees.Add(employee);
        }

        public List<Employee> LayDanhSachNhanVien()
        {
            return _employees;
        }

        public void SuaNhanVien(int id, Employee employeeMoi)
        {
            var employee = _employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                employee.FirstName = employeeMoi.FirstName;
                employee.LastName = employeeMoi.LastName;
                employee.Email = employeeMoi.Email;
            }
        }

        public void XoaNhanVien(int id)
        {
            var employee = _employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                _employees.Remove(employee);
            }
        }
    }

}
