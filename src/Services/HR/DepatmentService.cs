using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImadErp.Data;
using ImadErp.Model;

namespace ImadErp.Services.HR
{
    public class DepatmentService : IDepartment
    {
        private ERPDbContext db;
        public DepatmentService(ERPDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<Department> GetAll()
        {
            return db.Departments;
        }

        public Department GetById(int id)
        {
            return db.Departments.Find(id);
        }

        public void Insert(Department Emp)
        {
            db.Departments.Add(Emp);
            db.SaveChanges();
        }

        public void Update(Department Emp)
        {
            db.Departments.Update(Emp);
            db.SaveChanges();
        }
    }
}
