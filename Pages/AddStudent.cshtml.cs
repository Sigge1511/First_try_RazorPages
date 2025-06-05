using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using to_do_razor_v22.Data;

namespace to_do_razor_v22.Pages
{
    public class AddStudentModel : PageModel
    {
        [BindProperty]
        public Student Student { get; set; }
        
        public List<SelectListItem> CourseOptions { get; set; }

        public static List<Data.Student> StudentsList = new List<Data.Student>();
        public List<Data.Student> CurrentStudents => StudentsList;



        public void OnGet()
        {
            CourseOptions = CourseList();
            Console.WriteLine("Courses in OnGet: " + CourseOptions.Count);
        }

        public IActionResult OnPostCreate()
        {
            CourseOptions = CourseList();
            Console.WriteLine("Courses in OnGet: " + CourseOptions.Count);

            if (!ModelState.IsValid)
            {
                return Page();
            }

            StudentsList.Add(Student);

            TempData["SuccessMessage"] = "Tack, ny student sparad!";

            return RedirectToPage("AddStudent");
        }


        public List<SelectListItem> CourseList()
        {
            List<SelectListItem> CourseOptions = new List<SelectListItem>
            {
                new SelectListItem { Value = "Matte", Text = "Matte" },
                new SelectListItem { Value = "Naturvetenskap", Text = "Naturvetenskap" },
                new SelectListItem { Value = "Historia", Text = "Historia" },
                new SelectListItem { Value = "Litteratur", Text = "Litteratur" }
            };
            return CourseOptions;
        }




    }
}
