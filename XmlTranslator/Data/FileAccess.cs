using System.IO;
using System.Text;
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

        // Write Success Acknowledgement to given path
        public static void WriteSuccessAcknowledgment(string xml)
        {
            string saveDirectory = @"C:\temp\EskerXML";

            Directory.CreateDirectory(saveDirectory);

            using (StreamWriter sw = new StreamWriter(@"C:\temp\EskerXML\SuccessAcknowledgment.xml"))
            {
                sw.Write(xml);
            }
        }

        // Write Failed Acknowledgment to given path
        public static void WriteFailedAcknowledgment(string xml)
        {
            string saveDirectory = @"C:\temp\EskerXML";

            Directory.CreateDirectory(saveDirectory);

            using (StreamWriter sw = new StreamWriter(@"C:\temp\EskerXML\FailedAcknowledgment.xml"))
            {
                sw.Write(xml);
            }
        }

        // Use StringBuilder to generate success message
        public static string SuccessXMLMessage(Invoice invoice)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<?xml version='1.0' encoding='utf - 8'?>");
            sb.AppendLine("<ERPAck>");
            sb.AppendLine("<EskerInvoiceID>").Append(invoice.RUID).AppendLine("</EskerInvoiceID>");
            sb.AppendLine("<ERPID>").Append(invoice.InvoiceNumber).AppendLine("</ERPID>");
            sb.Append("</ERPAck>");

            WriteSuccessAcknowledgment(sb.ToString());

            return sb.ToString();
        }

        // Use StringBuilder to generate failed message
        public static string FailedXMLMessage(Invoice invoice)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<?xml version='1.0' encoding='utf - 8'?>");
            sb.AppendLine("<ERPAck>");
            sb.AppendLine("<ERPPostingError>").Append(invoice.RUID).AppendLine("</ERPPostingError>");
            sb.AppendLine("<ERPID>").Append("ERP Error").AppendLine("</ERPID>");
            sb.Append("</ERPAck>");

            WriteFailedAcknowledgment(sb.ToString());

            return sb.ToString();
        }
    }
}
