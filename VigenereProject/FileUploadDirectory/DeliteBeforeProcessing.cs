namespace VigenereProject
{
    public class DeliteBeforeProcessing
    {
        public static void Delite(string dirPath)
        {
            if (Directory.Exists(dirPath))
            {
                Directory.Delete(dirPath, true);
            }
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
        }
    }
}
