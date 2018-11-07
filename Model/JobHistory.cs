using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImadErp.Model
{
    public class JobHistory:BaseEntity
    {
        [Key]
        public int JobHistoryId { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employees { get; set; }
        public int DepartmentId { get; set; }
        public Department Departments { get; set; }
        public int JobId { get; set; }
        public Job Jobs { get; set; }
        public string Hire_Date { get; set; }
        public string End_Date { get; set; }

    }
}
