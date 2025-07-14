using System.ComponentModel.DataAnnotations;

namespace EMS.Shared
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

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
