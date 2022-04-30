namespace VigenereProject
{
    public class VigenereChipper
    {
        static string lowerAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        static string UpperAlphabet = lowerAlphabet.ToUpper();
        static int n = lowerAlphabet.Length;

        public static string Encryption(string plaintext, string keyword)
        {
            keyword = keyword.ToLower();
            string cipherText = "";
            int keyIndex = 0;
            for (int i = 0; i < plaintext.Length; i++)
            {
                cipherText += lowerAlphabet.IndexOf(plaintext[i]) == -1 ? "" :
                    lowerAlphabet[(lowerAlphabet.IndexOf(plaintext[i]) + lowerAlphabet.IndexOf(keyword[keyIndex])) % n].ToString();
                cipherText += UpperAlphabet.IndexOf(plaintext[i]) == -1 ? "" :
                    UpperAlphabet[(UpperAlphabet.IndexOf(plaintext[i]) + lowerAlphabet.IndexOf(keyword[keyIndex])) % n].ToString();
                if (cipherText.Length == i) { cipherText += plaintext[i]; }
                else { keyIndex = ++keyIndex % keyword.Length; }
            }
            return cipherText;
        }

        public static string Decryption(string cipherText, string keyword)
        {
            keyword = keyword.ToLower();
            string plainText = "";
            int keyIndex = 0;
            for (int i = 0; i < cipherText.Length; i++)
            {
                plainText += lowerAlphabet.IndexOf(cipherText[i]) == -1 ? "" :
                    lowerAlphabet[(n + lowerAlphabet.IndexOf(cipherText[i]) - lowerAlphabet.IndexOf(keyword[keyIndex])) % n].ToString();
                plainText += UpperAlphabet.IndexOf(cipherText[i]) == -1 ? "" :
                    UpperAlphabet[(n + UpperAlphabet.IndexOf(cipherText[i]) - lowerAlphabet.IndexOf(keyword[keyIndex])) % n].ToString();
                if (plainText.Length == i) { plainText += cipherText[i]; }
                else { keyIndex = ++keyIndex % keyword.Length; }
            }
            return plainText;
        }
    }
}
