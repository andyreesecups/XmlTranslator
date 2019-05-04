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


            // If InsertDataToDatabase fails then call XMLErrorMessageWriter to write failed XML Acknowledgment
            if(Data.DataAccess.InsertDataToDatabase(invoice, out Message) == false)
            {
                Data.FileAccess.XMLErrorMessageWriter(invoice);
            }
            // Else call XMLSuccessMessageWriter to write success XML Acknowledgment
            else
            {
                Data.FileAccess.XMLSuccessMessageWriter(invoice);
            }
        }
    }
}
