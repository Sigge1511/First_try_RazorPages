using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using to_do_razor_v22.Data;


namespace to_do_razor_v22.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public static List<Note> NotesList { get; set; } = new(); /*jag skapar en ny statisk lista direkt, ska ej kunna finnas flera av denna*/


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            
        }
        
        public void OnGet()
        {

        }
        public IActionResult OnPostAdd(string newNote) 
        { 
            Note newnote = new Note() { NoteText = newNote, IsDone = false };
            NotesList.Add(newnote);
            return RedirectToPage("Index");
        }
        public IActionResult OnPostDelete(string noteText)
        {
            var noteToRemove = NotesList.FirstOrDefault(n => n.NoteText == noteText);
            if (noteToRemove != null)
            {
                NotesList.Remove(noteToRemove);
            }
            return RedirectToPage();
        }

        public IActionResult OnPostToggleIsDone(string noteText)
        {
            var note = NotesList.FirstOrDefault(n => n.NoteText == noteText);
            if (note != null)
            {
                note.IsDone = true;
            }
            return RedirectToPage();
        }

    }
}
