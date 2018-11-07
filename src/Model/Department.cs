using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImadErp.Model
{
    public class Department :BaseEntity
    {
        [Key]
        public int DepartmentId { get; set; }
        public string Department_Name { get; set; }

    }
}
