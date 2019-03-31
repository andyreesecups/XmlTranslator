using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XmlTranslator.Models;

namespace XmlTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
                XmlSerializer serializer = new XmlSerializer(typeof(Invoice));
                Invoice invoice = new Invoice();

                using (FileStream fileStream = new FileStream(@"C:\temp\Non_PO_Invoice.xml", FileMode.Open))
                {
                    invoice = (Invoice)serializer.Deserialize(fileStream);
                }

        }
    }
}
