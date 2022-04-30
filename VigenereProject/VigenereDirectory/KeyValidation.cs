namespace VigenereProject
{
    public class KeyValidation
    {
        public static bool isValidated(string key)
        {
            if (String.IsNullOrEmpty(key) || String.IsNullOrWhiteSpace(key)) { return false; }
            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            alphabet += alphabet.ToUpper();
            for(int i = 0; i < key.Length; i++)
            {
                if (!alphabet.Contains(key[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
