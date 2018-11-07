using ImadErp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImadErp.Services.HR
{
   public interface IDepartment
    {
        IEnumerable<Department> GetAll();
        Department GetById(int id);
        void Insert(Department Emp);
        void Update(Department Emp);
    }
}
