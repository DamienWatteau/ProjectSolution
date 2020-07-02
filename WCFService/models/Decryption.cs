using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ceTe.DynamicPDF;
using ceTe.DynamicPDF.PageElements;
using System.Text;

namespace WCFService.models
{
    public class Decryption
    {
        public static string Decripted(string key, string path)
        {
            var text = System.IO.File.ReadAllText(path);

            byte[] result = new byte[text.Length];

            for (int c = 0; c < text.Length; c++)
            {
                result[c] = (byte)((uint)text[c] ^ (uint)key[c % key.Length]);
            }

            string decript = Encoding.UTF8.GetString(result);

            return decript;
        }
    }
}
