using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImadErp.Model
{
    public class Employee : BaseEntity
    {
        [Key]
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone_Number { get; set; }
        public string Hire_Date { get; set; }
        public string Salary { get; set; }


        public int   JobId { get; set; }   
        public Job Jobs { get; set; }

        public int DepartmentId { get; set; }
        public Department Departments { get; set; }


    }
}
