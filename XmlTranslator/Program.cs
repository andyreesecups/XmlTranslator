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

            // Call Data Access function to insert data into the database
            // If InsertDataToDatabase function fails send failed XML acknowledgment 
            // Else send success XML acknowledgment
            if(Data.DataAccess.InsertDataToDatabase(invoice, out Message) == false)
            {
                Data.FileAccess.FailedXMLMessage(invoice);
            }
            else
            {
                Data.FileAccess.SuccessXMLMessage(invoice);
            }
        }
    }
}
