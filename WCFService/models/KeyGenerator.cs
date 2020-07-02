using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using WCFService.LibOthers;

namespace WCFService.models
{
    public class KeyGenerator
    {
        public static void KeyGen(string FilePath)
        {
            string[] alphaArray = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] Keyarray = new string[] { "A", "A", "A", "A" };

            int z = 0;
            int val1 = 1;
            int val2 = 1;
            int val3 = 1;
            string LastLetter = "Z";
            FileDecrypt fileDecrypt;

            while (z < 17576)
            {
                if (Keyarray[1] == LastLetter && Keyarray[2] == LastLetter && Keyarray[3] == LastLetter)
                {
                    Keyarray[0] = alphaArray[val3];
                    val3++;
                }
                if (Keyarray[2] == LastLetter)
                {
                    if (Keyarray[1] == LastLetter) { val2 = 0; }
                    Keyarray[1] = alphaArray[val2];
                    val2++;
                }
                if (Keyarray[3] == LastLetter)
                {
                    if (Keyarray[2] == LastLetter) { val1 = 0; }
                    Keyarray[2] = alphaArray[val1];
                    val1++;
                }
                for (int i = 0; i < 26; i++)
                {
                    int A1 = 3;
                    Keyarray[A1] = alphaArray[i];
                    string key00 = Keyarray[0];
                    string key02 = Keyarray[1];
                    string key03 = Keyarray[2];
                    string key04 = Keyarray[3];

                    fileDecrypt = new FileDecrypt();
                    fileDecrypt.FilePath = FilePath;
                    fileDecrypt.Key = key00 + key02 + key03 + key04;
                    fileDecrypt.TxtFile = Decryption.Decripted(fileDecrypt.Key, fileDecrypt.FilePath);
                    System.Diagnostics.Debug.WriteLine(fileDecrypt.TxtFile);

                    String[] array = ConvertToArray(fileDecrypt.FilePath, fileDecrypt.Key, fileDecrypt.TxtFile);

                    String tauxDeConfiance = new ServiceReferenceJava.DecipherClient().SendFile(array);
                    fileDecrypt.Fiability = Int16.Parse(tauxDeConfiance);

                    int bestFiability = FileResult.getIntance().Fiability;
                    if (fileDecrypt.Fiability > bestFiability)
                    {
                        UpdateBestFileResult(fileDecrypt.FilePath, fileDecrypt.Key, fileDecrypt.Fiability, fileDecrypt.TxtFile);
                    }
                }
                z++;

            }
        }

        public static void UpdateBestFileResult(string filePath, string key, int fiability, string fileDecypted)
        {
            FileResult fileResult = FileResult.getIntance();
            fileResult.FilePath = filePath;
            fileResult.Key = key;
            fileResult.Fiability = fiability;
            fileResult.TxtFile = fileDecypted;
        }

        public static String[] ConvertToArray(String FilePath, String Key, String FileContentDecrypted)
        {
            String[] t = { FilePath, Key, XML.ToValidXmlCharactersString(FileContentDecrypted) };
            return t;
        }
    }
}