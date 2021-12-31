using System.Collections.Generic;
using System.Linq;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;
using System;
public static class Program
{
    public static void Main()
    {
        using (PdfDocument document = PdfDocument.Open(@"C:\Users\AHAD RAZA\Downloads\AHAD RAZA NUML (1).pdf"))
        {
            foreach (Page page in document.GetPages())
            {
                string pagetext = page.Text;
                foreach(Word word in page.GetWords())
                {
                    Console.WriteLine(word.Text);
                }
            }
        }
    }
}