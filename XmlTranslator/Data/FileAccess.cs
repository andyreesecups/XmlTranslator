using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using XmlTranslator.Models;

namespace XmlTranslator.Data
{
    public class FileAccess
    {
        // Deserialize XML into Invoice object and out that object instance
        public static void DeserializeToObject(out Invoice invoice)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Invoice));
            invoice = new Invoice();

            using (FileStream fileStream = new FileStream(@"C:\temp\Non_PO_Invoice.xml", FileMode.Open))
            {
                invoice = (Invoice)serializer.Deserialize(fileStream);
            }
        }

        // XMLWriter to create Success Acknowledgment XML
        public static string XMLSuccessMessageWriter(Invoice invoice)
        {
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                NewLineOnAttributes = true
            };

            using (XmlWriter writer = XmlWriter.Create(@"C:\temp\EskerXML\FailedAcknowledgment.xml", settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("ERPack");
                writer.WriteElementString("EskerInvoiceID", invoice.RUID);
                writer.WriteElementString("ERPID", invoice.InvoiceNumber);
                writer.WriteEndElement();

                return writer.ToString();
            }
        }

        // XMLWriter to create Error Acknowledgment XML
        public static string XMLErrorMessageWriter(Invoice invoice)
        {
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                NewLineOnAttributes = true
            };

            using (XmlWriter writer = XmlWriter.Create(@"C:\temp\EskerXML\FailedAcknowledgment.xml", settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("ERPack");
                writer.WriteElementString("ERPPostingError", invoice.RUID);
                writer.WriteElementString("ERPID", "ERP Error");
                writer.WriteEndElement();

                return writer.ToString();
            }
        }
    }
}
