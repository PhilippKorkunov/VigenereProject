using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VigenereProject.Pages
{
    public class EncryptionResultModel : PageModel
    {
        public FileContentResult OnGet()
        {
            var dirPath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Files");
            var filePath = Path.Combine(dirPath, "output.txt");
            if (System.IO.File.Exists(filePath))
            {
                return File(System.IO.File.ReadAllBytes(filePath), "application/octet-stream", "Result.txt");
            }
            else
            {
                filePath = Path.Combine(dirPath, "output.docx");
                return File(System.IO.File.ReadAllBytes(filePath), "application/octet-stream", "Result.docx");
            }
        }
        
    }
}
