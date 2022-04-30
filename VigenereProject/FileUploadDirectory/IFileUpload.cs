namespace VigenereProject.FileUploadDirectory
{
    public interface IFileUpload
    {
        Task<string> UploadFileAsync(IFormFile file); 
    }
}
