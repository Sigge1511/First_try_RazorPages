using System.ComponentModel.DataAnnotations;

namespace to_do_razor_v22.Data
{
    public class Student
    {
        [Required(ErrorMessage = "First name is required")]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters long")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last name is required")]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters long")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address format")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Age is required")]
        [Range(18, 100, ErrorMessage = "Age must be between 18 and 100")]
        public int Age { get; set; }


        [Required]
        public string Course { get; set; }


        //behöver ev inte skriva ut en tom ctor??
        public Student()
        {
            
        }
    }
}
