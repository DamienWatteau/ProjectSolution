using ceTe.DynamicPDF;
using ceTe.DynamicPDF.PageElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCFService.models;

namespace WCFService.Controllers
{
    public class PdfFileCreator
    {
        public static string PdfCreator()
        {

            FileResult fileResult = FileResult.getIntance();
            

            Document document = new Document();
            Page page = new Page(PageSize.Letter, PageOrientation.Portrait, 54.0f);
            document.Pages.Add(page);

            string titre = "\r\nRapport de déchiffrement";
            string fiabiliteText = "\r\nPourcentage de fiabilité : " + fileResult.Fiability + "%";
            string clef = "\r\nClef utilisée : " + fileResult.Key;


            string decryptext = "\r\nNom document : " + fileResult.FilePath ;


            Label titrelabel = new Label(titre, 0, 0, 504, 100, Font.Helvetica, 25, TextAlign.Left);
            page.Elements.Add(titrelabel);

            Label fiabilitelabel = new Label(fiabiliteText, 0, 50, 504, 100, Font.Helvetica, 18, TextAlign.Left);
            page.Elements.Add(fiabilitelabel);

            Label cleflabel = new Label(clef, 0, 80, 504, 100, Font.Helvetica, 18, TextAlign.Left);
            page.Elements.Add(cleflabel);


            Label decryptlabel = new Label(decryptext, 0, 150, 504, 100, Font.Helvetica, 18, TextAlign.Left);
            page.Elements.Add(decryptlabel);


            /*for (int i = 0; i < fileResult.TxtFile.Length; i = i + 3500)
            {
                int splitValue = 3500;
                if (i + 3500 > fileResult.TxtFile.Length)
                {
                    splitValue = fileResult.TxtFile.Length - i;
                }
                string textToPrint = fileResult.TxtFile.Substring(i, splitValue);

                Page page1 = new Page(PageSize.Letter, PageOrientation.Portrait, 54.0f);
                document.Pages.Add(page1);

                Label textlabel = new Label(textToPrint, 0, 0, 504, 1000, Font.Helvetica, 12, TextAlign.Left);
                page1.Elements.Add(textlabel);
            }*/

            string pdfPath = $"C:\\Users\\Damien\\Desktop\\Oracle\\rapport\\Rapport.pdf";

            document.Draw(pdfPath);
            return pdfPath;

        }
        private static string ExtractFileName(String filePath)
        {
            string[] fName = filePath.Split(new char[] { '\\' });
            string fileName = fName[fName.Length - 1];
            return fileName;
        }
    }
}
