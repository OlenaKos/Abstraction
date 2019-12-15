using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Abstraction
{
    abstract class AbstractHandler
    {

        public string HadlerType { set; get; }
        public virtual void Open(Document doc)
        {
            Console.WriteLine($"***********{this.HadlerType} file is opened");
            FileStream fs;
            StreamReader fr;

            fs = new FileStream(doc.DocPath, FileMode.Open, FileAccess.Read);
            fr = new StreamReader(fs);

            string content = fr.ReadToEnd();

            Console.WriteLine("Text of Document {0}", content);
        }
        public virtual void Create(Document doc)
        {
            Console.WriteLine($"{this.HadlerType} file is created");
        }

        internal static AbstractHandler GetHandler(Document doc)
        {

             switch (doc.DefineDocType())
            {
                case DocType.doc:
                    {
                        return new DocHandler();
                    }
                case DocType.txt:
                    {
                        return new TXTHandler();

                    }
                case DocType.xml:
                    {
                        return new XMLHandler();
                    }
                default:
                    {
                        throw new Exception();
                    }
            }
        }

        public virtual void Change(Document doc)
        {
            Console.WriteLine($"{this.HadlerType} file is changed");
        }
        public virtual void Save(Document doc)
        {
            Console.WriteLine($"{this.HadlerType} file is saved");
        }
    }
}
