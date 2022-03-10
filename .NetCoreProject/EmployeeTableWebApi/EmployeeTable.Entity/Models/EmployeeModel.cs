using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EmployeeTable.Entity.Models
{
    public class EmployeeModel
    {
        [Key]
        [Required]
        public int EmpID { get; set; }

        [StringLength(50)]
        [Required]
        public string EmpName { get; set; }

        [StringLength(50)]
        [Required]
        public string EmpContact { get; set; }

        [StringLength(50)]
        [Required]
        public string EmpEmailID { get; set; }

        [StringLength(250)]
        [Required]
        public string EmpAddress { get; set; }

    }
}
