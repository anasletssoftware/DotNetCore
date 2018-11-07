using ImadErp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImadErp.Services.HR
{
    public interface IJob
    {
        IEnumerable<Job> GetAll();
        Job GetById(int id);
        void Insert(Job Jobs);
        void Update(Job Jobs);
    }
}
