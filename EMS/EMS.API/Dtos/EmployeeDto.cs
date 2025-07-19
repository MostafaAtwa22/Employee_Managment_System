using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.API.Dtos
{
    public class EmployeeDto
    {
        [Required]
        public int Id { get; set; }

        public string EmployeeIdField
        {
            get
            {
                return "EMP" + Id.ToString("D5");
            }
        }

        [MinLength(3), MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [MinLength(3), MaxLength(50)]
        public string Department { get; set; } = string.Empty;

        public DateTime DateOfBirth { get; set; }

        [Range(18, 65)]
        public int Age { get; set; }

        [MaxLength(15), MinLength(10)]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}