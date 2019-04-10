using System.IO;
using System.Xml.Serialization;
using XmlTranslator.Models;

namespace XmlTranslator.Data
{
    public class FileAccess
    {
        public static void DeserializeToObject(out Invoice invoice)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Invoice));
            invoice = new Invoice();

            using (FileStream fileStream = new FileStream(@"C:\temp\Non_PO_Invoice.xml", FileMode.Open))
            {
                invoice = (Invoice)serializer.Deserialize(fileStream);
            }
        }
    }
}
