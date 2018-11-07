using ImadErp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImadErp.Services.HR
{
    public interface IJobHistroy
    {
        IEnumerable<JobHistory> GetJobHistories();
        JobHistory GetById(int id);
        void Insert(JobHistory Jobs);
        void Update(JobHistory Jobs);
    }
}
