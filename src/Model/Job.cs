using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImadErp.Model
{
    public class Job : BaseEntity
    {
        [Key]
        public int JobId { get; set; }
        public string Job_Title { get; set; }
        public decimal Min_Salary { get; set; }
        public decimal Max_Salary { get; set; }
        
    }
}
