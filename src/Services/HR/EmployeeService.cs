using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImadErp.Data;
using ImadErp.Model;

namespace ImadErp.Services.HR
{
    public class EmployeeService : IEmployee
    {
        private ERPDbContext db;
        public EmployeeService(ERPDbContext db)
        {
            this.db = db;
        }
       

        public IEnumerable<Employee> GetAll()
        {
            return db.Employees; 
        }

        public Employee GetById(int id)
        {
            Employee Emp = new Employee();
            return db.Employees.Find(id);
        }

        public void Insert(Employee Emp)
        {
            Emp.IsActive = true;
            Emp.IsDeleted = false;
            Emp.CreatedOn = System.DateTime.Now.Date.ToString("dd/MM/yyyy");
            db.Employees.Add(Emp);
            db.SaveChanges();
        }

        public void Update(Employee Emp)
        {
            Emp.CreatedOn = System.DateTime.Now.Date.ToString("dd/MM/yyyy");
            db.Employees.Update(Emp);
            db.SaveChanges();
        }
        
    }
}
