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
            if(Data.DataAccess.InsertDataToDatabase(invoice, out Message) == false)
            {
                Console.WriteLine("An error occurred in the Data Access call " + Message);
            }
        }
    }
}
