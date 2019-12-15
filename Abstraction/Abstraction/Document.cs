using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Document
    {

        public string DocPath { get; set; }

        public DocType DefineDocType()
        {
            DocType docType;
            if ((DocPath.EndsWith(".doc")) || (DocPath.EndsWith(".docx")) || (DocPath.EndsWith(".rtf")) )
            {
                docType = DocType.doc;
            }
            else if (DocPath.EndsWith(".xml"))
            {
                docType = DocType.xml;
            }
            else if (DocPath.EndsWith(".txt"))
            {
                docType = DocType.txt;
            }
            else
            {
                docType = DocType.undef;
            }

            return docType;
        }

        public Document()
        {

        }

        public Document(string path)
        {
            DocPath = path;
        }

    }
}
