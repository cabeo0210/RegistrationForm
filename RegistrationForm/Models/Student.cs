using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationForm.Models
{
    public class Student
    {
        private String name;
        private String email;
        private String phone;
        private bool hasGraduate;

        [Required(ErrorMessage = "Plese Enter Your Name!")]
        public string Name { get => name; set => name = value; }

        [Required(ErrorMessage = "Plese Enter Your Email!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get => email; set => email = value; }

        [Required(ErrorMessage = "Plese Enter Your Phone!")]

        public string Phone { get => phone; set => phone = value; }
        [Required(ErrorMessage = "Plese choose if you are graduate or not")]

        public bool? HasGraduate { get; set; }
    }
}
