using System.IO;

namespace VSC.Utils
{
    public static class Utility
    {
        public static void SaveTextToFile(string text, string filePath)
        {
            using(StreamWriter outFile = new StreamWriter(filePath))
            {
                outFile.WriteLine(text);
            }
        }

        /// <summary>
        /// Loads text from the file by reading whole file to the end.
        /// </summary>
        /// <param name="filePath">Full path to the file to read text from.</param>
        /// <returns>text</returns>
        public static string LoadTextFromFile(string filePath)
        {
            string text = string.Empty;

            using(StreamReader inFile = new StreamReader(filePath))
            {
                text = inFile.ReadToEnd();
            }

            return text;
        }
    }
}