using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    enum DocType { doc, txt, xml, undef } ;

    class Program
    {

        static void Main(string[] args)
        {

            Document doc1 = new Document("..\\..\\Test1.txt");
            Document doc2 = new Document("..\\..\\Test2.xml");
           // Document doc3 = new Document("..\\..\\Test3.docx");
            Document doc4 = new Document("..\\..\\Test4.rtf");

            List<Document> docs = new List<Document> { doc1, doc2, doc4 };
            foreach (Document doc in docs)
            {
                AbstractHandler handler = AbstractHandler.GetHandler(doc);
                handler.Open(doc);
                handler.Create(doc);
                handler.Change(doc);
                handler.Save(doc);
                Console.WriteLine();
            }


            Console.ReadLine();

        }
    }
}
