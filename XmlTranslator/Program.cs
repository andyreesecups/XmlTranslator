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
            Invoice invoice = new Invoice();
            // Call DeserializeToObject Function
            Data.FileAccess.DeserializeToObject(out invoice);
        }
    }
}
