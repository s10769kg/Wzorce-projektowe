using System;

namespace InvoiceGeneration
{
   
    public class InvoiceGenerator
    {
        public void GenerateInvoice()
        {
         
            int invoiceNumber = 12345;
            PdfWriter pdfWriter = new PdfWriter($"Invoice_{invoiceNumber}.pdf");

            pdfWriter.Write("Invoice Content");
            pdfWriter.Close();
        }

        public void OtherMethod()
        {
            
        }
    }

   
    public class PdfWriter
    {
        private string _fileName;

        public PdfWriter(string fileName)
        {
            _fileName = fileName;
        }

        public void Write(string content)
        {
         
            Console.WriteLine($"Writing to {_fileName}: {content}");
        }

        public void Close()
        {
           
            Console.WriteLine($"Closing {_fileName}");
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
           
            InvoiceGenerator generator = new InvoiceGenerator();

            
            generator.GenerateInvoice();

            
            generator.OtherMethod();
        }
    }
}
