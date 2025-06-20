using System;

namespace DesignPatternsExample
{
    // Step 1: Document Interface
    public interface IDocument
    {
        void Open();
    }

    // Step 2: Concrete Documents
    public class WordDocument : IDocument
    {
        public void Open() => Console.WriteLine("Opening Word document...");
    }

    public class PdfDocument : IDocument
    {
        public void Open() => Console.WriteLine("Opening PDF document...");
    }

    public class ExcelDocument : IDocument
    {
        public void Open() => Console.WriteLine("Opening Excel document...");
    }

    // Step 3: Abstract Factory
    public abstract class DocumentFactory
    {
        public abstract IDocument CreateDocument();
    }

    // Step 4: Concrete Factories
    public class WordDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument() => new WordDocument();
    }

    public class PdfDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument() => new PdfDocument();
    }

    public class ExcelDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument() => new ExcelDocument();
    }

    // Step 5: Main Program
    class Program
    {
        static void Main(string[] args)
        {
            DocumentFactory wordFactory = new WordDocumentFactory();
            IDocument wordDoc = wordFactory.CreateDocument();
            wordDoc.Open();

            DocumentFactory pdfFactory = new PdfDocumentFactory();
            IDocument pdfDoc = pdfFactory.CreateDocument();
            pdfDoc.Open();

            DocumentFactory excelFactory = new ExcelDocumentFactory();
            IDocument excelDoc = excelFactory.CreateDocument();
            excelDoc.Open();
        }
    }
}
