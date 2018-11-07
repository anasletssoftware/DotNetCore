using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImadErp.Data;
using ImadErp.Model;

namespace ImadErp.Services.HR
{
    public class JobService : IJob
    {
        private ERPDbContext db;
        public JobService(ERPDbContext db)
        {
            this.db = db;
        }


        public IEnumerable<Job> GetAll()
        {
            return db.Jobs.OrderBy(x => x.Job_Title);
        }

        public Job GetById(int id)
        {
            return db.Jobs.Find(id);
        }

        public void Insert(Job Jobs)
        {
            db.Jobs.Add(Jobs);
            db.SaveChanges();
        }

        public void Update(Job Jobs)
        {
            db.Jobs.Update(Jobs);
            db.SaveChanges();
        }
    }
}
