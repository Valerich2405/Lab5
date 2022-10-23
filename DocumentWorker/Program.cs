using System;
using System.Text;
using System.IO;

namespace DocumentWorker
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            using (StreamReader _sw = new StreamReader(@"C:\Users\Omen\Documents\Lab5\Document.txt", Encoding.Default))
            {
                Console.WriteLine(_sw.ReadToEnd());
                _sw.Close();
            }
            Console.WriteLine("The document is open.");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Document editing is available in the Pro version.");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Document saving is available in the Pro version.");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void OpenDocument()
        {
            base.OpenDocument();
        }
        public override async void EditDocument()
        {
            Console.WriteLine("Enter the change: ");
            using (StreamWriter sr = new StreamWriter(@"C:\Users\Omen\Documents\Lab5\Document.txt", true))
            {
                await sr.WriteLineAsync(Console.ReadLine());
            }
            this.OpenDocument();
            Console.WriteLine("The document has been edited.");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("The document is saved in the old format, saving in other formats is available in the Expert version.");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void OpenDocument()
        {
            base.OpenDocument();
        }
        public override void EditDocument()
        {
            base.EditDocument();
        }
        public override void SaveDocument()
        {
            using (StreamReader streamReader = new StreamReader(@"C:\Users\Omen\Documents\Lab5\Document.txt"))
            {
                string text = streamReader.ReadToEnd();
                using (StreamWriter sw = new StreamWriter(@"C:\Users\Omen\Documents\Lab5\Document2.txt"))
                {
                    sw.WriteLine(text);
                }
            }
            Console.WriteLine("The document is saved in a new format.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
            Console.WriteLine();

            if(password == "12345")
            {
                Console.WriteLine("---Pro version---");
                Console.WriteLine();
                ProDocumentWorker pro = new ProDocumentWorker();
                pro.OpenDocument();
                pro.EditDocument();
                pro.SaveDocument();      
            }

            else if (password == "123456789")
            {
                Console.WriteLine("---Expert version---");
                Console.WriteLine();
                ExpertDocumentWorker expert = new ExpertDocumentWorker();
                expert.OpenDocument();
                expert.EditDocument();
                expert.SaveDocument();               
            }

            else
            {
                Console.WriteLine("---Free version---");
                Console.WriteLine();
                DocumentWorker free = new DocumentWorker();
                free.OpenDocument();
                free.EditDocument();
                free.SaveDocument();
            }
        }
    }
}
