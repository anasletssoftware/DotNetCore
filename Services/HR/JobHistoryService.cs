using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImadErp.Data;
using ImadErp.Model;

namespace ImadErp.Services.HR
{
    public class JobHistoryService : IJobHistroy
    {
        private readonly ERPDbContext db;
        public JobHistoryService(ERPDbContext db)
        {
            this.db = db;
        }

        public JobHistory GetById(int id)
        {
            return db.JobHistories.Find(id);
        }

        public IEnumerable<JobHistory> GetJobHistories()
        {
            return db.JobHistories;
        }

        public void Insert(JobHistory Jobs)
        {
            db.JobHistories.Add(Jobs);
            db.SaveChanges();
        }

        public void Update(JobHistory Jobs)
        {
            db.JobHistories.Update(Jobs);
            db.SaveChanges();
        }
    }
}
