using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Israfil_Zekai_Yilmaz_68134_T8
{
    public static class Class1
    {
        public static List<string> Words {  get;private set; }=new List<string>();
        public static List<string> Senteces {  get;private set; }= new List<string>();
        public static List<string> Both { get; private set; } = new List<string>();
        public static GameMode CurrentGameMode {  get; set; }
        private static Random random =new Random();

        public static void LoadData()
        {
           

            string[] lines = File.ReadAllLines("AllWordsAndSentences.txt");
            foreach (var line in lines)
            {
                string[] parts = line.Split(' ');

                if (parts.Length == 1)
                {
                    Words.Add(parts[0]);

                }
                else
                {
                    Senteces.Add(string.Join(" ",parts));
                }
                Both.Add(line);
            }
           
        }
        public static string Next()
        {
            switch(CurrentGameMode)
            {
                case GameMode.WordsOnly:
                    return Words[random.Next(Words.Count)];
                case GameMode.Sentencesonly:
                    return Senteces[random.Next(Senteces.Count)];
                default:
                    return Both[random.Next(Both.Count)];
            }
        }
    }
}
