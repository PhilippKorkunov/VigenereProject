using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VigenereProject.FileUploadDirectory;

namespace VigenereProject.Pages
{
    public class EncryptionModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private readonly IFileUpload _fileUpload;
        public string FilePath { get; set; }
        public string FileEx { get; set; }
        public string FileKey { get; set; }
        public string FileVigenereText { get; set; }
        public string FileText { get; set; }

        public EncryptionModel(ILogger<PrivacyModel> logger, IFileUpload fileUpload)
        {
            _logger = logger;
            _fileUpload = fileUpload;
            this.isEncryption = true;
        }
        public void OnGet()
        {
        }

        public bool isEncryption = true;


        public async Task<IActionResult> OnPost(IFormFile file, string text)
        {
            FileKey = text;
            FilePath = await _fileUpload.UploadFileAsync(file);
            FileEx =  Path.GetExtension(FilePath);
            FileText = "";
            if (FilePath != "error" && KeyValidation.isValidated(FileKey))
            {
                if (FileEx == ".docx" || FileEx == ".doc")
                {
                    FileText = TextParse.WordParse(FilePath);
                    FileVigenereText = isEncryption ? VigenereChipper.Encryption(FileText, FileKey) : VigenereChipper.Decryption(FileText, FileKey);
                    TextParse.WordWrite(FilePath, FileVigenereText);
                    return RedirectToPage("EncryptionResult");
                }
                else if (FileEx == ".txt")
                {
                    FileText = TextParse.TxtParse(FilePath);
                    FileVigenereText = isEncryption ? VigenereChipper.Encryption(FileText, FileKey) : VigenereChipper.Decryption(FileText, FileKey);
                    TextParse.TxtWrite(FilePath, FileVigenereText);
                    return RedirectToPage("EncryptionResult");
                }
            }
            return null;
        }
    }
}
