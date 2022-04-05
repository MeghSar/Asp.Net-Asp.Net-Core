using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePOC.WebApi.Model
{
    public class EmployeeTable
    {
        [Key]
        [Required]
        public int EmpId { get; set; }

        [StringLength(50)]
        [Required]
        public string EmpName { get; set; }

        [StringLength(50)]
        [Required]
        public string EmpContact { get; set; }

        [StringLength(50)]
        [Required]
        public string EmpEmailId { get; set; }

        [StringLength(250)]
        [Required]
        public string EmpAddress { get; set; }
    }
}
