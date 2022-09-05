using System;
using System.ComponentModel.DataAnnotations;
namespace DoctorMangementSytem
{
    public class Doctor
    {
        [Required]
        [RegularExpression(@"[0-9]{7}",ErrorMessage ="Enter only digits")]
        public string registrationNo { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Enter only alphabets")]
        public string doctorName { get; set; }

        [Required]
        public string city { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Enter only alphabets")]
        public string areaOfSepecialization { get; set; }

        [Required]
        public string clinicAddress { get; set; }

        [Required]
        [RegularExpression(@"[a-zA-z0-9!@#$%^&*()_=+]", ErrorMessage = "Enter time")]
        public string clinicTime { get; set; }

        [Required]
        [RegularExpression(@"[0-9]{10}", ErrorMessage = "Enter only 10 digits")]
        public string contactNo { get; set; }


        
    }
    
}

