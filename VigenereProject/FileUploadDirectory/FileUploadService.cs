namespace VigenereProject.FileUploadDirectory
{
    public class FileUploadService : IFileUpload
    {
        private readonly IWebHostEnvironment appEnvironment;

        public FileUploadService(IWebHostEnvironment environment)
        {
            appEnvironment = environment;
        }

        public async Task<string> UploadFileAsync(IFormFile file)
        {
            if (file != null && file.Length > 0 && Path.GetExtension(file.FileName).Length>0)
            {
                var dirPath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Files");
                DeliteBeforeProcessing.Delite(dirPath);
                var filePath = Path.Combine(dirPath,file.FileName);
                using FileStream fileStream = new FileStream(filePath, FileMode.Create);
                try
                {
                    await file.CopyToAsync(fileStream);
                    fileStream.Close();
                }
                finally { fileStream.Close(); }
                if (File.Exists(filePath)) { return filePath; }
            }
            return "error";
        }
    }
}
