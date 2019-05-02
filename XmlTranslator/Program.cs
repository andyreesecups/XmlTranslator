using System;
using XmlTranslator.Models;

namespace XmlTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice();
            string Message = "";

            // Call DeserializeToObject Function
            Data.FileAccess.DeserializeToObject(out invoice);

            // Call XMLSuccessMessageWriter
            Data.FileAccess.XMLSuccessMessageWriter(invoice);

            // Call XMLErrorMessageWriter
            Data.FileAccess.XMLErrorMessageWriter(invoice);
        }
    }
}
