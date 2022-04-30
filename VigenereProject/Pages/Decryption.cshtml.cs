using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VigenereProject.FileUploadDirectory;

namespace VigenereProject.Pages
{
    public class DecryptionModel : EncryptionModel
    {
        public DecryptionModel(ILogger<PrivacyModel> logger, IFileUpload fileUpload) : base(logger, fileUpload)
        {
            this.isEncryption = false;
        }

       
    }
}

