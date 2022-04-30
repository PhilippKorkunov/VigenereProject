using Xceed.Words.NET;

namespace VigenereProject
{
    public class TextParse
    {
        public static string WordParse(string filePath)
        {
            string textForEditor = "";
            try
            {
                DocX doc = DocX.Load(filePath);
                textForEditor = doc.Text;
            }
            finally
            {
            }
            return textForEditor;
        }

        public static void WordWrite(string filePath, string textForEditor)
        {
            try
            {
                string path = Path.GetDirectoryName(filePath);
                DocX doc = DocX.Create(Path.Combine(path, "output.docx"));
                doc.InsertParagraph(textForEditor);
                doc.Save();
            }
            finally
            {
            }
        }

        public static string TxtParse(string filePath)
        {
            string textForEditor = "";
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    textForEditor = reader.ReadToEnd();
                }
            }
            finally { }
            return textForEditor;
        }

        public static void TxtWrite(string filePath, string textForEditor)
        {
            try
            {
                string path = Path.GetDirectoryName(filePath);
                File.AppendAllText(Path.Combine(path, "output.txt"), textForEditor);
            }
            finally { }
        }
    }
}
