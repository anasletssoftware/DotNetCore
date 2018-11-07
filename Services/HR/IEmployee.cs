using ImadErp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImadErp.Services.HR
{
    public interface IEmployee
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        void Insert(Employee Emp);
        void Update(Employee Emp);
       
    }
}
